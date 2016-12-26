using System;
using System.Linq;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using IWSProject.Models;
using IWSProject.Content;
namespace IWSProject.Controllers
{
    [Authorize]
    public class AccountsController : Controller
    {
        // GET: Accounts
        public ActionResult Index()
        {
            return View(db.Accounts);
        }

        IWSDataContext db = new IWSDataContext();

        [ValidateInput(false)]
        public ActionResult AccountsGridViewPartial()
        {
            return PartialView("AccountsGridViewPartial", db.Accounts);
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult AccountsGridViewPartialAddNew([ModelBinder(typeof(DevExpressEditorsBinder))] Account item)
        {
            var model = db.Accounts;
            ViewData["accounts"] = item;
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
            return PartialView("AccountsGridViewPartial", model);
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult AccountsGridViewPartialUpdate([ModelBinder(typeof(DevExpressEditorsBinder))]Account item)
        {
            var model = db.Accounts;
            ViewData["accounts"] = item;
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
            return PartialView("AccountsGridViewPartial", model);
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult AccountsGridViewPartialDelete(string id)
        {
            var model = db.Accounts;
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
            return PartialView("AccountsGridViewPartial", model);
        }
    }
}
