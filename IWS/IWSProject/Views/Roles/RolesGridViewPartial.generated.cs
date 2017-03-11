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
    
    #line 1 "..\..\Views\Roles\RolesGridViewPartial.cshtml"
    using IWSProject.Content;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Roles/RolesGridViewPartial.cshtml")]
    public partial class _Views_Roles_RolesGridViewPartial_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Roles_RolesGridViewPartial_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Roles\RolesGridViewPartial.cshtml"
  
    var grid = Html.DevExpress().GridView(settings =>
    {
        settings.Name = "RolesGridView";
        settings.Caption = IWSLocalResource.Roles;

        settings.CallbackRouteValues = new { Controller = "Roles", Action = "RolesGridViewPartial" };

        settings.SettingsEditing.AddNewRowRouteValues = new { Controller = "Roles", Action = "RolesGridViewPartialAddNew" };
        settings.SettingsEditing.UpdateRowRouteValues = new { Controller = "Roles", Action = "RolesGridViewPartialUpdate" };
        settings.SettingsEditing.DeleteRowRouteValues = new { Controller = "Roles", Action = "RolesGridViewPartialDelete" };
        settings.SettingsEditing.Mode = GridViewEditingMode.EditFormAndDisplayRow;

        settings.CommandColumn.Visible = true;
        settings.CommandColumn.Width = Unit.Pixel(120);
        settings.CommandColumn.ShowNewButtonInHeader = true;
        settings.CommandColumn.ShowDeleteButton = false;
        settings.CommandColumn.ShowEditButton = true;

        settings.SettingsCommandButton.NewButton.Image.IconID = IconID.ActionsAdditem16x16;
        settings.SettingsCommandButton.EditButton.Image.IconID = IconID.ActionsEdit16x16devav;
        settings.SettingsCommandButton.DeleteButton.Image.IconID = IconID.ActionsDeletelist16x16;

        settings.KeyFieldName = "Id";

        settings.SettingsBehavior.AllowSelectByRowClick = true;
        settings.SettingsBehavior.EnableRowHotTrack = true;

        settings.Styles.RowHotTrack.Cursor = "pointer";
        settings.Styles.AlternatingRow.BackColor = System.Drawing.Color.Beige;

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

        settings.Columns.Add("Name").Caption = IWSLocalResource.name;

        #region Template Edit
        settings.SetEditFormTemplateContent(templateContent =>
        {
            var editItem = ViewData["role"] != null ? ViewData["role"] : templateContent.DataItem;

            Html.DevExpress().FormLayout(formLayoutSettings =>
            {
                formLayoutSettings.Name = "RolesViewEdit";
                formLayoutSettings.Width = Unit.Percentage(100);
                formLayoutSettings.ColCount = 1;

                formLayoutSettings.Items.Add(i =>
                {
                    i.FieldName = "Name";
                    i.Caption = IWSLocalResource.name;
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
                    btnSettings.ClientSideEvents.Click = "function(s, e){ RolesGridView.UpdateEdit(); }";
                }).Render();

                    Html.DevExpress().Button(
                btnSettings =>
                {
                    btnSettings.Name = "btnCancel";
                    btnSettings.Text = IWSLocalResource.btnCancel;
                    btnSettings.Style[HtmlTextWriterStyle.MarginLeft] = "5px";
                    btnSettings.Images.Image.IconID = IconID.ActionsCancel16x16;
                    btnSettings.ClientSideEvents.Click = "function(s, e){ RolesGridView.CancelEdit(); }";
                }).Render();
                    ViewContext.Writer.Write("</div>");
                });
            })
            .Bind(ViewData["role"] ?? templateContent.DataItem)
            .Render();
        });
        #endregion

        settings.DataBinding = (sender, e) =>
        {
            ((MVCxGridView)sender).ForceDataRowType(typeof(Roles));
        };
    });
    if (ViewData["GenericError"] != null)
    {
        grid.SetEditErrorText((string)ViewData["GenericError"]);
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 129 "..\..\Views\Roles\RolesGridViewPartial.cshtml"
Write(grid.Bind(Model).GetHtml());

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
