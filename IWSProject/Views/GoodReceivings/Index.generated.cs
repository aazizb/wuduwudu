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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/GoodReceivings/Index.cshtml")]
    public partial class _Views_GoodReceivings_Index_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_GoodReceivings_Index_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n    function OnItemSelectedIndexChanged(s, e) {\r\n        $.ajax({\r\n           " +
" url: \'");

            
            #line 4 "..\..\Views\GoodReceivings\Index.cshtml"
             Write(Url.Action("PackUnit", "GoodReceivings"));

            
            #line default
            #line hidden
WriteLiteral(@"',
            type: ""POST"",
            data: { selectedItemIndex: s.GetValue() },
            success: function (data) {
                unit.SetText(data);
            },
            error: function (xhr, textStatus, errorThrown) {
                alert('Request Status: ' + xhr.status + '; Status Text: ' + textStatus + '; Error: ' + errorThrown);
            }
        });
        $.ajax({
            url: '");

            
            #line 15 "..\..\Views\GoodReceivings\Index.cshtml"
             Write(Url.Action("VatCode", "GoodReceivings"));

            
            #line default
            #line hidden
WriteLiteral(@"',
            type: ""POST"",
            data: { selectedItemIndex: s.GetValue() },
            success: function (data) {
                VatCode.SetText(data);
            },
            error: function (xhr, textStatus, errorThrown) {
                alert('Request Status: ' + xhr.status + '; Status Text: ' + textStatus + '; Error: ' + errorThrown);
            }
        });
        $.ajax({
            url: '");

            
            #line 26 "..\..\Views\GoodReceivings\Index.cshtml"
             Write(Url.Action("Price", "GoodReceivings"));

            
            #line default
            #line hidden
WriteLiteral(@"',
            type: ""POST"",
            data: { selectedItemIndex: s.GetValue() },
            success: function (data) {
                price.SetText(data);
            },
            error: function (xhr, textStatus, errorThrown) {
                alert('Request Status: ' + xhr.status + '; Status Text: ' + textStatus + '; Error: ' + errorThrown);
            }
        });
        $.ajax({
            url: '");

            
            #line 37 "..\..\Views\GoodReceivings\Index.cshtml"
             Write(Url.Action("Text", "GoodReceivings"));

            
            #line default
            #line hidden
WriteLiteral(@"',
            type: ""POST"",
            data: { selectedItemIndex: s.GetValue() },
            success: function (data) {
                text.SetText(data);
            },
            error: function (xhr, textStatus, errorThrown) {
                alert('Request Status: ' + xhr.status + '; Status Text: ' + textStatus + '; Error: ' + errorThrown);
            }
        });
    }

    function OnOIDSelectedIndexChanged(s, e) {
        $.ajax({
            url: '");

            
            #line 51 "..\..\Views\GoodReceivings\Index.cshtml"
             Write(Url.Action("Store", "GoodReceivings"));

            
            #line default
            #line hidden
WriteLiteral(@"',
            type: ""POST"",
            data: { selectedOIDIndex: s.GetValue() },
            success: function (data) {
                store.SetText(data);
            },
            error: function (xhr, textStatus, errorThrown) {
                alert('Request Status: ' + xhr.status + '; Status Text: ' + textStatus + '; Error: ' + errorThrown);
            }
        });
        $.ajax({
            url: '");

            
            #line 62 "..\..\Views\GoodReceivings\Index.cshtml"
             Write(Url.Action("Supplier", "GoodReceivings"));

            
            #line default
            #line hidden
WriteLiteral(@"',
            type: ""POST"",
            data: { selectedOIDIndex: s.GetValue() },
            success: function (data) {
                account.SetText(data);
            },
            error: function (xhr, textStatus, errorThrown) {
                alert('Request Status: ' + xhr.status + '; Status Text: ' + textStatus + '; Error: ' + errorThrown);
            }
        });
        $.ajax({
            url: '");

            
            #line 73 "..\..\Views\GoodReceivings\Index.cshtml"
             Write(Url.Action("HeaderText", "GoodReceivings"));

            
            #line default
            #line hidden
WriteLiteral(@"',
            type: ""POST"",
            data: { selectedItemIndex: s.GetValue() },
            success: function (data) {
                HeaderText.SetText(data);
            },
            error: function (xhr, textStatus, errorThrown) {
                alert('Request Status: ' + xhr.status + '; Status Text: ' + textStatus + '; Error: ' + errorThrown);
            }
        });
    }

</script>


");

            
            #line 88 "..\..\Views\GoodReceivings\Index.cshtml"
 using (Html.BeginForm("MasterGridViewPartialAddNew", "GoodReceivings"))
{
    
            
            #line default
            #line hidden
            
            #line 90 "..\..\Views\GoodReceivings\Index.cshtml"
Write(Html.Hidden("cbxOID"));

            
            #line default
            #line hidden
            
            #line 90 "..\..\Views\GoodReceivings\Index.cshtml"
                          ;
}

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 93 "..\..\Views\GoodReceivings\Index.cshtml"
Write(Html.Partial("MasterGridViewPartial"));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
