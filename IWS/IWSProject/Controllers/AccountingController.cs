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

            var model = new List<ValidadeBLViewModel>();

            foreach (ValidadeBLViewModel bl in BL)
            {
                model.Add(bl);
            }
            return View(model);
        }
        [HttpGet]
        public ActionResult AccountBalanceView()
        {
            var AB = IWSLookUp.GetAccountBalance();

            var model = new List<AccountBalanceViewModel>();

            foreach (AccountBalanceViewModel item in AB)
            {
                model.Add(item);
            }

            return View(model);
        }
        [HttpGet]
        public ActionResult StockView()
        {
            var SV = IWSLookUp.GetStock();
            var model = new List<StockViewModel>();
            foreach (StockViewModel item in SV)
            {
                model.Add(item);
            }
            return View(SV);
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

                    UpdateStock(BLID);

                    Compta(BLID, CompanyID);

                    UpdateBL(BLID);

                }
            }

            var BL = IWSLookUp.GetBL(false);

            var model = new List<ValidadeBLViewModel>();

            foreach (ValidadeBLViewModel bl in BL)
            {
                model.Add(bl);
            }
            return View(model);
        }
        public ActionResult ValidateBLPartialView()
        {
            var BL = IWSLookUp.GetBL(false);

            var model = new List<ValidadeBLViewModel>();

            foreach (ValidadeBLViewModel bl in BL)
            {
                model.Add(bl);
            }
            return PartialView(model);
        }
 
        #region Helper
        private void Compta(int BLID, string companyID)
        {

                ///for the given GoodReceiving gets the peiode and accounts to credit from LineGoodReceivings and does the stuff
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
                ///gets the total of TTC
                var TotTTC = Az.Sum(t => t.TTC);

                foreach (var az in Az)
                {

                    var periodicAccountBalance = db.PeriodicAccountBalances.FirstOrDefault(s => s.Periode == az.Periode && s.AccountId == az.Account);

                    if (periodicAccountBalance == null)
                    {
                        periodicAccountBalance = new PeriodicAccountBalance();
                        periodicAccountBalance.Name = "NA";
                        periodicAccountBalance.ModelId = 106;
                        periodicAccountBalance.Periode = az.Periode;
                        periodicAccountBalance.AccountId = az.Account;
                        periodicAccountBalance.Debit = Convert.ToDecimal(az.TTC);

                        db.PeriodicAccountBalances.InsertOnSubmit(periodicAccountBalance);
                    }
                    else
                    {
                        periodicAccountBalance.Debit += Convert.ToDecimal(az.TTC);
                    }
                }
                ///gets the accounting periode as six digits
                var periode = db.GoodReceivings.Where(i => i.id == BLID).Select(c => Convert.ToString((int?)c.ItemDate.Value.Year) +
                                                    ((Convert.ToString((int?)c.ItemDate.Value.Month)).Length == 1 ?
                                                    '0' + Convert.ToString((int?)c.ItemDate.Value.Month) :
                                                        Convert.ToString((int?)c.ItemDate.Value.Month))).FirstOrDefault().ToString();

                var companyAccount = db.Companies.Where(c => c.id == companyID).Select(c => c.purchasingclearingaccountid).SingleOrDefault();

                var periodicAccount = db.PeriodicAccountBalances.FirstOrDefault(s => s.Periode == periode && s.AccountId == companyAccount);//accountTocredit
                if (periodicAccount == null)
                {
                    periodicAccount = new PeriodicAccountBalance();

                    periodicAccount.Name = "NA";
                    periodicAccount.ModelId = 106;
                    periodicAccount.AccountId = companyAccount;
                    periodicAccount.Periode = periode;
                    periodicAccount.Credit = Convert.ToDecimal(TotTTC);

                    db.PeriodicAccountBalances.InsertOnSubmit(periodicAccount);
                }
                else
                {
                    periodicAccount.Credit = Convert.ToDecimal(TotTTC);
                }

                db.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);
        
        }
        private void UpdateStock(int BLID)
        {

                /*for the given GoodReceiving ID, gets the account and amount and does the stuff*/
                var Az = from line in db.LineGoodReceivings
                         where
                           line.GoodReceiving.id == BLID
                         orderby line.item
                         select new
                         {
                             Store = line.GoodReceiving.store,
                             Item = line.Article.id,
                             Quantity = line.quantity,
                             Price = line.price
                         };

                foreach (var az in Az)
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
                db.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);
            }
        private void UpdateBL(int BLID)
        {
            /*for the given GoodReceiving ID, sets IsValidated to true*/
            var Az = db.GoodReceivings.FirstOrDefault(item => item.id == BLID);
            Az.IsValidated = true;
            db.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);
        }
        #endregion
    }
}