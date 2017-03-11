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
    
    #line 1 "..\..\Views\Companies\CompaniesGridViewPartial.cshtml"
    using IWSProject.Content;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Companies\CompaniesGridViewPartial.cshtml"
    using IWSProject.Models;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Companies/CompaniesGridViewPartial.cshtml")]
    public partial class _Views_Companies_CompaniesGridViewPartial_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Companies_CompaniesGridViewPartial_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Companies\CompaniesGridViewPartial.cshtml"
  
    var grid = Html.DevExpress().GridView(settings =>
    {
        settings.Name = "CompaniesGridView";
        settings.Caption = IWSLocalResource.company;

        settings.CallbackRouteValues = new { Controller = "Companies", Action = "CompaniesGridViewPartial" };

        settings.SettingsEditing.AddNewRowRouteValues = new { Controller = "Companies", Action = "CompaniesGridViewPartialAddNew" };
        settings.SettingsEditing.UpdateRowRouteValues = new { Controller = "Companies", Action = "CompaniesGridViewPartialUpdate" };
        settings.SettingsEditing.DeleteRowRouteValues = new { Controller = "Companies", Action = "CompaniesGridViewPartialDelete" };
        settings.SettingsEditing.Mode = GridViewEditingMode.EditFormAndDisplayRow;

        settings.CommandColumn.Visible = true;
        settings.CommandColumn.Width = Unit.Pixel(120);
        settings.CommandColumn.ShowNewButtonInHeader = true;
        settings.CommandColumn.ShowDeleteButton = true;
        settings.CommandColumn.ShowEditButton = true;

        settings.KeyFieldName = "id";

        settings.SettingsBehavior.AllowSelectByRowClick = true;
        settings.SettingsBehavior.EnableRowHotTrack = true;

        settings.Styles.RowHotTrack.Cursor = "pointer";
        settings.Styles.AlternatingRow.BackColor = System.Drawing.Color.Beige;

        settings.SettingsCommandButton.NewButton.Image.IconID = IconID.ActionsAdditem16x16;
        settings.SettingsCommandButton.EditButton.Image.IconID = IconID.ActionsEdit16x16devav;
        settings.SettingsCommandButton.DeleteButton.Image.IconID = IconID.ActionsDeletelist16x16;

        settings.Settings.ShowFilterRow = true;
        settings.SettingsBehavior.ConfirmDelete = true;
        settings.SettingsBehavior.AllowSelectByRowClick = true;

        settings.Width = Unit.Percentage(80);
        settings.Height = Unit.Percentage(300);
        settings.Settings.VerticalScrollBarMode = ScrollBarMode.Hidden;
        settings.Settings.VerticalScrollableHeight = 350;
        settings.ControlStyle.Paddings.Padding = Unit.Pixel(10);
        settings.ControlStyle.Border.BorderWidth = Unit.Pixel(0);
        settings.ControlStyle.BorderBottom.BorderWidth = Unit.Pixel(1);

        settings.SettingsAdaptivity.AdaptivityMode = GridViewAdaptivityMode.Off;
        settings.SettingsAdaptivity.AdaptiveColumnPosition = GridViewAdaptiveColumnPosition.Right;
        settings.SettingsAdaptivity.AdaptiveDetailColumnCount = 1;
        settings.SettingsAdaptivity.AllowOnlyOneAdaptiveDetailExpanded = false;
        settings.SettingsAdaptivity.HideDataCellsAtWindowInnerWidth = 0;

        settings.SettingsPager.Visible = true;
        settings.SettingsPager.Position = PagerPosition.Bottom;
        settings.SettingsPager.FirstPageButton.Visible = true;
        settings.SettingsPager.LastPageButton.Visible = true;
        settings.SettingsPager.PageSizeItemSettings.Visible = true;
        settings.SettingsPager.PageSizeItemSettings.Items = new string[] { "24", "30", "36", "50" };
        settings.SettingsPager.PageSize = 24;

        settings.Columns.Add("id").Caption = IWSLocalResource.id;
        settings.Columns.Add("name").Caption = IWSLocalResource.name;
        settings.Columns.Add("street").Caption = IWSLocalResource.street;
        settings.Columns.Add("city").Caption = IWSLocalResource.city;
        settings.Columns.Add("state").Caption = IWSLocalResource.state;
        settings.Columns.Add("zip").Caption = IWSLocalResource.zip;
        settings.Columns.Add(column =>
        {
            column.FieldName = "bankaccountid";
            column.Caption = IWSLocalResource.bankaccountid;
            column.EditorProperties().ComboBox(combo =>
            {
                combo.TextField = "Name";
                combo.ValueField = "id";
                combo.ValueType = typeof(string);
                combo.DataSource = IWSLookUp.GetAccounts();
                combo.Columns.Add("id").Caption = IWSLocalResource.id;
                combo.Columns.Add("name").Caption = IWSLocalResource.item;
                combo.TextFormatString = "{0}-{1}";
            });
        });
        settings.Columns.Add(column =>
        {
            column.FieldName = "purchasingclearingaccountid";
            column.Caption = IWSLocalResource.purchasingclearingaccountid;
            column.EditorProperties().ComboBox(combo =>
            {
                combo.TextField = "Name";
                combo.ValueField = "id";
                combo.ValueType = typeof(string);
                combo.DataSource = IWSLookUp.GetAccounts();
                combo.Columns.Add("id").Caption = IWSLocalResource.id;
                combo.Columns.Add("name").Caption = IWSLocalResource.item;
                combo.TextFormatString = "{0}-{1}";
            });
        });
        settings.Columns.Add(column =>
        {
            column.FieldName = "salesclearingaccountid";
            column.Caption = IWSLocalResource.salesclearingaccountid;
            column.EditorProperties().ComboBox(combo =>
            {
                combo.TextField = "Name";
                combo.ValueField = "id";
                combo.ValueType = typeof(string);
                combo.DataSource = IWSLookUp.GetAccounts();
                combo.Columns.Add("id").Caption = IWSLocalResource.id;
                combo.Columns.Add("name").Caption = IWSLocalResource.item;
                combo.TextFormatString = "{0}-{1}";
            });
        });
        settings.Columns.Add(column =>
        {
            column.FieldName = "paymentclearingaccountid";
            column.Caption = IWSLocalResource.paymentclearingaccountid;
            column.EditorProperties().ComboBox(combo =>
            {
                combo.TextField = "Name";
                combo.ValueField = "id";
                combo.ValueType = typeof(string);
                combo.DataSource = IWSLookUp.GetAccounts();
                combo.Columns.Add("id").Caption = IWSLocalResource.id;
                combo.Columns.Add("name").Caption = IWSLocalResource.item;
                combo.TextFormatString = "{0}-{1}";
            });
        });
        settings.Columns.Add(column =>
        {
            column.FieldName = "settlementclearingaccountid";
            column.Caption = IWSLocalResource.settlementclearingaccountid;
            column.EditorProperties().ComboBox(combo =>
            {
                combo.TextField = "Name";
                combo.ValueField = "id";
                combo.ValueType = typeof(string);
                combo.DataSource = IWSLookUp.GetAccounts();
                combo.Columns.Add("id").Caption = IWSLocalResource.id;
                combo.Columns.Add("name").Caption = IWSLocalResource.item;
                combo.TextFormatString = "{0}-{1}";
            });
        });

        settings.Columns.Add("periode").Caption = IWSLocalResource.periode;
        settings.Columns.Add("nextperiode").Caption = IWSLocalResource.nextperiode;

        settings.Columns.Add(column =>
        {
            column.FieldName = "taxcode";
            column.Caption = IWSLocalResource.taxcode;
            column.EditorProperties().ComboBox(combo =>
            {
                combo.TextField = "Name";
                combo.ValueField = "id";
                combo.ValueType = typeof(string);
                combo.DataSource = IWSLookUp.GetAccounts();
                combo.Columns.Add("id").Caption = IWSLocalResource.id;
                combo.Columns.Add("name").Caption = IWSLocalResource.item;
                combo.TextFormatString = "{0}-{1}";
            });
        });
        settings.Columns.Add(column =>
        {
            column.FieldName = "vatcode";
            column.Caption = IWSLocalResource.vatcode;
            column.EditorProperties().ComboBox(combo =>
            {
                combo.TextField = "Name";
                combo.ValueField = "id";
                combo.ValueType = typeof(string);
                combo.DataSource = IWSLookUp.GetAccounts();
                combo.Columns.Add("id").Caption = IWSLocalResource.id;
                combo.Columns.Add("name").Caption = IWSLocalResource.item;
                combo.TextFormatString = "{0}-{1}";
            });
        });
        #region Template Edit
        settings.SetEditFormTemplateContent(templateContent =>
        {
            var editItem = ViewData["company"] != null ? ViewData["company"] : templateContent.DataItem;

            Html.DevExpress().FormLayout(formLayoutSettings =>
            {
                formLayoutSettings.Name = "CompaniesViewEdit";
                formLayoutSettings.Width = Unit.Percentage(80);
                formLayoutSettings.ColCount = 2;
                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "id";
                    i.Caption = IWSLocalResource.id;
                    i.NestedExtension().TextBox(s =>
                    {
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.ShowModelErrors = true;
                        s.Width = Unit.Percentage(80);
                    });
                });
                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "name";
                    i.Caption = IWSLocalResource.name;
                    i.NestedExtension().TextBox(s =>
                    {
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.ShowModelErrors = true;
                        s.Width = Unit.Percentage(80);
                    });
                });
                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "modelid";
                    i.Visible = false;
                    i.Caption = IWSLocalResource.modelid;
                    i.NestedExtension().TextBox(s =>
                    {
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.ShowModelErrors = true;
                        s.Width = Unit.Percentage(80);
                    });
                });
                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "street";
                    i.Caption = IWSLocalResource.street;
                    i.NestedExtension().TextBox(s =>
                    {
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.ShowModelErrors = true;
                        s.Width = Unit.Percentage(80);
                    });
                });
                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "city";
                    i.Caption = IWSLocalResource.city;
                    i.NestedExtension().TextBox(s =>
                    {
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.ShowModelErrors = true;
                        s.Width = Unit.Percentage(80);
                    });
                });
                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "state";
                    i.Caption = IWSLocalResource.state;
                    i.NestedExtension().TextBox(s =>
                    {
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.ShowModelErrors = true;
                        s.Width = Unit.Percentage(80);
                    });
                });
                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "zip";
                    i.Caption = IWSLocalResource.zip;
                    i.NestedExtension().TextBox(s =>
                    {
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.ShowModelErrors = true;
                        s.Width = Unit.Percentage(80);
                    });
                });
                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "bankaccountid";
                    i.Caption = IWSLocalResource.bankaccountid;
                    i.NestedExtension().ComboBox(s =>
                    {
                        s.Properties.TextField = "name";
                        s.Properties.ValueField = "id";
                        s.Properties.ValueType = typeof(string);
                        s.Properties.DataSource = IWSLookUp.GetAccounts();
                        s.Properties.Columns.Add("id").Caption = IWSLocalResource.id;
                        s.Properties.Columns.Add("name").Caption = IWSLocalResource.item;
                        s.Properties.TextFormatString = "{0}-{1}";
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.ShowModelErrors = true;
                        s.Width = Unit.Percentage(80);
                    });
                });
                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "purchasingclearingaccountid";
                    i.Caption = IWSLocalResource.purchasingclearingaccountid;
                    i.NestedExtension().ComboBox(s =>
                    {
                        s.Properties.TextField = "name";
                        s.Properties.ValueField = "id";
                        s.Properties.ValueType = typeof(string);
                        s.Properties.DataSource = IWSLookUp.GetAccounts();
                        s.Properties.Columns.Add("id").Caption = IWSLocalResource.id;
                        s.Properties.Columns.Add("name").Caption = IWSLocalResource.item;
                        s.Properties.TextFormatString = "{0}-{1}";
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.ShowModelErrors = true;
                        s.Width = Unit.Percentage(80);
                    });
                });
                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "salesclearingaccountid";
                    i.Caption = IWSLocalResource.salesclearingaccountid;
                    i.NestedExtension().ComboBox(s =>
                    {
                        s.Properties.TextField = "name";
                        s.Properties.ValueField = "id";
                        s.Properties.ValueType = typeof(string);
                        s.Properties.DataSource = IWSLookUp.GetAccounts();
                        s.Properties.Columns.Add("id").Caption = IWSLocalResource.id;
                        s.Properties.Columns.Add("name").Caption = IWSLocalResource.item;
                        s.Properties.TextFormatString = "{0}-{1}";
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.ShowModelErrors = true;
                        s.Width = Unit.Percentage(80);
                    });
                });
                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "paymentclearingaccountid";
                    i.Caption = IWSLocalResource.paymentclearingaccountid;
                    i.NestedExtension().ComboBox(s =>
                    {
                        s.Properties.TextField = "name";
                        s.Properties.ValueField = "id";
                        s.Properties.ValueType = typeof(string);
                        s.Properties.DataSource = IWSLookUp.GetAccounts();
                        s.Properties.Columns.Add("id").Caption = IWSLocalResource.id;
                        s.Properties.Columns.Add("name").Caption = IWSLocalResource.item;
                        s.Properties.TextFormatString = "{0}-{1}";
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.ShowModelErrors = true;
                        s.Width = Unit.Percentage(80);
                    });
                });
                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "settlementclearingaccountid";
                    i.Caption = IWSLocalResource.settlementclearingaccountid;
                    i.NestedExtension().ComboBox(s =>
                    {
                        s.Properties.TextField = "name";
                        s.Properties.ValueField = "id";
                        s.Properties.ValueType = typeof(string);
                        s.Properties.DataSource = IWSLookUp.GetAccounts();
                        s.Properties.Columns.Add("id").Caption = IWSLocalResource.id;
                        s.Properties.Columns.Add("name").Caption = IWSLocalResource.item;
                        s.Properties.TextFormatString = "{0}-{1}";
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.ShowModelErrors = true;
                        s.Width = Unit.Percentage(80);
                    });
                });
                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "periode";
                    i.Caption = IWSLocalResource.periode;
                    i.NestedExtension().TextBox(s =>
                    {
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.ShowModelErrors = true;
                        s.Width = Unit.Percentage(80);
                    });
                });
                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "nextperiode";
                    i.Caption = IWSLocalResource.nextperiode;
                    i.NestedExtension().TextBox(s =>
                    {
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.ShowModelErrors = true;
                        s.Width = Unit.Percentage(80);
                    });
                });
                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "taxcode";
                    i.Caption = IWSLocalResource.taxcode;
                    i.NestedExtension().ComboBox(s =>
                    {
                        s.Properties.TextField = "name";
                        s.Properties.ValueField = "id";
                        s.Properties.ValueType = typeof(string);
                        s.Properties.DataSource = IWSLookUp.GetAccounts();
                        s.Properties.Columns.Add("id").Caption = IWSLocalResource.id;
                        s.Properties.Columns.Add("name").Caption = IWSLocalResource.item;
                        s.Properties.TextFormatString = "{0}-{1}";
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.ShowModelErrors = true;
                        s.Width = Unit.Percentage(80);
                    });
                });
                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "vatcode";
                    i.Caption = IWSLocalResource.vatcode;
                    i.NestedExtension().ComboBox(s =>
                    {
                        s.Properties.TextField = "name";
                        s.Properties.ValueField = "id";
                        s.Properties.ValueType = typeof(string);
                        s.Properties.DataSource = IWSLookUp.GetAccounts();
                        s.Properties.Columns.Add("id").Caption = IWSLocalResource.id;
                        s.Properties.Columns.Add("name").Caption = IWSLocalResource.item;
                        s.Properties.TextFormatString = "{0}-{1}";
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.ShowModelErrors = true;
                        s.Width = Unit.Percentage(80);
                    });
                });
                formLayoutSettings.Items.AddEmptyItem();
                formLayoutSettings.Items.Add(i =>
                {
                    i.ShowCaption = DefaultBoolean.False;
                }).SetNestedContent(() =>
                {
                    ViewContext.Writer.Write("<div style='float:right'>");

                    Html.DevExpress().Button(
                btnSettings =>
                {
                    btnSettings.Name = "btnUpdate";
                    btnSettings.Text = IWSLocalResource.btnUpdate;
                    btnSettings.Style[HtmlTextWriterStyle.MarginRight] = "5px";
                    btnSettings.Images.Image.IconID = IconID.ActionsUp216x16;
                    btnSettings.ClientSideEvents.Click = "function(s, e){ CompaniesGridView.UpdateEdit(); }";
                }).Render();

                    Html.DevExpress().Button(
                btnSettings =>
                {
                    btnSettings.Name = "btnCancel";
                    btnSettings.Text = IWSLocalResource.btnCancel;
                    btnSettings.Style[HtmlTextWriterStyle.MarginLeft] = "5px";
                    btnSettings.Images.Image.IconID = IconID.ActionsCancel16x16;
                    btnSettings.ClientSideEvents.Click = "function(s, e){ CompaniesGridView.CancelEdit(); }";
                }).Render();
                    ViewContext.Writer.Write("</div>");
                });
            })
            .Bind(ViewData["company"] ?? templateContent.DataItem)
            .Render();
        });
        #endregion

        settings.DataBinding = (sender, e) =>
        {
            ((MVCxGridView)sender).ForceDataRowType(typeof(Store));
        };
    });
    if (ViewData["GenericError"] != null)
    {
        grid.SetEditErrorText((string)ViewData["GenericError"]);
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 456 "..\..\Views\Companies\CompaniesGridViewPartial.cshtml"
Write(grid.Bind(Model).GetHtml());

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
