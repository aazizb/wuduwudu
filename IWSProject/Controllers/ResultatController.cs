using IWSProject.Models;
using System.Collections.Generic;
using System.Web.Mvc;


namespace IWSProject.Controllers
{
    public class ResultatController : Controller
    {
        // GET: Resultat
        public ActionResult Index()
        {
            ViewData["class"] = IWSLookUp.GetClass();
            return View();
        }
        [ValidateInput(false)]
        public ActionResult ResultatPartial()
        {
            string classId = (string)Session["ClassId"];
            string txtStart = (string)Session["txtStart"];
            string txtEnd = (string)Session["txtEnd"];
            string company = (string)Session["CompanyID"];
            var resultat = IWSLookUp.GetResultat(classId, txtStart, txtEnd, company);
            var model = new List<ResultsViewModel>();
            foreach (ResultsViewModel item in resultat)
            {
                model.Add(item);
            }
            return PartialView("ResultatPartialView", model);
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult CallbackPanelPartial(string classId, string txtStart, string txtEnd)
        {
            Session["ClassId"] = classId;
            Session["txtStart"] = txtStart;
            Session["txtEnd"] = txtEnd;
            string company = (string)Session["CompanyID"];
            var resultat = IWSLookUp.GetResultat(classId, txtStart, txtEnd, company);
            var model = new List<ResultsViewModel>();
            foreach (ResultsViewModel item in resultat)
            {
                model.Add(item);
            }
            return PartialView("_CallbackPartialView", model);

        }
    }
}
