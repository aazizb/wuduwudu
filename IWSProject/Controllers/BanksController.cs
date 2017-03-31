using System;
using System.Linq;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using IWSProject.Models;
using IWSProject.Content;
namespace IWSProject.Controllers
{
    [Authorize]
    public class BanksController : Controller
    {
        private IWSDataContext db = new IWSDataContext();
        // GET: Banks
        public ActionResult Index()
        {
            return View(db.Banks.Where(c => c.CompanyID == (string)Session["CompanyID"]));
        }

        [ValidateInput(false)]
        public ActionResult BanksGridViewPartial()
        {
            return PartialView("BanksGridViewPartial", db.Banks.Where(c => c.CompanyID == (string)Session["CompanyID"]));
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult BanksGridViewPartialAddNew([ModelBinder(typeof(DevExpressEditorsBinder))] Bank item)
        {
            var model = db.Banks;
            ViewData["bank"] = item;
            item.CompanyID = (string)Session["CompanyID"];
            item.modelid = 11;
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
            return PartialView("BanksGridViewPartial", db.Banks.Where(c => c.CompanyID == (string)Session["CompanyID"]));
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult BanksGridViewPartialUpdate([ModelBinder(typeof(DevExpressEditorsBinder))] BankAccount item)
        {
            var model = db.Banks;
            ViewData["bank"] = item;
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
            return PartialView("BanksGridViewPartial", db.Banks.Where(c => c.CompanyID == (string)Session["CompanyID"]));
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult BanksGridViewPartialDelete(string id)
        {
            var model = db.Banks;
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
            return PartialView("BanksGridViewPartial", db.Banks.Where(c => c.CompanyID == (string)Session["CompanyID"]));
        }
    }
}
