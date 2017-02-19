using System.Net;
using System.Web.Mvc;

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
    }
}