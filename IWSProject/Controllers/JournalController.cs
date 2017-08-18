using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IWSProject.Models;

namespace IWSProject.Controllers
{
    [Authorize]
    public class JournalController : Controller
    {
        // GET: Balance
        public ActionResult Index()
        {
            ViewData["accounts"] = IWSLookUp.GetAccounts();
            return View();
        }
        [ValidateInput(false)]
        public ActionResult JournalPartialView()
        {
            string start = (string)Session["Start"];
            string end = (string)Session["End"];
            string selectedIDs = (string)Session["selectedIDs"];
            string company = (string)Session["CompanyID"];
            List<JournalViewModel> model = (List<JournalViewModel>)IWSLookUp.GetJournal(start, end, selectedIDs, company);
            return PartialView(model);
        }
        public ActionResult GridLookUpPartial()
        {
            ViewData["accounts"] = IWSLookUp.GetAccounts();
            return PartialView("GridLookUpPartial");
        }

        public ActionResult CallbackPanelPartial(string start, string end, string selectedIDs)
        {
            if (string.IsNullOrWhiteSpace(start) || string.IsNullOrWhiteSpace(end))
                return PartialView("_CallbackPartialView");

            Session["Start"] = start;
            Session["End"] = end;
            Session["selectedIDs"] = selectedIDs;
            string company = (string)Session["CompanyID"];
            List<JournalViewModel> model = (List<JournalViewModel>)IWSLookUp.GetJournal(start, end, selectedIDs, company); 
            return PartialView("_CallbackPartialView", model);
        }
    }
}