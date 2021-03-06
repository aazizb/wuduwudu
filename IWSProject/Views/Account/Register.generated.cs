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
    
    #line 1 "..\..\Views\Account\Register.cshtml"
    using IWSProject.Content;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Account\Register.cshtml"
    using IWSProject.Models;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Account/Register.cshtml")]
    public partial class _Views_Account_Register_cshtml : System.Web.Mvc.WebViewPage<RegisterModel>
    {
        public _Views_Account_Register_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"accountHeader\"");

WriteLiteral(">\r\n    <h2>");

            
            #line 6 "..\..\Views\Account\Register.cshtml"
   Write(IWSLocalResource.NewUser);

            
            #line default
            #line hidden
WriteLiteral(" </h2>\r\n</div>\r\n\r\n");

            
            #line 9 "..\..\Views\Account\Register.cshtml"
  
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

            
            #line 26 "..\..\Views\Account\Register.cshtml"
 using (Html.BeginForm())
{
    
            
            #line default
            #line hidden
            
            #line 28 "..\..\Views\Account\Register.cshtml"
Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 28 "..\..\Views\Account\Register.cshtml"
                            
    
            
            #line default
            #line hidden
            
            #line 29 "..\..\Views\Account\Register.cshtml"
Write(Html.DevExpress().FormLayout(settings =>
{
    settings.Name = "formRegister";


    settings.Items.AddGroupItem(group =>
    {
        group.Caption = IWSLocalResource.UserInformation;
        group.GroupBoxDecoration = GroupBoxDecoration.HeadingLine;

        group.Items.Add(i => i.FirstName, TextBoxSettingsMethod).Caption=IWSLocalResource.FirstName;
        group.Items.Add(i => i.LastName, TextBoxSettingsMethod).Caption=IWSLocalResource.LastName;
        group.Items.Add(combo =>
        {
            combo.Name = "Company";
            combo.Caption = IWSLocalResource.company;
            combo.NestedExtension().ComboBox(s =>
            {
                s.Properties.TextField = "Name";
                s.Properties.ValueField = "Id";
                s.Properties.ValueType = typeof(string);
                s.Properties.DataSource = IWSLookUp.GetCompanies(); 
                s.Properties.Columns.Add("id").Caption = IWSLocalResource.id;
                s.Properties.Columns.Add("name").Caption = IWSLocalResource.company;
            });
        });

    });

    settings.Items.AddGroupItem(group =>
    {
        group.Caption = IWSLocalResource.UserCredential;
        group.GroupBoxDecoration = GroupBoxDecoration.HeadingLine;

        group.Items.Add(i => i.UserName, TextBoxSettingsMethod).Caption=IWSLocalResource.User;
        group.Items.Add(i => i.Email, TextBoxSettingsMethod).Caption=IWSLocalResource.Email;
        group.Items.Add(i => i.Password, TextBoxSettingsMethod).Caption=IWSLocalResource.Password;
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
            
            #line 87 "..\..\Views\Account\Register.cshtml"
            
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
