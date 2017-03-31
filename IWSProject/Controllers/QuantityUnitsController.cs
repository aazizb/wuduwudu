using System;
using System.Linq;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using IWSProject.Models;
using IWSProject.Content;
namespace IWSProject.Controllers
{
    [Authorize]
    public class QuantityUnitsController : Controller
    {
        private IWSDataContext db = new IWSDataContext();

        // GET: QuantityUnits
        public ActionResult Index()
        {
            return View(db.QuantityUnits.Where(c => c.CompanyID == (string)Session["CompanyID"]));
        }

        [ValidateInput(false)]
        public ActionResult QuantityUnitsGridViewPartial()
        {
            return PartialView("QuantityUnitsGridViewPartial", db.QuantityUnits.Where(c => c.CompanyID == (string)Session["CompanyID"]));
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult QuantityUnitsGridViewPartialAddNew([ModelBinder(typeof(DevExpressEditorsBinder))] QuantityUnit item)
        {
            var model = db.QuantityUnits;
            item.modelid = 4;
            item.CompanyID = (string)Session["CompanyID"];
            ViewData["quantityunit"] = item;
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
            return PartialView("QuantityUnitsGridViewPartial", db.QuantityUnits.Where(c => c.CompanyID == (string)Session["CompanyID"]));
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult QuantityUnitsGridViewPartialUpdate([ModelBinder(typeof(DevExpressEditorsBinder))] QuantityUnit item)
        {
            var model = db.QuantityUnits;

            ViewData["quantityunit"] = item;
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
            return PartialView("QuantityUnitsGridViewPartial", db.QuantityUnits.Where(c => c.CompanyID == (string)Session["CompanyID"]));
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult QuantityUnitsGridViewPartialDelete(string id)
        {
            var model = db.QuantityUnits;
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
            return PartialView("QuantityUnitsGridViewPartial", db.QuantityUnits.Where(c => c.CompanyID == (string)Session["CompanyID"]));
        }
    }
}
