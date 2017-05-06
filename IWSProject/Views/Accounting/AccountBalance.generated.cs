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
    
    #line 1 "..\..\Views\Accounting\AccountBalance.cshtml"
    using IWSProject.Content;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Accounting\AccountBalance.cshtml"
    using IWSProject.Models;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Accounting/AccountBalance.cshtml")]
    public partial class _Views_Accounting_AccountBalance_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Accounting_AccountBalance_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Accounting\AccountBalance.cshtml"
Write(Html.DevExpress().GridView(
    settings =>
    {
        settings.Name = "AccountBalanceGridView";
        settings.CallbackRouteValues = new { Controller = "Accounting", Action = "AccountBalanceView" };

        settings.SettingsResizing.ColumnResizeMode = ColumnResizeMode.NextColumn;
        settings.SettingsResizing.Visualization = ResizingMode.Postponed;

        settings.KeyFieldName = "AccountID";
        settings.Width = System.Web.UI.WebControls.Unit.Percentage(100);
        settings.SettingsPager.PageSize = 32;
        settings.Settings.VerticalScrollBarMode = ScrollBarMode.Visible;
        settings.Settings.VerticalScrollableHeight = 350;
        settings.ControlStyle.Paddings.Padding = System.Web.UI.WebControls.Unit.Pixel(0);
        settings.ControlStyle.Border.BorderWidth = System.Web.UI.WebControls.Unit.Pixel(0);
        settings.ControlStyle.BorderBottom.BorderWidth = System.Web.UI.WebControls.Unit.Pixel(1);
        settings.Columns.Add(column =>
        {
            column.FieldName = "AccountID";
            column.Caption = IWSLocalResource.account;
            column.EditorProperties().ComboBox(combo =>
            {
                combo.TextField = "Name";
                combo.ValueField = "id";
                combo.ValueType = typeof(string);
                combo.DataSource = IWSLookUp.GetAccounts();
                combo.Columns.Add("id").Caption = IWSLocalResource.id;
                combo.Columns.Add("name").Caption = IWSLocalResource.account;
                combo.TextFormatString = "{0}-{1}";
            });
        });
        settings.Columns.Add("Periode").Caption = IWSLocalResource.periode;
        settings.Columns.Add("Debit").Caption = IWSLocalResource.debit;
        settings.Columns.Add("Credit").Caption = IWSLocalResource.credit;

    }).Bind(Model).GetHtml());

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591