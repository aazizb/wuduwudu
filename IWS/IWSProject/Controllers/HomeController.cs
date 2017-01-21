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
        public ActionResult GoodReceiving()
        {
            return View();
        }
        public ActionResult About(string id)
        {
            return View();
        }
    }
}