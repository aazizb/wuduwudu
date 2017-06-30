using System;
using System.Linq;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using IWSProject.Models;
using IWSProject.Content;
namespace IWSProject.Controllers
{
    [Authorize]
    public class StoresController : Controller
    {
        private IWSDataContext db = new IWSDataContext();

        // GET: stores
        public ActionResult Index()
        {
            return View(db.Stores.Where(c => c.CompanyID == (string)Session["CompanyID"]));
        }

        [ValidateInput(false)]
        public ActionResult StoresGridViewPartial()
        {
            return PartialView("StoresGridViewPartial", db.Stores.Where(c => c.CompanyID == (string)Session["CompanyID"]));
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult StoresGridViewPartialAddNew([ModelBinder(typeof(DevExpressEditorsBinder))]Store item)
        {
            var model = db.Stores;
            item.CompanyID = (string)Session["CompanyID"];
            ViewData["stores"] = item;
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
            return PartialView("StoresGridViewPartial", db.Stores.Where(c => c.CompanyID == (string)Session["CompanyID"]));
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult StoresGridViewPartialUpdate([ModelBinder(typeof(DevExpressEditorsBinder))] Store item)
        {
            var model = db.Stores;
            ViewData["stores"] = item;
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
            return PartialView("StoresGridViewPartial", db.Stores.Where(c => c.CompanyID == (string)Session["CompanyID"]));
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult StoresGridViewPartialDelete(string id)
        {
            var model = db.Stores;
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
            return PartialView("StoresGridViewPartial", db.Stores.Where(c => c.CompanyID == (string)Session["CompanyID"]));
        }
    }
}
