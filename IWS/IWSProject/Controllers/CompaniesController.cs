using System;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using IWSProject.Content;
using IWSProject.Models;

namespace IWSProject.Controllers
{

    [Authorize]
    public class CompaniesController : Controller
    {
        private IWSDataContext db = new IWSDataContext();

        // GET: Companies
        public ActionResult Index()
        {
            return View(db.Companies);
        }
        [ValidateInput(false)]
        public ActionResult SetLogo()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SetLogo(SetLogoViewModel logo)
        {
            if (ModelState.IsValid)
            {
                byte[] imageData = null;
                if (Request.Files.Count > 0)
                {
                    HttpPostedFileBase poImgFile = Request.Files["Logo"];

                    using (var binary = new BinaryReader(poImgFile.InputStream))
                    {
                        imageData = binary.ReadBytes(poImgFile.ContentLength);
                        logo.Logo = imageData;
                    }
                }
                var logoImage = new SetLogoViewModel
                {
                    CompanyID = logo.CompanyID,
                    Logo = logo.Logo
                };
            }
            return View();
        }
        
        [ValidateInput(false)]
        public ActionResult CompaniesGridViewPartial()
        {
            return PartialView("CompaniesGridViewPartial", db.Companies);
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult CompaniesGridViewPartialAddNew([ModelBinder(typeof(DevExpressEditorsBinder))]Company item)
        {
            var model = db.Companies;
            item.modelid = 10;
            //item.CompanyID = (string)Session["CompanyID"];
            ViewData["company"] = item;
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
            return PartialView("CompaniesGridViewPartial", model);
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult CompaniesGridViewPartialUpdate([ModelBinder(typeof(DevExpressEditorsBinder))]Company item)
        {
            var model = db.Companies;
            ViewData["company"] = item;
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
            return PartialView("CompaniesGridViewPartial", model);
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult CompaniesGridViewPartialDelete(string id)
        {
            var model = db.Companies;
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
            return PartialView("CompaniesGridViewPartial", model);
        }
    }
}
