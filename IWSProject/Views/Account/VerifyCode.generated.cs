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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Account/VerifyCode.cshtml")]
    public partial class _Views_Account_VerifyCode_cshtml : System.Web.Mvc.WebViewPage<IWSProject.Models.VerifyCodeViewModel>
    {
        public _Views_Account_VerifyCode_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 3 "..\..\Views\Account\VerifyCode.cshtml"
  
    ViewBag.Title = "Verify Code";

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"accountHeader\"");

WriteLiteral(">\r\n    <h2>");

            
            #line 7 "..\..\Views\Account\VerifyCode.cshtml"
   Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n</div>\r\n");

            
            #line 9 "..\..\Views\Account\VerifyCode.cshtml"
 using (Html.BeginForm("VerifyCode", "Account", new { ReturnUrl = Model.ReturnUrl }, FormMethod.Post)) {
    
            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\Account\VerifyCode.cshtml"
Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\Account\VerifyCode.cshtml"
                            
    
            
            #line default
            #line hidden
            
            #line 11 "..\..\Views\Account\VerifyCode.cshtml"
Write(Html.Hidden("provider", @Model.Provider));

            
            #line default
            #line hidden
            
            #line 11 "..\..\Views\Account\VerifyCode.cshtml"
                                             
    
            
            #line default
            #line hidden
            
            #line 12 "..\..\Views\Account\VerifyCode.cshtml"
Write(Html.Hidden("rememberMe", @Model.RememberMe));

            
            #line default
            #line hidden
            
            #line 12 "..\..\Views\Account\VerifyCode.cshtml"
                                                 

            
            #line default
            #line hidden
WriteLiteral("    <h4>Enter verification code</h4>\r\n");

            
            #line 14 "..\..\Views\Account\VerifyCode.cshtml"
    
            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\Account\VerifyCode.cshtml"
Write(Html.DevExpress().TextBoxFor(m => m.Code, s=>{
        s.Properties.Caption = "Code";
        s.Properties.CaptionSettings.Position = EditorCaptionPosition.Top;
        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithText;
        s.ShowModelErrors = true;
    }).GetHtml());

            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\Account\VerifyCode.cshtml"
                
    
            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\Account\VerifyCode.cshtml"
Write(Html.DevExpress().CheckBoxFor(m => m.RememberBrowser, s=>s.Text = "Remember me").GetHtml());

            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\Account\VerifyCode.cshtml"
                                                                                               

            
            #line default
            #line hidden
WriteLiteral("    <br />\r\n");

            
            #line 22 "..\..\Views\Account\VerifyCode.cshtml"
    
            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\Account\VerifyCode.cshtml"
Write(Html.DevExpress().Button(s => {
        s.Name = s.Text = "Submit";
        s.UseSubmitBehavior = true;
    }).GetHtml());

            
            #line default
            #line hidden
            
            #line 25 "..\..\Views\Account\VerifyCode.cshtml"
                
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
