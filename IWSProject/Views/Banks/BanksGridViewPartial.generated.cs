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
    
    #line 1 "..\..\Views\Banks\BanksGridViewPartial.cshtml"
    using IWSProject.Content;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Banks\BanksGridViewPartial.cshtml"
    using IWSProject.Models;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Banks/BanksGridViewPartial.cshtml")]
    public partial class _Views_Banks_BanksGridViewPartial_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Banks_BanksGridViewPartial_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Banks\BanksGridViewPartial.cshtml"
  
    var grid = Html.DevExpress().GridView(settings =>
    {
        settings.Name = "BanksGridView";
        settings.Caption = IWSLocalResource.account;

        settings.CallbackRouteValues = new { Controller = "Banks", Action = "BanksGridViewPartial" };

        settings.SettingsEditing.AddNewRowRouteValues = new { Controller = "Banks", Action = "BanksGridViewPartialAddNew" };
        settings.SettingsEditing.UpdateRowRouteValues = new { Controller = "Banks", Action = "BanksGridViewPartialUpdate" };
        settings.SettingsEditing.DeleteRowRouteValues = new { Controller = "Banks", Action = "BanksGridViewPartialDelete" };

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
        //settings.Columns.Add("modelid").Caption = IWSLocalResource.modelid;
        settings.Columns.Add("description").Caption = IWSLocalResource.description;

        #region Template Edit
        settings.SetEditFormTemplateContent(templateContent =>
        {
            var editItem = ViewData["bank"] != null ? ViewData["bank"] : templateContent.DataItem;

            Html.DevExpress().FormLayout(formLayoutSettings =>
            {
                formLayoutSettings.Name = "BanksViewEdit";
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
                    b.ClientSideEvents.Click = "function(s, e){ BanksGridView.UpdateEdit(); }";
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
                    b.ClientSideEvents.Click = "function(s, e){ BanksGridView.CancelEdit(); }";
                }).Render();
                });
            })
            .Bind(ViewData["bank"] ?? templateContent.DataItem)
            .Render();
        });
        #endregion

        settings.DataBinding = (sender, e) =>
        {
            ((MVCxGridView)sender).ForceDataRowType(typeof(Bank));
        };
    });
    if (ViewData["GenericError"] != null)
    {
        grid.SetEditErrorText((string)ViewData["GenericError"]);
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 180 "..\..\Views\Banks\BanksGridViewPartial.cshtml"
Write(grid.Bind(Model).GetHtml());

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

        }
    }
}
#pragma warning restore 1591