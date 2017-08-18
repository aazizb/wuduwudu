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
    
    #line 1 "..\..\Views\BankStatements\BankStatementsGridViewPartial.cshtml"
    using IWSProject.Content;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\BankStatements\BankStatementsGridViewPartial.cshtml"
    using IWSProject.Models;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/BankStatements/BankStatementsGridViewPartial.cshtml")]
    public partial class _Views_BankStatements_BankStatementsGridViewPartial_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_BankStatements_BankStatementsGridViewPartial_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\BankStatements\BankStatementsGridViewPartial.cshtml"
  
    var grid = Html.DevExpress().GridView(settings =>
    {
        settings.Name = "BankStatementsGridView";
        settings.Caption = IWSLocalResource.BankStatement;

        settings.CallbackRouteValues = new { Controller = "BankStatements", Action = "BankStatementsGridViewPartial" };

        settings.SettingsEditing.AddNewRowRouteValues = new { Controller = "BankStatements", Action = "BankStatementsGridViewPartialAddNew" };
        settings.SettingsEditing.UpdateRowRouteValues = new { Controller = "BankStatements", Action = "BankStatementsGridViewPartialUpdate" };
        settings.SettingsEditing.DeleteRowRouteValues = new { Controller = "BankStatements", Action = "BankStatementsGridViewPartialDelete" };

        settings.SettingsEditing.Mode = GridViewEditingMode.PopupEditForm;

        settings.SettingsBehavior.EnableCustomizationWindow = true;
        settings.ClientSideEvents.CustomizationWindowCloseUp= "CustomizationWindowCloseUp";

        settings.SettingsResizing.ColumnResizeMode = ColumnResizeMode.NextColumn;
        settings.SettingsResizing.Visualization = ResizingMode.Postponed;

        settings.CommandColumn.ShowSelectCheckbox = true;

        settings.CommandColumn.Visible = true;
        settings.CommandColumn.Width = Unit.Pixel(80);

        settings.Styles.RowHotTrack.Cursor = "pointer";
        settings.Styles.AlternatingRow.BackColor = System.Drawing.Color.Beige;

        settings.ClientSideEvents.SelectionChanged = "OnSelectionChanged";
        settings.ClientSideEvents.BeginCallback = "OnBeginCallback";

        settings.SettingsBehavior.EnableRowHotTrack = true;
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

        settings.InitNewRow = (s, e) =>
        {
            e.NewValues["Buchungstag"] = DateTime.Today;
            e.NewValues["Valutadatum"] = DateTime.Today;
        };

        settings.KeyFieldName = "id";

        settings.Settings.ShowFilterRow = true;
        settings.Settings.ShowFilterRowMenu = true;
        settings.SettingsBehavior.AllowFocusedRow = true;

        settings.Settings.ShowGroupPanel = true;

        settings.SettingsBehavior.ConfirmDelete = true;

        settings.Width = Unit.Percentage(100);
        
        
        
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
        settings.Columns.Add("Auftragskonto").Caption = IWSLocalResource.OrderAccount;
        settings.Columns.Add(column =>
        {
            column.FieldName = "Buchungstag";
            column.Caption = IWSLocalResource.OrderDate;
            column.ColumnType = MVCxGridViewColumnType.DateEdit;
            column.EditorProperties().DateEdit(d =>
            {
                d.EditFormatString = "MM/dd/yyyy";
                d.NullDisplayText = "MM/dd/yyyy";
                d.EditFormat = EditFormat.Custom;
                d.DisplayFormatString = "yyyy-MM-dd";
                d.DisplayFormatInEditMode = true;
                d.AllowUserInput = true;
                d.AllowMouseWheel = true;
            });
        });
        settings.Columns.Add(column =>
        {
            column.FieldName = "Valutadatum";
            column.Caption = IWSLocalResource.ValueDate;
            column.ColumnType = MVCxGridViewColumnType.DateEdit;
            column.EditorProperties().DateEdit(d =>
            {
                d.EditFormatString = "MM/dd/yyyy";
                d.NullDisplayText = "MM/dd/yyyy";
                d.EditFormat = EditFormat.Custom;
                d.DisplayFormatString = "yyyy-MM-dd";
                d.DisplayFormatInEditMode = true;
                d.AllowUserInput = true;
                d.AllowMouseWheel = true;
            });
        });
        settings.Columns.Add("Buchungstext").Caption = IWSLocalResource.BookingText;
        settings.Columns.Add("Verwendungszweck").Caption = IWSLocalResource.Usage;
        settings.Columns.Add("BeguenstigterZahlungspflichtiger").Caption = IWSLocalResource.BeneficiaryOfPayment;
        settings.Columns.Add("Kontonummer").Caption = IWSLocalResource.IBAN;
        settings.Columns.Add("BLZ").Caption = IWSLocalResource.BLZ;
        settings.Columns.Add(column =>
        {
            column.FieldName = "Betrag";
            column.Caption = IWSLocalResource.amount;
            column.EditorProperties().TextBox(p =>
            {
                p.DisplayFormatString = "N";
                p.DisplayFormatInEditMode = true;
                p.Width = Unit.Percentage(100);
            });
        });
        settings.Columns.Add("Waehrung").Caption = IWSLocalResource.Currency;

        #region Template Edit
        settings.SetEditFormTemplateContent(templateContent =>
        {
            Html.DevExpress().FormLayout(formLayoutSettings =>
            {
                formLayoutSettings.Name = "BankStatementsViewEdit";
                formLayoutSettings.Width = Unit.Percentage(100);
                formLayoutSettings.ColCount = 1;
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
                    i.FieldName = "Auftragskonto";
                    i.Caption = IWSLocalResource.OrderAccount;
                    i.NestedExtension().TextBox(s =>
                    {
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.ShowModelErrors = true;
                        s.Width = Unit.Percentage(100);
                    });
                });
                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "Buchungstag";
                    i.Caption = IWSLocalResource.OrderDate;
                    i.NestedExtensionType = FormLayoutNestedExtensionItemType.DateEdit;

                    i.NestedExtension().DateEdit(s =>
                    {
                        s.Properties.UseMaskBehavior = true;
                        s.Properties.EditFormat = EditFormat.Date;
                        s.Properties.EditFormatString = "d";
                        s.Width = Unit.Percentage(94);
                        s.Properties.AllowUserInput = true;
                        s.Properties.AllowMouseWheel = true;
                    });
                });
                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "Valutadatum";
                    i.Caption = IWSLocalResource.ValueDate;
                    i.NestedExtensionType = FormLayoutNestedExtensionItemType.DateEdit;
                    i.NestedExtension().DateEdit(s =>
                    {
                        s.Properties.UseMaskBehavior = true;
                        s.Properties.EditFormat = EditFormat.Date;
                        s.Properties.EditFormatString = "d";
                        s.Width = Unit.Percentage(94);
                        s.Properties.AllowUserInput = true;
                        s.Properties.AllowMouseWheel = true;
                    });
                });
                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "Buchungstext";
                    i.Caption = IWSLocalResource.BookingText;
                    i.NestedExtension().TextBox(s =>
                    {
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.ShowModelErrors = true;
                        s.Width = Unit.Percentage(100);
                    });
                });
                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "Verwendungszweck";
                    i.Caption = IWSLocalResource.Usage;
                    i.NestedExtension().Memo(s =>
                    {
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.ShowModelErrors = true;
                        s.Width = Unit.Percentage(100);
                    });
                });
                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "BeguenstigterZahlungspflichtiger";
                    i.Caption = IWSLocalResource.BeneficiaryOfPayment;
                    i.NestedExtension().TextBox(s =>
                    {
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.ShowModelErrors = true;
                        s.Width = Unit.Percentage(100);
                    });
                });
                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "Kontonummer";
                    i.Caption = IWSLocalResource.IBAN;
                    i.NestedExtension().TextBox(s =>
                    {
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.ShowModelErrors = true;
                        s.Width = Unit.Percentage(100);
                    });
                });
                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "BLZ";
                    i.Caption = IWSLocalResource.BLZ;
                    i.NestedExtension().TextBox(s =>
                    {
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.ShowModelErrors = true;
                        s.Width = Unit.Percentage(100);
                    });
                });
                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "Betrag";
                    i.Caption = IWSLocalResource.amount;
                    i.NestedExtension().TextBox(s =>
                    {
                        s.Properties.DisplayFormatString = "N";
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.ShowModelErrors = true;
                        s.Width = Unit.Percentage(100);
                    });
                });
                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "Waehrung";
                    i.Caption = IWSLocalResource.Currency;
                    i.NestedExtension().ComboBox(s =>
                    {
                        s.Properties.TextField = "name";
                        s.Properties.ValueField = "id";
                        s.Properties.ValueType = typeof(string);
                        s.Properties.DataSource = IWSLookUp.GetCurrency();
                        s.Properties.Columns.Add("id").Caption = IWSLocalResource.id;
                        s.Properties.Columns.Add("name").Caption = IWSLocalResource.Currency;
                        s.Properties.TextFormatString = "{0}";
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.ShowModelErrors = true;
                        s.Width = Unit.Percentage(100);
                    });
                });
                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "Info";
                    i.Caption = IWSLocalResource.Info;
                    i.NestedExtension().Memo(s =>
                    {
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.ShowModelErrors = true;
                        s.Width = Unit.Percentage(100);
                    });
                });

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
                            b.ClientSideEvents.Click = "function(s, e){ BankStatementsGridView.UpdateEdit(); }";
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
                            b.ClientSideEvents.Click = "function(s, e){ BankStatementsGridView.CancelEdit(); }";
                        }).Render();
                });
            })
        .Bind(ViewData["BankStatement"] ?? templateContent.DataItem)
        .Render();
        });
        #endregion
        settings.DataBinding = (sender, e) =>
        {
            ((MVCxGridView)sender).ForceDataRowType(typeof(BankStatement));
        };
    });
    if (ViewData["GenericError"] != null)
    {
        grid.SetEditErrorText((string)ViewData["GenericError"]);
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 346 "..\..\Views\BankStatements\BankStatementsGridViewPartial.cshtml"
Write(grid.Bind(Model).GetHtml());

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
