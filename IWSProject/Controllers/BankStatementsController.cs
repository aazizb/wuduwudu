namespace IWSProject.Controllers
{
    using DevExpress.Web.Mvc;
    using IWSProject.Content;
    using IWSProject.Models;
    using System;
    using System.Collections;
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
            return View(IWSLookUp.GetBankStatements((string)Session["CompanyID"], false));
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult Index(string selectedIDsHF)
        {
            string selectedItems = selectedIDsHF;

            if (!string.IsNullOrEmpty(selectedItems))
            {
                int ItemID = 0;
                string Area = null;
                bool results = false;

                IList<string> items = new List<string>(selectedItems.Split(new string[] { ";" },
                                                                StringSplitOptions.None));
                foreach (string item in items)
                {

                    var list = item.Split(new string[] { "," }, StringSplitOptions.None);

                    ItemID = Convert.ToInt32(list[0]);
                    if (Convert.ToDecimal(list[1]) == 0 || list[1] == null)
                    {
                        ViewData["GenericError"] = IWSLocalResource.GenericError;
                        return RedirectToAction("Index");
                    }

                    if (Convert.ToDecimal(list[1]) >= 0)
                    {
                        Area = IWSLookUp.Area.Selling.ToString();
                    }
                    if (Convert.ToDecimal(list[1]) <= 0)
                    {
                        Area = IWSLookUp.Area.Purchasing.ToString();
                    }

                    results = MakePayment(ItemID, Area);
                    if (!results)
                    {
                        ViewData["GenericError"] = IWSLocalResource.GenericError;
                        return RedirectToAction("Index");
                    }
                    results = ValidateItem(ItemID);
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
            item.modelid = 1600;
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
            return PartialView("BankStatementsGridViewPartial", db.BankStatements.Where(c => c.CompanyID == (string)Session["CompanyID"]));
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
            return PartialView("BankStatementsGridViewPartial", db.BankStatements.Where(c => c.CompanyID == (string)Session["CompanyID"]));
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
            return PartialView("BankStatementsGridViewPartial", db.BankStatements.Where(c => c.CompanyID == (string)Session["CompanyID"]));
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

            //foreach (var item in files)
            //{
            string fullPath = files[0].ToString();

            string msg = string.Empty;

            string fileName = fullPath.Substring(fullPath.IndexOf(@"\") + 1);

            if (fileName == null)
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

                Lines = Lines.Skip(1).ToArray();                    //remove headers
                List<BankStatement> BankStatement = new List<Models.BankStatement>();
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
                int count = 0;
                foreach (var n in BankStatement)
                {
                    var u = db.BankStatements.Where(o => o.Auftragskonto.Equals(n.Auftragskonto)
                                && o.BeguenstigterZahlungspflichtiger.Equals(n.BeguenstigterZahlungspflichtiger)
                                && o.Betrag.Equals(n.Betrag)
                                && o.BLZ.Equals(n.BLZ)
                                && o.Buchungstag.Equals(n.Buchungstag)
                                && o.Buchungstext.Equals(n.Buchungstext)
                                && o.Info.Equals(n.Info)
                                && o.Kontonummer.Equals(n.Kontonummer)
                                && o.Valutadatum.Equals(n.Valutadatum)
                                && o.Verwendungszweck.Equals(n.Verwendungszweck)
                                && o.Waehrung.Equals(n.Waehrung)
                                && o.CompanyID.Equals(n.CompanyID)).FirstOrDefault();
                    if (u == null)          // add new record
                    {
                        n.modelid = 1600;
                        n.IsValidated = false;
                        db.BankStatements.InsertOnSubmit(n);
                        count += 1;         //and counts inserted record
                    }
                }
                db.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);
                if (count > 0)
                {
                    msg= $"{count} {IWSLocalResource.Imported}";
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
            AddNewAccount();
            return Json(Message);
        }

        #region Helper
        /// <summary>
        /// Add new Customer and/or Supplier from newly imported CSV bank statement data
        /// </summary>
        /// <returns>true on success and false otherwize</returns>
        private bool AddNewAccount()
        {
            string companyID = (string)Session["CompanyID"];

            var customerID = db.Customers.Max(i => i.id);   

            int customerMax =  Convert.ToInt32(customerID);

            var supplierID = db.Suppliers.Max(i => i.id);   

            int supplierMax = Convert.ToInt32(supplierID);

            try
            {
                var query =
                    (from b in db.BankStatements
                     where
                        b.BeguenstigterZahlungspflichtiger.Length > 0 &&
                        b.Kontonummer.Length > 0 &&
                        b.IsValidated.Equals(false)
                     select new
                     {
                         Name = b.BeguenstigterZahlungspflichtiger,
                         IBAN=b.Kontonummer,
                         IsCustomer = Math.Sign((int)b.Betrag) <0 ? false : true
                     }).Distinct();

                    foreach (var r in query)
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
                                name = r.Name,
                                modelid = 3,
                                street = "",
                                city = "",
                                state = "",
                                zip = "",
                                accountid = "7000",
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
                                name = r.Name,
                                modelid = 1,
                                street="",
                                city="",
                                state="",
                                zip="",
                                accountid = "8000",
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
        private bool MakePayment(int bankStatementID, string area)
        {
            StatementDetailViewModel SD = IWSLookUp.GetStatementDetail(bankStatementID, area);
            int itemID = 0;
            bool results=false;
            if (SD == null)
                return results;
            if (area.Equals(IWSLookUp.Area.Purchasing.ToString()))
            {
                Payment payment = new Payment
                {
                    oid = 0,
                    modelid = 114,
                    store = "200",
                    account = SD.Id,
                    text = SD.Info,
                    ItemDate = (DateTime)SD.Buchungstag,
                    CompanyId = (string)Session["CompanyID"],
                    IsValidated = false
                };
                itemID = new AccountingController().MakePaymentHeader(payment);
                results = (itemID > 0);
                if (results)
                {
                    List<LinePayment> linePayment = new List<LinePayment>
                    { new LinePayment{
                        transid = itemID,
                        modelid = 113,
                        account = SD.AccountID,
                        side = true,
                        oaccount = SD.BankAccountID,
                        amount = SD.Betrag,
                        Currency = SD.Waehrung,
                        duedate = SD.Valutadatum,
                        text = SD.Buchungstext}
                    };
                    int countLineID = new AccountingController().MakePaymentLine(linePayment);
                    results = (countLineID > 0);
                }
            }

            if (area.Equals(IWSLookUp.Area.Selling.ToString()))
            {
                Settlement settlement = new Settlement
                {
                    oid = 0,
                    modelid = 114,
                    store = "100",
                    account = SD.Id,
                    text = SD.Info,
                    ItemDate = (DateTime)SD.Buchungstag,
                    CompanyId = (string)Session["CompanyID"],
                    IsValidated = false
                };
                itemID = new AccountingController().MakeSettlementHeader(settlement);
                results = (itemID > 0);
                if (results)
                {
                    List<LineSettlement> lineSettlement = new List<LineSettlement>
                    { new LineSettlement{
                        transid = itemID,
                        modelid = 113,
                        account = SD.AccountID,
                        side = true,
                        oaccount = SD.BankAccountID,
                        amount = SD.Betrag,
                        Currency = SD.Waehrung,
                        duedate = SD.Valutadatum,
                        text = SD.Buchungstext}
                    };
                    int countLineID = new AccountingController().MakeSettlementLine(lineSettlement);
                    results = (countLineID > 0);
                }
            }

            return results;
        }

        private bool ValidateItem(int bankStatementID)
        {
            try
            { 
                var docs = db.BankStatements.Single(item => item.id == bankStatementID);
                if (docs != null)
                {
                    docs.IsValidated = true;
                    return true;
                }
            }
            catch (Exception e)
            {
                ViewData["GenericError"] = e.Message;
            }
            return false;
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