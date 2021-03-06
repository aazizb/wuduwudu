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
    
    #line 1 "..\..\Views\Balance\AccountBalancePartialView.cshtml"
    using IWSProject.Content;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Balance/AccountBalancePartialView.cshtml")]
    public partial class _Views_Balance_AccountBalancePartialView_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Balance_AccountBalancePartialView_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 3 "..\..\Views\Balance\AccountBalancePartialView.cshtml"
Write(Html.DevExpress().GridView(settings =>
{
    settings.Name = "AccountBlanacePartialView";
    settings.Caption = IWSLocalResource.AccountBalance;

    settings.CallbackRouteValues = new { Controller = "Balance", Action = "AccountBalancePartialView" };

    settings.KeyFieldName = "AccountID";



    settings.SettingsBehavior.AllowSelectByRowClick = true;
    settings.SettingsBehavior.EnableRowHotTrack = true;

    settings.Styles.RowHotTrack.Cursor = "pointer";
    settings.Styles.AlternatingRow.BackColor = System.Drawing.Color.Beige;

    settings.Settings.ShowFilterRow = true;
    settings.Settings.ShowFilterRowMenu = true;
    settings.SettingsBehavior.AllowFocusedRow = true;

    settings.Width = Unit.Percentage(100);
    settings.SettingsPager.PageSize = 24;
    
    
    settings.ControlStyle.Paddings.Padding = Unit.Pixel(0);
    settings.ControlStyle.Border.BorderWidth = Unit.Pixel(0);
    settings.ControlStyle.BorderBottom.BorderWidth = Unit.Pixel(1);

    settings.Columns.Add(column =>
    {
        column.FieldName = "AccountID";
        column.Caption = IWSLocalResource.account;
    });
    settings.Columns.Add("Periode").Caption = IWSLocalResource.periode;
    settings.Columns.Add(column =>
    {
        column.FieldName = "Debit";
        column.Caption = IWSLocalResource.debit;

        column.EditorProperties().TextBox(textBox =>
        {
            textBox.DisplayFormatString = "N";
        });
    });
    settings.Columns.Add(column =>
    {
        column.FieldName = "Credit";
        column.Caption = IWSLocalResource.credit;

        column.EditorProperties().TextBox(textBox =>
        {
            textBox.DisplayFormatString = "N";
        });
    });
    settings.Columns.Add(column =>
    {
        column.FieldName = "Currency";
        column.Caption = IWSLocalResource.Currency;
    });

}).Bind(Model).GetHtml());

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
