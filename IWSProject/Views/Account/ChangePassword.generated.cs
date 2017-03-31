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
    
    #line 2 "..\..\Views\Account\ChangePassword.cshtml"
    using IWSProject.Content;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Account/ChangePassword.cshtml")]
    public partial class _Views_Account_ChangePassword_cshtml : System.Web.Mvc.WebViewPage<IWSProject.Models.ChangePasswordModel>
    {
        public _Views_Account_ChangePassword_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("    ");

            
            #line 3 "..\..\Views\Account\ChangePassword.cshtml"
  
    Html.EnableClientValidation();
    Html.EnableUnobtrusiveJavaScript();

    Action<MVCxFormLayoutItem> TextBoxSettingsMethod = (item) =>
    {
        item.NestedExtension().TextBox(s =>
        {
            s.Properties.Password = s.Name.Contains("email") || s.Name.Contains("Password");
            s.Properties.ValidationSettings.ErrorTextPosition = ErrorTextPosition.Bottom;
            s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.Text;
            s.Properties.ValidationSettings.Display = Display.Dynamic;
            s.ShowModelErrors = true;
        });
    };

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 20 "..\..\Views\Account\ChangePassword.cshtml"
 using (Html.BeginForm())
{
    
            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\Account\ChangePassword.cshtml"
Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\Account\ChangePassword.cshtml"
                            
    
            
            #line default
            #line hidden
            
            #line 23 "..\..\Views\Account\ChangePassword.cshtml"
Write(Html.DevExpress().FormLayout(settings =>
{
    settings.Name = "formChangePassword";

    settings.Items.AddGroupItem(group =>
    {
        group.Caption = IWSLocalResource.CurrentPassword;
        group.GroupBoxDecoration = GroupBoxDecoration.HeadingLine;

        group.Items.Add(i => i.OldPassword, TextBoxSettingsMethod).Caption=IWSLocalResource.CurrentPassword;
    });

    settings.Items.AddGroupItem(group =>
    {
        group.Caption = IWSLocalResource.NewPassword;
        group.GroupBoxDecoration = GroupBoxDecoration.HeadingLine;
        group.Items.Add(i => i.NewPassword, TextBoxSettingsMethod).Caption=IWSLocalResource.NewPassword;
        group.Items.Add(i => i.ConfirmPassword, TextBoxSettingsMethod).Caption=IWSLocalResource.ConfirmPassword;
    });


    settings.Items.AddGroupItem(group =>
    {
        group.Caption = "  ";
        group.GroupBoxDecoration = GroupBoxDecoration.HeadingLine;
        group.Items.Add(i =>
        {
            i.Caption = " ";
            i.NestedExtension().Button(b =>
            {
                b.Name = "signUp";
                b.Text = IWSLocalResource.SignUp;
                b.UseSubmitBehavior = true;
                b.Width = Unit.Pixel(120);
            });
        });
    });

}).GetHtml());

            
            #line default
            #line hidden
            
            #line 61 "..\..\Views\Account\ChangePassword.cshtml"
            
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
