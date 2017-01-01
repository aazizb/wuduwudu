using System.Collections.Generic;
using System.Web.Mvc;
using IWSProject.Models;

namespace IWSProject.Controllers
{
    [Authorize]
    public class StocksController : Controller
    {
        private IWSDataContext db = new IWSDataContext();

        // GET: Stocks
        public ActionResult Index()
        {
            var SV = IWSLookUp.GetStock();
            var model = new List<StockViewModel>();
            foreach (StockViewModel item in SV)
            {
                model.Add(item);
            }
            return View(model);
        }
        public ActionResult StocksPartialView()
        {
            var SV = IWSLookUp.GetStock();
            var model = new List<StockViewModel>();
            foreach (StockViewModel item in SV)
            {
                model.Add(item);
            }
            return PartialView(model);
        }
    }
}
