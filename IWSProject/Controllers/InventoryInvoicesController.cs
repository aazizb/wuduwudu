﻿using System;
using System.Linq;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using IWSProject.Models;
using IWSProject.Content;
namespace IWSProject.Controllers
{
    [Authorize]
    public class InventoryInvoicesController : Controller
    {
        IWSDataContext db = new IWSDataContext();
        // GET: InventoryInvoices
        public ActionResult Index()
        {
            return View(IWSLookUp.GetInventoryInvoice());
        }
        [ValidateInput(false)]
        public ActionResult MasterGridViewPartial()
        {
            return PartialView("MasterGridViewPartial", IWSLookUp.GetInventoryInvoice());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult MasterGridViewPartialAddNew([ModelBinder(typeof(DevExpressEditorsBinder))] InventoryInvoice item)
        {
            var model = db.InventoryInvoices;
            item.IsValidated = false;
            item.modelid = 110;
            item.CompanyId = (string)Session["CompanyID"];
            item.oid = item.oid != 0 ? item.oid : 0;
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
            return PartialView("MasterGridViewPartial", IWSLookUp.GetInventoryInvoice());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult MasterGridViewPartialUpdate([ModelBinder(typeof(DevExpressEditorsBinder))] InventoryInvoice item)
        {
            var model = db.InventoryInvoices;

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
            return PartialView("MasterGridViewPartial", IWSLookUp.GetInventoryInvoice());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult MasterGridViewPartialDelete(int id)
        {
            var model = db.InventoryInvoices;

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
            return PartialView("MasterGridViewPartial", IWSLookUp.GetInventoryInvoice());
        }
        [ValidateInput(false)]
        public ActionResult DetailGridViewPartial(int transid)
        {
            return PartialView("DetailGridViewPartial", db.LineInventoryInvoices.Where(p => p.transid == transid).ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult DetailGridViewPartialAddNew([ModelBinder(typeof(DevExpressEditorsBinder))] LineInventoryInvoice line, int transId)
        {
            var model = db.LineInventoryInvoices;
            line.modelid = 111;
            line.transid = transId;
            if (line.Currency == null)
                line.Currency = (string)Session["Currency"];
            ViewData["lineInventory"] = line;
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
        public ActionResult DetailGridViewPartialUpdate([ModelBinder(typeof(DevExpressEditorsBinder))] LineInventoryInvoice line, int transId)
        {
            var model = db.LineInventoryInvoices;
            ViewData["lineInventory"] = line;
            if (ModelState.IsValid)
            {
                try
                {
                    var modelItem = model.FirstOrDefault(p => p.id == line.id);

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
            return PartialView("DetailGridViewPartial", db.LineInventoryInvoices.Where(p => p.transid == transId).ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult DetailGridViewPartialDelete(int Id, int transId)
        {

            var model = db.LineInventoryInvoices;

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
            return PartialView("DetailGridViewPartial", db.LineInventoryInvoices.Where(p => p.transid == transId).ToList());
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
        public ActionResult VATCode(string selectedItemIndex)
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