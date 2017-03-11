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
    
    #line 1 "..\..\Views\PurchaseOrders\DetailGridViewPartial.cshtml"
    using IWSProject.Content;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\PurchaseOrders\DetailGridViewPartial.cshtml"
    using IWSProject.Models;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/PurchaseOrders/DetailGridViewPartial.cshtml")]
    public partial class _Views_PurchaseOrders_DetailGridViewPartial_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_PurchaseOrders_DetailGridViewPartial_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 4 "..\..\Views\PurchaseOrders\DetailGridViewPartial.cshtml"
  
    var grid = Html.DevExpress().GridView(settings =>
    {
        settings.Name = "DetailGridView";
        settings.Caption = IWSLocalResource.linepurchaseorder;
        settings.SettingsDetail.MasterGridName = "MasterGridViewPartial";
        settings.CallbackRouteValues = new { Controller = "PurchaseOrders", Action = "DetailGridViewPartial", transid = Session["transid"] };

        settings.SettingsEditing.AddNewRowRouteValues = new { Controller = "PurchaseOrders", Action = "DetailGridViewPartialAddNew", transid = Session["transid"] };
        settings.SettingsEditing.UpdateRowRouteValues = new { Controller = "PurchaseOrders", Action = "DetailGridViewPartialUpdate", transid = Session["transid"] };
        settings.SettingsEditing.DeleteRowRouteValues = new { Controller = "PurchaseOrders", Action = "DetailGridViewPartialDelete", transid = Session["transid"] };
        settings.SettingsEditing.Mode = GridViewEditingMode.EditFormAndDisplayRow;
        settings.SettingsBehavior.ConfirmDelete = true;
        settings.CommandColumn.Visible = true;settings.CommandColumn.Width = Unit.Pixel(120);
        settings.CommandColumn.ShowNewButtonInHeader = true;
        settings.CommandColumn.ShowDeleteButton = true;
        settings.CommandColumn.ShowEditButton = true;
        settings.SettingsCommandButton.NewButton.Image.IconID = IconID.ActionsAdditem16x16;
        settings.SettingsCommandButton.EditButton.Image.IconID = IconID.ActionsEdit16x16devav;
        settings.SettingsCommandButton.DeleteButton.Image.IconID = IconID.ActionsDeletelist16x16;
        settings.CommandButtonInitialize = (s, e) =>
        {
            var value = Session["IsValidated"];
            if (e.ButtonType == ColumnCommandButtonType.Edit || e.ButtonType == ColumnCommandButtonType.Delete
                                                    || e.ButtonType == ColumnCommandButtonType.New)
            {
                e.Enabled = false.Equals(value);
            }
        };

        //set default value
        settings.InitNewRow = (s, e) =>
        {
            e.NewValues["duedate"] = DateTime.Today.AddDays(14);
        };
        settings.KeyFieldName = "id";

        settings.Width = Unit.Percentage(100);
        settings.SettingsPager.PageSize = 24;
        settings.Settings.VerticalScrollBarMode = ScrollBarMode.Hidden;
        settings.Settings.VerticalScrollableHeight = 350;
        settings.ControlStyle.Paddings.Padding = Unit.Pixel(0);
        settings.ControlStyle.Border.BorderWidth = Unit.Pixel(0);
        settings.ControlStyle.BorderBottom.BorderWidth = Unit.Pixel(1);


        settings.SettingsPager.Visible = true;
        settings.Settings.ShowGroupPanel = true;
        settings.Settings.ShowFilterRow = true;
        settings.SettingsBehavior.AllowSelectByRowClick = true;

        settings.SettingsBehavior.AllowSelectByRowClick = true;
        settings.SettingsBehavior.EnableRowHotTrack = true;

        settings.Styles.RowHotTrack.Cursor = "pointer";
        settings.Styles.AlternatingRow.BackColor = System.Drawing.Color.Beige;

        settings.SettingsAdaptivity.AdaptivityMode = GridViewAdaptivityMode.Off;
        settings.SettingsAdaptivity.AdaptiveColumnPosition = GridViewAdaptiveColumnPosition.Right;
        settings.SettingsAdaptivity.AdaptiveDetailColumnCount = 1;
        settings.SettingsAdaptivity.AllowOnlyOneAdaptiveDetailExpanded = true;
        settings.SettingsAdaptivity.HideDataCellsAtWindowInnerWidth = 0;

        settings.Columns.Add("id").Caption = IWSLocalResource.id;

        settings.Columns.Add(column =>
        {
            column.FieldName = "item";
            column.Caption = IWSLocalResource.item;
            column.EditorProperties().ComboBox(combo =>
            {
                combo.TextField = "Name";
                combo.ValueField = "id";
                combo.ValueType = typeof(string);
                combo.DataSource = IWSLookUp.GetArticle();
                combo.Columns.Add("id").Caption = IWSLocalResource.id;
                combo.Columns.Add("name").Caption = IWSLocalResource.item;
                combo.TextFormatString = "{0}-{1}";
            });

        });

        settings.Columns.Add("unit").Caption = IWSLocalResource.unit;

        settings.Columns.Add(column =>
        {
            column.FieldName = "price";
            column.Caption = IWSLocalResource.price;
            column.EditorProperties().SpinEdit(p =>
            {
                p.DisplayFormatString = "c";
                p.DisplayFormatInEditMode = true;
                p.MinValue = 0;
                p.MaxValue = UInt32.MaxValue;
                p.SpinButtons.ShowLargeIncrementButtons = true;
                p.Width = Unit.Percentage(100);
            });
        });

        settings.Columns.Add(column =>
        {
            column.FieldName = "quantity";
            column.Caption = IWSLocalResource.quantity;
            column.EditorProperties().SpinEdit(p =>
            {
                p.DisplayFormatInEditMode = true;
                p.MinValue = 0;
                p.MaxValue = UInt32.MaxValue;
                p.SpinButtons.ShowLargeIncrementButtons = true;
                p.Width = Unit.Percentage(100);
            });
        });

        settings.Columns.Add(column =>
        {
            column.FieldName = "VatCode";
            column.Caption = IWSLocalResource.vatcode;
            column.EditorProperties().ComboBox(combo =>
            {
                combo.TextField = "Name";
                combo.ValueField = "id";
                combo.ValueType = typeof(string);
                combo.DataSource = IWSLookUp.GetVAT();
                combo.Columns.Add("id").Caption = IWSLocalResource.id;
                combo.Columns.Add("name").Caption = IWSLocalResource.vat;
                combo.TextFormatString = "{0}-{1}";
            });
        });

        settings.Columns.Add(column =>
        {
            column.FieldName = "duedate";
            column.Caption = IWSLocalResource.duedate;
            column.ColumnType = MVCxGridViewColumnType.DateEdit;
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

        settings.Columns.Add("text").Caption = IWSLocalResource.text;
        settings.Columns.Add(column =>
        {
            column.FieldName = "Total";
            column.Caption = IWSLocalResource.Total;
            column.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            column.PropertiesEdit.DisplayFormatString = "c";
        });

        settings.CustomUnboundColumnData = (sender, e) =>
        {
            if (e.Column.FieldName == "Total")
            {
                decimal price = Convert.ToDecimal(e.GetListSourceFieldValue("price"));
                decimal quantity = Convert.ToDecimal(e.GetListSourceFieldValue("quantity"));
                e.Value = price * quantity;
            }
        };
        settings.Settings.ShowFooter = true;
        settings.TotalSummary.Add(DevExpress.Data.SummaryItemType.Sum, "Total");
        #region Template
        settings.SetEditFormTemplateContent(templateContent =>
        {
            var editItem = ViewData["linePurchase"] != null ? ViewData["linePurchase"] : templateContent.DataItem;

            Html.DevExpress().FormLayout(formLayoutSettings =>
            {
                formLayoutSettings.Name = "DetailGridViewEdit";
                formLayoutSettings.Width = Unit.Percentage(100);
                formLayoutSettings.ColCount = 3;

                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "item";
                    i.Caption = IWSLocalResource.item;
                    i.NestedExtension().ComboBox(s =>
                    {
                        s.Properties.TextField = "name";
                        s.Properties.ValueField = "id";
                        s.Properties.ValueType = typeof(string);
                        s.Properties.DataSource = IWSLookUp.GetArticle();
                        s.Properties.Columns.Add("id").Caption = IWSLocalResource.id;
                        s.Properties.Columns.Add("name").Caption = IWSLocalResource.item;
                        s.Properties.TextFormatString = "{0}-{1}";
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.ShowModelErrors = true;
                        s.Width = Unit.Percentage(100);
                        s.Properties.ClientSideEvents.SelectedIndexChanged = "OnSelectedIndexChanged";
                    });
                });

                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "unit";
                    i.Caption = IWSLocalResource.unit;
                    i.NestedExtension().TextBox(s =>
                    {
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.ShowModelErrors = true;
                        s.Width = Unit.Percentage(100);
                    });
                });

                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "price";
                    i.Caption = IWSLocalResource.price;
                    i.NestedExtension().SpinEdit(s =>
                    {
                        s.Properties.DisplayFormatString = "C";
                        s.Properties.MinValue = 0;
                        s.Properties.MaxValue = UInt32.MaxValue;
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.Properties.SpinButtons.ShowLargeIncrementButtons = true;
                        s.Width = Unit.Percentage(100);
                    });
                });

                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "quantity";
                    i.Caption = IWSLocalResource.quantity;
                    i.NestedExtension().SpinEdit(s =>
                    {
                        s.Properties.MinValue = 0;
                        s.Properties.MaxValue = UInt32.MaxValue;
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.Properties.SpinButtons.ShowLargeIncrementButtons = true;
                        s.ShowModelErrors = true;
                        s.Width = Unit.Percentage(100);
                    });
                });

                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "VatCode";
                    i.Caption = IWSLocalResource.vat;
                    i.NestedExtension().ComboBox(s =>
                    {
                        s.Properties.TextField = "name";
                        s.Properties.ValueField = "id";
                        s.Properties.ValueType = typeof(string);
                        s.Properties.DataSource = IWSLookUp.GetVAT();
                        s.Properties.Columns.Add("id").Caption = IWSLocalResource.id;
                        s.Properties.Columns.Add("name").Caption = IWSLocalResource.vat;
                        s.Properties.TextFormatString = "{0}-{1}";
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.ShowModelErrors = true;
                        s.Width = Unit.Percentage(100);
                    });
                });

                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "duedate";
                    i.Caption = IWSLocalResource.duedate;
                    i.NestedExtensionType = FormLayoutNestedExtensionItemType.DateEdit;
                    i.NestedExtension().DateEdit(d =>
                    {
                        d.Properties.EditFormatString = "MM/dd/yyyy";
                        d.Properties.NullDisplayText = "MM/dd/yyyy";
                        d.Properties.EditFormat = EditFormat.Custom;
                        d.Properties.Width = Unit.Percentage(100);
                        d.Properties.DisplayFormatString = "yyyy-MM-dd";
                        d.Properties.DisplayFormatInEditMode = true;
                        d.Properties.AllowUserInput = true;
                        d.Properties.AllowMouseWheel = true;
                    });
                });

                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "text";
                    i.Caption = IWSLocalResource.text;
                    i.NestedExtension().Memo(s =>
                    {
                        s.ShowModelErrors = true;
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
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
                    btnSettings.ClientSideEvents.Click = "function(s, e){ DetailGridView.UpdateEdit(); }";
                }).Render();

                    Html.DevExpress().Button(
                btnSettings =>
                {
                    btnSettings.Name = "btnCancel";
                    btnSettings.Text = IWSLocalResource.btnCancel;
                    btnSettings.Style[HtmlTextWriterStyle.MarginLeft] = "5px";
                    btnSettings.Images.Image.IconID = IconID.ActionsCancel16x16;
                    btnSettings.ClientSideEvents.Click = "function(s, e){ DetailGridView.CancelEdit(); }";
                }).Render();
                    ViewContext.Writer.Write("</div>");
                });
            })
            .Bind(ViewData["linePurchase"] ?? templateContent.DataItem)
            .Render();
        });
        #endregion

        settings.DataBinding = (sender, e) =>
        {
            ((MVCxGridView)sender).ForceDataRowType(typeof(LinePurchaseOrder));
        };
    });

    if (ViewData["GenericError"] != null)
    {
        grid.SetEditErrorText((string)ViewData["GenericError"]);

    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 339 "..\..\Views\PurchaseOrders\DetailGridViewPartial.cshtml"
Write(grid.Bind(Model).GetHtml());

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
