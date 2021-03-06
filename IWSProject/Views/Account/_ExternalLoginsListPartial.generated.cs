﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using System.Web.WebPages;
    using DevExpress.Utils;
    using DevExpress.Web;
    using DevExpress.Web.ASPxThemes;
    using DevExpress.Web.Mvc;
    using DevExpress.Web.Mvc.UI;
    
    #line 2 "..\..\Views\Account\_ExternalLoginsListPartial.cshtml"
    using Microsoft.Owin.Security;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Account/_ExternalLoginsListPartial.cshtml")]
    public partial class _Views_Account__ExternalLoginsListPartial_cshtml : System.Web.Mvc.WebViewPage<IWSProject.Models.ExternalLoginListViewModel>
    {
        public _Views_Account__ExternalLoginsListPartial_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<h4>Use another service to log in.</h4>\r\n");

            
            #line 5 "..\..\Views\Account\_ExternalLoginsListPartial.cshtml"
  
    var loginProviders = Context.GetOwinContext().Authentication.GetExternalAuthenticationTypes();
    if (loginProviders.Count() == 0) {

            
            #line default
            #line hidden
WriteLiteral("        <div>\r\n            <p>\r\n                There are no external authenticat" +
"ion services configured. See <a");

WriteLiteral(" href=\"http://go.microsoft.com/fwlink/?LinkId=403804\"");

WriteLiteral(">this article</a>\r\n                for details on setting up this ASP.NET applica" +
"tion to support logging in via external services.\r\n            </p>\r\n        </d" +
"iv>\r\n");

            
            #line 14 "..\..\Views\Account\_ExternalLoginsListPartial.cshtml"
    }
    else {
        using (Html.BeginForm("ExternalLogin", "Account", new { ReturnUrl = Model.ReturnUrl })) {
            
            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\Account\_ExternalLoginsListPartial.cshtml"
       Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\Account\_ExternalLoginsListPartial.cshtml"
                                    

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" id=\"socialLoginList\"");

WriteLiteral(">\r\n                <p>\r\n");

            
            #line 20 "..\..\Views\Account\_ExternalLoginsListPartial.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\Account\_ExternalLoginsListPartial.cshtml"
                     foreach (AuthenticationDescription p in loginProviders) {

            
            #line default
            #line hidden
WriteLiteral("                        <button");

WriteLiteral(" type=\"submit\"");

WriteAttribute("id", Tuple.Create(" id=\"", 945), Tuple.Create("\"", 971)
            
            #line 21 "..\..\Views\Account\_ExternalLoginsListPartial.cshtml"
, Tuple.Create(Tuple.Create("", 950), Tuple.Create<System.Object, System.Int32>(p.AuthenticationType
            
            #line default
            #line hidden
, 950), false)
);

WriteLiteral(" name=\"provider\"");

WriteAttribute("value", Tuple.Create(" value=\"", 988), Tuple.Create("\"", 1017)
            
            #line 21 "..\..\Views\Account\_ExternalLoginsListPartial.cshtml"
                 , Tuple.Create(Tuple.Create("", 996), Tuple.Create<System.Object, System.Int32>(p.AuthenticationType
            
            #line default
            #line hidden
, 996), false)
);

WriteAttribute("title", Tuple.Create(" title=\"", 1018), Tuple.Create("\"", 1062)
, Tuple.Create(Tuple.Create("", 1026), Tuple.Create("Log", 1026), true)
, Tuple.Create(Tuple.Create(" ", 1029), Tuple.Create("in", 1030), true)
, Tuple.Create(Tuple.Create(" ", 1032), Tuple.Create("using", 1033), true)
, Tuple.Create(Tuple.Create(" ", 1038), Tuple.Create("your", 1039), true)
            
            #line 21 "..\..\Views\Account\_ExternalLoginsListPartial.cshtml"
                                                               , Tuple.Create(Tuple.Create(" ", 1043), Tuple.Create<System.Object, System.Int32>(p.Caption
            
            #line default
            #line hidden
, 1044), false)
, Tuple.Create(Tuple.Create(" ", 1054), Tuple.Create("account", 1055), true)
);

WriteLiteral(">");

            
            #line 21 "..\..\Views\Account\_ExternalLoginsListPartial.cshtml"
                                                                                                                                                               Write(p.AuthenticationType);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n");

            
            #line 22 "..\..\Views\Account\_ExternalLoginsListPartial.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </p>\r\n            </div>\r\n");

            
            #line 25 "..\..\Views\Account\_ExternalLoginsListPartial.cshtml"
        }
    }

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
