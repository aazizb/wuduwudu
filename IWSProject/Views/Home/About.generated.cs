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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Home/About.cshtml")]
    public partial class _Views_Home_About_cshtml : System.Web.Mvc.WebViewPage<List<string>>
    {
        public _Views_Home_About_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("Key Value is ");

            
            #line 2 "..\..\Views\Home\About.cshtml"
        Write(ViewData["Key"]);

            
            #line default
            #line hidden
WriteLiteral("\r\n<br /><br /><br />\r\n");

            
            #line 4 "..\..\Views\Home\About.cshtml"
Write(Html.ActionLink("<< Home", "Index"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
    $(document).ready(function() {
        $(""#SelectionMode"").change(function() { $(""form"").submit(); });
    });
    function FeaturesSelectionChanged(s, e) {
        var selectedFeatures = s.GetSelectedValues();
        lbModels.PerformCallback({ ""selectedFeatures"": selectedFeatures ? selectedFeatures.join() : null });
    }
</script>

");

            
            #line 16 "..\..\Views\Home\About.cshtml"
 using (Html.BeginForm())
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" style=\"margin-bottom: 32px\"");

WriteLiteral(">\r\n        <label");

WriteLiteral(" for=\"SelectionMode\"");

WriteLiteral(">Selection mode:</label>\r\n    </div>\r\n");

WriteLiteral("    <div");

WriteLiteral(" style=\"float: left\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 22 "..\..\Views\Home\About.cshtml"
   Write(Html.DevExpress().ListBox(
            settings =>
            {
                settings.Name = "lbFeatures";
                settings.Width = 250;
                settings.Height = 210;
                settings.Properties.Caption = "Phone features:";
                settings.Properties.CaptionSettings.Position = EditorCaptionPosition.Top;
                settings.Properties.ValueField = "ID";
                settings.Properties.ValueType = typeof(string);
                settings.Properties.TextField = "Name";
                settings.Properties.ClientSideEvents.SelectedIndexChanged = "FeaturesSelectionChanged";
            }
        ).BindList(Model).GetHtml());

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n");

            
            #line 37 "..\..\Views\Home\About.cshtml"

}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591