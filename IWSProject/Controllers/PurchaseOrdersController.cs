﻿using System;
using System.Linq;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using IWSProject.Models;
using IWSProject.Content;
namespace IWSProject.Controllers
{
    [Authorize]
    public class PurchaseOrdersController : Controller
    {
        private IWSDataContext db = new IWSDataContext();
        // GET: purchaseorders
        public ActionResult Index()
        {
            return View(IWSLookUp.GetPurchaseOrder());
        }
        [ValidateInput(false)]
        public ActionResult MasterGridViewPartial()
        {
            return PartialView("MasterGridViewPartial", IWSLookUp.GetPurchaseOrder());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult MasterGridViewPartialAddNew([ModelBinder(typeof(DevExpressEditorsBinder))] PurchaseOrder item)
        {
            var model = db.PurchaseOrders;
            item.IsValidated = false;
            item.modelid = 101;
            item.CompanyId = (string)Session["CompanyID"];
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
            return PartialView("MasterGridViewPartial", IWSLookUp.GetPurchaseOrder());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult MasterGridViewPartialUpdate([ModelBinder(typeof(DevExpressEditorsBinder))] PurchaseOrder item)
        {
            var model = db.PurchaseOrders;
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
            return PartialView("MasterGridViewPartial", IWSLookUp.GetPurchaseOrder());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult MasterGridViewPartialDelete(Int32 id)
        {
            var model = db.PurchaseOrders;

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
            return PartialView("MasterGridViewPartial", IWSLookUp.GetPurchaseOrder());
        }
        [ValidateInput(false)]
        public ActionResult DetailGridViewPartial(int transid)
        {
            return PartialView("DetailGridViewPartial", db.LinePurchaseOrders.Where(p => p.transid == transid).ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult DetailGridViewPartialAddNew([ModelBinder(typeof(DevExpressEditorsBinder))] LinePurchaseOrder line, int transId)
        {
            var model = db.LinePurchaseOrders;

            line.modelid = 102;
            line.transid = transId;
            if(line.Currency==null)
                line.Currency = (string)Session["Currency"];
            ViewData["linePurchase"] = line;
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
            return PartialView("DetailGridViewPartial", model.Where(m => m.transid == transId));
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult DetailGridViewPartialUpdate([ModelBinder(typeof(DevExpressEditorsBinder))] LinePurchaseOrder line, int transId)
        {
            var model = db.LinePurchaseOrders;

            line.transid = transId;

            ViewData["linePurchase"] = line;
            if (ModelState.IsValid)
            {
                try
                {
                    var modelItem = model.FirstOrDefault(it => it.id == line.id);

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
            return PartialView("DetailGridViewPartial", db.LinePurchaseOrders.Where(p => p.transid == transId));
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult DetailGridViewPartialDelete(int Id, int transId)
        {

            var model = db.LinePurchaseOrders;

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
            return PartialView("DetailGridViewPartial", db.LinePurchaseOrders.Where(p => p.transid == transId));
        }

        #region Helper
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
            return Json(IWSLookUp.GetSalesPrice(selectedItemIndex));
        }
        public ActionResult Text(string selectedItemIndex)
        {
            return Json(IWSLookUp.GetText(selectedItemIndex));
        }

        #endregion
    }
}
