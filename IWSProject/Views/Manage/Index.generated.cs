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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Manage/Index.cshtml")]
    public partial class _Views_Manage_Index_cshtml : System.Web.Mvc.WebViewPage<IWSProject.Models.IndexViewModel>
    {
        public _Views_Manage_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Manage\Index.cshtml"
   
    ViewBag.Title = "Manage"; 

            
            #line default
            #line hidden
WriteLiteral(" \r\n \r\n<p>");

            
            #line 6 "..\..\Views\Manage\Index.cshtml"
Write(ViewBag.StatusMessage);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n<div");

WriteLiteral(" class=\"accountHeader\"");

WriteLiteral(">\r\n    <h2>Change your account settings</h2>\r\n</div>\r\n<ul>\r\n    <li>\r\n        Pas" +
"sword:\r\n \r\n        [\r\n");

            
            #line 15 "..\..\Views\Manage\Index.cshtml"
        
            
            #line default
            #line hidden
            
            #line 15 "..\..\Views\Manage\Index.cshtml"
         if (Model.HasPassword) { 
            
            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Manage\Index.cshtml"
       Write(Html.ActionLink("Change your password", "ChangePassword", "Account"));

            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Manage\Index.cshtml"
                                                                                  
        } else { 
            
            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\Manage\Index.cshtml"
       Write(Html.ActionLink("Create", "SetPassword"));

            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\Manage\Index.cshtml"
                                                      
        } 

            
            #line default
            #line hidden
WriteLiteral("        ]\r\n \r\n    </li>\r\n    <li>\r\n        External Logins: ");

            
            #line 24 "..\..\Views\Manage\Index.cshtml"
                    Write(Model.Logins.Count);

            
            #line default
            #line hidden
WriteLiteral(" \r\n \r\n        [");

            
            #line 26 "..\..\Views\Manage\Index.cshtml"
    Write(Html.ActionLink("Manage", "ManageLogins"));

            
            #line default
            #line hidden
WriteLiteral("]\r\n \r\n    </li>\r\n    ");

WriteLiteral(" \r\n    ");

WriteLiteral(" \r\n    <li>\r\n        Two-Factor Authentication:\r\n        There are no two-factor " +
"authentication providers configured. See <a");

WriteLiteral(" href=\"http://go.microsoft.com/fwlink/?LinkId=403804\"");

WriteLiteral(">this article</a>\r\n        for details on setting up this ASP.NET application to " +
"support two-factor authentication.\r\n \r\n        ");

WriteLiteral(" \r\n \r\n    </li>\r\n</ul>");

        }
    }
}
#pragma warning restore 1591