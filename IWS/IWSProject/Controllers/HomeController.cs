using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using IWSProject.Content;
using IWSProject.Models;
namespace IWSProject.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [ValidateInput(false)]
        public ActionResult SalesInvoice()
        {
            return View();
        }
        [ValidateInput(false)]
        public ActionResult BillOfDelivery()
        {
            return View();
        }
        [ValidateInput(false)]
        public ActionResult PeriodicBalance()
        {
            return View();
        }
        [ValidateInput(false)]
        public ActionResult About(string id)
        {
            return View();
        }
        public ActionResult Upload()
        {
            return View("Upload");
        }
        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase upload)
        {
            if (ModelState.IsValid) 
            {
                if ( (upload == null) || (upload.ContentLength == 0))
                {
                    ViewData["data"] = IWSLocalResource.SelectFile;
                    return View();
                }

                string fileName = Path.GetFileName(upload.FileName);

                string path = Path.Combine(Server.MapPath(HomeSettings.RootFolder), fileName);//"~/Content/Uploads"

                try
                {
                    if (System.IO.File.Exists(path))
                        System.IO.File.Delete(path);

                    upload.SaveAs(path);

                    string[] Lines = System.IO.File.ReadAllLines(path);

                    string[] Fields;

                    //remove headers
                    Lines = Lines.Skip(1).ToArray();
                    List<BankStatement> BankStatement = new List<Models.BankStatement>();
                    foreach (var line in Lines)
                    {
                        Fields = line.Split(new char[] { ';' });
                        BankStatement.Add(new BankStatement
                        {
                            Auftragskonto = Fields[0].Replace("\"", ""),
                            Buchungstag = Fields[1].Replace("\"", ""),
                            Valutadatum = Fields[2].Replace("\"", ""),
                            Buchungstext = Fields[3].Replace("\"", ""),
                            Verwendungszweck = Fields[4].Replace("\"", ""),
                            BeguenstigterZahlungspflichtiger = Fields[5].Replace("\"", ""),
                            Kontonummer = Fields[6].Replace("\"", ""),
                            BLZ = Fields[7].Replace("\"", ""),
                            Betrag = Fields[8].Replace("\"", ""),
                            Waehrung = Fields[9].Replace("\"", ""),
                            Info = Fields[10].Replace("\"", ""),
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
                                     && o.Waehrung.Equals(n.Waehrung)).FirstOrDefault();
                            if (u == null)// add new
                            {
                                db.BankStatements.InsertOnSubmit(n);
                                count += 1;
                            }
                        }
                        db.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);
                        if (count > 0)
                        {
                            ViewData["data"] = $"{count} {IWSLocalResource.Imported}";
                        }
                        else
                        {
                            ViewData["data"] = $"{IWSLocalResource.ImportedNone}";
                        }
                    }
                }
                catch (Exception ex)
                {
                    if (System.IO.File.Exists(path))
                        System.IO.File.Delete(path);
                    ViewData["data"] = ex.Message;
                }
                if (System.IO.File.Exists(path))
                    System.IO.File.Delete(path);

                return View();
            }
            return View();
        }

        public object RootFolder = "~/Content/Uploads";
        public ActionResult ImportCSV()
        {
            return View("ImportCSV", RootFolder);
        }
        [ValidateInput(false)]
        public ActionResult ImportCSVPartial(string currentFileName)
        {
            return PartialView("ImportCSVPartial", RootFolder); 
        }
        public ActionResult UploadToDB(string[] files)
        {

            //foreach (var item in files)
            //{
            string fullPath = files[0].ToString();

            string fileName=fullPath.Substring(fullPath.IndexOf(@"\")+1);

            if (fileName == null)
                {
                    ViewData["Session"] = IWSLocalResource.SelectFile;
                    return View();
                }
            try
            {

                string path = Path.Combine(Server.MapPath(HomeSettings.RootFolder), fileName);
                string[] Lines = System.IO.File.ReadAllLines(path);

                string[] Fields;
                
                Lines = Lines.Skip(1).ToArray();                    //remove headers
                List<BankStatement> BankStatement = new List<Models.BankStatement>();
                foreach (var line in Lines)
                {
                    Fields = line.Split(new char[] { ';' });
                    BankStatement.Add(new BankStatement
                    {
                        Auftragskonto = Fields[0].Replace("\"", ""),
                        Buchungstag = Fields[1].Replace("\"", ""),
                        Valutadatum = Fields[2].Replace("\"", ""),
                        Buchungstext = Fields[3].Replace("\"", ""),
                        Verwendungszweck = Fields[4].Replace("\"", ""),
                        BeguenstigterZahlungspflichtiger = Fields[5].Replace("\"", ""),
                        Kontonummer = Fields[6].Replace("\"", ""),
                        BLZ = Fields[7].Replace("\"", ""),
                        Betrag = Fields[8].Replace("\"", ""),
                        Waehrung = Fields[9].Replace("\"", ""),
                        Info = Fields[10].Replace("\"", ""),
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
                                 && o.Waehrung.Equals(n.Waehrung)).FirstOrDefault();
                        if (u == null)          // add new record
                        {
                            db.BankStatements.InsertOnSubmit(n);
                            count += 1;         //counts inserted record
                        }
                    }
                    db.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);
                    if (count > 0)
                    {
                        Session["GenericError"] = $"{count} {IWSLocalResource.Imported}";
                    }
                    else
                    {
                        Session["GenericError"] = $"{IWSLocalResource.ImportedNone}";
                    }
                }
            }
            catch (Exception ex)
            {
                Session["GenericError"] = ex.Message;
            }
            //}
            return View("ImportCSV", RootFolder);
        }
        public ActionResult CustomToolbarAction(string viewType)
        {
            return PartialView("FileManagerPartial", RootFolder);
        }
    }
    public class HomeSettings
    {
        public const string RootFolder = "~/Content/Uploads";
        public static string Model { get { return RootFolder; } }

        public static string[] AllowedFileExtensions = new string[] { ".csv", ".txt" };

    }
}
