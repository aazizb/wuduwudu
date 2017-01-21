using System.Collections.Generic;
using System.Web.Mvc;
using IWSProject.Models;

namespace IWSProject.Controllers
{
    public class BalanceController : Controller
    {
        // GET: Balance
        public ActionResult Index()
        {
            var items = IWSLookUp.GetAccountBalance();
            var model = new List<AccountBalanceViewModel>();
            foreach (AccountBalanceViewModel item in items)
            {
                model.Add(item);
            }
            return View(model);
        }
        public ActionResult AccountBalancePartialView()
        {
            var items = IWSLookUp.GetAccountBalance();
            var model = new List<AccountBalanceViewModel>();
            foreach (AccountBalanceViewModel item in items)
            {
                model.Add(item);
            }
            return PartialView(model);

        }
    }
}