using DevExpress.Web.Mvc;
using IWSProject.Content;
using IWSProject.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace IWSProject.Controllers
{
    public class CurrenciesController : Controller
    {
        // GET: Currency
        private IWSDataContext db = new IWSDataContext();

        // GET: Currencies
        public ActionResult Index()
        {
            return View(db.Currencies.Where(c => c.CompanyID == (string)Session["CompanyID"]));
        }

        [ValidateInput(false)]
        public ActionResult CurrenciesGridViewPartial()
        {
            return PartialView("CurrenciesGridViewPartial", db.Currencies.Where(c => c.CompanyID == (string)Session["CompanyID"]));
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult CurrenciesGridViewPartialAddNew([ModelBinder(typeof(DevExpressEditorsBinder))] Currency item)
        {
            var model = db.Currencies;
            item.CompanyID = (string)Session["CompanyID"];
            ViewData["Currencies"] = item;
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
            return PartialView("CurrenciesGridViewPartial", db.Currencies.Where(c => c.CompanyID == (string)Session["CompanyID"]));
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult CurrenciesGridViewPartialUpdate([ModelBinder(typeof(DevExpressEditorsBinder))] Currency item)
        {
            var model = db.Currencies;

            ViewData["Currencies"] = item;
            if (ModelState.IsValid)
            {
                try
                {
                    var modelItem = model.FirstOrDefault(it => it.Id == item.Id);
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
            return PartialView("CurrenciesGridViewPartial", db.Currencies.Where(c => c.CompanyID == (string)Session["CompanyID"]));
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult CurrenciesGridViewPartialDelete(string id)
        {
            var model = db.Currencies;
            if (id != null)
            {
                try
                {
                    var item = model.FirstOrDefault(it => it.Id == id);
                    if (item != null)
                        model.DeleteOnSubmit(item);

                    db.SubmitChanges();
                }
                catch (Exception e)
                {
                    ViewData["GenericError"] = e.Message;
                }
            }
            return PartialView("CurrenciesGridViewPartial", db.Currencies.Where(c => c.CompanyID == (string)Session["CompanyID"]));
        }
    }
}