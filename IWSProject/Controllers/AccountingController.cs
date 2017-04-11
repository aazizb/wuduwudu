using IWSProject.Content;
using IWSProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
//
using DevExpress.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections;
using System.Threading;
using System.Web;

namespace IWSProject.Controllers
{
    [Authorize]
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

        [HttpPost, ValidateInput(false)]
        public ActionResult Index(string selectedIDsHF)
        {
            string selectedItems = selectedIDsHF;
            //check if items were selected previously
            if (!string.IsNullOrEmpty(selectedItems))
            {
                IList<string> items = new List<string>(selectedItems.Split(new string[] { ";" }, StringSplitOptions.None));
                foreach (string item in items)
                {
                    bool results = false;
                    int ItemID;
                    string ItemType;
                    var list = item.Split(new string[] { "," }, StringSplitOptions.None);

                    ItemID = Convert.ToInt32(list[0]);

                    ItemType = GetItemType(list[1]);

                    results = UpdateStock(ItemID, ItemType);
                    if (!results)
                    {
                        ViewData["GenericError"] = IWSLocalResource.GenericError;
                        return RedirectToAction("Index");
                    }
                    results = Account(ItemID, ItemType);
                    if (!results)
                    {
                        ViewData["GenericError"] = IWSLocalResource.GenericError;
                        return RedirectToAction("Index");
                    }
                    results = Validate(ItemID, ItemType);
                    if (results)
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

        [ValidateInput(false)]
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

        /// <summary>
        /// validates documents
        /// </summary>
        /// <param name="document ID ItemID"></param>
        /// <param name="document type ItemType"></param>
        /// <returns>bool</returns>
        private bool Account(int ItemID, string ItemType)
        {
            bool results;
            if (ItemType.Equals(IWSLookUp.DocsType.GoodReceiving.ToString()))
            {
               return ValidateGoodReceiving(ItemID);
            }
            if (ItemType.Equals(IWSLookUp.DocsType.BillOfDelivery.ToString()))
            {
                return ValidateBillOfDelivery(ItemID);
            }
            if (ItemType.Equals(IWSLookUp.DocsType.InventoryInvoice.ToString()))
            {
                return MakeVendorInvoice(ItemID);
            }
            if (ItemType.Equals(IWSLookUp.DocsType.CustomerInvoice.ToString()))
            {
                results = MakeSettlement(ItemID);
                if (results)
                    return ValidateCustmerInvoice(ItemID);
            }
            if (ItemType.Equals(IWSLookUp.DocsType.VendorInvoice.ToString()))
            {
                results = MakePayment(ItemID);
                if(results)
                    return ValidateVendorInvoice(ItemID);
            }
            if (ItemType.Equals(IWSLookUp.DocsType.SalesInvoice.ToString()))
            {
                return MakeCustomerInvoice(ItemID);
             }
            if (ItemType.Equals(IWSLookUp.DocsType.Payment.ToString()))
            {
                return ValidatePayment(ItemID);
            }
            if (ItemType.Equals(IWSLookUp.DocsType.Settlement.ToString()))
            {
                return ValidateSettlement(ItemID);
            }
            if (ItemType.Equals(IWSLookUp.DocsType.GeneralLedger.ToString()))
            {
                return ValidateGeneralLedger(ItemID);
            }
            return true;
        }
        private bool UpdateStock(int DocumentID, string DocumentType)
        {
            if (DocumentType.Equals(IWSLookUp.DocsType.GoodReceiving.ToString()))
            {
                List<ValidateStockViewModel> validateStock =
                    (from line in db.LineGoodReceivings
                     group new { line, line.GoodReceiving, line.Article } by new
                     {
                         DocumentID = line.GoodReceiving.id,
                         StoreID = line.GoodReceiving.store,
                         ItemID = line.item,
                         ItemName=line.Article.name,
                         Price = line.price,
                         Currency=line.Currency,
                         IsService = line.Article.IsService
                     } into g
                     where g.Key.DocumentID == DocumentID
                     select new ValidateStockViewModel
                     {
                         StoreID = g.Key.StoreID,
                         ItemID = g.Key.ItemID,
                         ItemName=g.Key.ItemName,
                         Quantity = g.Sum(q => q.line.quantity),
                         Price = g.Key.Price,
                         Currency=g.Key.Currency,
                         IsService = g.Key.IsService
                     }).ToList();
                if (validateStock.Any())
                {
                    return StockIn(validateStock);
                }
            }
            if (DocumentType.Equals(IWSLookUp.DocsType.BillOfDelivery.ToString()))
            {
                List<ValidateStockViewModel> validateStock =
                    (from line in db.LineBillOfDeliveries
                     group new { line, line.BillOfDelivery } by new
                     {
                         DocumentID = line.BillOfDelivery.id,
                         StoreID = line.BillOfDelivery.store,
                         ItemID = line.item,
                         ItemName = line.Article.name,
                         Price = line.price,
                         IsService = line.Article.IsService
                     } into g
                     where g.Key.DocumentID == DocumentID
                     select new ValidateStockViewModel
                     {
                         StoreID = g.Key.StoreID,
                         ItemID = g.Key.ItemID,
                         ItemName=g.Key.ItemName,
                         Quantity = g.Sum(q => q.line.quantity),
                         Price = g.Key.Price,
                         IsService = g.Key.IsService
                     }).ToList();
                if (validateStock.Any(i=>i.IsService==false))
                {
                    return StockOut(validateStock);
                }
            }
            return true;
        }
        private bool Validate(int ItemID, string ItemType)
        {
            try
            {
                if (ItemType.Equals(IWSLookUp.DocsType.PurchaseOrder.ToString()))
                {
                    var docs = db.PurchaseOrders.Single(item => item.id == ItemID);
                    if (docs != null)
                    {
                        docs.IsValidated = true;
                        return true;
                    }
                }
                if (ItemType.Equals(IWSLookUp.DocsType.SalesOrder.ToString()))
                {
                    var docs = db.SalesOrders.Single(item => item.id == ItemID);
                    if (docs != null)
                    {
                        docs.IsValidated = true;
                        return true;
                    }
                }
                if (ItemType.Equals(IWSLookUp.DocsType.GoodReceiving.ToString()))
                {
                    var docs = db.GoodReceivings.Single(item => item.id == ItemID);
                    if (docs != null)
                    {
                        docs.IsValidated = true;
                        return true;
                    }
                }
                if (ItemType.Equals(IWSLookUp.DocsType.BillOfDelivery.ToString()))
                {
                    var docs = db.BillOfDeliveries.Single(item => item.id == ItemID);
                    if (docs != null)
                    {
                        docs.IsValidated = true;
                        return true;
                    }
                }
                if (ItemType.Equals(IWSLookUp.DocsType.InventoryInvoice.ToString()))
                {
                    var docs = db.InventoryInvoices.Single(item => item.id == ItemID);
                    if (docs != null)
                    {
                        docs.IsValidated = true;
                        return true;
                    }
                }
                if (ItemType.Equals(IWSLookUp.DocsType.CustomerInvoice.ToString()))
                {
                    var docs = db.CustomerInvoices.Single(item => item.id == ItemID);
                    if (docs != null)
                    {
                        docs.IsValidated = true;
                        return true;
                    }
                }
                if (ItemType.Equals(IWSLookUp.DocsType.VendorInvoice.ToString()))
                {
                    var docs = db.VendorInvoices.Single(item => item.id == ItemID);
                    if (docs != null)
                    {
                        docs.IsValidated = true;
                        return true;
                    }
                }
                if (ItemType.Equals(IWSLookUp.DocsType.SalesInvoice.ToString()))
                {
                    var docs = db.SalesInvoices.Single(item => item.id == ItemID);
                    if (docs != null)
                    {
                        docs.IsValidated = true;
                        return true;
                    }
                }
                if (ItemType.Equals(IWSLookUp.DocsType.Payment.ToString()))
                {
                    var docs = db.Payments.Single(item => item.id == ItemID);
                    if (docs != null)
                    {
                        docs.IsValidated = true;
                        return true;
                    }
                }
                if (ItemType.Equals(IWSLookUp.DocsType.Settlement.ToString()))
                {
                    var docs = db.Settlements.Single(item => item.id == ItemID);
                    if (docs != null)
                    {
                        docs.IsValidated = true;
                        return true;
                    }
                }
                if (ItemType.Equals(IWSLookUp.DocsType.GeneralLedger.ToString()))
                {
                    var docs = db.GeneralLedgers.Single(item => item.id == ItemID);
                    if (docs != null)
                    {
                        docs.IsValidated = true;
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                ViewData["GenericError"] = e.Message;
            }
            return false;
        }
        private bool UpdateAccountBalance(string accountID, decimal amount)
        {
            try
            {
                var docs = db.Accounts.FirstOrDefault(a => a.id == accountID);
                if (docs != null)
                {
                    docs.balance += amount;
                    return true;
                }
            }
            catch (Exception e)
            {
                ViewData["GenericError"] = e.Message;
            }
            return false;
        }
        private bool UpdatePeriodicAccountBalance(string Periode, string AccountID, decimal amount, string currency, bool IsDebit)
        {
            string companyID = (string)Session["CompanyID"];
            var docs = db.PeriodicAccountBalances
                       .FirstOrDefault(p => p.Periode == Periode 
                        && p.AccountId == AccountID 
                        && p.CompanyID==companyID);
            if (docs == null)
            {
                string name = db.Accounts
                    .Where(a => a.id == AccountID && a.CompanyID == companyID)
                    .Select(n => n.name)
                    .Single();
                docs = new PeriodicAccountBalance
                {
                    Name = name,
                    ModelId = 106,
                    Periode = Periode,
                    AccountId = AccountID,
                    CompanyID = companyID,
                    Debit = 0,
                    Credit = 0,
                    Currency=currency
                 };
                if (IsDebit)
                {
                    docs.Debit = amount;
                }
                else
                {
                    docs.Credit = amount;
                }
                try
                {
                    db.PeriodicAccountBalances.InsertOnSubmit(docs);
                    return true;
                }
                catch (Exception e)
                {
                    ViewData["GenericError"] = e.Message;
                    return false;
                }
            }
            else
            {
                try
                {
                    if (IsDebit)
                    {
                        docs.Debit += amount;
                    }
                    else
                    {
                        docs.Credit += amount;
                    }
                    return true;
                }
                catch (Exception e)
                {
                    ViewData["GenericError"] = e.Message;
                    return false;
                }
            }
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
                    var article = db.Articles
                        .FirstOrDefault(i => i.id == item.ItemID 
                        && i.CompanyID== (string)Session["CompanyID"]);
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
                        bool isItemInStock = db.Stocks.
                            Any(i => i.itemid == item.ItemID
                            && i.CompanyID== (string)Session["CompanyID"]);
                        if (isItemInStock)
                        {
                            currentStock = db.Stocks
                                .Where(i => i.itemid == item.ItemID 
                                && i.CompanyID== (string)Session["CompanyID"])
                                .Sum(q => q.quantity);
                        }
                        var stock = db.Stocks
                            .FirstOrDefault(s => s.storeid == item.StoreID 
                            && s.itemid == item.ItemID 
                            && s.CompanyID== (string)Session["CompanyID"]);
                        if (stock == null)
                        {
                            stock = new Stock()
                            {
                                itemid = item.ItemID,
                                name = item.ItemName,
                                modelid = 107,
                                storeid = item.StoreID,
                                CompanyID = (string)Session["CompanyID"],
                                Currency = item.Currency,
                                quantity = (float)item.Quantity
                            };
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
            try
            {
                foreach (var item in items.Where(i=>i.IsService==false))
                {
                        var stock = db.Stocks.FirstOrDefault(s => s.storeid == item.StoreID && s.itemid == item.ItemID);
                        if (stock != null)
                        {
                            decimal RequestedQuantity = Convert.ToDecimal(item.Quantity);
                            decimal AvailableQuantity = Convert.ToDecimal(stock.quantity + stock.minstock);
                            if (AvailableQuantity >= RequestedQuantity)
                            {
                                stock.quantity -= (float)item.Quantity;
                            }
                            else
                            {
                                ViewData["GenericError"] = IWSLocalResource.InsufficientStock + ": " + item.ItemID + "-" + item.ItemName;
                                return false;
                            }
                        }
                        else
                        {
                            ViewData["GenericError"] = IWSLocalResource.InsufficientStock + ": " + item.ItemID + "-" + item.ItemName;
                            return false;
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
        private bool ValidateInventoryInvoice(int ItemID)
        {
            List<ValidateInvoiceViewModel> docs =
                (from line in db.LineInventoryInvoices
                 group new { line, line.Article.Vat, line.InventoryInvoice } by new
                 {
                     line.VATCode,
                     line.Currency,
                     line.InventoryInvoice.id,
                     line.InventoryInvoice.oid,
                     line.InventoryInvoice.store,
                     line.InventoryInvoice.account,
                     line.InventoryInvoice.text,
                     line.InventoryInvoice.ItemDate,
                     line.InventoryInvoice.CompanyId,
                     line.Article.Vat.inputvataccountid,
                     line.InventoryInvoice.Supplier.accountid,
                     line.InventoryInvoice.Company.purchasingclearingaccountid,
                     xMonth = (Convert.ToString((int?)line.InventoryInvoice.ItemDate.Month)).Length == 1 ?
                                             '0' + Convert.ToString((int?)line.InventoryInvoice.ItemDate.Month) :
                                             Convert.ToString((int?)line.InventoryInvoice.ItemDate.Month),
                     xYear = Convert.ToString((int?)line.InventoryInvoice.ItemDate.Year)
                 } into g
                 where g.Key.id == ItemID
                 select new ValidateInvoiceViewModel
                 {
                     ID = g.Key.id,
                     StoreID = g.Key.store,
                     SupplierID = g.Key.account,
                     ItemDate = g.Key.ItemDate,
                     Text = g.Key.text,
                     CompanyID = g.Key.CompanyId,
                     VatCode = g.Key.VATCode,
                     VatAccountID = g.Key.inputvataccountid,
                     Periode = g.Key.xYear + g.Key.xMonth,
                     DebitAccountID = g.Key.purchasingclearingaccountid,
                     CreditAccountID = g.Key.accountid,
                     TotHTVA = g.Sum(p => p.line.quantity * p.line.price),
                     TotTVA = g.Sum(p => p.line.quantity * p.line.price * p.line.Article.Vat.PVat),
                     Currency = g.Key.Currency
                 }).ToList();
            if (docs.Any())
            {
                try
                {
                    bool debitPeriodic = false;
                    bool updateAccount = false;
                    bool creditPeriodic = false;
                    var htva = Math.Round(docs.Sum(s => s.TotHTVA), 2);
                    var ttc = Math.Round(docs.Sum(s => s.TotTVA), 2) + 
                                    Math.Round(docs.Sum(s => s.TotHTVA), 2);

                    foreach (var doc in docs)
                    {
                        var tva = Math.Round(doc.TotTVA, 2);

                        debitPeriodic = UpdatePeriodicAccountBalance(doc.Periode,
                                        doc.VatAccountID, tva, doc.Currency, true);

                        updateAccount = UpdateAccountBalance(doc.VatAccountID, tva);
                    }
                    var periode = docs.Select(p => p.Periode).First();

                    var debitAccount = docs.Select(c => c.DebitAccountID).FirstOrDefault();

                    var currency = docs.Select(p => p.Currency).First();

                    debitPeriodic = UpdatePeriodicAccountBalance(periode, debitAccount, htva, currency, true);

                    var creditAccount = docs.Select(c => c.CreditAccountID).FirstOrDefault();

                    creditPeriodic = UpdatePeriodicAccountBalance(periode, creditAccount, ttc, currency, false);

                    return debitPeriodic && creditPeriodic && updateAccount;
                }
                catch (Exception e)
                {
                    ViewData["GenericError"] = e.Message;
                    return false;
                }
            }
            return false;
        }
        private bool ValidateGoodReceiving(int ItemID)
        {
           List<JournalViewModel> docs = (from line in db.LineGoodReceivings
                       group new { line, line.Article.Vat, line.GoodReceiving } by new
                       {
                           line.GoodReceiving.id,
                           line.GoodReceiving.oid,
                           line.modelid,
                           line.Currency,
                           line.GoodReceiving.account,
                           line.GoodReceiving.store,
                           line.GoodReceiving.ItemDate,
                           line.GoodReceiving.Company.purchasingclearingaccountid,
                           line.Article.Vat.stockaccountid,
                           xMonth = (Convert.ToString((int?)line.GoodReceiving.ItemDate.Month)).Length == 1 ?
                                                   '0' + Convert.ToString((int?)line.GoodReceiving.ItemDate.Month) :
                                                   Convert.ToString((int?)line.GoodReceiving.ItemDate.Month),
                           xYear = Convert.ToString((int?)line.GoodReceiving.ItemDate.Year)
                       } into g
                       where g.Key.id == ItemID
                       select new JournalViewModel
                       {
                           ItemID = g.Key.id,
                           OID = Convert.ToInt32( g.Key.oid),
                           ModelID = g.Key.modelid,
                           CustSupplierID=g.Key.account,
                           StoreID=g.Key.store,
                           TransDate=g.Key.ItemDate,
                           Periode = g.Key.xYear + g.Key.xMonth,
                           Account = g.Key.stockaccountid,
                           OAccount=g.Key.purchasingclearingaccountid,
                           Amount = g.Sum(p => p.line.quantity * p.line.price),
                           Currency=g.Key.Currency
                       }).ToList();

            if (docs.Any())
            {
                try
                {
                    bool results;
                    string accountID = string.Empty;
                    var periode = docs.Select(p => p.Periode).FirstOrDefault().ToString();
                    decimal tvaAmount = 0;
                    string currency = string.Empty;
                    foreach (var doc in docs)
                    {
                        accountID = doc.Account;

                        tvaAmount = Math.Round(doc.Amount, 2);

                        currency = (doc.Currency == null) ? (string)Session["Currency"] : doc.Currency;

                        results= UpdatePeriodicAccountBalance(periode, accountID, tvaAmount, currency, true);

                        if(!results)
                            return results;

                        results = UpdateAccountBalance(accountID, tvaAmount);

                        if (!results)
                            return results;

                        List<Journal> journal = new List<Journal> {
                            new Journal { ItemID=doc.ItemID,
                                OID =doc.OID,
                                ModelID =doc.ModelID,
                                CustSupplierID=doc.CustSupplierID,
                                StoreID =doc.StoreID,
                                TransDate =doc.TransDate,
                                Periode=doc.Periode,
                                Account =doc.Account,
                                OAccount =doc.OAccount,
                                Amount =doc.Amount,
                                Currency=doc.Currency,
                                ItemType = IWSLookUp.DocsType.GoodReceiving.ToString(),
                                Side = IWSLookUp. Side.Debit.ToString(),
                                CompanyID=(string)Session["CompanyID"]},
                            new Journal { ItemID=doc.ItemID,
                                OID =doc.OID, ModelID=doc.ModelID,
                                CustSupplierID=doc.CustSupplierID,
                                StoreID =doc.StoreID,
                                TransDate =doc.TransDate,
                                Periode=doc.Periode,
                                Account =doc.OAccount,
                                OAccount =doc.Account,
                                Amount =doc.Amount,
                                Currency=doc.Currency,
                                ItemType = IWSLookUp. DocsType.GoodReceiving.ToString(),
                                Side =IWSLookUp. Side.Credit.ToString(),
                                CompanyID=(string)Session["CompanyID"]} };
                        
                        results = SendToJournal(journal);

                        if (!results)
                            return results;
                    }
                    var item = (from doc in docs
                                       group new { doc } by new
                                       {
                                           doc.Periode,
                                           doc.OAccount,
                                           doc.Currency
                                       } into g
                                       select new { Periode = g.Key.Periode,
                                                   accountID =g.Key.OAccount,
                                                   tvaAmount = g.Sum(p => p.doc.Amount),
                                                   currency=g.Key.Currency }).Single();
                    return UpdatePeriodicAccountBalance(item.Periode, item.accountID, item.tvaAmount, item.currency, false);
                }
                catch (Exception e)
                {
                    ViewData["GenericError"] = e.Message;
                }
            }
            return false;
        }
        private bool ValidateBillOfDelivery(int ItemID)
        {
            List<JournalViewModel> docs = (from line in db.LineBillOfDeliveries
                                           group new { line, line.Article.Vat, line.BillOfDelivery } by new
                                           {
                                               line.BillOfDelivery.id,
                                               line.BillOfDelivery.oid,
                                               line.modelid,
                                               line.Currency,
                                               line.BillOfDelivery.account,
                                               line.BillOfDelivery.store,
                                               line.BillOfDelivery.ItemDate,
                                               line.BillOfDelivery.Company.salesclearingaccountid,
                                               line.Article.Vat.expenseaccountid,
                                               xMonth = (Convert.ToString((int?)line.BillOfDelivery.ItemDate.Month)).Length == 1 ?
                                                                       '0' + Convert.ToString((int?)line.BillOfDelivery.ItemDate.Month) :
                                                                       Convert.ToString((int?)line.BillOfDelivery.ItemDate.Month),
                                               xYear = Convert.ToString((int?)line.BillOfDelivery.ItemDate.Year)
                                           } into g
                                           where g.Key.id == ItemID
                                           select new JournalViewModel
                                           {
                                               ItemID = g.Key.id,
                                               OID = Convert.ToInt32(g.Key.oid),
                                               ModelID = g.Key.modelid,
                                               CustSupplierID = g.Key.account,
                                               StoreID = g.Key.store,
                                               TransDate = g.Key.ItemDate,
                                               Periode = g.Key.xYear + g.Key.xMonth,
                                               Account = g.Key.expenseaccountid,
                                               OAccount = g.Key.salesclearingaccountid,
                                               Amount = g.Sum(p => p.line.quantity * p.line.Article.avgprice),
                                               Currency = g.Key.Currency
                                           }).ToList();
            if (docs.Any())
            {
                try
                {
                    bool results;

                    string accountID = string.Empty;
                    var periode = docs.Select(p => p.Periode).FirstOrDefault().ToString();
                    decimal tvaAmount = 0;
                    string currency = string.Empty;
                    foreach (var doc in docs)
                    {
                        accountID = doc.Account;

                        tvaAmount = Math.Round(doc.Amount, 2);

                        currency = (doc.Currency == null) ? (string)Session["Currency"] : doc.Currency;

                        results = UpdatePeriodicAccountBalance(periode, accountID, tvaAmount, currency, true);

                        if (!results)
                            return results;

                        results = UpdateAccountBalance(accountID, tvaAmount);

                        if (!results)
                            return results;

                        List<Journal> journal = new List<Journal> {
                            new Journal { ItemID=doc.ItemID,
                                OID =doc.OID,
                                ModelID =doc.ModelID,
                                CustSupplierID=doc.CustSupplierID,
                                StoreID =doc.StoreID,
                                TransDate =doc.TransDate,
                                Periode=doc.Periode,
                                Account =doc.Account,
                                OAccount =doc.OAccount,
                                Amount =doc.Amount,
                                Currency =doc.Currency,
                                ItemType = IWSLookUp. DocsType.BillOfDelivery.ToString(),
                                Side = IWSLookUp. Side.Debit.ToString(),
                                CompanyID=(string)Session["CompanyID"]},
                            new Journal { ItemID=doc.ItemID,
                                OID =doc.OID,
                                ModelID =doc.ModelID,
                                CustSupplierID=doc.CustSupplierID,
                                StoreID = doc.StoreID,
                                TransDate =doc.TransDate,
                                Periode=doc.Periode,
                                Account =doc.OAccount,
                                OAccount =doc.Account,
                                Amount =doc.Amount,
                                Currency=doc.Currency,
                                ItemType = IWSLookUp. DocsType.BillOfDelivery.ToString(),
                                Side = IWSLookUp. Side.Credit.ToString(),
                                CompanyID=(string)Session["CompanyID"]} };
                        results = SendToJournal(journal);

                        if (!results)
                            return results;
                    }
                    var item = (from doc in docs
                                group new { doc } by new
                                {
                                    doc.Periode,
                                    doc.OAccount,doc.Currency
                                } into g
                                select new
                                {
                                    Periode = g.Key.Periode,
                                    accountID = g.Key.OAccount,
                                    tvaAmount = g.Sum(p => p.doc.Amount),
                                    currency=g.Key.Currency
                                }).Single();
                    return UpdatePeriodicAccountBalance(item.Periode, item.accountID, item.tvaAmount, item.currency, false);
                }
                catch (Exception e)
                {
                    ViewData["GenericError"] = e.Message;
                }
            }
            return false;
        }
        private bool ValidateVendorInvoice(int vendorInvoiceID)
        {
            var docs =
                (from line in db.LineVendorInvoices
                 group new { line, line.VendorInvoice } by new
                 {
                     line.VendorInvoice.id,
                     line.text,
                     line.account,
                     line.side,
                     line.oaccount,
                     line.amount,
                     line.Currency,
                     line.duedate,
                     xMonth = (Convert.ToString((int?)line.VendorInvoice.ItemDate.Month)).Length == 1 ?
                                             '0' + Convert.ToString((int?)line.VendorInvoice.ItemDate.Month) :
                                             Convert.ToString((int?)line.VendorInvoice.ItemDate.Month),
                     xYear = Convert.ToString((int?)line.VendorInvoice.ItemDate.Year)
                 } into g
                 where g.Key.id == vendorInvoiceID
                 select new
                 {
                     Description=g.Key.text,
                     AccountId=g.Key.account,
                     OAccountId=g.Key.oaccount,
                     Periode = g.Key.xYear + g.Key.xMonth,
                     Amount=g.Key.amount,
                     Currency=g.Key.Currency
                 }).ToList();
            if (docs.Any())
            {
                try
                {
                    bool debitPeriodic = false;
                    bool updateAccount = false;
                    bool creditPeriodic = false;
                
                    foreach (var doc in docs)
                    {
                        debitPeriodic = UpdatePeriodicAccountBalance(doc.Periode,
                                        doc.AccountId, doc.Amount, doc.Currency, true);
                        updateAccount = UpdateAccountBalance(doc.AccountId, doc.Amount);
                    }
                    var periode = docs.Select(p => p.Periode).First();

                    var creditAccount = docs.Select(c => c.OAccountId).FirstOrDefault();
                    var ttc = docs.Sum(s => s.Amount);
                    var currency = docs.Select(p => p.Currency).First();
                    creditPeriodic = UpdatePeriodicAccountBalance(periode, creditAccount, ttc, currency, false);

                    return debitPeriodic && creditPeriodic && updateAccount;
                }
                catch (Exception e)
                {
                    ViewData["GenericError"] = e.Message;
                    return false;
                }
            }
            return true;

        }
        private bool ValidateCustmerInvoice(int customernvoiceID)
        {
            var docs =
                (from line in db.LineCustomerInvoices
                 group new { line, line.CustomerInvoice } by new
                 {
                     line.CustomerInvoice.id,
                     line.text,
                     line.account,
                     line.side,
                     line.oaccount,
                     line.amount,
                     line.Currency,
                     line.duedate,
                     xMonth = (Convert.ToString((int?)line.CustomerInvoice.ItemDate.Month)).Length == 1 ?
                                             '0' + Convert.ToString((int?)line.CustomerInvoice.ItemDate.Month) :
                                             Convert.ToString((int?)line.CustomerInvoice.ItemDate.Month),
                     xYear = Convert.ToString((int?)line.CustomerInvoice.ItemDate.Year)
                 } into g
                 where g.Key.id == customernvoiceID
                 select new
                 {
                     Description = g.Key.text,
                     AccountId = g.Key.oaccount,
                     OAccountId = g.Key.account,
                     Periode = g.Key.xYear + g.Key.xMonth,
                     Amount = g.Key.amount,
                     Currency= g.Key.Currency
                 }).ToList();
            if (docs.Any())
            {
                try
                {
                    bool debitPeriodic = false;
                    bool updateAccount = false;
                    bool creditPeriodic = false;

                    foreach (var doc in docs)
                    {
                        debitPeriodic = UpdatePeriodicAccountBalance(doc.Periode,
                                        doc.AccountId, doc.Amount, doc.Currency, false);              
                        updateAccount = UpdateAccountBalance(doc.AccountId, doc.Amount);
                    }
                    var periode = docs.Select(p => p.Periode).First();

                    var creditAccount = docs.Select(c => c.OAccountId).FirstOrDefault();
                    var ttc = docs.Sum(s => s.Amount);
                    var currency = docs.Select(p => p.Currency).First();
                    creditPeriodic = UpdatePeriodicAccountBalance(periode, creditAccount, ttc, currency, true);  

                    return debitPeriodic && creditPeriodic && updateAccount;
                }
                catch (Exception e)
                {
                    ViewData["GenericError"] = e.Message;
                    return false;
                }
            }
            return true;

        }
        private bool ValidatePayment(int paymentID)
        {
            bool results = false;
            var docs =
                (from line in db.LinePayments
                 group new { line, line.Payment } by new
                 {
                     line.Payment.id,
                     line.Payment.Company.bankaccountid,
                     line.text,
                     line.account,
                     line.side,
                     line.oaccount,
                     line.amount,
                     line.Currency,
                     line.duedate,
                     xMonth = (Convert.ToString((int?)line.Payment.ItemDate.Month)).Length == 1 ?
                                             '0' + Convert.ToString((int?)line.Payment.ItemDate.Month) :
                                             Convert.ToString((int?)line.Payment.ItemDate.Month),
                     xYear = Convert.ToString((int?)line.Payment.ItemDate.Year)
                 } into g
                 where g.Key.id == paymentID
                 select new
                 {
                     Description = g.Key.text,
                     BankAccountID=g.Key.bankaccountid,
                     AccountId = g.Key.account,
                     OAccountId = g.Key.oaccount,
                     Periode = g.Key.xYear + g.Key.xMonth,
                     Amount = g.Key.amount,
                     Currency=g.Key.Currency
                 }).ToList();
            if (docs.Any())
            {
                try
                {

                    foreach (var doc in docs)
                    {
                        results = UpdatePeriodicAccountBalance(doc.Periode,
                                            doc.OAccountId, doc.Amount, doc.Currency, false);
                        if (!results)
                            return results;
                        results = UpdateAccountBalance(doc.OAccountId, doc.Amount);
                        if (!results)
                            return results;
                    }
                    var periode = docs.Select(p => p.Periode).First();
                    var creditAccount = docs.Select(c => c.AccountId).FirstOrDefault();
                    var ttc = docs.Sum(s => s.Amount);
                    var currency = docs.Select(p => p.Currency).First();
                    results = UpdatePeriodicAccountBalance(periode, creditAccount, ttc, currency, true);
                    if (!results)
                        return results;
               
                    if (!results)
                        return results;
                    var journals =
                         (from line in db.LinePayments
                          group new { line, line.Payment } by new
                          {
                              line.Payment.id,
                              line.Payment.oid,
                              line.Payment.modelid,
                              line.Payment.store,
                              SupplierID = line.Payment.account,
                              line.Payment.text,
                              line.Payment.ItemDate,
                              line.Payment.CompanyId,
                              line.account,
                              line.oaccount,
                              line.amount,
                              line.Currency,
                              line.Payment.Company.bankaccountid,
                              xMonth = (Convert.ToString((int?)line.Payment.ItemDate.Month)).Length == 1 ?
                                                      '0' + Convert.ToString((int?)line.Payment.ItemDate.Month) :
                                                      Convert.ToString((int?)line.Payment.ItemDate.Month),
                              xYear = Convert.ToString((int?)line.Payment.ItemDate.Year)
                          } into g
                          where g.Key.id == paymentID
                          select new
                          {
                              ItemID = g.Key.id,
                              OID = (int)g.Key.oid,
                              ModelID = g.Key.modelid,
                              ItemType = IWSLookUp.DocsType.Payment.ToString(),
                              CustSupplierID = g.Key.SupplierID,
                              StoreID = g.Key.store,
                              TransDate = g.Key.ItemDate,
                              Periode = g.Key.xYear + g.Key.xMonth,
                              Account = g.Key.account,
                              OAccount = g.Key.oaccount,
                              Amount = g.Key.amount,
                              Currency=g.Key.Currency
                          }).ToList();

                    foreach (var item in journals)
                    {
                        List<Journal> journal = new List<Journal> {
                            new Journal { ItemID=item.ItemID,
                            OID =item.OID,
                            ModelID =item.ModelID,
                            CustSupplierID=item.CustSupplierID,
                            StoreID =item.StoreID,
                            TransDate =item.TransDate,
                            Periode=item.Periode,
                            Account =item.Account,
                            OAccount =item.OAccount,
                            Amount =item.Amount,
                            Currency=item.Currency,
                            ItemType =IWSLookUp. DocsType.Payment.ToString(),
                            Side =IWSLookUp. Side.Debit.ToString(),
                            CompanyID=(string)Session["CompanyID"]},
                        new Journal { ItemID=item.ItemID,
                            OID =item.OID, ModelID=item.ModelID,
                            CustSupplierID=item.CustSupplierID,
                            StoreID =item.StoreID,
                            TransDate =item.TransDate,
                            Periode=item.Periode,
                            Account =item.OAccount,
                            OAccount =item.Account,
                            Amount =item.Amount,
                            Currency=item.Currency,
                            ItemType = IWSLookUp. DocsType.Payment.ToString(),
                            Side = IWSLookUp. Side.Credit.ToString(),
                            CompanyID=(string)Session["CompanyID"]} };
                        results = SendToJournal(journal);
                        if (!results)
                            return results;
                    }
                }
                catch (Exception e)
                {
                    ViewData["GenericError"] = e.Message;
                }
            }
            return results;
        }
        private bool ValidateSettlement(int settlementID)
        {
            bool results = false;
            var docs =
                (from line in db.LineSettlements
                 group new { line, line.Settlement } by new
                 {
                     line.Settlement.id,
                     line.Settlement.Company.bankaccountid,
                     line.text,
                     line.account,
                     line.side,
                     line.oaccount,
                     line.amount,
                     line.Currency,
                     line.duedate,
                     xMonth = (Convert.ToString((int?)line.Settlement.ItemDate.Month)).Length == 1 ?
                                             '0' + Convert.ToString((int?)line.Settlement.ItemDate.Month) :
                                             Convert.ToString((int?)line.Settlement.ItemDate.Month),
                     xYear = Convert.ToString((int?)line.Settlement.ItemDate.Year)
                 } into g
                 where g.Key.id == settlementID
                 select new
                 {
                     Description = g.Key.text,
                     BankAccountID = g.Key.bankaccountid,
                     AccountId = g.Key.account,
                     OAccountId = g.Key.oaccount,
                     Periode = g.Key.xYear + g.Key.xMonth,
                     Amount = g.Key.amount,
                     Currency=g.Key.Currency
                 }).ToList();
            if (docs.Any())
            {
                try
                {

                    foreach (var doc in docs)
                    {
                        results = UpdatePeriodicAccountBalance(doc.Periode,
                                            doc.OAccountId, doc.Amount, doc.Currency, false);
                        if (!results)
                            return results;
                        results = UpdateAccountBalance(doc.OAccountId, doc.Amount);
                        if (!results)
                            return results;
                    }
                    var periode = docs.Select(p => p.Periode).First();
                    var creditAccount = docs.Select(c => c.AccountId).FirstOrDefault();
                    var ttc = docs.Sum(s => s.Amount);
                    var currency = docs.Select(p => p.Currency).First();
                    results = UpdatePeriodicAccountBalance(periode, creditAccount, ttc, currency, true);
                    if (!results)
                        return results;
                    var journals =
                         (from line in db.LineSettlements
                          group new { line, line.Settlement } by new
                          {
                              line.Settlement.id,
                              line.Settlement.oid,
                              line.Settlement.modelid,
                              line.Settlement.store,
                              SupplierID = line.Settlement.account,
                              line.Settlement.text,
                              line.Settlement.ItemDate,
                              line.Settlement.CompanyId,
                              line.account,
                              line.oaccount,
                              line.amount,
                              line.Currency,
                              line.Settlement.Company.bankaccountid,
                              xMonth = (Convert.ToString((int?)line.Settlement.ItemDate.Month)).Length == 1 ?
                                                      '0' + Convert.ToString((int?)line.Settlement.ItemDate.Month) :
                                                      Convert.ToString((int?)line.Settlement.ItemDate.Month),
                              xYear = Convert.ToString((int?)line.Settlement.ItemDate.Year)
                          } into g
                          where g.Key.id == settlementID
                          select new
                          {
                              ItemID = g.Key.id,
                              OID = (int)g.Key.oid,
                              ModelID = g.Key.modelid,
                              ItemType = IWSLookUp.DocsType.Settlement.ToString(),
                              CustSupplierID = g.Key.SupplierID,
                              StoreID = g.Key.store,
                              TransDate = g.Key.ItemDate,
                              Periode = g.Key.xYear + g.Key.xMonth,
                              Account = g.Key.account,
                              OAccount = g.Key.oaccount,
                              Amount = g.Key.amount,
                              Currency=g.Key.Currency
                          }).ToList();

                    foreach (var item in journals)
                    {
                        List<Journal> journal = new List<Journal> {
                            new Journal { ItemID=item.ItemID,
                            OID =item.OID,
                            ModelID =item.ModelID,
                            CustSupplierID=item.CustSupplierID,
                            StoreID =item.StoreID,
                            TransDate =item.TransDate,
                            Periode=item.Periode,
                            Account =item.Account,
                            OAccount =item.OAccount,
                            Amount =item.Amount,
                            Currency=item.Currency,
                            ItemType =IWSLookUp. DocsType.Settlement.ToString(),
                            Side =IWSLookUp. Side.Debit.ToString(),
                            CompanyID=(string)Session["CompanyID"]},
                        new Journal { ItemID=item.ItemID,
                            OID =item.OID, ModelID=item.ModelID,
                            CustSupplierID=item.CustSupplierID,
                            StoreID =item.StoreID,
                            TransDate =item.TransDate,
                            Periode=item.Periode,
                            Account =item.OAccount,
                            OAccount =item.Account,
                            Amount =item.Amount,
                            Currency=item.Currency,
                            ItemType = IWSLookUp. DocsType.Settlement.ToString(),
                            Side = IWSLookUp. Side.Credit.ToString(),
                            CompanyID=(string)Session["CompanyID"]} };

                        results = SendToJournal(journal);
                        if (!results)
                            return results;
                    }
                }
                catch (Exception e)
                {
                    ViewData["GenericError"] = e.Message;
                }
            }
            return results;
        }
        private bool ValidateGeneralLedger(int ledgerID)
        {
            bool results = false;
            var docs =
                (from line in db.LineGeneralLedgers
                 group new { line, line.GeneralLedger } by new
                 {
                     line.GeneralLedger.id,
                     line.text,
                     line.account,
                     line.side,
                     line.oaccount,
                     line.amount,
                     line.Currency,
                     line.duedate,
                     xMonth = (Convert.ToString((int?)line.GeneralLedger.ItemDate.Month)).Length == 1 ?
                                             '0' + Convert.ToString((int?)line.GeneralLedger.ItemDate.Month) :
                                             Convert.ToString((int?)line.GeneralLedger.ItemDate.Month),
                     xYear = Convert.ToString((int?)line.GeneralLedger.ItemDate.Year)
                 } into g
                 where g.Key.id == ledgerID
                 select new
                 {
                     Description = g.Key.text,
                     AccountId = g.Key.account,
                     OAccountId = g.Key.oaccount,
                     Periode = g.Key.xYear + g.Key.xMonth,
                     Amount = g.Key.amount,
                     Currency=g.Key.Currency
                 }).ToList();

            if (docs.Any())
            {
                try
                {

                    foreach (var doc in docs)
                    {
                        results = UpdatePeriodicAccountBalance(doc.Periode,
                                            doc.OAccountId, doc.Amount, doc.Currency, false);
                        if (!results)
                            return results;
                        results = UpdateAccountBalance(doc.OAccountId, doc.Amount);
                        if (!results)
                            return results;
                    }
                    var periode = docs.Select(p => p.Periode).First();
                    var creditAccount = docs.Select(c => c.AccountId).FirstOrDefault();
                    var ttc = docs.Sum(s => s.Amount);
                    var currency = docs.Select(p => p.Currency).First();
                    results = UpdatePeriodicAccountBalance(periode, creditAccount, ttc, currency, true);
                    if (!results)
                        return results;

                    var journals =
                         (from line in db.LineGeneralLedgers
                          group new { line, line.GeneralLedger } by new
                          {
                              line.GeneralLedger.id,
                              line.GeneralLedger.oid,
                              line.GeneralLedger.modelid,
                              line.GeneralLedger.CostCenter,
                              SupplierID = line.GeneralLedger.Area,
                              line.GeneralLedger.text,
                              line.GeneralLedger.ItemDate,
                              line.GeneralLedger.CompanyId,
                              line.account,
                              line.oaccount,
                              line.amount,
                              line.Currency,
                              line.GeneralLedger.Company.bankaccountid,
                              xMonth = (Convert.ToString((int?)line.GeneralLedger.ItemDate.Month)).Length == 1 ?
                                                      '0' + Convert.ToString((int?)line.GeneralLedger.ItemDate.Month) :
                                                      Convert.ToString((int?)line.GeneralLedger.ItemDate.Month),
                              xYear = Convert.ToString((int?)line.GeneralLedger.ItemDate.Year)
                          } into g
                          where g.Key.id == ledgerID
                          select new
                          {
                              ItemID = g.Key.id,
                              OID = (int)g.Key.oid,
                              ModelID = g.Key.modelid,
                              ItemType = IWSLookUp.DocsType.GeneralLedger.ToString(),
                              CustSupplierID = g.Key.SupplierID,
                              StoreID = g.Key.CostCenter,
                              TransDate = g.Key.ItemDate,
                              Periode = g.Key.xYear + g.Key.xMonth,
                              Account = g.Key.account,
                              OAccount = g.Key.oaccount,
                              Amount = g.Key.amount,
                              Currency=g.Key.Currency
                          }).ToList();

                    foreach (var item in journals)
                    {
                        List<Journal> journal = new List<Journal> {
                            new Journal { ItemID=item.ItemID,
                            OID =item.OID,
                            ModelID =item.ModelID,
                            CustSupplierID=item.CustSupplierID,
                            StoreID =item.StoreID,
                            TransDate =item.TransDate,
                            Periode=item.Periode,
                            Account =item.Account,
                            OAccount =item.OAccount,
                            Amount =item.Amount,
                            Currency=item.Currency,
                            ItemType =IWSLookUp. DocsType.GeneralLedger.ToString(),
                            Side =IWSLookUp. Side.Debit.ToString(),
                            CompanyID=(string)Session["CompanyID"]},
                        new Journal { ItemID=item.ItemID,
                            OID =item.OID, ModelID=item.ModelID,
                            CustSupplierID=item.CustSupplierID,
                            StoreID =item.StoreID,
                            TransDate =item.TransDate,
                            Periode=item.Periode,
                            Account =item.OAccount,
                            OAccount =item.Account,
                            Amount =item.Amount,
                            Currency=item.Currency,
                            ItemType = IWSLookUp. DocsType.GeneralLedger.ToString(),
                            Side = IWSLookUp. Side.Credit.ToString(),
                            CompanyID=(string)Session["CompanyID"]} };
                        results = SendToJournal(journal);
                        if (!results)
                            return results;
                    }
                }
                catch (Exception e)
                {
                    ViewData["GenericError"] = e.Message;
                }
            }
            return results;
        }
        private bool MakeCustomerInvoice(int salesInvoiceItemID)
        {
            bool results = false;
            List<ValidateInvoiceViewModel> salesInvoice =
                (from line in db.LineSalesInvoices
                 group new { line, line.Article.Vat, line.SalesInvoice } by new
                 {
                     line.VATCode,
                     line.Currency,
                     line.SalesInvoice.id,
                     line.SalesInvoice.oid,
                     line.SalesInvoice.store,
                     line.SalesInvoice.account,
                     line.SalesInvoice.text,
                     line.SalesInvoice.ItemDate,
                     line.SalesInvoice.CompanyId,
                     line.Article.Vat.revenueaccountid,
                     line.Article.Vat.outputvataccountid,
                     line.SalesInvoice.Customer.accountid,
                     line.SalesInvoice.Company.salesclearingaccountid,
                     xMonth = (Convert.ToString((int?)line.SalesInvoice.ItemDate.Month)).Length == 1 ?
                                             '0' + Convert.ToString((int?)line.SalesInvoice.ItemDate.Month) :
                                             Convert.ToString((int?)line.SalesInvoice.ItemDate.Month),
                     xYear = Convert.ToString((int?)line.SalesInvoice.ItemDate.Year)
                 } into g
                 where g.Key.id == salesInvoiceItemID
                 select new ValidateInvoiceViewModel
                 {
                     ID = g.Key.id,
                     OID = (int)g.Key.oid,
                     StoreID = g.Key.store,
                     SupplierID = g.Key.account,
                     ItemDate = g.Key.ItemDate,
                     Text = g.Key.text,
                     CompanyID = g.Key.CompanyId,
                     VatCode = g.Key.VATCode,
                     VatAccountID = g.Key.outputvataccountid,
                     CreditAccountID = g.Key.revenueaccountid, 
                     Periode = g.Key.xYear + g.Key.xMonth,
                     DebitAccountID = Convert.ToString(g.Key.accountid),
                     TotHTVA = g.Sum(p => p.line.quantity * p.line.price),
                     TotTVA = g.Sum(p => p.line.quantity * p.line.price * p.line.Article.Vat.PVat),
                     Currency=g.Key.Currency
                 }).ToList();
            if (salesInvoice.Any())
            {
                int itemID = 0;
                CustomerInvoice invoiceHeader = (from item in salesInvoice
                                               select new CustomerInvoice
                                               {
                                                   oid = item.ID,
                                                   modelid = 1112,
                                                   store = item.StoreID,
                                                   account = item.SupplierID,
                                                   text = item.Text,
                                                   ItemDate = item.ItemDate,
                                                   CompanyId = item.CompanyID,
                                                   IsValidated = false
                                               }).FirstOrDefault();
                itemID = CustomerInvoiceHeader(invoiceHeader);
                if (itemID > 0)
                {
                    List<LineCustomerInvoice> lineCustomer = (from item in salesInvoice
                                                          select new LineCustomerInvoice
                                                          {
                                                              transid = itemID,
                                                              modelid = 1113,
                                                              account = item.DebitAccountID,
                                                              side = false,
                                                              oaccount = item.VatAccountID,
                                                              amount = Math.Round(item.TotTVA, 2),
                                                              Currency=item.Currency,
                                                              duedate = item.ItemDate,
                                                              text = item.Text
                                                          }).ToList();
                    string accountID = salesInvoice.Select(a => a.CreditAccountID ).First();

                    string oAccountID = salesInvoice.Select(a => a.DebitAccountID).First();

                    decimal amount = Math.Round(salesInvoice.Sum(t => t.TotHTVA), 2);

                    string currency = salesInvoice.Select(a => a.Currency).First();

                    DateTime dueDate = salesInvoice.Select(d => d.ItemDate).First();

                    string text = salesInvoice.Select(t => t.Text).First();

                    LineCustomerInvoice line = new LineCustomerInvoice
                    {
                        transid = itemID,
                        modelid = 1113,
                        account = oAccountID,
                        side = false,
                        oaccount = accountID,
                        amount = amount,
                        Currency=currency,
                        duedate = dueDate,
                        text = text
                    };
                    lineCustomer.Add(line);
                    int countLineID = MakeCustomerInvoiceLine(lineCustomer);
                    results = (countLineID > 0);
                    if (!results)
                        return results;
                }
            }
            return results;
        }
        private int CustomerInvoiceHeader(CustomerInvoice invoice)
        {
            int id = 0;
            try
            {
                db.CustomerInvoices.InsertOnSubmit(invoice);
                db.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);
                id = db.CustomerInvoices.Max(i => i.id);
            }
            catch (Exception e)
            {
                ViewData["GenericError"] = e.Message;
                return 0;
            }
            return id;
        }
        private int MakeCustomerInvoiceLine(List<LineCustomerInvoice> line)
        {
            int id = 0;
            try
            {
                foreach (var item in line)
                {
                    db.LineCustomerInvoices.InsertOnSubmit(item);
                    id++;
                }
                db.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);
                return id;
            }
            catch (Exception e)
            {
                ViewData["GenericError"] = e.Message;
                return 0;
            }
        }
        private bool MakeVendorInvoice(int InventoryInvoiceItemID)
        {
            bool results = false;
            List<ValidateInvoiceViewModel> inventoryInvoice =
                (from line in db.LineInventoryInvoices
                 group new { line, line.Article.Vat, line.InventoryInvoice } by new
                 {
                     line.VATCode,
                     line.Currency,
                     line.InventoryInvoice.id,
                     line.InventoryInvoice.oid,
                     line.InventoryInvoice.store,
                     line.InventoryInvoice.account,
                     line.InventoryInvoice.text,
                     line.InventoryInvoice.ItemDate,
                     line.InventoryInvoice.CompanyId,
                     line.Article.Vat.inputvataccountid,
                     line.InventoryInvoice.Supplier.accountid,
                     line.InventoryInvoice.Company.purchasingclearingaccountid,
                     xMonth = (Convert.ToString((int?)line.InventoryInvoice.ItemDate.Month)).Length == 1 ?
                                             '0' + Convert.ToString((int?)line.InventoryInvoice.ItemDate.Month) :
                                             Convert.ToString((int?)line.InventoryInvoice.ItemDate.Month),
                     xYear = Convert.ToString((int?)line.InventoryInvoice.ItemDate.Year)
                 } into g
                 where g.Key.id == InventoryInvoiceItemID
                 select new ValidateInvoiceViewModel
                 {
                     ID = g.Key.id,
                     OID =(int)g.Key.oid,
                     StoreID = g.Key.store,
                     SupplierID = g.Key.account,
                     ItemDate = g.Key.ItemDate,
                     Text = g.Key.text,
                     CompanyID = g.Key.CompanyId,
                     VatCode = g.Key.VATCode,
                     VatAccountID = g.Key.inputvataccountid,
                     Periode = g.Key.xYear + g.Key.xMonth,
                     DebitAccountID = g.Key.purchasingclearingaccountid,
                     CreditAccountID = g.Key.accountid,
                     TotHTVA = g.Sum(p => p.line.quantity * p.line.price),
                     TotTVA = g.Sum(p => p.line.quantity * p.line.price * p.line.Article.Vat.PVat),
                     Currency=g.Key.Currency
                 }).ToList();

            if (inventoryInvoice.Any())
            {
                int itemID = 0;
                VendorInvoice invoiceHeader = (from item in inventoryInvoice
                                         select new VendorInvoice
                                         {
                                             oid = item.ID,
                                             modelid = 112,
                                             store = item.StoreID,
                                             account = item.SupplierID,
                                             text = item.Text,
                                             ItemDate = item.ItemDate,
                                             CompanyId = item.CompanyID,
                                             IsValidated =false
                                         }).FirstOrDefault();
                itemID = MakeVendorInvoiceHeader(invoiceHeader);
                if (itemID > 0)
                {
                    List<LineVendorInvoice> lineVendor = (from item in inventoryInvoice
                                                          select new LineVendorInvoice
                                                          {
                                                              transid = itemID,
                                                              modelid = 113,
                                                              account = item.VatAccountID,
                                                              side = true,
                                                              oaccount = item.CreditAccountID,
                                                              amount = Math.Round(item.TotTVA, 2),
                                                              Currency=item.Currency,
                                                              duedate = item.ItemDate,
                                                              text = item.Text
                                                          }).ToList();
     
                    string accountID = inventoryInvoice.Select(a => a.DebitAccountID).First();

                    string oAccountID = inventoryInvoice.Select(a => a.CreditAccountID).First();

                    decimal amount = Math.Round(inventoryInvoice.Sum(t => t.TotHTVA), 2);

                    string currency = inventoryInvoice.Select(a => a.Currency).First();

                    DateTime dueDate = inventoryInvoice.Select(d => d.ItemDate).First();

                    string text = inventoryInvoice.Select(t => t.Text).First();

                    LineVendorInvoice line = new LineVendorInvoice
                    {
                        transid = itemID,
                        modelid = 113,
                        account = accountID,
                        side = true,
                        oaccount = oAccountID,
                        amount = amount,
                        Currency=currency,
                        duedate = dueDate,
                        text = text
                    };
                    lineVendor.Add(line);
                    int countLineID = MakeVendorInvoiceLine(lineVendor);
                    results = (countLineID > 0);
                    if (!results)
                        return results;

                }
            }
            return results;
        }
        private int MakeVendorInvoiceHeader(VendorInvoice invoice)
        {
            int id = 0;
            try
            {
                db.VendorInvoices.InsertOnSubmit(invoice);
                db.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);
                id=db.VendorInvoices.Max(i=>i.id);
            }
            catch (Exception e)
            {
                ViewData["GenericError"] = e.Message;
                return 0;
            }
            return id;
        }
        private int MakeVendorInvoiceLine(List<LineVendorInvoice> line)
        {
            int id = 0;
            try
            {
                foreach (var item in line)
                {
                    db.LineVendorInvoices.InsertOnSubmit(item);
                    id ++;
                }
                db.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);
                return id;
            }
            catch (Exception e)
            {
                ViewData["GenericError"] = e.Message;
                return 0;
            }
        }
        private bool MakePayment(int vendorInvoiceID)
        {
            bool results = false;
            List<ValidateInvoiceViewModel> vendorInvoice =
                (from line in db.LineVendorInvoices
                 group new { line, line.VendorInvoice } by new
                 {
                     line.VendorInvoice.id,
                     line.VendorInvoice.store,
                     SupplierID = line.VendorInvoice.account,
                     line.VendorInvoice.text,
                     line.VendorInvoice.ItemDate,
                     line.VendorInvoice.CompanyId,
                     line.VendorInvoice.Supplier.accountid,
                     line.VendorInvoice.Company.bankaccountid,
                     xMonth = (Convert.ToString((int?)line.VendorInvoice.ItemDate.Month)).Length == 1 ?
                                             '0' + Convert.ToString((int?)line.VendorInvoice.ItemDate.Month) :
                                             Convert.ToString((int?)line.VendorInvoice.ItemDate.Month),
                     xYear = Convert.ToString((int?)line.VendorInvoice.ItemDate.Year)
                 } into g
                 where g.Key.id == vendorInvoiceID
                 select new ValidateInvoiceViewModel
                 {
                     ID = g.Key.id,
                     StoreID = g.Key.store,
                     SupplierID = g.Key.SupplierID,
                     ItemDate = g.Key.ItemDate,
                     Periode=g.Key.xYear+g.Key.xMonth,
                     Text = g.Key.text,
                     CompanyID = g.Key.CompanyId,
                     CreditAccountID =g.Key.bankaccountid,
                     DebitAccountID = g.Key.accountid,
                     TotTVA = g.Sum(a=>a.line.amount)
                 }).ToList();

            if (vendorInvoice.Any())
            {
                int itemID = 0;
                Payment payment = (from item in vendorInvoice
                                         select new Payment
                                         {
                                             oid = item.ID,
                                             modelid = 114,
                                             store = item.StoreID,
                                             account = item.SupplierID,
                                             text = item.Text,
                                             ItemDate = item.ItemDate,
                                             CompanyId = item.CompanyID,
                                             IsValidated = false
                                         }).First();
                itemID = MakePaymentHeader(payment);
                if (itemID > 0)
                {
                    List<LinePayment> lineVendor = (from item in vendorInvoice
                                                          select new LinePayment
                                                          {
                                                              transid = itemID,
                                                              modelid = 113,
                                                              account = item.DebitAccountID,
                                                              side = false,
                                                              oaccount = item.CreditAccountID,
                                                              amount = Math.Round(item.TotTVA, 2),
                                                              Currency=item.Currency,
                                                              duedate = item.ItemDate,
                                                              text = item.Text
                                                          }).ToList();
                    int countLineID = MakePaymentLine(lineVendor);
                    results= (countLineID > 0);
                }
                if (!results)
                    return results;
               var journals = 
                    (from line in db.LineVendorInvoices
                     group new { line, line.VendorInvoice } by new
                     {
                         line.VendorInvoice.id,
                         line.VendorInvoice.oid,
                         line.VendorInvoice.modelid,
                         line.VendorInvoice.store,
                         SupplierID = line.VendorInvoice.account,
                         line.VendorInvoice.text,
                         line.VendorInvoice.ItemDate,
                         line.VendorInvoice.CompanyId,
                         line.account,
                         line.oaccount,
                         line.amount,
                         line.Currency,
                         line.VendorInvoice.Company.bankaccountid,
                         xMonth = (Convert.ToString((int?)line.VendorInvoice.ItemDate.Month)).Length == 1 ?
                                                 '0' + Convert.ToString((int?)line.VendorInvoice.ItemDate.Month) :
                                                 Convert.ToString((int?)line.VendorInvoice.ItemDate.Month),
                         xYear = Convert.ToString((int?)line.VendorInvoice.ItemDate.Year)
                     } into g
                     where g.Key.id == vendorInvoiceID
                     select new 
                     {
                         ItemID = g.Key.id,
                         OID=(int)g.Key.oid,
                         ModelID=g.Key.modelid,
                         ItemType = IWSLookUp.DocsType.GoodReceiving.ToString(),
                         CustSupplierID = g.Key.SupplierID,
                         StoreID = g.Key.store,
                         TransDate = g.Key.ItemDate,
                         Periode = g.Key.xYear + g.Key.xMonth,
                         Account=g.Key.account,
                         OAccount=g.Key.oaccount,
                         Amount=g.Key.amount,
                         Currency=g.Key.Currency
                     }).ToList();

                foreach (var item in journals)
                {
                    List<Journal> journal = new List<Journal> {
                            new Journal { ItemID=item.ItemID,
                            OID =item.OID,
                            ModelID =item.ModelID,
                            CustSupplierID=item.CustSupplierID,
                            StoreID =item.StoreID,
                            TransDate =item.TransDate,
                            Periode=item.Periode,
                            Account =item.Account,
                            OAccount =item.OAccount,
                            Amount =item.Amount,
                            Currency=item.Currency,
                            ItemType = IWSLookUp. DocsType.VendorInvoice.ToString(),
                            Side = IWSLookUp. Side.Debit.ToString(),
                            CompanyID=(string)Session["CompanyID"]},
                        new Journal { ItemID=item.ItemID,
                            OID =item.OID, ModelID=item.ModelID,
                            CustSupplierID=item.CustSupplierID,
                            StoreID =item.StoreID,
                            TransDate =item.TransDate,
                            Periode=item.Periode,
                            Account =item.OAccount,
                            OAccount =item.Account,
                            Amount =item.Amount,
                            Currency=item.Currency,
                            ItemType = IWSLookUp. DocsType.VendorInvoice.ToString(),
                            Side = IWSLookUp. Side.Credit.ToString(),
                            CompanyID=(string)Session["CompanyID"]} };

                    results = SendToJournal(journal);
                    if (!results)
                        return results;
                }
            }
            return results;
        }
        public int MakePaymentHeader(Payment payment)
        {
            int id = 0;
            try
            {
                db.Payments.InsertOnSubmit(payment);
                db.SubmitChanges(System.Data.Linq.ConflictMode.ContinueOnConflict);
                id = db.Payments.Max(i => i.id);
            }
            catch (Exception e)
            {
                ViewData["GenericError"] = e.Message;
            }
            return id;
        }
        public int MakePaymentLine(List<LinePayment> linePayment)
        {
            int id = 0;
            try
            {
                foreach (var item in linePayment)
                {
                    db.LinePayments.InsertOnSubmit(item);
                    id++;
                }
                db.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);
                return id;
            }
            catch (Exception e)
            {
                ViewData["GenericError"] = e.Message;
                return 0;
            }
        }
        private bool MakeSettlement(int customerInvoiceID)
        {
            bool results = false;
            List<ValidateInvoiceViewModel> customerInvoice =
                (from line in db.LineCustomerInvoices
                 group new { line, line.CustomerInvoice } by new
                 {
                     line.CustomerInvoice.id,
                     line.CustomerInvoice.store,
                     SupplierID = line.CustomerInvoice.account,
                     line.CustomerInvoice.text,
                     line.CustomerInvoice.ItemDate,
                     line.CustomerInvoice.CompanyId,
                     line.CustomerInvoice.Customer.accountid,
                     line.CustomerInvoice.Company.bankaccountid,
                     line.Currency,
                     xMonth = (Convert.ToString((int?)line.CustomerInvoice.ItemDate.Month)).Length == 1 ?
                                             '0' + Convert.ToString((int?)line.CustomerInvoice.ItemDate.Month) :
                                             Convert.ToString((int?)line.CustomerInvoice.ItemDate.Month),
                     xYear = Convert.ToString((int?)line.CustomerInvoice.ItemDate.Year)
                 } into g
                 where g.Key.id == customerInvoiceID
                 select new ValidateInvoiceViewModel
                 {
                     ID = g.Key.id,
                     StoreID = g.Key.store,
                     SupplierID = g.Key.SupplierID,
                     ItemDate = g.Key.ItemDate,
                     Periode = g.Key.xYear + g.Key.xMonth,
                     Text = g.Key.text,
                     CompanyID = g.Key.CompanyId,
                     CreditAccountID = Convert.ToString(g.Key.accountid),
                     DebitAccountID = g.Key.bankaccountid,
                     TotTVA = g.Sum(a => a.line.amount),
                     Currency=g.Key.Currency
                 }).ToList();


            if (customerInvoice.Any())
            {
                int itemID = 0;
                Settlement settlement = (from item in customerInvoice
                                   select new Settlement
                                   {
                                       oid = item.ID,
                                       modelid = 1114,
                                       store = item.StoreID,
                                       account = item.SupplierID,
                                       text = item.Text,
                                       ItemDate = item.ItemDate,
                                       CompanyId = item.CompanyID,
                                       IsValidated = false
                                   }).First();
                itemID = MakeSettlementHeader(settlement);
                if (itemID > 0)
                {
                    List<LineSettlement> lineSettlement = (from item in customerInvoice
                                                    select new LineSettlement
                                                    {
                                                        transid = itemID,
                                                        modelid = 1113,
                                                        account = item.DebitAccountID,
                                                        side = false,
                                                        oaccount = item.CreditAccountID,
                                                        amount = Math.Round(item.TotTVA, 2),
                                                        Currency=item.Currency,
                                                        duedate = item.ItemDate,
                                                        text = item.Text
                                                    }).ToList();
                    int countLineID = MakeSettlementLine(lineSettlement);
                    results = (countLineID > 0);
                }
                if (!results)
                    return results;
                var journals =
                     (from line in db.LineCustomerInvoices
                      group new { line, line.CustomerInvoice } by new
                      {
                          line.CustomerInvoice.id,
                          line.CustomerInvoice.oid,
                          line.CustomerInvoice.modelid,
                          line.CustomerInvoice.store,
                          SupplierID = line.CustomerInvoice.account,
                          line.CustomerInvoice.text,
                          line.CustomerInvoice.ItemDate,
                          line.CustomerInvoice.CompanyId,
                          line.account,
                          line.oaccount,
                          line.amount,
                          line.Currency,
                          line.CustomerInvoice.Company.bankaccountid,
                          xMonth = (Convert.ToString((int?)line.CustomerInvoice.ItemDate.Month)).Length == 1 ?
                                                  '0' + Convert.ToString((int?)line.CustomerInvoice.ItemDate.Month) :
                                                  Convert.ToString((int?)line.CustomerInvoice.ItemDate.Month),
                          xYear = Convert.ToString((int?)line.CustomerInvoice.ItemDate.Year)
                      } into g
                      where g.Key.id == customerInvoiceID
                      select new
                      {
                          ItemID = g.Key.id,
                          OID = (int)g.Key.oid,
                          ModelID = g.Key.modelid,
                          ItemType = IWSLookUp.DocsType.CustomerInvoice.ToString(),
                          CustSupplierID = g.Key.SupplierID,
                          StoreID = g.Key.store,
                          TransDate = g.Key.ItemDate,
                          Periode = g.Key.xYear + g.Key.xMonth,
                          Account = g.Key.account,
                          OAccount = g.Key.oaccount,
                          Amount = g.Key.amount,
                          Currency=g.Key.Currency
                      }).ToList();

                foreach (var item in journals)
                {
                    List<Journal> journal = new List<Journal> {
                        new Journal { ItemID=item.ItemID,
                            OID =item.OID,
                            ModelID =item.ModelID,
                            CustSupplierID=item.CustSupplierID,
                            StoreID =item.StoreID,
                            TransDate =item.TransDate,
                            Periode=item.Periode,
                            Account =item.Account,
                            OAccount =item.OAccount,
                            Amount =item.Amount,
                            Currency=item.Currency,
                            ItemType = IWSLookUp. DocsType.CustomerInvoice.ToString(),
                            Side = IWSLookUp. Side.Debit.ToString(),
                            CompanyID=(string)Session["CompanyID"]},
                        new Journal { ItemID=item.ItemID,
                            OID =item.OID, ModelID=item.ModelID,
                            CustSupplierID=item.CustSupplierID,
                            StoreID =item.StoreID,
                            TransDate =item.TransDate,
                            Periode=item.Periode,
                            Account =item.OAccount,
                            OAccount =item.Account,
                            Amount =item.Amount,
                            Currency=item.Currency,
                            ItemType = IWSLookUp. DocsType.CustomerInvoice.ToString(),
                            Side = IWSLookUp. Side.Credit.ToString(),
                            CompanyID=(string)Session["CompanyID"]} };
                    results = SendToJournal(journal);
                    if (!results)
                        return results;
                }
            }
            return results;
        }
        public int MakeSettlementHeader(Settlement settlement)
        {
            int id = 0;
            try
            {
                db.Settlements.InsertOnSubmit(settlement);
                db.SubmitChanges(System.Data.Linq.ConflictMode.ContinueOnConflict);
                id = db.Settlements.Max(i => i.id);
            }
            catch (Exception e)
            {
                ViewData["GenericError"] = e.Message;
            }
            return id;
        }
        public int MakeSettlementLine(List<LineSettlement> lineSettlement)
        {
            int id = 0;
            try
            {
                foreach (var item in lineSettlement)
                {
                    db.LineSettlements.InsertOnSubmit(item);
                    id++;
                }
                db.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);
                return id;
            }
            catch (Exception e)
            {
                ViewData["GenericError"] = e.Message;
                return 0;
            }
        }
        public bool SendToJournal(List<Journal> journal)
        {
            bool results = false;
            if (ModelState.IsValid)
            {
                try
                {
                    foreach (Journal item in journal)
                    {
                        //item.CompanyID = (string)Session["CompanyID"];
                        //if (item.Currency == null)
                        //    item.Currency = (string)Session["Currency"];
                        db.Journals.InsertOnSubmit(item);
                    }
                    results = true;
                }
                catch (Exception e)
                {
                    ViewData["GenericError"] = e.Message;
                }
            }
            return results;
        }
        #endregion
    }
}