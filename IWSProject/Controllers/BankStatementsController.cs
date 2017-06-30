namespace IWSProject.Controllers
{
    using DevExpress.Web.Mvc;
    using IWSProject.Content;
    using IWSProject.Models;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Web.Mvc;
    [Authorize]
    public class BankStatementsController : Controller
    {
        IWSDataContext db = new IWSDataContext();
        // GET: BankStatements
        public ActionResult Index()
        {
            return View(IWSLookUp.GetBankStatements(
                    (string)Session["CompanyID"], false));
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult Index(string selectedIDsHF)
        {
            string selectedItems = selectedIDsHF;

            if (!string.IsNullOrEmpty(selectedItems))
            {
                int ItemID = 0;

                int oid = 0;
                bool results = false;

                Decimal amount;

                IList<string> items = new List<string>(
                    selectedItems.Split(new string[] { ";" },
                        StringSplitOptions.None));

                foreach (string item in items)
                {

                    var list = item.Split(new string[] { "," }, StringSplitOptions.None);

                    ItemID = Convert.ToInt32(list[0]);

                    amount = Convert.ToDecimal(list[1]);

                    if (amount == 0 )
                    {
                        ViewData["GenericError"] = IWSLocalResource.GenericError;
                        return RedirectToAction("Index");
                    }

                    if (amount > 0)
                    {
                        oid = MakeCustomerInvoice(ItemID);
                        if (oid !=0)
                            results = MakeSettlement(ItemID, oid);
                    }
                    if (amount < 0)
                    {
                        oid = MakeVendorInvoice(ItemID);
                        if (oid != 0)
                            results = MakePayment(ItemID, oid);
                    }

                    if (!results)
                    {
                        ViewData["GenericError"] = IWSLocalResource.GenericError;
                        return RedirectToAction("Index");
                    }

                    results = ValidateBankStatement(ItemID);

                    if (!results)
                    {
                        ViewData["GenericError"] = IWSLocalResource.GenericError;
                        return RedirectToAction("Index");
                    }
                    db.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);
                }
            }
            return View(IWSLookUp.GetBankStatements((string)Session["CompanyID"], false));
        }

        [ValidateInput(false)]
        public ActionResult BankStatementsGridViewPartial()
        {
            return PartialView("BankStatementsGridViewPartial",
                        IWSLookUp.GetBankStatements((string)Session["CompanyID"], false));
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult BankStatementsGridViewPartialAddNew([ModelBinder(typeof(DevExpressEditorsBinder))] BankStatement item)
        {
            var model = db.BankStatements;
            if (item.Waehrung == null)
                item.Waehrung = (string)Session["Currency"];

            item.CompanyID = (string)Session["CompanyID"];

            ViewData["BankStatement"] = item;
            if (ModelState.IsValid)
            {
                try
                {
                    model.InsertOnSubmit(item);
                    db.SubmitChanges();
                }
                catch (Exception e)
                {
                    ViewData["GenericError"] = e.Message;
                }
            }
            else
            {
                ViewData["GenericError"] = IWSLocalResource.GenericError;
            }
            return PartialView("BankStatementsGridViewPartial", 
                    IWSLookUp.GetBankStatements((string)Session["CompanyID"], false));
                    }
        [HttpPost, ValidateInput(false)]
        public ActionResult BankStatementsGridViewPartialUpdate([ModelBinder(typeof(DevExpressEditorsBinder))] BankStatement item)
        {
            var model = db.BankStatements;
            ViewData["BankStatement"] = item;
            if (ModelState.IsValid)
            {
                try
                {   
                    var modelItem = model.FirstOrDefault(it => it.id == item.id);
                    if (modelItem != null)
                    {
                        this.UpdateModel(modelItem);

                        db.SubmitChanges();
                    }
                }
                catch (Exception e)
                {
                    ViewData["GenericError"] = e.Message;
                }
            }
            else
            {
                ViewData["GenericError"] = IWSLocalResource.GenericError;
            }
            return PartialView("BankStatementsGridViewPartial", 
                    IWSLookUp.GetBankStatements((string)Session["CompanyID"], false));
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult BankStatementsGridViewPartialDelete(int id)
        {
            var model = db.BankStatements;
            if (id >=0)
            {
                try
                {
                    var item = model.FirstOrDefault(it => it.id == id);
                    if (item != null)
                        model.DeleteOnSubmit(item);

                    db.SubmitChanges();
                }
                catch (Exception e)
                {
                    ViewData["GenericError"] = e.Message;
                }
            }
            return PartialView("BankStatementsGridViewPartial", 
                    IWSLookUp.GetBankStatements((string)Session["CompanyID"], false)); 
        }

        private object RootFolder = "~/Content/Uploads";

        public ActionResult ImportCSV()
        {
            return View("ImportCSV", RootFolder);
        }
        [ValidateInput(false)]
        public ActionResult ImportCSVPartial(string currentFileName)
        {
            return PartialView("ImportCSVPartial", RootFolder);
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult UploadToDB(string[] files)
        {
            const string bankStatement = "Auftragskonto;Buchungstag;Valutadatum;" +
                "Buchungstext;Verwendungszweck;Beguenstigter/Zahlungspflichtiger;" +
                "Kontonummer;BLZ;Betrag;Waehrung;Info";
            const string accounts = "AccountId;AccountName;Balance";
            //foreach (var item in files)
            //{
            string fullPath = files[0].ToString();

            string msg = string.Empty;
            string option = string.Empty;

            string fileName = fullPath.Substring(fullPath.IndexOf(@"\") + 1);

            if (fileName.Equals(null))
            {
                return View("ImportCSV");
            }
            try
            {
                string Pattern = "^\\d{2}.\\d{2}.\\d{2}$";
                string path = Path.Combine(Server.MapPath(Helper.RootFolder), fileName);
                string[] Lines = System.IO.File.ReadAllLines(path);
                string[] Fields;
                string Buchungstag;
                string Valutadatum;
                string Betrag;
                int count = 0;
                string Headers = Lines.FirstOrDefault().ToString();

                Headers=Headers.Replace("\"","");

                Lines = Lines.Skip(1).ToArray();

                if (Headers.Equals(bankStatement))
                {
                    option = IWSLocalResource.BankStatement;

                    List<BankStatement> BankStatement = new List<BankStatement>();

                    foreach (var line in Lines)
                    {          
                        Fields = line.Split(new char[] { ';' });
                        Buchungstag = Fields[1].Replace("\"", "");
                        if (Regex.IsMatch(Buchungstag, Pattern))
                        {
                            Buchungstag = (Buchungstag.Substring(0, 6) + "20" + Buchungstag.Substring(6, 2)).Replace(".", "/");
                        }
                        Valutadatum = Fields[2].Replace("\"", "");
                        if(Regex.IsMatch(Valutadatum, Pattern))
                        {
                            Valutadatum = (Valutadatum.Substring(0, 6) + "20" + Valutadatum.Substring(6, 2)).Replace(".", "/");
                        }
                        Betrag = Fields[8].Replace("\"", "");
                        BankStatement.Add(new BankStatement
                        {
                            Auftragskonto = Fields[0].Replace("\"", ""),
                            Buchungstag = Convert.ToDateTime(DateTime.ParseExact(Buchungstag, "dd/MM/yyyy", CultureInfo.InvariantCulture)),
                            Valutadatum = Convert.ToDateTime(DateTime.ParseExact(Valutadatum, "dd/MM/yyyy", CultureInfo.InvariantCulture)),
                            Buchungstext = Fields[3].Replace("\"", ""),
                            Verwendungszweck = Fields[4].Replace("\"", ""),
                            BeguenstigterZahlungspflichtiger = Fields[5].Replace("\"", ""),
                            Kontonummer = Fields[6].Replace("\"", ""),
                            BLZ = Fields[7].Replace("\"", ""),
                            Betrag = Convert.ToDecimal(Betrag),
                            Waehrung = Fields[9].Replace("\"", ""),
                            Info = Fields[10].Replace("\"", ""),
                            CompanyID = (string)Session["CompanyID"]
                        });
                    }

                    foreach (var n in BankStatement)
                    {
                        var u = db.BankStatements.Where(o => o.Auftragskonto.Equals(n.Auftragskonto)
                                    && o.BeguenstigterZahlungspflichtiger.Equals(n.BeguenstigterZahlungspflichtiger)
                                    && o.Betrag.Equals(n.Betrag)
                                    && o.BLZ.Equals(n.BLZ)
                                    && o.Buchungstag.Equals(n.Buchungstag)
                                    && o.Buchungstext.Equals(n.Buchungstext)
                                    && o.Info.Equals(n.Info)
                                    //&& o.Kontonummer.Equals(n.Kontonummer)
                                    && o.Valutadatum.Equals(n.Valutadatum)
                                    && o.Verwendungszweck.Equals(n.Verwendungszweck)
                                    && o.Waehrung.Equals(n.Waehrung)
                                    && o.CompanyID.Equals(n.CompanyID)).FirstOrDefault();
                        if (u == null)
                        {
                            n.IsValidated = false;
                            db.BankStatements.InsertOnSubmit(n);
                            count += 1;
                        }
                    }

                }

                if (Headers.Equals(accounts))
                {
                    option = IWSLocalResource.account;

                    List<Account> Account = new List<Account>();
                    foreach (var line in Lines)
                    {
                        Fields = line.Split(new char[] { ';' });

                        Account.Add(new Account
                        {
                            id = Fields[0],
                            name = Fields[1],
                            description = string.Empty,
                            dateofopen = DateTime.Now,
                            dateofclose = DateTime.Now, 
                            balance = Convert.ToDecimal(Fields[2]),
                            CompanyID = (string)Session["CompanyID"],
                            ParentId = string.Empty,
                            IsUsed = true
                        });
                        
                    }

                    foreach (var n in Account)
                    {
                        var u = db.Accounts.Where(o => o.id.Equals(n.id)
                                   && o.CompanyID.Equals(n.CompanyID)).FirstOrDefault();
                        if (u == null)
                        {
                            db.Accounts.InsertOnSubmit(n);
                            count += 1;
                        }
                    }

                }

                db.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);

                if (Headers.Equals(bankStatement))
                {
                    var bankStatements =
                        from statement in db.BankStatements
                        where
                          statement.Buchungstext == "ABSCHLUSS" &&
                          statement.Kontonummer.Length == 0
                        select statement;
                        foreach (var item in bankStatements)
                        {
                        item.Kontonummer = ("DE47" + item.BLZ + "00" + item.Auftragskonto);
                        }
                        db.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);

                        AddNewAccount();
                }

                if (count > 0)
                {
                    msg= $"{count} {IWSLocalResource.Imported} {option} ";
                }
                else
                {
                    msg = $"{IWSLocalResource.ImportedNone}";
                }
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            //}
            var Message = new { Description = msg };

            return Json(Message);
        }

        #region Helper

        /// <summary>
        /// Add new Customer and/or Supplier from newly imported CSV bank statements data
        /// </summary>
        /// <returns>true on success or false otherwize</returns>
        private bool AddNewAccount()
        {
            string companyID = (string)Session["CompanyID"];

            var customerID = db.Customers.Max(i => i.id);   

            int customerMax =  Convert.ToInt32(customerID);

            var supplierID = db.Suppliers.Max(i => i.id);   

            int supplierMax = Convert.ToInt32(supplierID);

            try
            {

                var bankStatement =
                    (from b in db.BankStatements
                     orderby
                       (int?)Math.Sign((int)b.Betrag)
                     select new
                     {
                         Name = b.BeguenstigterZahlungspflichtiger,
                         IBAN = b.Kontonummer,
                         BIC = b.BLZ,
                         IsCustomer = Math.Sign((int)b.Betrag) < 0 ? false : true
                     }).Distinct();

                    foreach (var r in bankStatement)
                    {
                    if (r.IsCustomer.Equals(true))
                    {
                        var u = db.Customers.FirstOrDefault(o => o.IBAN.Equals(r.IBAN) 
                                                        && o.CompanyID.Equals(companyID));
                        if (u == null)
                        {
                            customerMax++;
                            u = new Customer
                            {
                                id = Convert.ToString(customerMax),
                                name = r.Name??"QWQWQWQWQ",
                                BIC=r.BIC,
                                street = "",
                                city = "",
                                state = "",
                                zip = "",
                                accountid = "400100",// clients divers
                                CompanyID = companyID,
                                IBAN=r.IBAN
                            };
                            var b = db.Customers.FirstOrDefault(o => o.IBAN.Equals(u.IBAN) 
                                                            && o.CompanyID.Equals(companyID));
                            if(b==null)
                                db.Customers.InsertOnSubmit(u);
                        }
                    }
                    if (r.IsCustomer.Equals(false))
                    {
                        var u = db.Suppliers.FirstOrDefault(o => o.IBAN.Equals(r.IBAN) 
                                                        && o.CompanyID.Equals(companyID));
                        if (u == null)
                        {
                            supplierMax++;
                            u = new Supplier
                            {
                                id = Convert.ToString(supplierMax),
                                name = r.Name ?? "QWQWQWQWQ",
                                BIC = r.BIC,
                                street = "",
                                city= "",
                                state= "",
                                zip="",
                                accountid = "440100", // fournisseurs divers
                                CompanyID = companyID,
                                IBAN=r.IBAN
                            };
                            var b = db.Suppliers.FirstOrDefault(o => o.IBAN.Equals(r.IBAN) 
                                                            && o.CompanyID.Equals(companyID));
                            if(b==null)
                                db.Suppliers.InsertOnSubmit(u);
                        }
                    }
                    db.SubmitChanges(System.Data.Linq.ConflictMode.ContinueOnConflict);
                    }
                return true;
            }
            catch (Exception e)
            {
                ViewData["GenericError"] = e.Message;
                return false;
            }
        }

        private int MakeCustomerInvoice(int bankStatementID)
        {
            StatementDetailViewModel SD = IWSLookUp.GetStatementDetail(bankStatementID,
                                            IWSLookUp.DocsType.CustomerInvoice.ToString());

            int itemID = 0;

            if (SD.Equals(null))
                return itemID;

            CustomerInvoice customerInvoice = new CustomerInvoice
            {
                oid = 0,
                CostCenter = "200", // to be confirmed
                account = SD.Id,
                HeaderText = SD.Verwendungszweck,
                TransDate = SD.Valutadatum,
                ItemDate = SD.Buchungstag,
                EntryDate = DateTime.Today,
                CompanyId = (string)Session["CompanyID"],
                IsValidated = false
            };
            itemID = new AccountingController().MakeCustomerInvoiceHeader(customerInvoice);

            if (itemID == 0)
                return itemID;

            List<LineCustomerInvoice> lineCustomerInvoice = new List<LineCustomerInvoice>
            {
                new LineCustomerInvoice
                {
                    transid = itemID,
                    account = SD.AccountID,
                    side = true,
                    oaccount = SD.BankAccountID,
                    amount = SD.Betrag,
                    Currency = SD.Waehrung,
                    duedate = SD.Valutadatum,
                    text = SD.Buchungstext
                }
            };
            int countLineID = new AccountingController().MakeCustomerInvoiceLine(lineCustomerInvoice);

            if (countLineID == 0)
                return countLineID;

            return itemID;
        }

        private int MakeVendorInvoice(int bankStatementID)
        {
            StatementDetailViewModel SD = IWSLookUp.GetStatementDetail(bankStatementID,
                                            IWSLookUp.DocsType.VendorInvoice.ToString());

            int itemID = 0;

            if (SD.Equals(null))
                return itemID;

            VendorInvoice vendorInvoice = new VendorInvoice
            {
                oid = 0,
                CostCenter = "200", // to be confirmed
                account = SD.Id,
                HeaderText = SD.Verwendungszweck,
                TransDate = SD.Valutadatum,
                ItemDate = SD.Buchungstag,
                EntryDate = DateTime.Today,
                CompanyId = (string)Session["CompanyID"],
                IsValidated = false
            };
            itemID = new AccountingController().MakeVendorInvoiceHeader(vendorInvoice);            

            if (itemID == 0)
                return itemID;

            List<LineVendorInvoice> lineVendorInvoice = new List<LineVendorInvoice>
            {
                new LineVendorInvoice
                {
                    transid = itemID,
                    account = SD.AccountID,
                    side = true,
                    oaccount = SD.BankAccountID,
                    amount = SD.Betrag,
                    Currency = SD.Waehrung,
                    duedate = SD.Valutadatum,
                    text = SD.Buchungstext
                }
            };
            int countLineID = new AccountingController().MakeVendorInvoiceLine(lineVendorInvoice);

            if(countLineID == 0)
                return countLineID;

            return itemID;
        }

        private bool MakePayment(int bankStatementID, int oid)
        {
            StatementDetailViewModel SD = IWSLookUp.GetStatementDetail(bankStatementID,
                                            IWSLookUp.DocsType.Payment.ToString());

            int itemID = 0;

            if (SD.Equals(null) )
                return false;

            Payment payment = new Payment
            {
                oid = oid,
                CostCenter = "200", // to be confirmed
                account = SD.Id,
                HeaderText = SD.Verwendungszweck,
                TransDate = SD.Valutadatum,
                ItemDate = SD.Buchungstag,
                EntryDate = DateTime.Today,
                CompanyId = (string)Session["CompanyID"],
                IsValidated = false
            };
            itemID = new AccountingController().MakePaymentHeader(payment);

            if (!(itemID > 0))
                return false;

            List<LinePayment> linePayment = new List<LinePayment>
            {
                new LinePayment
                {
                    transid = itemID,
                    account = SD.AccountID,
                    side = true,
                    oaccount = SD.BankAccountID,
                    amount = SD.Betrag,
                    Currency = SD.Waehrung,
                    duedate = SD.Valutadatum,
                    text = SD.Buchungstext
                }
            };
            int countLineID = new AccountingController().MakePaymentLine(linePayment);

            return (countLineID > 0);
        }

        private bool MakeSettlement(int bankStatementID, int oid)
        {
            StatementDetailViewModel SD = IWSLookUp.GetStatementDetail(bankStatementID,
                                                IWSLookUp.DocsType.Settlement.ToString());
            int itemID = 0;

            if (SD.Equals(null))
                return false;

            Settlement settlement = new Settlement
                {
                    oid = oid,
                    CostCenter = "100", // to be confirmed
                    account = SD.Id,
                    HeaderText = SD.Verwendungszweck,
                    TransDate = SD.Valutadatum,
                    ItemDate = SD.Buchungstag,
                    EntryDate = DateTime.Today,
                    CompanyId = (string)Session["CompanyID"],
                    IsValidated = false
                };
            itemID = new AccountingController().MakeSettlementHeader(settlement);

            if (!(itemID > 0))
                return false;

            List<LineSettlement> lineSettlement = new List<LineSettlement>
                {
                    new LineSettlement
                    {
                        transid = itemID,
                        account = SD.BankAccountID,
                        side = true,
                        oaccount = SD.AccountID,
                        amount = SD.Betrag,
                        Currency = SD.Waehrung,
                        duedate = SD.Valutadatum,
                        text = SD.Buchungstext
                    }
                };
            int countLineID = new AccountingController().MakeSettlementLine(lineSettlement);

            return (countLineID > 0);
        }

        private bool ValidateBankStatement(int ItemID)
        {
            try
            { 
                var docs = db.BankStatements.Single(item => item.id == ItemID);

                if (docs.Equals(null))
                    return false;

                docs.IsValidated = true;

                return true;
            }
            catch (Exception e)
            {
                ViewData["GenericError"] = e.Message;

                return false;
            }
        }

        public class Helper
        {
            public const string RootFolder = "~/Content/Uploads";
            public static string Model { get { return RootFolder; } }

            public static string[] AllowedFileExtensions = new string[] { ".csv", ".txt" };
        }

        #endregion
    }

}