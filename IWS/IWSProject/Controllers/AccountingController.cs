using System;
using System.Collections.Generic;
using System.Web.Mvc;
using IWSProject.Models;
using IWSProject.Content;
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

            var docs = IWSLookUp.GetAccountingDocument(false);
            var model = new List<DocumentsViewModel>();
            foreach (DocumentsViewModel doc in docs)
            {
                model.Add(doc);
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult Index(string selectedIDsHF)
        {
            string selectedItems = selectedIDsHF;
            
            if (!string.IsNullOrEmpty(selectedItems))// check if items were selected previously
            {
                IList<string> items = new List<string>(selectedItems.Split(new string[] { ";" }, StringSplitOptions.None));
                bool results = false;
                int ItemID;
                string ItemType;
                foreach (string item in items)
                {
                    var list = item.Split(new string[] { "," }, StringSplitOptions.None);

                    ItemID = Convert.ToInt32(list[0]);

                    ItemType = GetItemType(list[1]);

                    results =  UpdateStock(ItemID, ItemType);
                    if (false.Equals(results))
                    {
                        ViewData["GenericError"] = IWSLocalResource.GenericError;
                        return RedirectToAction("Index");
                    }
                    results = Compta(ItemID, ItemType);
                    if (false.Equals(results))
                    {
                        ViewData["GenericError"] = IWSLocalResource.GenericError;
                        return RedirectToAction("Index");
                    }
                    results = SetToValidated(ItemID, ItemType);
                    if (true.Equals(results))
                    {
                        db.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);
                    }
                }
            }
            var docs = IWSLookUp.GetAccountingDocument(false);

            var model = new List<DocumentsViewModel>();

            foreach (DocumentsViewModel doc in docs)
            {
                model.Add(doc);
            }
            return View(model);
        }
        public ActionResult ValidateBLPartialView()
        {
            var docs = IWSLookUp.GetAccountingDocument(false);
            var model = new List<DocumentsViewModel>();
            foreach (DocumentsViewModel doc in docs)
            {
                model.Add(doc);
            }
            return PartialView(model);
        }
        #region Helper
        private bool Compta(int ItemID, string ItemType)
        {
            //for a given GoodReceiving gets the periodes and accounts to credit from LineGoodReceivings and does the stuff
            #region Good Receiving
            if (ItemType.Equals("GoodReceiving"))
            {
                var Az = from line in db.LineGoodReceivings
                         group new { line, line.Article.Vat, line.GoodReceiving } by new
                         {
                             //line.VatCode,
                             line.Article.Vat.expenseaccountid,
                             line.GoodReceiving.id,
                             xMonth = (Convert.ToString((int?)line.GoodReceiving.ItemDate.Month)).Length == 1 ?
                                                     '0' + Convert.ToString((int?)line.GoodReceiving.ItemDate.Month) :
                                                     Convert.ToString((int?)line.GoodReceiving.ItemDate.Month),
                             xYear = Convert.ToString((int?)line.GoodReceiving.ItemDate.Year)
                         } into g
                         where g.Key.id == ItemID
                         select new
                         {
                             ID = g.Key.id,
                             //VatCode = g.Key.VatCode,
                             Periode = g.Key.xYear + g.Key.xMonth,
                             Account = g.Key.expenseaccountid,
                             TotHTVA = g.Sum(p => p.line.quantity * p.line.price),
                             TotTVA = g.Sum(p => p.line.quantity * p.line.price * p.line.Article.Vat.PVat),
                             TTC = g.Sum(p => p.line.quantity * p.line.price * (1 + p.line.Article.Vat.PVat))
                         };
                if (Az != null)
                {
                    try
                    {
                        var TotHTVA = Az.Sum(t => t.TotHTVA);
                        var TotTVA = Az.Sum(t => t.TotTVA);
                        bool debitPeriodic = false;
                        bool creditPeriodic = false;
                        bool updateAccount = false;
                        foreach (var az in Az)
                        {
                            debitPeriodic = DebitPerioicAccountBalance(az.Periode, az.Account, Convert.ToDecimal(az.TotHTVA));

                            updateAccount = UpdateAccountBalabce(az.Account, Convert.ToDecimal(az.TotHTVA));
                        }
                        ///gets the accounting periode as six digits
                        var periode = db.GoodReceivings.Where(i => i.id == ItemID).Select(c => Convert.ToString((int?)c.ItemDate.Year) +
                                                            ((Convert.ToString((int?)c.ItemDate.Month)).Length == 1 ?
                                                            '0' + Convert.ToString((int?)c.ItemDate.Month) :
                                                                Convert.ToString((int?)c.ItemDate.Month))).FirstOrDefault().ToString();

                        var company = db.GoodReceivings.Where(c => c.id == ItemID).Select(c => c.CompanyId).SingleOrDefault();

                        var companyAccount = db.Companies.Where(c => c.id == company).Select(c => c.purchasingclearingaccountid).SingleOrDefault();

                        creditPeriodic = CreditPerioicAccountBalance(periode, companyAccount, Convert.ToDecimal(TotHTVA));

                        return debitPeriodic && creditPeriodic && updateAccount;
                    }
                    catch (Exception e)
                    {
                        ViewData["GenericError"] = e.Message;
                    }
                }
            }
            #endregion
            #region Inventory Invoice
            if (ItemType.Equals("InventoryInvoice"))
            {
                var Az = from line in db.LineInventoryInvoices
                         group new { line, line.Article.Vat, line.InventoryInvoice } by new
                         {
                             line.VATCode,
                             line.InventoryInvoice.id,
                             line.Article.Vat.inputvataccountid,
                             line.InventoryInvoice.Supplier.accountid,
                             line.InventoryInvoice.Company.purchasingclearingaccountid,
                             xMonth = (Convert.ToString((int?)line.InventoryInvoice.ItemDate.Month)).Length == 1 ?
                                                     '0' + Convert.ToString((int?)line.InventoryInvoice.ItemDate.Month) :
                                                     Convert.ToString((int?)line.InventoryInvoice.ItemDate.Month),
                             xYear = Convert.ToString((int?)line.InventoryInvoice.ItemDate.Year)
                         } into g
                         where g.Key.id == ItemID
                         select new
                         {
                             ID = g.Key.id,
                             VatCode = g.Key.VATCode,
                             VatAccountID=g.Key.inputvataccountid,
                             Periode = g.Key.xYear + g.Key.xMonth,
                             Debit = g.Key.purchasingclearingaccountid,
                             Credit=g.Key.accountid,
                             TotHTVA = g.Sum(p => p.line.quantity * p.line.price),
                             TotTVA = g.Sum(p => p.line.quantity * p.line.price * p.line.Article.Vat.PVat),
                             TTC = g.Sum(p => p.line.quantity * p.line.price * (1 + p.line.Article.Vat.PVat))
                         };
                if (Az != null)
                {
                    try
                    {
                        var ttc = Convert.ToDecimal(Az.Sum(s => s.TTC));
                        var htva = Convert.ToDecimal(Az.Sum(s => s.TotHTVA));
                        bool debitPeriodic = false;
                        bool creditPeriodic = false;
                        bool updateAccount = false;
                        foreach (var az in Az)
                        {
                            debitPeriodic = DebitPerioicAccountBalance(az.Periode, 
                                            az.VatAccountID, Convert.ToDecimal(az.TotTVA));

                            updateAccount = UpdateAccountBalabce(az.VatAccountID, Convert.ToDecimal(az.TotTVA));
                        }
                        var periode = Az.Select(p => p.Periode).First();

                        var debitAccount=Az.Select(c => c.Debit).FirstOrDefault();

                        debitPeriodic = DebitPerioicAccountBalance(periode, debitAccount, htva);

                        var creditAccount = Az.Select(c => c.Credit).FirstOrDefault();

                        creditPeriodic = CreditPerioicAccountBalance(periode, creditAccount, ttc);

                        return debitPeriodic && creditPeriodic && updateAccount;
                    }
                    catch (Exception e)
                    {
                        ViewData["GenericError"] = e.Message;
                    }
                }
            }
            #endregion
            #region Vendor Invoice
            if (ItemType.Equals("VendorInvoice"))
            {
                var Az = from line in db.LineVendorInvoices
                         group new { line, line.VendorInvoice } by new
                         {
                             line.VendorInvoice.id,
                             Debit=line.VendorInvoice.Company.paymentclearingaccountid, 
                             Credit=line.VendorInvoice.Supplier.accountid,
                             xMonth = (Convert.ToString((int?)line.VendorInvoice.ItemDate.Month)).Length == 1 ?
                                                     '0' + Convert.ToString((int?)line.VendorInvoice.ItemDate.Month) :
                                                     Convert.ToString((int?)line.VendorInvoice.ItemDate.Month),
                             xYear = Convert.ToString((int?)line.VendorInvoice.ItemDate.Year)
                         } into g
                         where g.Key.id == ItemID
                         select new
                         {
                             Periode = g.Key.xYear + g.Key.xMonth,
                             Debit=g.Key.Debit,
                             Credit=g.Key.Credit,
                             TTC = g.Sum(p => p.line.amount)
                         };
                if (Az != null)
                {
                    try
                    {
                        bool results = false;
                        foreach (var az in Az)
                        {
                            results = DebitPerioicAccountBalance(az.Periode, az.Debit, Convert.ToDecimal(az.TTC));
                            if (false.Equals(results))
                            {
                                return results;
                            }
                            results = CreditPerioicAccountBalance(az.Periode, az.Credit, Convert.ToDecimal(az.TTC));
                            if (false.Equals(results))
                            {
                                return results;
                            }
                            //return UpdateAccountBalabce(az.Account, Convert.ToDecimal(az.TotHTVA));
                        }
                        return true;
                    }
                    catch (Exception e)
                    {
                        ViewData["GenericError"] = e.Message;
                    }
                }
            }
            #endregion
            #region Purchase Order
            if (ItemType.Equals("PurchaseOrder"))
            {
                return true;
            }
            #endregion
            #region Payment
            if (ItemType.Equals("Payment"))
            {
                var Az = from line in db.LinePayments
                         group new { line, line.Payment } by new
                         {
                             line.Payment.id,
                             Debit = line.Payment.Company.paymentclearingaccountid,
                             Credit = line.Payment.Supplier.accountid,
                             AccountID=line.account,
                             OAccountID=line.oaccount,
                             Side=line.side,
                             xMonth = (Convert.ToString((int?)line.Payment.ItemDate.Month)).Length == 1 ?
                                                     '0' + Convert.ToString((int?)line.Payment.ItemDate.Month) :
                                                     Convert.ToString((int?)line.Payment.ItemDate.Month),
                             xYear = Convert.ToString((int?)line.Payment.ItemDate.Year)
                         } into g
                         where g.Key.id == ItemID
                         select new
                         {
                             Periode = g.Key.xYear + g.Key.xMonth,
                             Debit = g.Key.Debit,
                             Credit = g.Key.Credit,
                             AccountID=g.Key.AccountID,
                             OAccount=g.Key.OAccountID,
                             TTC = g.Sum(p => p.line.amount)
                         };
                if (Az != null)
                {
                    try
                    {
                        bool results = false;
                        foreach (var az in Az)
                        {
                            results = DebitPerioicAccountBalance(az.Periode, az.Debit, Convert.ToDecimal(az.TTC));
                            if (false.Equals(results))
                            {
                                return results;
                            }
                            results = CreditPerioicAccountBalance(az.Periode, az.Credit, Convert.ToDecimal(az.TTC));
                            if (false.Equals(results))
                            {
                                return results;
                            }
                            //return UpdateAccountBalabce(az.Account, Convert.ToDecimal(az.TotHTVA));
                        }
                        return true;
                    }
                    catch (Exception e)
                    {
                        ViewData["GenericError"] = e.Message;
                    }
                }
            }
            #endregion

            return false;
        }
        private bool UpdateStock(int DocumentID, string DocumentType)
        {
            if (DocumentType.Equals("GoodReceiving"))
            {
                List<ValidateStockViewModel> validateStock = 
                    (from line in db.LineGoodReceivings
                    group new { line, line.GoodReceiving } by new
                    {
                        DocumentID=line.GoodReceiving.id,
                        StoreID = line.GoodReceiving.store,
                        ItemID = line.item,
                        Price=line.price,
                        IsService = line.Article.IsService
                    } into g
                    where g.Key.DocumentID == DocumentID
                    select new ValidateStockViewModel
                    {
                        StoreID = g.Key.StoreID,
                        ItemID = g.Key.ItemID,
                        Quantity = g.Sum(q => q.line.quantity),
                        Price = g.Key.Price,
                        IsService = g.Key.IsService
                    }).ToList();

                if (validateStock!=null)
                {
                    return StockIn(validateStock);
                }
            }
            return true;//there is need to change later like: return StockOut(validateStock)
        }
        private bool SetToValidated(int ItemID, string ItemType)
        {
            try
            {
                if (ItemType=="GoodReceiving")
                {
                    var Az = db.GoodReceivings.FirstOrDefault(item => item.id == ItemID);
                    if (Az != null)
                    {
                        Az.IsValidated = true;
                        return true;
                    }
                }
                if (ItemType == "PurchaseOrder")
                {
                    var Az = db.PurchaseOrders.FirstOrDefault(item => item.id == ItemID);
                    if (Az != null)
                    {
                        Az.IsValidated = true;
                        return true;
                    }
                }
                if (ItemType == "InventoryInvoice")
                {
                    var Az = db.InventoryInvoices.FirstOrDefault(item => item.id == ItemID);
                    if (Az != null)
                    {
                        Az.IsValidated = true;
                        return true;
                    }
                }
                if (ItemType == "Payment")
                {
                    var Az = db.Payments.FirstOrDefault(item => item.id == ItemID);
                    if (Az != null)
                    {
                        Az.IsValidated = true;
                        return true;
                    }
                }
                if (ItemType == "VendorInvoice")
                {
                    var Az = db.VendorInvoices.FirstOrDefault(item => item.id == ItemID);
                    if (Az != null)
                    {
                        Az.IsValidated = true;
                        return true;
                    }
                }
                return false;
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
        private bool DebitPerioicAccountBalance(string Periode, string Account, decimal amount)
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
                    periodicAccountBalance.Debit = amount;

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
                periodicAccountBalance.Debit += amount;
            }
            return true;
        }
        private bool CreditPerioicAccountBalance(string Periode, string Account, decimal amount)
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
                    periodicAccountBalance.Credit = amount;

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
                periodicAccountBalance.Debit += amount;
            }
            return true;
        }
        private string GetItemType(string ItemType)
        {
            return db.Localizations.Where(i => i.LocalName == ItemType).Select(i => i.ItemName).FirstOrDefault();
        }
        private bool StockIn(List<ValidateStockViewModel> items)
        {
            try
            {
                foreach (var item in items)
                {
                    var article = db.Articles.FirstOrDefault(i => i.id == item.ItemID);
                    if (item.IsService)
                    {
                        //for IsService=true items
                        article.price = item.Price;
                        article.avgprice = item.Price;
                    }
                    else
                    {
                        //for IsService=false items
                        float currentStock = 0;
                        bool isItemInStock = db.Stocks.Any(i => i.itemid == item.ItemID);
                        if (isItemInStock)
                        {
                            currentStock = db.Stocks.Where(i => i.itemid == item.ItemID).Sum(q => q.quantity);
                        }
                        var stock = db.Stocks.FirstOrDefault(s => s.storeid == item.StoreID && s.itemid == item.ItemID);
                        if (stock == null)
                        {
                            stock = new Stock();
                            stock.id = Guid.NewGuid().ToString();
                            stock.name = "NA";
                            stock.modelid = 107;
                            stock.storeid = item.StoreID;
                            stock.itemid = item.ItemID;
                            stock.quantity = (float)item.Quantity;
                            db.Stocks.InsertOnSubmit(stock);
                        }
                        else
                        {
                            stock.quantity += (float)item.Quantity;
                        }
                        article.price = item.Price;
                        article.avgprice = (article.avgprice * (decimal)currentStock +
                                            item.Price * item.Quantity) / ((decimal)currentStock + item.Quantity);
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                ViewData["GenericError"] = e.Message;
            }
            return false;
        }
        private bool StockOut(List<ValidateStockViewModel> items)
        {
            //try
            //{
            //    foreach (var item in items)
            //    {
            //        var article = db.Articles.FirstOrDefault(i => i.id == item.ItemID);
            //        if (item.IsService)
            //        {
            //            //for IsService=true items
            //            article.price = item.Price;
            //            article.avgprice = item.Price;
            //        }
            //        else
            //        {
            //            //for IsService=false items
            //            float currentStock = 0;
            //            bool isItemInStock = db.Stocks.Any(i => i.itemid == item.ItemID);
            //            if (isItemInStock)
            //            {
            //                currentStock = db.Stocks.Where(i => i.itemid == item.ItemID).Sum(q => q.quantity);
            //            }
            //            var stock = db.Stocks.FirstOrDefault(s => s.storeid == item.StoreID && s.itemid == item.ItemID);
            //            if (stock == null)
            //            {
            //                stock = new Stock();
            //                stock.id = Guid.NewGuid().ToString();
            //                stock.name = "NA";
            //                stock.modelid = 107;
            //                stock.storeid = item.StoreID;
            //                stock.itemid = item.ItemID;
            //                stock.quantity = (float)item.Quantity;
            //                db.Stocks.InsertOnSubmit(stock);
            //            }
            //            else
            //            {
            //                stock.quantity += (float)item.Quantity;
            //            }
            //            article.price = item.Price;
            //            article.avgprice = (article.avgprice * (decimal)currentStock +
            //                                item.Price * item.Quantity) / ((decimal)currentStock + item.Quantity);
            //        }
            //    }
            //    return true;
            //}
            //catch (Exception e)
            //{
            //    ViewData["GenericError"] = e.Message;
            //}
            return false;
        }
        #endregion
    }
}