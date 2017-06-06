using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace IWSProject
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            DevExpress.XtraReports.Web.WebDocumentViewer.Native.WebDocumentViewerBootstrapper.SessionState = System.Web.SessionState.SessionStateBehavior.Disabled;
            AreaRegistration.RegisterAllAreas();

            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            
            ModelBinders.Binders.DefaultBinder = new DevExpress.Web.Mvc.DevExpressEditorsBinder();

            DevExpress.Web.ASPxWebControl.CallbackError += Application_Error;
        }

        protected void Application_Error(object sender, EventArgs e) 
        {
            Exception exception = System.Web.HttpContext.Current.Server.GetLastError();
            //TODO: Handle Exception
            //Server.ClearError();
            //Response.Redirect("/Home/Error");
        }
        //how to specify culture & uiculture in Global.asax
        protected void Application_AcquireRequestState(object sender, EventArgs e)
        {
            if (Request.Cookies["Culture"] != null && !string.IsNullOrEmpty(Request.Cookies["Culture"].Value))
            {
                string culture = Request.Cookies["Culture"].Value;
                CultureInfo ci = new CultureInfo(culture);
                Thread.CurrentThread.CurrentUICulture = ci;
                Thread.CurrentThread.CurrentCulture = ci;
            }
        }
        //how to specify a theme in Global.asax
        protected void Application_PreRequestHandlerExecute(object sender, EventArgs e)
        {
            DevExpress.Web.Mvc.DevExpressHelper.Theme = "Office2010Blue";//"Aqua";// "PlasticBlue";//  "BlackGlass";// "RedWine";// "MulBerry";//"Glass";// "Material";// "Moderno";// "iOS";
        }
    }
}