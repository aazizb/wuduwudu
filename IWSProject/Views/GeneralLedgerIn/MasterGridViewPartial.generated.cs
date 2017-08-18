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
    
    #line 2 "..\..\Views\GeneralLedgerIn\MasterGridViewPartial.cshtml"
    using IWSProject.Content;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\GeneralLedgerIn\MasterGridViewPartial.cshtml"
    using IWSProject.Models;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/GeneralLedgerIn/MasterGridViewPartial.cshtml")]
    public partial class _Views_GeneralLedgerIn_MasterGridViewPartial_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_GeneralLedgerIn_MasterGridViewPartial_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 4 "..\..\Views\GeneralLedgerIn\MasterGridViewPartial.cshtml"
  
    var grid = Html.DevExpress().GridView(settings =>
    {
        settings.Name = "GeneralLedgerIn";
        settings.Caption = IWSLocalResource.GeneralLedger;

        settings.CallbackRouteValues = new { Controller = "GeneralLedgerIn", Action = "MasterGridViewPartial" };

        settings.SettingsEditing.AddNewRowRouteValues = new { Controller = "GeneralLedgerIn", Action = "MasterGridViewPartialAddNew" };
        settings.SettingsEditing.UpdateRowRouteValues = new { Controller = "GeneralLedgerIn", Action = "MasterGridViewPartialUpdate" };
        settings.SettingsEditing.DeleteRowRouteValues = new { Controller = "GeneralLedgerIn", Action = "MasterGridViewPartialDelete" };

        settings.SettingsEditing.Mode = GridViewEditingMode.EditFormAndDisplayRow;

        settings.CommandColumn.Visible = true;
        settings.CommandColumn.Width = Unit.Pixel(80);

        settings.SettingsBehavior.EnableRowHotTrack = true;
        settings.Styles.RowHotTrack.Cursor = "pointer";
        settings.Styles.AlternatingRow.BackColor = System.Drawing.Color.Beige;

        //when an end-user double-clicks a grid row, the edit form appears, allowing an end-user to edit the row.  
        //settings.SettingsBehavior.AllowSelectByRowClick = true;
        //settings.ClientSideEvents.RowDblClick = "function(sender, e) { sender.StartEditRow(e.visibleIndex); }";

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

        //conditionally disable command buttons depending on IsValidated column value
        settings.CommandButtonInitialize = (s, e) =>
        {

            var value = (s as MVCxGridView).GetRowValues(e.VisibleIndex, "IsValidated");
            if (e.ButtonType == ColumnCommandButtonType.Edit || e.ButtonType == ColumnCommandButtonType.Delete)
            {
                e.Enabled = false.Equals(value);
            }
        };

        settings.InitNewRow = (s, e) =>
        {
            e.NewValues["ItemDate"] = DateTime.Today;
            e.NewValues["oid"] = 0;
        };

        settings.KeyFieldName = "id";

        settings.Settings.ShowFilterRow = true;
        settings.SettingsBehavior.ConfirmDelete = true;
        settings.SettingsBehavior.AllowSelectByRowClick = true;

        settings.Width = Unit.Percentage(100);
        
        
        
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
            column.FieldName = "CostCenter";
            column.Caption = IWSLocalResource.costcenters;
            column.EditorProperties().ComboBox(combo =>
            {
                combo.TextField = "Name";
                combo.ValueField = "id";
                combo.ValueType = typeof(string);
                combo.DataSource = IWSLookUp.GetCostCenters();
                combo.Columns.Add("id").Caption = IWSLocalResource.id;
                combo.Columns.Add("name").Caption = IWSLocalResource.costcenters;
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
            column.FieldName = "oTotal";
            column.Caption = IWSLocalResource.Total;
            column.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            column.PropertiesEdit.DisplayFormatString = "N";
        });
        settings.Columns.Add(column =>
        {
            column.FieldName = "oCurrency";
            column.Caption = IWSLocalResource.Currency;
            column.UnboundType = DevExpress.Data.UnboundColumnType.String;
        });
        settings.Columns.Add(column =>
        {
            column.FieldName = "HeaderText";
            column.Caption = IWSLocalResource.text;
        });

        #region Template

        settings.SetEditFormTemplateContent(c =>
        {

            Html.DevExpress().FormLayout(formLayoutSettings =>
            {
                formLayoutSettings.Name = "GeneralLedgerInEdit";

                formLayoutSettings.Width = Unit.Percentage(100);
                formLayoutSettings.ColCount = 2;

                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "oid";
                    i.Caption = IWSLocalResource.oid;
                    i.NestedExtension().ComboBox(s =>
                    {
                        s.Properties.TextField = "Name";
                        s.Properties.ValueField = "id";
                        s.Properties.ValueType = typeof(int);
                        s.Properties.DataSource = IWSLookUp.GetGeneralLedgerInOID();
                        s.Properties.Columns.Add("id").Caption = IWSLocalResource.id;
                        s.Properties.Columns.Add("Customer").Caption = IWSLocalResource.customer;
                        s.Properties.Columns.Add("CostCenter").Caption = IWSLocalResource.costcenters;
                        s.Properties.Columns.Add("DueDate").Caption = IWSLocalResource.duedate;
                        s.Properties.TextFormatString = "{0}";
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.ShowModelErrors = true;
                        s.Width = Unit.Percentage(100);
                        s.Properties.ClientSideEvents.SelectedIndexChanged = "OnOIDSelectedIndexChanged";

                    });
                });

                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "CostCenter";
                    i.Caption = IWSLocalResource.costcenters;
                    i.NestedExtension().ComboBox(s =>
                    {
                        s.Properties.TextField = "Name";
                        s.Properties.ValueField = "id";
                        s.Properties.ValueType = typeof(string);
                        s.Properties.DataSource = IWSLookUp.GetCostCenters();
                        s.Properties.Columns.Add("id").Caption = IWSLocalResource.id;
                        s.Properties.Columns.Add("Name").Caption = IWSLocalResource.name;
                        s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                        s.Properties.TextFormatString = "{0}-{1}";
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
                        s.Width = Unit.Percentage(94);
                        s.Properties.AllowUserInput = true;
                        s.Properties.AllowMouseWheel = true;
                    });
                });
                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "HeaderText";
                    i.Caption = IWSLocalResource.text;
                    i.NestedExtension().Memo(s =>
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
                    i.HorizontalAlign = FormLayoutHorizontalAlign.Center;
                }).SetNestedContent(() =>
                {

                    Html.DevExpress().Button(
                btnSettings =>
                {
                    btnSettings.Name = "btnUpdate";
                    btnSettings.Text = "";
                    btnSettings.ToolTip = IWSLocalResource.btnUpdate;
                    btnSettings.Style[HtmlTextWriterStyle.MarginRight] = "5px";
                    btnSettings.Images.Image.IconID = IconID.ActionsApply16x16;
                    btnSettings.ClientSideEvents.Click = "function(s, e){ GeneralLedgerIn.UpdateEdit(); }";
                }).Render();

                    Html.DevExpress().Button(
                btnSettings =>
                {
                    btnSettings.Name = "btnCancel";
                    btnSettings.Text = "";
                    btnSettings.ToolTip = IWSLocalResource.btnCancel;
                    btnSettings.Style[HtmlTextWriterStyle.MarginLeft] = "5px";
                    btnSettings.Images.Image.IconID = IconID.ActionsCancel16x16;
                    btnSettings.ClientSideEvents.Click = "function(s, e){ GeneralLedgerIn.CancelEdit(); }";
                }).Render();

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

            
            #line 292 "..\..\Views\GeneralLedgerIn\MasterGridViewPartial.cshtml"
Write(grid.Bind(Model).GetHtml());

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
