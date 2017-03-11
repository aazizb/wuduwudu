using System;
using System.Linq;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using IWSProject.Models;
using IWSProject.Content;
namespace IWSProject.Controllers
{
    [Authorize]
    public class BankAccountsController : Controller
    {
        IWSDataContext db = new IWSDataContext();
        // GET: bankaccounts
        public ActionResult Index()
        {
            return View(db.BankAccounts.Where(c => c.CompanyID == (string)Session["CompanyID"]));
        }

        [ValidateInput(false)]
        public ActionResult BankAccountsGridViewPartial()
        {
            return PartialView("BankAccountsGridViewPartial", db.BankAccounts.Where(c => c.CompanyID == (string)Session["CompanyID"]));
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult BankAccountsGridViewPartialAddNew([ModelBinder(typeof(DevExpressEditorsBinder))] BankAccount item)
        {
            var model = db.BankAccounts;
            item.modelid = 12;
            item.CompanyID = (string)Session["CompanyID"];
            ViewData["bankAccount"] = item;
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
            return PartialView("BankAccountsGridViewPartial", db.BankAccounts.Where(c => c.CompanyID == (string)Session["CompanyID"]));
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult BankAccountsGridViewPartialUpdate([ModelBinder(typeof(DevExpressEditorsBinder))] BankAccount item)
        {
            var model = db.BankAccounts;
            ViewData["bankAccount"] = item;
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
            return PartialView("BankAccountsGridViewPartial", db.BankAccounts.Where(c => c.CompanyID == (string)Session["CompanyID"]));
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult BankAccountsGridViewPartialDelete(string id)
        {
            var model = db.BankAccounts;
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
            return PartialView("BankAccountsGridViewPartial", db.BankAccounts.Where(c => c.CompanyID == (string)Session["CompanyID"]));
        }
    }
}
