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

namespace IWSProject.Controllers
{
    [Authorize]
    public class BankStatementsController : Controller
    {
        IWSDataContext db = new IWSDataContext();
        // GET: BankStatements
        public ActionResult Index()
        {
            return View(db.BankStatements.Where(c => c.CompanyID == (string)Session["CompanyID"]));
        }

        [ValidateInput(false)]
        public ActionResult BankStatementsGridViewPartial()
        {
            return PartialView("BankStatementsGridViewPartial", db.BankStatements.Where(c => c.CompanyID == (string)Session["CompanyID"]));
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
                using (IWSDataContext db = new IWSDataContext())
                {
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
        private bool MakePayment(BankStatement item)
        {
            return true;
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