using System;
using System.Collections.Generic;
using System.Web.Mvc;
using IWSProject.Models;
using System.Linq;

namespace IWSProject.Controllers
{
    public class AccountingController : Controller
    {
        IWSDataContext db = new IWSDataContext();
        // GET: Accounting
        [HttpGet]
        public ActionResult Index()
        {
            var BL = IWSLookUp.GetBL(false);
            var model = new List<ValidateBLViewModel>();
            foreach (ValidateBLViewModel bl in BL)
            {
                model.Add(bl);
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult Index(string selectedIDsHF)
        {
            string selectedItems = selectedIDsHF;
            // check if items were selected previously
            if (!string.IsNullOrEmpty(selectedItems))
            {
                IList<string> items = new List<string>(selectedItems.Split(new string[] { ";" }, StringSplitOptions.None));

                foreach (string item in items)
                {
                    var list = item.Split(new string[] { "," }, StringSplitOptions.None);

                    int BLID = Convert.ToInt32(list[0]);

                    string CompanyID = Convert.ToString(list[1]);

                    bool updateStock =  UpdateStock(BLID);

                    bool compta = Compta(BLID, CompanyID);

                    bool updateBL = UpdateBL(BLID);

                    if (updateBL && compta && updateStock)
                    {
                        db.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);
                    }
                }
            }

            var BL = IWSLookUp.GetBL(false);

            var model = new List<ValidateBLViewModel>();

            foreach (ValidateBLViewModel bl in BL)
            {
                model.Add(bl);
            }
            return View(model);
        }
        public ActionResult ValidateBLPartialView()
        {
            var BL = IWSLookUp.GetBL(false);
            var model = new List<ValidateBLViewModel>();
            foreach (ValidateBLViewModel bl in BL)
            {
                model.Add(bl);
            }
            return PartialView(model);
        }
 
        #region Helper
        private bool Compta(int BLID, string companyID)
        {
            ///for a given GoodReceiving gets the periodes and accounts to credit from LineGoodReceivings and does the stuff
            var Az = from line in db.LineGoodReceivings
                        group new { line, line.Article.Vat, line.GoodReceiving } by new
                        {
                            line.VatCode,
                            line.Article.Vat.stockaccountid,
                            line.GoodReceiving.id,
                            Column1 = (Convert.ToString((int?)line.GoodReceiving.ItemDate.Value.Month)).Length == 1 ?
                                                    '0' + Convert.ToString((int?)line.GoodReceiving.ItemDate.Value.Month) :
                                                    Convert.ToString((int?)line.GoodReceiving.ItemDate.Value.Month),
                            Column2 = Convert.ToString((int?)line.GoodReceiving.ItemDate.Value.Year)
                        } into g
                        where g.Key.id == BLID
                        select new
                        {
                            ID = g.Key.id,
                            VatCode = g.Key.VatCode,
                            Periode = g.Key.Column2 + g.Key.Column1,
                            month = g.Key.Column1,
                            Account = g.Key.stockaccountid,
                            TotHTVA = (decimal?)g.Sum(p => (decimal)p.line.quantity * p.line.price),
                            TotTVA = (double?)g.Sum(p => (double)p.line.quantity * (double)p.line.price * p.line.Article.Vat.PVat),
                            TTC = (decimal?)g.Sum(p => (decimal)p.line.quantity * (decimal)p.line.price * (1 + (decimal)p.line.Article.Vat.PVat))
                        };
            if (Az!=null)
            {
                try
                {
                    ///gets totals
                    var TotTTC = Az.Sum(t => t.TTC);
                    var TotTVA = Az.Sum(t => t.TotTVA);
                    bool debitPeriodic = false;
                    bool creditPeriodic = false;
                    bool updateAccount = false;
                    foreach (var az in Az)
                    {
                        debitPeriodic = DebitPerioicAccountBalance(az.Periode, az.Account, Convert.ToDecimal(az.TTC));

                        updateAccount=UpdateAccountBalabce(az.Account, Convert.ToDecimal(az.TTC));
                    }
                    ///gets the accounting periode as six digits
                    var periode = db.GoodReceivings.Where(i => i.id == BLID).Select(c => Convert.ToString((int?)c.ItemDate.Value.Year) +
                                                        ((Convert.ToString((int?)c.ItemDate.Value.Month)).Length == 1 ?
                                                        '0' + Convert.ToString((int?)c.ItemDate.Value.Month) :
                                                            Convert.ToString((int?)c.ItemDate.Value.Month))).FirstOrDefault().ToString();

                    var companyAccount = db.Companies.Where(c => c.id == companyID).Select(c => c.purchasingclearingaccountid).SingleOrDefault();

                    creditPeriodic = CreditPerioicAccountBalance(periode, companyAccount, Convert.ToDecimal(TotTTC));

                    return debitPeriodic && creditPeriodic && updateAccount;
                }
                catch (Exception e)
                {
                    ViewData["GenericError"] = e.Message;
                }
            }
            return false;
        }
        private bool UpdateStock(int BLID)
        {

            /*for the given GoodReceiving ID, gets the account and amount and does the stuff*/
            var Az = from line in db.LineGoodReceivings
                     where
                       line.GoodReceiving.id == BLID
                     select new
                     {
                         Store = line.GoodReceiving.store,
                         Item = line.item,
                         Quantity = line.quantity,
                         Price = line.price,
                         IsService= line.Article.IsService
                     };
            if (Az!=null)
            {
                try
                {
                    foreach (var az in Az)
                    {
                        if (false.Equals(az.IsService))
                        {
                            var stockCum = db.Stocks.Where(i => i.itemid == az.Item).Sum(q => q.quantity);
                            var stock = db.Stocks.FirstOrDefault(s => s.storeid == az.Store && s.itemid == az.Item);
                            float? currentStock;
                            currentStock = db.Stocks.Where(i => i.itemid == az.Item).Sum(q => q.quantity);
                            if (stock == null)
                            {
                                stock = new Stock();
                                stock.id = Guid.NewGuid().ToString();
                                stock.name = "NA";
                                stock.modelid = 107;
                                stock.storeid = az.Store;
                                stock.itemid = az.Item;
                                stock.quantity = az.Quantity;
                                db.Stocks.InsertOnSubmit(stock);
                            }
                            else
                            {
                                stock.quantity += az.Quantity;
                            }
                            var article = db.Articles.FirstOrDefault(item => item.id == az.Item);
                            currentStock = currentStock == null ? 0 : currentStock;
                            if (article != null)
                            {
                                article.salesprice = az.Price;
                                article.avgprice = (decimal)((float)article.avgprice * currentStock +
                                                    (float)az.Price * az.Quantity) / (decimal)(currentStock + az.Quantity);
                            }
                        }
                    }
                    return true;
                }
                catch (Exception e)
                {
                    ViewData["GenericError"] = e.Message;

                }
            }
            return false;
        }
        private bool UpdateBL(int BLID)
        {
            try
            {
            /*for the given GoodReceiving ID, sets IsValidated to true*/
            var Az = db.GoodReceivings.FirstOrDefault(item => item.id == BLID);
                if (Az!=null)
                {
                    Az.IsValidated = true;
                    return true;
                }
            }
            catch (Exception e)
            {
                ViewData["GenericError"] = e.Message;
            }
            return false;
        }
        private bool UpdateAccountBalabce(string accountID, decimal amount)
        {
            try
            {
                var Az = db.Accounts.FirstOrDefault(a => a.id == accountID);
                if (Az!=null)
                {
                    Az.balance += amount;
                    return true;
                }
            }
            catch (Exception e)
            {
                ViewData["GenericError"] = e.Message;
            }
            return false;
        }
        private bool DebitPerioicAccountBalance(string Periode, string Account, decimal TotalVAT)
        {

            var periodicAccountBalance = db.PeriodicAccountBalances.FirstOrDefault(s => s.Periode == Periode && s.AccountId == Account);

            if (periodicAccountBalance == null)
            {
                try
                {
                    periodicAccountBalance = new PeriodicAccountBalance();
                    periodicAccountBalance.Name = "NA";
                    periodicAccountBalance.ModelId = 106;
                    periodicAccountBalance.Periode = Periode;
                    periodicAccountBalance.AccountId = Account;
                    periodicAccountBalance.Debit = TotalVAT;

                    db.PeriodicAccountBalances.InsertOnSubmit(periodicAccountBalance);
                }
                catch (Exception e)
                {
                    ViewData["GenericError"] = e.Message;
                    return false;
                }
            }
            else
            {
                periodicAccountBalance.Debit += TotalVAT;
            }
            return true;
        }
        private bool CreditPerioicAccountBalance(string Periode, string Account, decimal TotalTTC)
        {

            var periodicAccountBalance = db.PeriodicAccountBalances.FirstOrDefault(s => s.Periode == Periode && s.AccountId == Account);

            if (periodicAccountBalance == null)
            {
                try
                {
                    periodicAccountBalance = new PeriodicAccountBalance();
                    periodicAccountBalance.Name = "NA";
                    periodicAccountBalance.ModelId = 106;
                    periodicAccountBalance.Periode = Periode;
                    periodicAccountBalance.AccountId = Account;
                    periodicAccountBalance.Credit = TotalTTC;

                    db.PeriodicAccountBalances.InsertOnSubmit(periodicAccountBalance);
                }
                catch (Exception e)
                {
                    ViewData["GenericError"] = e.Message;
                    return false;
                }
            }
            else
            {
                periodicAccountBalance.Debit += TotalTTC;
            }
            return true;
        }

        #endregion
    }
}