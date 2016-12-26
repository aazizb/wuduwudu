using System;
using System.Linq;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using IWSProject.Models;
using IWSProject.Content;
namespace IWSProject.Controllers
{
    [Authorize]
    public class StocksController : Controller
    {
        private IWSDataContext db = new IWSDataContext();

        // GET: Stocks
        public ActionResult Index()
        {
            return View(db.Stocks);
        }

        [ValidateInput(false)]
        public ActionResult StocksGridViewPartial()
        {
            return PartialView("StocksGridViewPartial", db.Stocks);
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult StocksGridViewPartialAddNew([ModelBinder(typeof(DevExpressEditorsBinder))] Stock item)
        {
            var model = db.Stocks;
            ViewData["stock"] = item;
            if (ModelState.IsValid)
            {
                try
                {
                    model.InsertOnSubmit(item);

                    db.SubmitChanges();
                }
                catch (Exception e)
                {
                    ViewData["GenericError"] = e.Message;
                }
            }
            else
            {
                ViewData["GenericError"] = IWSLocalResource.GenericError;
            }
            return PartialView("StocksGridViewPartial", model);
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult StocksGridViewPartialUpdate([ModelBinder(typeof(DevExpressEditorsBinder))] Stock item)
        {
            var model = db.Stocks;
            ViewData["stock"] = item;
            if (ModelState.IsValid)
            {
                try
                {
                    var modelItem = model.FirstOrDefault(it => it.id == item.id);
                    if (modelItem != null)
                    {
                        this.UpdateModel(modelItem);

                        db.SubmitChanges();
                    }
                }
                catch (Exception e)
                {
                    ViewData["GenericError"] = e.Message;
                }
            }
            else
            {
                ViewData["GenericError"] = IWSLocalResource.GenericError;
            }
            return PartialView("StocksGridViewPartial", model);
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult StocksGridViewPartialDelete(string id)
        {
            var model = db.Stocks;
            if (id != null)
            {
                try
                {
                    var item = model.FirstOrDefault(it => it.id == id);
                    if (item != null)
                        model.DeleteOnSubmit(item);

                    db.SubmitChanges();
                }
                catch (Exception e)
                {
                    ViewData["GenericError"] = e.Message;
                }
            }
            return PartialView("StocksGridViewPartial", model);
        }
    }
}
