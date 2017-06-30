using System;
using System.Linq;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using IWSProject.Models;
using IWSProject.Content;
namespace IWSProject.Controllers
{
    [Authorize]
    public class CustomersController : Controller
    {
        IWSDataContext db = new IWSDataContext();

        // GET: Customers
        public ActionResult Index()
        {
            return View(db.Customers.Where(c => c.CompanyID == (string)Session["CompanyID"]));
        }

        [ValidateInput(false)]
        public ActionResult CustomersGridViewPartial()
        {
            return PartialView("CustomersGridViewPartial", db.Customers);
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult CustomersGridViewPartialAddNew([ModelBinder(typeof(DevExpressEditorsBinder))]Customer item)
        {
            var model = db.Customers;
            item.CompanyID = (string)Session["CompanyID"];
            ViewData["customer"] = item;
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
            return PartialView("CustomersGridViewPartial", db.Customers.Where(c => c.CompanyID == (string)Session["CompanyID"]));
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult CustomersGridViewPartialUpdate([ModelBinder(typeof(DevExpressEditorsBinder))]Customer item)
        {
            var model = db.Customers;
            ViewData["customer"] = item;
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
            return PartialView("CustomersGridViewPartial", db.Customers.Where(c => c.CompanyID == (string)Session["CompanyID"]));
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult CustomersGridViewPartialDelete(string id)
        {
            var model = db.Customers;
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
            return PartialView("CustomersGridViewPartial", db.Customers.Where(c => c.CompanyID == (string)Session["CompanyID"]));
        }
    }
}
