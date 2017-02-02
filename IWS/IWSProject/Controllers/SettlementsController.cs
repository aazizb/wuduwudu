using System;
using System.Linq;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using IWSProject.Models;
using IWSProject.Content;

namespace IWSProject.Controllers
{
    public class SettlementsController : Controller
    {
        IWSDataContext db = new IWSDataContext();
        // GET: CashInflow
        public ActionResult Index()
        {
            return View(db.Settlements);
        }
        [ValidateInput(false)]
        public ActionResult MasterGridViewPartial()
        {
            return PartialView("MasterGridViewPartial", db.Settlements);
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult MasterGridViewPartialAddNew([ModelBinder(typeof(DevExpressEditorsBinder))] Settlement item)
        {
            var model = db.Settlements;
            item.IsValidated = false;
            item.modelid = 1114;
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
            return PartialView("MasterGridViewPartial", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult MasterGridViewPartialUpdate([ModelBinder(typeof(DevExpressEditorsBinder))] Settlement  item)
        {
            var model = db.Settlements;

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
            var model = db.Settlements;

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
            return PartialView("DetailGridViewPartial", db.LineSettlements.Where(p => p.transid == transid).ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult DetailGridViewPartialAddNew([ModelBinder(typeof(DevExpressEditorsBinder))] LineSettlement line, int transId)
        {
            var model = db.LineSettlements;

            line.transid = transId;
            line.modelid = 1115;
            ViewData["lineCashInflow"] = line;
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
        public ActionResult DetailGridViewPartialUpdate([ModelBinder(typeof(DevExpressEditorsBinder))] LineSettlement linegood, int transId)
        {
            var model = db.LineSettlements;
            ViewData["lineCashInflow"] = linegood;
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
            return PartialView("DetailGridViewPartial", db.LineSettlements.Where(p => p.transid == transId).ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult DetailGridViewPartialDelete(int Id, int transId)
        {

            var model = db.LineSettlements;

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
            return PartialView("DetailGridViewPartial", db.LineSettlements.Where(p => p.transid == transId).ToList());
        }
    }
}