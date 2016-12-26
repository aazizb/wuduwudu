using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using IWSProject.Models;

namespace IWSProject.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        //IWSDataContext db = new IWSDataContext();
        //List<Menu> menuList;
        public ActionResult Index()
        {
            //if (ViewBag.MenuItems == null)
            //{
            //    menuList = db.Menus.ToList();
            //    ViewBag.MenuItems = menuList.ToList();
            //}
            return View();
        }
        public ActionResult GoodReceiving()
        {
            return View();
        }

        public ActionResult About(string id)
        {
            if (id == null)
            {

                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ViewData["Key"] = id;
            return View();
        }

    }
}