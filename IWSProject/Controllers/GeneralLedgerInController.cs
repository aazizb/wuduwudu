using System;
using System.Linq;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using IWSProject.Content;
using IWSProject.Models;

namespace IWSProject.Controllers
{
    [Authorize]
    public class GeneralLedgerInController : Controller
    {
        IWSDataContext db = new IWSDataContext();
        // GET: GeneralLedgers
        public ActionResult Index()
        {
            return View(IWSLookUp.GetGeneralLedger(IWSLookUp.Area.Selling.ToString()));
        }
        [ValidateInput(false)]
        public ActionResult MasterGridViewPartial()
        {
            return PartialView("MasterGridViewPartial", IWSLookUp.GetGeneralLedger(IWSLookUp.Area.Selling.ToString()));
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult MasterGridViewPartialAddNew([ModelBinder(typeof(DevExpressEditorsBinder))] GeneralLedger item)
        {
            var model = db.GeneralLedgers;
            item.IsValidated = false;
            item.modelid = 2000;
            item.CompanyId = (string)Session["CompanyID"];
            item.Area = IWSLookUp.Area.Selling.ToString();
            ViewData["item"] = item;
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
            return PartialView("MasterGridViewPartial", model.Where(a => a.Area == IWSLookUp.Area.Selling.ToString()).ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult MasterGridViewPartialUpdate([ModelBinder(typeof(DevExpressEditorsBinder))] GeneralLedger item)
        {
            var model = db.GeneralLedgers;

            ViewData["item"] = item;
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
            return PartialView("MasterGridViewPartial", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult MasterGridViewPartialDelete(Int32 id)
        {
            var model = db.GeneralLedgers;

            if (id >= 0)
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
            return PartialView("MasterGridViewPartial", model.ToList());
        }
        [ValidateInput(false)]
        public ActionResult DetailGridViewPartial(int transid)
        {
            return PartialView("DetailGridViewPartial", db.LineGeneralLedgers.Where(p => p.transid == transid).ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult DetailGridViewPartialAddNew([ModelBinder(typeof(DevExpressEditorsBinder))] LineGeneralLedger line, int transId)
        {
            var model = db.LineGeneralLedgers;

            line.modelid = 2001;
            line.transid = transId;
            if (line.Currency == null)
                line.Currency = (string)Session["Currency"];
            ViewData["lineGeneralLedger"] = line;
            if (ModelState.IsValid)
            {
                try
                {
                    model.InsertOnSubmit(line);
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
            return PartialView("DetailGridViewPartial", model.Where(p => p.transid == transId).ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult DetailGridViewPartialUpdate([ModelBinder(typeof(DevExpressEditorsBinder))] LineGeneralLedger linegood, int transId)
        {
            var model = db.LineGeneralLedgers;
            ViewData["lineGeneralLedger"] = linegood;
            if (ModelState.IsValid)
            {
                try
                {
                    var modelItem = model.FirstOrDefault(p => p.id == linegood.id);

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
            return PartialView("DetailGridViewPartial", db.LineGeneralLedgers.Where(p => p.transid == transId).ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult DetailGridViewPartialDelete(int Id, int transId)
        {

            var model = db.LineGeneralLedgers;

            if (Id >= 0)
            {
                try
                {
                    var item = model.FirstOrDefault(it => it.id == Id);

                    if (item != null)
                        model.DeleteOnSubmit(item);

                    db.SubmitChanges();
                }
                catch (Exception e)
                {
                    ViewData["GenericError"] = e.Message;
                }
            }
            return PartialView("DetailGridViewPartial", db.LineGeneralLedgers.Where(p => p.transid == transId).ToList());
        }

    }
}