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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Manage/VerifyPhoneNumber.cshtml")]
    public partial class _Views_Manage_VerifyPhoneNumber_cshtml : System.Web.Mvc.WebViewPage<IWSProject.Models.VerifyPhoneNumberViewModel>
    {
        public _Views_Manage_VerifyPhoneNumber_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n\r\n \r\n \r\n");

            
            #line 6 "..\..\Views\Manage\VerifyPhoneNumber.cshtml"
   
    ViewBag.Title = "Verify Phone Number"; 

            
            #line default
            #line hidden
WriteLiteral(" \r\n \r\n<div");

WriteLiteral(" class=\"accountHeader\"");

WriteLiteral(">\r\n    <h2>Enter verification code</h2>\r\n</div>\r\n");

            
            #line 13 "..\..\Views\Manage\VerifyPhoneNumber.cshtml"
 using (Html.BeginForm("VerifyPhoneNumber", "Manage")) {  
    
            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\Manage\VerifyPhoneNumber.cshtml"
Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\Manage\VerifyPhoneNumber.cshtml"
                             
 
    
            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Manage\VerifyPhoneNumber.cshtml"
Write(Html.HiddenFor(m => m.PhoneNumber));

            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Manage\VerifyPhoneNumber.cshtml"
                                        
    
            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\Manage\VerifyPhoneNumber.cshtml"
Write(Html.DevExpress().TextBoxFor(m => m.Code, s => {
        s.Properties.Caption = "Code";
        s.Properties.CaptionSettings.Position = EditorCaptionPosition.Top;
        s.ShowModelErrors = true;
        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithText;
    }).GetHtml());

            
            #line default
            #line hidden
WriteLiteral("    <br /> \r\n");

            
            #line 23 "..\..\Views\Manage\VerifyPhoneNumber.cshtml"
    
            
            #line default
            #line hidden
            
            #line 23 "..\..\Views\Manage\VerifyPhoneNumber.cshtml"
Write(Html.DevExpress().Button(s => {
        s.Name = s.Text = "Submit";
        s.UseSubmitBehavior = true;
    }).GetHtml());

            
            #line default
            #line hidden
            
            #line 26 "..\..\Views\Manage\VerifyPhoneNumber.cshtml"
                 
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
