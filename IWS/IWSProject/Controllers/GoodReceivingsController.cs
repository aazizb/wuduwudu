﻿using System;
using System.Linq;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using IWSProject.Models;
using IWSProject.Content;
namespace IWSProject.Controllers
{
    [Authorize]
    public class GoodReceivingsController : Controller
    {
        IWSDataContext db = new IWSDataContext();
        // GET: goodreceivings
        public ActionResult Index()
        {
            return View(db.GoodReceivings.ToList());
        }
        [ValidateInput(false)]
        public ActionResult MasterGridViewPartial()
        {
            return PartialView("MasterGridViewPartial", db.GoodReceivings.ToList().OrderByDescending(o => o.id));
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult MasterGridViewPartialAddNew([ModelBinder(typeof(DevExpressEditorsBinder))] Models.GoodReceiving item)
        {
            var model = db.GoodReceivings;
            item.IsValidated = false;
            item.modelid = 104;
            item.oid = 0;
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
        public ActionResult MasterGridViewPartialUpdate([ModelBinder(typeof(DevExpressEditorsBinder))] Models.GoodReceiving item)
        {
            var model = db.GoodReceivings;

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
            var model = db.GoodReceivings;

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
            return PartialView("DetailGridViewPartial", db.LineGoodReceivings.Where(p => p.transid == transid).ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult DetailGridViewPartialAddNew([ModelBinder(typeof(DevExpressEditorsBinder))] LineGoodReceiving lineGood, int transId)
        {
            var model = db.LineGoodReceivings;

            lineGood.transid = transId;
            lineGood.modelid = 105;
            ViewData["lineGood"] = lineGood;

            if (ModelState.IsValid)
            {
                try
                {
                    model.InsertOnSubmit(lineGood);
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
            return PartialView("DetailGridViewPartial", model.Where(p=>p.transid==transId).ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult DetailGridViewPartialUpdate([ModelBinder(typeof(DevExpressEditorsBinder))] LineGoodReceiving linegood, int transId)
        {
            var model = db.LineGoodReceivings;
            ViewData["lineGood"] = linegood;
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
            return PartialView("DetailGridViewPartial", db.LineGoodReceivings.Where(p => p.transid == transId).ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult DetailGridViewPartialDelete(int Id, int transId)
        {

            var model = db.LineGoodReceivings;

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
            return PartialView("DetailGridViewPartial", db.LineGoodReceivings.Where(p => p.transid == transId).ToList());
        }
        public ActionResult PackUnit(string selectedItemIndex)
        {
            return Json(IWSLookUp.GetPackUnit(selectedItemIndex));
        }
        public ActionResult QttyUnit(string selectedItemIndex)
        {
            return Json(IWSLookUp.GetQttyUnit(selectedItemIndex));
        }
        public ActionResult VatCode(string selectedItemIndex)
        {
            return Json(IWSLookUp.GetVatCode(selectedItemIndex));
        }
        public ActionResult Price(string selectedItemIndex)
        {
            return Json(IWSLookUp.GetPrice(selectedItemIndex));
        }
        public ActionResult Text(string selectedItemIndex)
        {
            return Json(IWSLookUp.GetText(selectedItemIndex));
        }
    }
}