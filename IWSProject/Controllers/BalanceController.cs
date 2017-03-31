using System.Collections.Generic;
using System.Web.Mvc;
using IWSProject.Models;

namespace IWSProject.Controllers
{
    [Authorize]
    public class BalanceController : Controller
    {
        // GET: Balance
        public ActionResult Index()
        {
            var items = IWSLookUp.GetAccountBalance((string)Session["CompanyID"]);
            var model = new List<AccountBalanceViewModel>();
            foreach (AccountBalanceViewModel item in items)
            {
                model.Add(item);
            }
            return View(model);
        }
        [ValidateInput(false)]
        public ActionResult AccountBalancePartialView()
        {
            var items = IWSLookUp.GetAccountBalance((string)Session["CompanyID"]);
            var model = new List<AccountBalanceViewModel>();
            foreach (AccountBalanceViewModel item in items)
            {
                model.Add(item);
            }
            return PartialView(model);

        }
    }
}