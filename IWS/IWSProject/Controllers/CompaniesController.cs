using System;
using System.Linq;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using IWSProject.Models;
using IWSProject.Content;
namespace IWSProject.Controllers
{
    [Authorize]
    public class CompaniesController : Controller
    {
        private IWSDataContext db = new IWSDataContext();

        // GET: Companies
        public ActionResult Index()
        {
            return View(db.Companies);
        }

        [ValidateInput(false)]
        public ActionResult CompaniesGridViewPartial()
        {
            return PartialView("CompaniesGridViewPartial", db.Companies);
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult CompaniesGridViewPartialAddNew([ModelBinder(typeof(DevExpressEditorsBinder))]Company item)
        {
            var model = db.Companies;

            ViewData["company"] = item;
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
            return PartialView("CompaniesGridViewPartial", model);
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult CompaniesGridViewPartialUpdate([ModelBinder(typeof(DevExpressEditorsBinder))]Company item)
        {
            var model = db.Companies;
            ViewData["company"] = item;
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
            return PartialView("CompaniesGridViewPartial", model);
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult CompaniesGridViewPartialDelete(string id)
        {
            var model = db.Companies;
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
            return PartialView("CompaniesGridViewPartial", model);
        }
    }
}
