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
            var journal = IWSLookUp.GetJournal();
            var model = new List<JournalViewModel>();
            foreach (JournalViewModel item in journal)
            {
                model.Add(item);
            }
            return View(model);
        }
        [ValidateInput(false)]
        public ActionResult JournalPartialView()
        {
            var journal = IWSLookUp.GetJournal();
            var model = new List<JournalViewModel>();
            foreach (JournalViewModel item in journal)
            {
                model.Add(item);
            }
            return PartialView(model);

        }
    }
}