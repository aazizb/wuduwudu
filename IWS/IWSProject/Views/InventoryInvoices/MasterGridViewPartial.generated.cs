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
    
    #line 1 "..\..\Views\InventoryInvoices\MasterGridViewPartial.cshtml"
    using IWSProject.Content;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\InventoryInvoices\MasterGridViewPartial.cshtml"
    using IWSProject.Models;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/InventoryInvoices/MasterGridViewPartial.cshtml")]
    public partial class _Views_InventoryInvoices_MasterGridViewPartial_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_InventoryInvoices_MasterGridViewPartial_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\InventoryInvoices\MasterGridViewPartial.cshtml"
  
    var grid = Html.DevExpress().GridView(settings =>
    {
        settings.Name = "InventoryInvoice";
        settings.Caption = IWSLocalResource.InventoryInvoice;

        settings.CallbackRouteValues = new { Controller = "InventoryInvoices", Action = "MasterGridViewPartial" };

        settings.SettingsEditing.AddNewRowRouteValues = new { Controller = "InventoryInvoices", Action = "MasterGridViewPartialAddNew" };
        settings.SettingsEditing.UpdateRowRouteValues = new { Controller = "InventoryInvoices", Action = "MasterGridViewPartialUpdate" };
        settings.SettingsEditing.DeleteRowRouteValues = new { Controller = "InventoryInvoices", Action = "MasterGridViewPartialDelete" };
        settings.SettingsEditing.Mode = GridViewEditingMode.EditFormAndDisplayRow;

        settings.CommandColumn.Visible = true;settings.CommandColumn.Width = Unit.Pixel(120);
        settings.CommandColumn.ShowNewButtonInHeader = true;
        settings.CommandColumn.ShowDeleteButton = true;
        settings.CommandColumn.ShowEditButton = true;
        settings.SettingsCommandButton.NewButton.Image.IconID = IconID.ActionsAdditem16x16;
        settings.SettingsCommandButton.EditButton.Image.IconID = IconID.ActionsEdit16x16devav;
        settings.SettingsCommandButton.DeleteButton.Image.IconID = IconID.ActionsDeletelist16x16;
        //conditionally disable command buttons
        settings.CommandButtonInitialize = (s, e) =>
        {
            //get gridview IsValidated column value
            var value = (s as MVCxGridView).GetRowValues(e.VisibleIndex, "IsValidated");
            if (e.ButtonType == ColumnCommandButtonType.Edit || e.ButtonType == ColumnCommandButtonType.Delete)
            {
                e.Enabled = false.Equals(value);
            }
        };
        settings.InitNewRow = (s, e) =>
        {
            e.NewValues["ItemDate"] = DateTime.Today.AddDays(14);
            e.NewValues["oid"] = 0;
        };
        settings.KeyFieldName = "id";

        settings.Settings.ShowFilterRow = true;
        settings.SettingsBehavior.ConfirmDelete = true;
        settings.SettingsBehavior.AllowSelectByRowClick = true;

        settings.Width = Unit.Percentage(100);
        settings.Height = Unit.Percentage(300);
        settings.Settings.VerticalScrollBarMode = ScrollBarMode.Hidden;
        settings.Settings.VerticalScrollableHeight = 350;
        settings.ControlStyle.Paddings.Padding = Unit.Pixel(10);
        settings.ControlStyle.Border.BorderWidth = Unit.Pixel(0);
        settings.ControlStyle.BorderBottom.BorderWidth = Unit.Pixel(1);

        settings.SettingsAdaptivity.AdaptivityMode = GridViewAdaptivityMode.HideDataCellsWindowLimit;
        settings.SettingsAdaptivity.AdaptiveColumnPosition = GridViewAdaptiveColumnPosition.Right;
        settings.SettingsAdaptivity.AdaptiveDetailColumnCount = 1;
        settings.SettingsAdaptivity.AllowOnlyOneAdaptiveDetailExpanded = false;
        settings.SettingsAdaptivity.HideDataCellsAtWindowInnerWidth = 0;

        settings.SettingsBehavior.AllowSelectByRowClick = true;
        settings.SettingsBehavior.EnableRowHotTrack = true;

        settings.Styles.RowHotTrack.Cursor = "pointer";
        settings.Styles.AlternatingRow.BackColor = System.Drawing.Color.Beige;

        settings.SettingsPager.Visible = true;
        settings.SettingsPager.Position = PagerPosition.Bottom;
        settings.SettingsPager.FirstPageButton.Visible = true;
        settings.SettingsPager.LastPageButton.Visible = true;
        settings.SettingsPager.PageSizeItemSettings.Visible = true;
        settings.SettingsPager.PageSizeItemSettings.Items = new string[] { "24", "30", "36", "50" };
        settings.SettingsPager.PageSize = 24;

        settings.SettingsDetail.AllowOnlyOneMasterRowExpanded = true;
        settings.SettingsDetail.ShowDetailRow = true;

        settings.Columns.Add(column =>
        {
            column.FieldName = "id";
            column.Caption = IWSLocalResource.id;
            column.Width = Unit.Pixel(60);
        });
        settings.Columns.Add(column =>
        {
            column.FieldName = "oid";
            column.Caption = IWSLocalResource.oid;
            column.Width = Unit.Pixel(60);
        });
        settings.Columns.Add(column =>
        {
            column.FieldName = "modelid";
            column.Caption = IWSLocalResource.modelid;
            column.Visible = false;
        });
        settings.Columns.Add(column =>
        {
            column.FieldName = "store";
            column.Caption = IWSLocalResource.store;
            column.EditorProperties().ComboBox(combo =>
            {
                combo.TextField = "Name";
                combo.ValueField = "id";
                combo.ValueType = typeof(string);
                combo.DataSource = IWSLookUp.GetStore();
                combo.Columns.Add("id").Caption = IWSLocalResource.id;
                combo.Columns.Add("name").Caption = IWSLocalResource.store;
                combo.TextFormatString = "{0}-{1}";
            });
        });
        settings.Columns.Add(column =>
        {
            column.FieldName = "account";
            column.Caption = IWSLocalResource.supplier;

            column.EditorProperties().ComboBox(combo =>
            {
                combo.TextField = "Name";
                combo.ValueField = "id";
                combo.ValueType = typeof(string);
                combo.DataSource = IWSLookUp.GetSuppliers();
                combo.Columns.Add("id").Caption = IWSLocalResource.id;
                combo.Columns.Add("name").Caption = IWSLocalResource.supplier;
                combo.TextFormatString = "{0}-{1}";
            });
        });
        settings.Columns.Add(column =>
        {
            column.FieldName = "CompanyId";
            column.Caption = IWSLocalResource.company;

            column.EditorProperties().ComboBox(combo =>
            {
                combo.TextField = "Name";
                combo.ValueField = "id";
                combo.ValueType = typeof(string);
                combo.DataSource = IWSLookUp.GetCompanies();
                combo.Columns.Add("id").Caption = IWSLocalResource.id;
                combo.Columns.Add("name").Caption = IWSLocalResource.supplier;
                combo.TextFormatString = "{0}-{1}";
            });
        });
        settings.Columns.Add(column =>
        {
            column.FieldName = "ItemDate";
            column.Caption = IWSLocalResource.duedate;
            column.ColumnType = MVCxGridViewColumnType.DateEdit;
            column.Width = Unit.Pixel(85);
            column.EditorProperties().DateEdit(d =>
            {
                d.EditFormatString = "MM/dd/yyyy";
                d.NullDisplayText = "MM/dd/yyyy";
                d.EditFormat = EditFormat.Custom;
                d.Width = Unit.Percentage(100);
                d.DisplayFormatString = "yyyy-MM-dd";
                d.DisplayFormatInEditMode = true;
                d.AllowUserInput = true;
                d.AllowMouseWheel = true;

            });
        });
        settings.Columns.Add(column =>
        {
            column.FieldName = "text";
            column.Caption = IWSLocalResource.text;
        });
        #region Template
        settings.SetEditFormTemplateContent(c =>
        {

            Html.DevExpress().FormLayout(formLayoutSettings =>
            {
                formLayoutSettings.Name = "InventoryInvoiceEdit";

                formLayoutSettings.Width = Unit.Percentage(100);
                formLayoutSettings.ColCount = 2;
                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "oid";
                    i.Caption = IWSLocalResource.oid;
                });
                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "store";
                    i.Caption = IWSLocalResource.store;
                    i.NestedExtension().ComboBox(s =>
                    {
                        s.Properties.TextField = "Name";
                        s.Properties.ValueField = "id";
                        s.Properties.ValueType = typeof(string);
                        s.Properties.DataSource = IWSLookUp.GetStore();
                        s.Properties.Columns.Add("id").Caption = IWSLocalResource.id;
                        s.Properties.Columns.Add("Name").Caption = IWSLocalResource.name;
                        s.Properties.TextFormatString = "{0}-{1}";
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.ShowModelErrors = true;
                        s.Width = Unit.Percentage(100);
                    });
                });
                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "account";
                    i.Caption = IWSLocalResource.supplier;
                    i.NestedExtension().ComboBox(s =>
                    {
                        s.Properties.TextField = "Name";
                        s.Properties.ValueField = "id";
                        s.Properties.ValueType = typeof(string);
                        s.Properties.DataSource = IWSLookUp.GetSuppliers();
                        s.Properties.Columns.Add("id").Caption = IWSLocalResource.id;
                        s.Properties.Columns.Add("Name").Caption = IWSLocalResource.name;
                        s.Properties.TextFormatString = "{0}-{1}";
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.ShowModelErrors = true;
                        s.Width = Unit.Percentage(100);
                    });
                });
                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "CompanyId";
                    i.Caption = IWSLocalResource.company;
                    i.NestedExtension().ComboBox(s =>
                    {
                        s.Properties.TextField = "Name";
                        s.Properties.ValueField = "id";
                        s.Properties.ValueType = typeof(string);
                        s.Properties.DataSource = IWSLookUp.GetCompanies();
                        s.Properties.Columns.Add("id").Caption = IWSLocalResource.id;
                        s.Properties.Columns.Add("Name").Caption = IWSLocalResource.name;
                        s.Properties.TextFormatString = "{0}-{1}";
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.ShowModelErrors = true;
                        s.Width = Unit.Percentage(100);
                    });
                });
                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "ItemDate";
                    i.Caption = IWSLocalResource.duedate;
                    i.NestedExtensionType = FormLayoutNestedExtensionItemType.DateEdit;
                    i.NestedExtension().DateEdit(s =>
                    {
                        s.Properties.UseMaskBehavior = true;
                        s.Properties.EditFormat = EditFormat.Date;
                        s.Properties.EditFormatString = "d";
                        s.Properties.Width = Unit.Percentage(100);
                        s.Properties.AllowUserInput = true;
                        s.Properties.AllowMouseWheel = true;
                    });
                });
                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "text";
                    i.Caption = IWSLocalResource.text;
                    i.NestedExtension().TextBox(s =>
                    {
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.ShowModelErrors = true;
                        s.Width = Unit.Percentage(100);
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
                    btnSettings.ClientSideEvents.Click = "function(s, e){ InventoryInvoice.UpdateEdit(); }";
                }).Render();

                    Html.DevExpress().Button(
                btnSettings =>
                {
                    btnSettings.Name = "btnCancel";
                    btnSettings.Text = IWSLocalResource.btnCancel;
                    btnSettings.Style[HtmlTextWriterStyle.MarginLeft] = "5px";
                    btnSettings.Images.Image.IconID = IconID.ActionsCancel16x16;
                    btnSettings.ClientSideEvents.Click = "function(s, e){ InventoryInvoice.CancelEdit(); }";
                }).Render();
                    ViewContext.Writer.Write("</div>");
                });
            })
            .Bind(ViewData["item"] ?? c.DataItem)
            .Render();
        });
        #endregion

        settings.SetDetailRowTemplateContent(c =>
        {
            Session["transid"] = DataBinder.Eval(c.DataItem, "ID");
            Session["IsValidated"] = DataBinder.Eval(c.DataItem, "IsValidated");
            Html.RenderAction("DetailGridViewPartial", new { transid = Session["transid"], IsValidated = Session["IsValidated"] });
        });
    });

    if (ViewData["GenericError"] != null)
    {
        grid.SetEditErrorText((string)ViewData["GenericError"]);
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 307 "..\..\Views\InventoryInvoices\MasterGridViewPartial.cshtml"
Write(grid.Bind(Model).GetHtml());

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
