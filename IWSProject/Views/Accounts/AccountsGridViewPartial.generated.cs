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
    
    #line 1 "..\..\Views\Accounts\AccountsGridViewPartial.cshtml"
    using IWSProject.Content;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Accounts\AccountsGridViewPartial.cshtml"
    using IWSProject.Models;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Accounts/AccountsGridViewPartial.cshtml")]
    public partial class _Views_Accounts_AccountsGridViewPartial_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Accounts_AccountsGridViewPartial_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Accounts\AccountsGridViewPartial.cshtml"
  
    var grid = Html.DevExpress().GridView(settings =>
    {
        settings.Name = "AccountsGridView";
        settings.Caption = IWSLocalResource.account;

        settings.CallbackRouteValues = new { Controller = "Accounts", Action = "AccountsGridViewPartial" };

        settings.SettingsEditing.AddNewRowRouteValues = new { Controller = "Accounts", Action = "AccountsGridViewPartialAddNew" };
        settings.SettingsEditing.UpdateRowRouteValues = new { Controller = "Accounts", Action = "AccountsGridViewPartialUpdate" };
        settings.SettingsEditing.DeleteRowRouteValues = new { Controller = "Accounts", Action = "AccountsGridViewPartialDelete" };
        settings.SettingsEditing.Mode = GridViewEditingMode.EditFormAndDisplayRow;

        settings.SettingsEditing.Mode = GridViewEditingMode.EditFormAndDisplayRow;

        settings.CommandColumn.Visible = true;
        settings.CommandColumn.Width = Unit.Pixel(70);

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

        settings.InitNewRow = (s, e) =>
        {
            e.NewValues["dateofopen"] = DateTime.Now;
            e.NewValues["dateofclose"] = DateTime.Now;
            e.NewValues["Currency"] = (string)Session["Currency"];
            e.NewValues["balance"] = 0;
            e.NewValues["Isused"] = true;
        };


        settings.KeyFieldName = "id";

        settings.Settings.ShowFilterRow = true;
        settings.Settings.ShowFilterRowMenu = true;
        settings.SettingsBehavior.ConfirmDelete = true;
        settings.SettingsBehavior.AllowSelectByRowClick = true;

        settings.SettingsBehavior.AllowSelectByRowClick = true;
        settings.SettingsBehavior.EnableRowHotTrack = true;

        settings.Styles.RowHotTrack.Cursor = "pointer";
        settings.Styles.AlternatingRow.BackColor = System.Drawing.Color.Beige;

        settings.Width = Unit.Percentage(100);
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
        settings.Columns.Add(column =>
        {
            column.FieldName = "ParentId";
            column.Caption = IWSLocalResource.SubAccountOf;
            column.EditorProperties().ComboBox(combo =>
            {
                combo.TextField = "Name";
                combo.ValueField = "id";
                combo.ValueType = typeof(string);
                combo.DataSource = IWSLookUp.GetAccounts();
                combo.Columns.Add("id").Caption = IWSLocalResource.id;
                combo.Columns.Add("name").Caption = IWSLocalResource.SubAccountOf;
                combo.TextFormatString = "{0}-{1}";
            });
        });
        settings.Columns.Add(column =>
        {
            column.FieldName = "IsUsed";
            column.Caption = IWSLocalResource.IsUsed;
            column.EditorProperties().CheckBox(checkBox =>
            {
            });
        });
        settings.Columns.Add("description").Caption = IWSLocalResource.description;
        settings.Columns.Add("groupid").Caption = IWSLocalResource.groupid;

        settings.Columns.Add(column =>
        {
            column.FieldName = "dateofopen";
            column.Caption = IWSLocalResource.dateofopen;
            column.ColumnType = MVCxGridViewColumnType.DateEdit;
            column.EditorProperties().DateEdit(d =>
            {
                d.EditFormatString = "MM/dd/yyyy";
                d.NullDisplayText = "yyyy-MM-dd";
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
            column.FieldName = "dateofclose";
            column.Caption = IWSLocalResource.dateofclose;
            column.ColumnType = MVCxGridViewColumnType.DateEdit;
            column.EditorProperties().DateEdit(d =>
            {
                d.EditFormatString = "MM/dd/yyyy";
                d.NullDisplayText = "yyyy-MM-dd";
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
            column.FieldName = "balance";
            column.Caption = IWSLocalResource.balance;
            column.EditorProperties().SpinEdit(p =>
            {
                p.DisplayFormatString = "N";
                p.DisplayFormatInEditMode = true;
                p.SpinButtons.ShowLargeIncrementButtons = true;
                p.Width = Unit.Percentage(100);
            });
        });
        settings.Columns.Add(column =>
        {
            column.FieldName = "Currency";
            column.Caption = IWSLocalResource.Currency;
            column.EditorProperties().ComboBox(combo =>
            {
                combo.TextField = "Name";
                combo.ValueField = "id";
                combo.ValueType = typeof(string);
                combo.DataSource = IWSLookUp.GetCurrency();
                combo.Columns.Add("id").Caption = IWSLocalResource.id;
                combo.Columns.Add("name").Caption = IWSLocalResource.Currency;
                combo.TextFormatString = "{0}-{1}";
            });
        });

        #region Template Edit
        settings.SetEditFormTemplateContent(templateContent =>
        {
            var editItem = ViewData["accounts"] != null ? ViewData["accounts"] : templateContent.DataItem;

            Html.DevExpress().FormLayout(formLayoutSettings =>
            {
                formLayoutSettings.Name = "AccountsViewEdit";
                formLayoutSettings.Width = Unit.Percentage(100);
                formLayoutSettings.ColCount = 2;
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
                    i.Caption = IWSLocalResource.name;
                    i.NestedExtension().TextBox(s =>
                    {
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.ShowModelErrors = true;
                        s.Width = Unit.Percentage(100);
                    });
                });
                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "ParentId";
                    i.Caption = IWSLocalResource.SubAccountOf;
                    i.NestedExtension().ComboBox(s =>
                    {
                        s.Properties.TextField = "name";
                        s.Properties.ValueField = "id";
                        s.Properties.ValueType = typeof(string);
                        s.Properties.DataSource = IWSLookUp.GetAccounts();
                        s.Properties.Columns.Add("id").Caption = IWSLocalResource.id;
                        s.Properties.Columns.Add("name").Caption = IWSLocalResource.SubAccountOf;
                        s.Properties.TextFormatString = "{0}-{1}";
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.ShowModelErrors = true;
                        s.Width = Unit.Percentage(100);
                    });
                });
                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "IsUsed";
                    i.Caption = IWSLocalResource.IsUsed;
                    i.NestedExtension().CheckBox(e =>
                    {

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
                        s.Width = Unit.Percentage(100);
                    });
                });

                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "groupid";
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
                    i.FieldName = "dateofopen";
                    i.Caption = IWSLocalResource.dateofopen;
                    i.NestedExtensionType = FormLayoutNestedExtensionItemType.DateEdit;
                    i.NestedExtension().DateEdit(d =>
                    {
                        d.Properties.UseMaskBehavior = true;
                        d.Properties.EditFormat = EditFormat.Date;
                        d.Properties.EditFormatString = "d";
                        d.Width = Unit.Percentage(94.5);
                        d.Properties.AllowUserInput = true;
                        d.Properties.AllowMouseWheel = true;
                    });
                });
                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "dateofclose";
                    i.Caption = IWSLocalResource.dateofclose;
                    i.NestedExtensionType = FormLayoutNestedExtensionItemType.DateEdit;
                    i.NestedExtension().DateEdit(d =>
                    {
                        d.Properties.UseMaskBehavior = true;
                        d.Properties.EditFormat = EditFormat.Date;
                        d.Properties.EditFormatString = "d";
                        d.Width = Unit.Percentage(94.5);
                        d.Properties.AllowUserInput = true;
                        d.Properties.AllowMouseWheel = true;
                    });
                });
                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "balance";
                    i.Caption = IWSLocalResource.balance;
                    i.NestedExtension().SpinEdit(s =>
                    {
                        s.Properties.DisplayFormatString = "N";
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.Properties.SpinButtons.ShowLargeIncrementButtons = true;
                        s.Width = Unit.Percentage(94.5);
                    });
                });
                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "Currency";
                    i.Caption = IWSLocalResource.Currency;
                    i.NestedExtension().ComboBox(s =>
                    {
                        s.Properties.TextField = "name";
                        s.Properties.ValueField = "id";
                        s.Properties.ValueType = typeof(string);
                        s.Properties.DataSource = IWSLookUp.GetCurrency();
                        s.Properties.Columns.Add("id").Caption = IWSLocalResource.id;
                        s.Properties.Columns.Add("name").Caption = IWSLocalResource.Currency;
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
                    b.Width = Unit.Pixel(70);
                    b.ClientSideEvents.Click = "function(s, e){ AccountsGridView.UpdateEdit(); }";
                }).Render();

                    Html.DevExpress().Button(
                b =>
                {
                    b.Name = "btnCancel";
                    b.Text = "";
                    b.ToolTip = IWSLocalResource.btnCancel;
                    b.Style[HtmlTextWriterStyle.MarginLeft] = "5px";
                    b.Images.Image.IconID = IconID.ActionsCancel16x16;
                    b.Width = Unit.Pixel(70);
                    b.ClientSideEvents.Click = "function(s, e){ AccountsGridView.CancelEdit(); }";
                }).Render();
                });
            })
            .Bind(ViewData["accounts"] ?? templateContent.DataItem)
            .Render();
        });
        #endregion

        settings.DataBinding = (sender, e) =>
        {
            ((MVCxGridView)sender).ForceDataRowType(typeof(Account));
        };
    });
    if (ViewData["GenericError"] != null)
    {
        grid.SetEditErrorText((string)ViewData["GenericError"]);
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 384 "..\..\Views\Accounts\AccountsGridViewPartial.cshtml"
Write(grid.Bind(Model).GetHtml());

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
