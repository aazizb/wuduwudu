using System;
using System.Linq;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using IWSProject.Models;
using IWSProject.Content;
namespace IWSProject.Controllers
{
    [Authorize]
    public class SuppliersController : Controller
    {
        IWSDataContext db = new IWSDataContext();

        // GET: suppliers
        public ActionResult Index()
        {
            return View(db.Suppliers);
        }

        [ValidateInput(false)]
        public ActionResult SuppliersGridViewPartial()
        {
            return PartialView("SuppliersGridViewPartial", db.Suppliers);
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult SuppliersGridViewPartialAddNew([ModelBinder(typeof(DevExpressEditorsBinder))] Supplier item)
        {
            var model = db.Suppliers;
            item.modelid = 1;
            ViewData["supplier"] = item;
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
                ViewData["GenericError"] = IWSLocalResource.GenericError;
            return PartialView("SuppliersGridViewPartial", model);
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult SuppliersGridViewPartialUpdate([ModelBinder(typeof(DevExpressEditorsBinder))]Supplier item)
        {
            var model = db.Suppliers;
            ViewData["supplier"] = item;
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
                ViewData["GenericError"] = IWSLocalResource.GenericError;
            return PartialView("SuppliersGridViewPartial", model);
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult SuppliersGridViewPartialDelete(string id)
        {
            var model = db.Suppliers;
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
            return PartialView("SuppliersGridViewPartial", model);
        }
    }
}
