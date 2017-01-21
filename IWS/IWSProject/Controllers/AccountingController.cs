using System;
using System.Collections.Generic;
using System.Web.Mvc;
using IWSProject.Models;
using IWSProject.Content;
using System.Linq;
using System.Collections;

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
            //check if items are selected previously
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
                    results = Compta(ItemID, ItemType);
                    if (!results)
                    {
                        ViewData["GenericError"] = IWSLocalResource.GenericError;
                        return RedirectToAction("Index");
                    }
                    results = SetToValidated(ItemID, ItemType);
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
        private enum DocsType
        {
            GoodReceiving,
            InventoryInvoice,
            Payment,
            PurchaseOrder,
            VendorInvoice
        }
        private enum Side
        {
            Debit,
            Credit
        }
        /// <summary>
        /// validates documents
        /// </summary>
        /// <param name="document ID ItemID"></param>
        /// <param name="document type ItemType"></param>
        /// <returns>bool</returns>
        private bool Compta(int ItemID, string ItemType)
        {
            bool results = false;
 
            if (ItemType.Equals(DocsType.PurchaseOrder.ToString()))
            {
                return SetToValidated(ItemID, ItemType);
            }
            if (ItemType.Equals(DocsType.GoodReceiving.ToString()))
            {
                results = ValidateGoodReceiving(ItemID);
                if (results)
                {
                    results = SetToValidated(ItemID, ItemType);
                }
                return results;
            }
            if (ItemType.Equals(DocsType.InventoryInvoice.ToString()))
            {
                results = MakeVendorInvoice(ItemID);
                if (results)
                {
                    return SetToValidated(ItemID, ItemType);
                }
                return results;
            }
            if (ItemType.Equals(DocsType.VendorInvoice.ToString()))
            {
                results = MakePayment(ItemID);
                if (results)
                {   
                    results = SetToValidated(ItemID, ItemType);
                    if (results)
                    {
                        return ValidateVendorInvoice(ItemID);
                    }
                }
                return results;
            }
            if (ItemType.Equals(DocsType.Payment.ToString()))
            {
                results = ValidatePayment(ItemID);
                if (results)
                {
                    return SetToValidated(ItemID, ItemType);
                }
                return results;
            }
            return false;
        }
        private bool UpdateStock(int DocumentID, string DocumentType)
        {
            if (DocumentType.Equals(DocsType.GoodReceiving.ToString()))
            {
                List<ValidateStockViewModel> validateStock =
                    (from line in db.LineGoodReceivings
                     group new { line, line.GoodReceiving } by new
                     {
                         DocumentID = line.GoodReceiving.id,
                         StoreID = line.GoodReceiving.store,
                         ItemID = line.item,
                         Price = line.price,
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

                if (validateStock.Any())
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
                if (ItemType.Equals(DocsType.PurchaseOrder.ToString()))
                {
                    var docs = db.PurchaseOrders.FirstOrDefault(item => item.id == ItemID);
                    if (docs != null)
                    {
                        docs.IsValidated = true;
                        return true;
                    }
                }
                if (ItemType.Equals(DocsType.GoodReceiving.ToString()))
                {
                    var docs = db.GoodReceivings.FirstOrDefault(item => item.id == ItemID);
                    if (docs != null)
                    {
                        docs.IsValidated = true;
                        return true;
                    }
                }
                if (ItemType.Equals(DocsType.InventoryInvoice.ToString()))
                {
                    var docs = db.InventoryInvoices.FirstOrDefault(item => item.id == ItemID);
                    if (docs != null)
                    {
                        docs.IsValidated = true;
                        return true;
                    }
                }
                if (ItemType.Equals(DocsType.VendorInvoice.ToString()))
                {
                    var docs = db.VendorInvoices.FirstOrDefault(item => item.id == ItemID);
                    if (docs != null)
                    {
                        docs.IsValidated = true;
                        return true;
                    }
                }
                if (ItemType.Equals(DocsType.Payment.ToString()))
                {
                    var docs = db.Payments.FirstOrDefault(item => item.id == ItemID);
                    if (docs != null)
                    {
                        docs.IsValidated = true;
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
        private bool UpdatePeriodicAccountBalance(string Periode, string AccountID, decimal amount, bool IsDebit)
        {
            var docs = db.PeriodicAccountBalances.FirstOrDefault(p => p.Periode == Periode && p.AccountId == AccountID);
            if (docs == null)
            {
                docs = new PeriodicAccountBalance
                {
                    Name = "NA",
                    ModelId = 106,
                    Periode = Periode,
                    AccountId = AccountID
                };
                if (IsDebit)
                {
                    docs.Debit = amount;
                    docs.Credit = 0;
                }
                else
                {
                    docs.Debit = 0;
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
        private bool ValidateInventoryInvoice(int ItemID)
        {
            List<ValidateInvoiceViewModel> docs =
                (from line in db.LineInventoryInvoices
                 group new { line, line.Article.Vat, line.InventoryInvoice } by new
                 {
                     line.VATCode,
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
                                        doc.VatAccountID, tva, true);

                        updateAccount = UpdateAccountBalance(doc.VatAccountID, tva);
                    }
                    var periode = docs.Select(p => p.Periode).First();

                    var debitAccount = docs.Select(c => c.DebitAccountID).FirstOrDefault();

                    debitPeriodic = UpdatePeriodicAccountBalance(periode, debitAccount, htva, true);

                    var creditAccount = docs.Select(c => c.CreditAccountID).FirstOrDefault();

                    creditPeriodic = UpdatePeriodicAccountBalance(periode, creditAccount, ttc, false);

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
                           line.GoodReceiving.account,
                           line.GoodReceiving.store,
                           line.GoodReceiving.ItemDate,
                           line.GoodReceiving.Company.purchasingclearingaccountid,
                           line.Article.Vat.expenseaccountid,
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
                           Account = g.Key.expenseaccountid,
                           OAccount=g.Key.purchasingclearingaccountid,
                           Amount = g.Sum(p => p.line.quantity * p.line.price),
                       }).ToList();

            if (docs.Any())
            {
                try
                {
                    bool results = false;

                    string accountID = string.Empty;
                    var periode = docs.Select(p => p.Periode).FirstOrDefault().ToString();
                    decimal tvaAmount = 0;

                    foreach (var doc in docs)
                    {
                       accountID = doc.Account;

                        tvaAmount = Math.Round(doc.Amount, 2);

                        results= UpdatePeriodicAccountBalance(periode, accountID, tvaAmount, true);

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
                                ItemType =DocsType.GoodReceiving.ToString(),
                                Side =Side.Debit.ToString()},
                            new Journal { ItemID=doc.ItemID,
                                OID =doc.OID, ModelID=doc.ModelID,
                                CustSupplierID=doc.CustSupplierID,
                                StoreID =doc.StoreID,
                                TransDate =doc.TransDate,
                                Periode=doc.Periode,
                                Account =doc.OAccount,
                                OAccount =doc.Account,
                                Amount =doc.Amount,
                                ItemType =DocsType.GoodReceiving.ToString(),
                                Side =Side.Credit.ToString() } };
                        
                        results = SendToJournal(journal);

                        if (!results)
                            return results;
                    }
                    var item = (from doc in docs
                                       group new { doc } by new
                                       {
                                           doc.Periode,
                                           doc.OAccount
                                       } into g
                                       select new { Periode = g.Key.Periode,
                                                   accountID =g.Key.OAccount,
                                                   tvaAmount = g.Sum(p => p.doc.Amount) }).Single();
                    return UpdatePeriodicAccountBalance(item.Periode, item.accountID, item.tvaAmount, false);
                }
                catch (Exception e)
                {
                    ViewData["GenericError"] = e.Message;
                }
            }
            return false;
        }
        private bool MakeVendorInvoice(int InventoryInvoiceItemID)
        {
            bool results = false;
            List<ValidateInvoiceViewModel> inventoryInvoice =
                (from line in db.LineInventoryInvoices
                 group new { line, line.Article.Vat, line.InventoryInvoice } by new
                 {
                     line.VATCode,
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
                     TotTVA = g.Sum(p => p.line.quantity * p.line.price * p.line.Article.Vat.PVat)
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
                                                              duedate = item.ItemDate,
                                                              text = item.Text
                                                          }).ToList();
                    
                    string accountID = inventoryInvoice.Select(a => a.DebitAccountID).First();

                    string oAccountID = inventoryInvoice.Select(a => a.CreditAccountID).First();

                    decimal amount = Math.Round(inventoryInvoice.Sum(t => t.TotHTVA), 2);

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
                        duedate = dueDate,
                        text = text
                    };
                    lineVendor.Add(line);
                    //var vv = lineVendor.Count();
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
        private int MakeVendorInvoiceLine(List<LineVendorInvoice> lineVendor)
        {
            int id = 0;
            try
            {
                foreach (var item in lineVendor)
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
                         ItemType = DocsType.GoodReceiving.ToString(),
                         CustSupplierID = g.Key.SupplierID,
                         StoreID = g.Key.store,
                         TransDate = g.Key.ItemDate,
                         Periode = g.Key.xYear + g.Key.xMonth,
                         Account=g.Key.account,
                         OAccount=g.Key.oaccount,
                         Amount=g.Key.amount
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
                            ItemType =DocsType.VendorInvoice.ToString(),
                            Side =Side.Debit.ToString()},
                        new Journal { ItemID=item.ItemID,
                            OID =item.OID, ModelID=item.ModelID,
                            CustSupplierID=item.CustSupplierID,
                            StoreID =item.StoreID,
                            TransDate =item.TransDate,
                            Periode=item.Periode,
                            Account =item.OAccount,
                            OAccount =item.Account,
                            Amount =item.Amount,
                            ItemType =DocsType.VendorInvoice.ToString(),
                            Side =Side.Credit.ToString() } };

                    results = SendToJournal(journal);
                    if (!results)
                        return results;
                }
            }
            return results;
        }
        private int MakePaymentHeader(Payment payment)
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
        private int MakePaymentLine(List<LinePayment> linePayment)
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
                     Amount=g.Key.amount
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
                                        doc.AccountId, doc.Amount, true);
                        updateAccount = UpdateAccountBalance(doc.AccountId, doc.Amount);
                    }
                    var periode = docs.Select(p => p.Periode).First();

                    var creditAccount = docs.Select(c => c.OAccountId).FirstOrDefault();
                    var ttc = docs.Sum(s => s.Amount);
                    creditPeriodic = UpdatePeriodicAccountBalance(periode, creditAccount, ttc, false);

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
                     Amount = g.Key.amount
                 }).ToList();
            if (docs.Any())
            {
                try
                {

                    foreach (var doc in docs)
                    {
                        results = UpdatePeriodicAccountBalance(doc.Periode,
                                            doc.OAccountId, doc.Amount, false);
                        if (!results)
                            return results;
                        results = UpdateAccountBalance(doc.OAccountId, doc.Amount);
                        if (!results)
                            return results;
                    }
                    var periode = docs.Select(p => p.Periode).First();
                    var creditAccount = docs.Select(c => c.AccountId).FirstOrDefault();
                    var ttc = docs.Sum(s => s.Amount);
                    results = UpdatePeriodicAccountBalance(periode, creditAccount, ttc, true);
                    if (!results)
                        return results;
                    creditAccount = docs.Select(c => c.BankAccountID).FirstOrDefault();
                    results = UpdatePeriodicAccountBalance(periode, creditAccount, ttc, false);

                    //============

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
                              ItemType = DocsType.GoodReceiving.ToString(),
                              CustSupplierID = g.Key.SupplierID,
                              StoreID = g.Key.store,
                              TransDate = g.Key.ItemDate,
                              Periode = g.Key.xYear + g.Key.xMonth,
                              Account = g.Key.account,
                              OAccount = g.Key.oaccount,
                              Amount = g.Key.amount
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
                            ItemType =DocsType.Payment.ToString(),
                            Side =Side.Debit.ToString()},
                        new Journal { ItemID=item.ItemID,
                            OID =item.OID, ModelID=item.ModelID,
                            CustSupplierID=item.CustSupplierID,
                            StoreID =item.StoreID,
                            TransDate =item.TransDate,
                            Periode=item.Periode,
                            Account =item.OAccount,
                            OAccount =item.Account,
                            Amount =item.Amount,
                            ItemType =DocsType.Payment.ToString(),
                            Side =Side.Credit.ToString() } };

                        results = SendToJournal(journal);
                        if (!results)
                            return results;

                        //=============
                    }
                }
                catch (Exception e)
                {
                    ViewData["GenericError"] = e.Message;
                }
            }
            return results;
        }
        private bool SendToJournal(List<Journal> journal)
        {
            bool results = false;
            if (ModelState.IsValid)
            {
                try
                {
                    foreach (Journal item in journal)
                    {
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