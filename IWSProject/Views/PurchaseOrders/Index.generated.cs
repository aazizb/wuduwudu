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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/PurchaseOrders/Index.cshtml")]
    public partial class _Views_PurchaseOrders_Index_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_PurchaseOrders_Index_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n    function OnSelectedIndexChanged(s, e) {\r\n        $.ajax({\r\n            url" +
": \'");

            
            #line 4 "..\..\Views\PurchaseOrders\Index.cshtml"
             Write(Url.Action("PackUnit", "PurchaseOrders"));

            
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

            
            #line 15 "..\..\Views\PurchaseOrders\Index.cshtml"
             Write(Url.Action("VatCode", "PurchaseOrders"));

            
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

            
            #line 26 "..\..\Views\PurchaseOrders\Index.cshtml"
             Write(Url.Action("Price", "PurchaseOrders"));

            
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

            
            #line 37 "..\..\Views\PurchaseOrders\Index.cshtml"
             Write(Url.Action("Text", "PurchaseOrders"));

            
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
</script>

");

            
            #line 50 "..\..\Views\PurchaseOrders\Index.cshtml"
Write(Html.Action("MasterGridViewPartial"));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
