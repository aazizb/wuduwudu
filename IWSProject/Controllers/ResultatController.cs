using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IWSProject.Models;


namespace IWSProject.Controllers
{
    public class ResultatController : Controller
    {
        // GET: Resultat
        public ActionResult Index(string account, string start, string end, string company)
        {
            return View(IWSLookUp.GetResultat("9900","201701","201712","1000"));
        }

        // GET: Resultat
        public ActionResult ResultatPartialView(string account, string start, string end, string company)
        {
            var resultat = IWSLookUp.GetResultat("9900", "201701", "201712", "1000");
            var model = new List<ResultsViewModel>();
            foreach (ResultsViewModel item in resultat)
            {
                model.Add(item);
            }
            return PartialView(model);
        }

    }
}
