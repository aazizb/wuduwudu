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
    using DevExpress.XtraReports;
    using DevExpress.XtraReports.UI;
    using DevExpress.XtraReports.Web;
    using DevExpress.XtraReports.Web.DocumentViewer;
    
    #line 1 "..\..\Views\Articles\ArticlesGridViewPartial.cshtml"
    using IWSProject.Content;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Articles\ArticlesGridViewPartial.cshtml"
    using IWSProject.Models;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Articles/ArticlesGridViewPartial.cshtml")]
    public partial class _Views_Articles_ArticlesGridViewPartial_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Articles_ArticlesGridViewPartial_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Articles\ArticlesGridViewPartial.cshtml"
  
    var grid = Html.DevExpress().GridView(settings =>
    {
        settings.Name = "ArticlesGridView";
        settings.Caption = IWSLocalResource.articles;

        settings.CallbackRouteValues = new { Controller = "articles", Action = "ArticlesGridViewPartial" };

        settings.SettingsEditing.AddNewRowRouteValues = new { Controller = "articles", Action = "ArticlesGridViewPartialAddNew" };
        settings.SettingsEditing.UpdateRowRouteValues = new { Controller = "articles", Action = "ArticlesGridViewPartialUpdate" };
        settings.SettingsEditing.DeleteRowRouteValues = new { Controller = "articles", Action = "ArticlesGridViewPartialDelete" };

        settings.SettingsEditing.Mode = GridViewEditingMode.EditFormAndDisplayRow;
        settings.SettingsResizing.Visualization = ResizingMode.Postponed;

        settings.CommandColumn.Visible = true;
        settings.CommandColumn.Width = Unit.Pixel(80);

        settings.SettingsBehavior.EnableRowHotTrack = true;
        settings.Styles.RowHotTrack.Cursor = "pointer";
        settings.Styles.AlternatingRow.BackColor = System.Drawing.Color.Beige;

        settings.SettingsBehavior.AllowSelectByRowClick = true;
        settings.ClientSideEvents.RowDblClick = "function(sender, e) { sender.StartEditRow(e.visibleIndex); }";

        settings.CommandColumn.ShowNewButtonInHeader = true;
        settings.SettingsCommandButton.NewButton.Image.IconID = IconID.ActionsAdditem16x16;
        settings.SettingsCommandButton.NewButton.Image.ToolTip = IWSLocalResource.btnAddNew;
        settings.SettingsCommandButton.NewButton.Text = " ";

        settings.SettingsCommandButton.EditButton.Image.IconID = IconID.ActionsEditname16x16;
        settings.SettingsCommandButton.EditButton.Image.ToolTip = IWSLocalResource.btnEdit;
        settings.SettingsCommandButton.EditButton.Text = " ";
        settings.CommandColumn.ShowEditButton = true;

        settings.SettingsCommandButton.DeleteButton.Image.IconID = IconID.ActionsDeletelist16x16;
        settings.SettingsCommandButton.DeleteButton.Image.ToolTip = IWSLocalResource.btnDelete;
        settings.SettingsCommandButton.DeleteButton.Text = " ";
        settings.CommandColumn.ShowDeleteButton = true;

        settings.KeyFieldName = "id";

        settings.SettingsBehavior.AllowSelectByRowClick = true;
        settings.SettingsBehavior.EnableRowHotTrack = true;

        settings.Styles.RowHotTrack.Cursor = "pointer";
        settings.Styles.AlternatingRow.BackColor = System.Drawing.Color.Beige;

        settings.Settings.ShowFilterRow = true;
        settings.Settings.ShowFilterRowMenu = true;

        settings.SettingsBehavior.ConfirmDelete = true;
        settings.SettingsBehavior.AllowSelectByRowClick = true;

        settings.Width = Unit.Percentage(100);
        settings.Height = Unit.Percentage(100);
        
        
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
        
        settings.SettingsPager.PageSize = 24;

        settings.Columns.Add("id").Caption = IWSLocalResource.id;
        settings.Columns.Add(column =>
        {
            column.FieldName = "name";
            column.Caption = IWSLocalResource.item;
            column.EditorProperties().TextBox(textBox =>
            {
                textBox.Width = Unit.Percentage(200);
            });
        });

        settings.Columns.Add(column =>
        {
            column.FieldName = "IsService";
            column.Caption = IWSLocalResource.IsService;
            column.EditorProperties().CheckBox(checkBox =>
            {
            });
        });
        settings.Columns.Add("description").Caption = IWSLocalResource.description;
        settings.Columns.Add(column =>
        {
            column.FieldName = "price";
            column.Caption = IWSLocalResource.price;
            column.EditorProperties().SpinEdit(p =>
            {
                p.DisplayFormatString = "N";
                p.DisplayFormatInEditMode = true;
                p.MinValue = 0;
                p.MaxValue = UInt32.MaxValue;
                p.SpinButtons.ShowLargeIncrementButtons = true;
                p.Width = Unit.Percentage(100);
            });
        });
        settings.Columns.Add(column =>
        {
            column.FieldName = "avgprice";
            column.Caption = IWSLocalResource.AveragePrice;
            column.EditorProperties().SpinEdit(p =>
            {
                p.DisplayFormatString = "N";
                p.DisplayFormatInEditMode = true;
                p.MinValue = 0;
                p.MaxValue = UInt32.MaxValue;
                p.SpinButtons.ShowLargeIncrementButtons = true;
                p.Width = Unit.Percentage(100);
            });
        });
        settings.Columns.Add(column =>
        {
            column.FieldName = "salesprice";
            column.Caption = IWSLocalResource.salesprice;
            column.EditorProperties().SpinEdit(p =>
            {
                p.DisplayFormatString = "N";
                p.DisplayFormatInEditMode = true;
                p.MinValue = 0;
                p.MaxValue = UInt32.MaxValue;
                p.SpinButtons.ShowLargeIncrementButtons = true;
                p.Width = Unit.Percentage(100);
            });
        });
        settings.Columns.Add(column =>
        {
            column.FieldName = "Currency";
            column.Visible = false;
            column.Caption = IWSLocalResource.Currency;
            column.EditorProperties().ComboBox(combo =>
            {
                combo.TextField = "Name";
                combo.ValueField = "id";
                combo.ValueType = typeof(string);
                combo.DataSource = IWSLookUp.GetCurrency();
                combo.Columns.Add("id").Caption = IWSLocalResource.id;
                combo.Columns.Add("name").Caption = IWSLocalResource.Currency;
                combo.TextFormatString = "{1}";
            });
        });
        settings.Columns.Add("qttyunit").Caption=IWSLocalResource.qttyunit;
        settings.Columns.Add("packunit").Caption=IWSLocalResource.packunit;
        //settings.Columns.Add("groupid").Caption=IWSLocalResource.groupid;
        settings.Columns.Add(column =>
        {
            column.FieldName = "VatCode";
            column.Caption = IWSLocalResource.vat;
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

        #region Template Edit

        settings.SetEditFormTemplateContent(templateContent =>
        {

            Html.DevExpress().FormLayout(formLayoutSettings =>
            {
                formLayoutSettings.Name = "ArticleViewEdit";
                formLayoutSettings.Width = Unit.Percentage(100);
                formLayoutSettings.ColCount = 3;
                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "id";
                    i.Caption = IWSLocalResource.id;
                    i.NestedExtension().TextBox(s =>
                    {
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.ShowModelErrors = true;
                        s.Width = Unit.Percentage(100);
                    });
                });

                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "name";
                    i.Caption = IWSLocalResource.item;
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
                        s.Properties.DisplayFormatString = "N";
                        s.Properties.MinValue = 0;
                        s.Properties.MaxValue = UInt32.MaxValue;
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.Properties.SpinButtons.ShowLargeIncrementButtons = true;
                        s.Width = Unit.Percentage(92);
                    });
                });

                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "avgprice";
                    i.Caption = IWSLocalResource.AveragePrice;
                    i.NestedExtension().SpinEdit(s =>
                    {
                        s.Properties.DisplayFormatString = "N";
                        s.Properties.MinValue = 0;
                        s.Properties.MaxValue = UInt32.MaxValue;
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.Properties.SpinButtons.ShowLargeIncrementButtons = true;
                        s.Width = Unit.Percentage(92);
                    });
                });

                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "salesprice";
                    i.Caption = IWSLocalResource.salesprice;
                    i.NestedExtension().SpinEdit(s =>
                    {
                        s.Properties.DisplayFormatString = "N";
                        s.Properties.MinValue = 0;
                        s.Properties.MaxValue = UInt32.MaxValue;
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.Properties.SpinButtons.ShowLargeIncrementButtons = true;
                        s.Width = Unit.Percentage(92);
                    });
                });
                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "Currency";
                    i.Caption = IWSLocalResource.Currency;
                    i.Visible = false;
                    i.NestedExtension().ComboBox(s =>
                    {
                        s.Properties.TextField = "name";
                        s.Properties.ValueField = "id";
                        s.Properties.ValueType = typeof(string);
                        s.Properties.DataSource = IWSLookUp.GetCurrency();
                        s.Properties.Columns.Add("id").Caption = IWSLocalResource.id;
                        s.Properties.Columns.Add("name").Caption = IWSLocalResource.Currency;
                        s.Properties.TextFormatString = "{1}";
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.ShowModelErrors = true;
                        s.Width = Unit.Percentage(100);
                    });
                });
                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "qttyunit";
                    i.Caption = IWSLocalResource.qttyunit;
                    i.NestedExtension().TextBox(s =>
                    {
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.ShowModelErrors = true;
                        s.Width = Unit.Percentage(100);
                    });
                });
                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "packunit";
                    i.Caption = IWSLocalResource.packunit;
                    i.NestedExtension().TextBox(s =>
                    {
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.ShowModelErrors = true;
                        s.Width = Unit.Percentage(100);
                    });
                });
                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "groupid";
                    i.Visible = false;
                    i.Caption = IWSLocalResource.groupid;
                    i.NestedExtension().TextBox(s =>
                    {
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
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
                    i.FieldName = "description";
                    i.Caption = IWSLocalResource.description;
                    i.NestedExtension().Memo(s =>
                    {
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.ShowModelErrors = true;
                        s.Width = Unit.Percentage(100);
                    });
                });
                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "IsService";
                    i.Caption = IWSLocalResource.IsService;
                    i.NestedExtension().CheckBox(e =>
                    {

                    });
                });
                formLayoutSettings.Items.AddEmptyItem();
                formLayoutSettings.Items.AddEmptyItem();
                formLayoutSettings.Items.AddEmptyItem();
                formLayoutSettings.Items.AddEmptyItem();
                formLayoutSettings.Items.Add(i =>
                {
                    i.ShowCaption = DefaultBoolean.False;
                    i.HorizontalAlign = FormLayoutHorizontalAlign.Center;
                }).SetNestedContent(() =>
                {
                    Html.DevExpress().Button(
                b =>
                {
                    b.Name = "btnUpdate";
                    b.Text = "";
                    b.ToolTip = IWSLocalResource.btnUpdate;
                    b.Style[HtmlTextWriterStyle.MarginRight] = "5px";
                    b.Images.Image.IconID = IconID.ActionsApply16x16;
                    b.Width = Unit.Pixel(80);
                    b.ClientSideEvents.Click = "function(s, e){ ArticlesGridView.UpdateEdit(); }";
                }).Render();

                    Html.DevExpress().Button(
                b =>
                {
                    b.Name = "btnCancel";
                    b.Text = "";
                    b.ToolTip = IWSLocalResource.btnCancel;
                    b.Style[HtmlTextWriterStyle.MarginLeft] = "5px";
                    b.Images.Image.IconID = IconID.ActionsCancel16x16;
                    b.Width = Unit.Pixel(80);
                    b.ClientSideEvents.Click = "function(s, e){ ArticlesGridView.CancelEdit(); }";
                }).Render();
                });
            })
            .Bind(ViewData["article"] ?? templateContent.DataItem)
            .Render();
        });
        #endregion

        settings.DataBinding = (sender, e) =>
        {
            ((MVCxGridView)sender).ForceDataRowType(typeof(Article));
        };
    });
    if (ViewData["GenericError"] != null){
        grid.SetEditErrorText((string)ViewData["GenericError"]);
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 400 "..\..\Views\Articles\ArticlesGridViewPartial.cshtml"
Write(grid.Bind(Model).GetHtml());

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
