using System;
using System.Linq;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using IWSProject.Models;
using IWSProject.Content;
namespace IWSProject.Controllers
{
    [Authorize]
    public class VatsController : Controller
    {
        private IWSDataContext db = new IWSDataContext();

        // GET: Vats
        public ActionResult Index()
        {
            return View(db.Vats);
        }

        [ValidateInput(false)]
        public ActionResult VatsGridViewPartial()
        {
            return PartialView("VatsGridViewPartial", db.Vats);
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult VatsGridViewPartialAddNew([ModelBinder(typeof(DevExpressEditorsBinder))] Vat item)
        {
            var model = db.Vats;

            ViewData["vats"] = item;
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
            return PartialView("VatsGridViewPartial", model);
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult VatsGridViewPartialUpdate([ModelBinder(typeof(DevExpressEditorsBinder))] Vat item)
        {
            var model = db.Vats;

            ViewData["vats"] = item;
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
            return PartialView("VatsGridViewPartial", model);
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult VatsGridViewPartialDelete(string id)
        {
            var model = db.Vats;
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
            return PartialView("VatsGridViewPartial", model);
        }
    }
}
