#pragma checksum "C:\Users\RizwanBashir\Desktop\securing-microservices-asp-dot-net-core\02\demos\start\GloboTicket.Client\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60e143b75924688c4e220a901cfad912fda14d59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\Users\RizwanBashir\Desktop\securing-microservices-asp-dot-net-core\02\demos\start\GloboTicket.Client\Views\_ViewImports.cshtml"
using GloboTicket.Web.Models.View;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60e143b75924688c4e220a901cfad912fda14d59", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03ed58786824169b4ed40dade632d67648d57ee4", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"

<h2>Your orders</h2>
<h4>Here is an overview of your orders.</h4>

<table class=""table"">
    <thead>
        <tr class=""columnHeader"">
            <th>ID</th>
            <th>DATE</th>
            <th>TOTAL</th>
            <th>PAID?</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 19 "C:\Users\RizwanBashir\Desktop\securing-microservices-asp-dot-net-core\02\demos\start\GloboTicket.Client\Views\Order\Index.cshtml"
         foreach (var line in Model.Orders)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\RizwanBashir\Desktop\securing-microservices-asp-dot-net-core\02\demos\start\GloboTicket.Client\Views\Order\Index.cshtml"
           Write(line.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\RizwanBashir\Desktop\securing-microservices-asp-dot-net-core\02\demos\start\GloboTicket.Client\Views\Order\Index.cshtml"
           Write(line.OrderPlaced.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"bold\">$");
#nullable restore
#line 24 "C:\Users\RizwanBashir\Desktop\securing-microservices-asp-dot-net-core\02\demos\start\GloboTicket.Client\Views\Order\Index.cshtml"
                         Write(line.OrderTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"bold\">");
#nullable restore
#line 25 "C:\Users\RizwanBashir\Desktop\securing-microservices-asp-dot-net-core\02\demos\start\GloboTicket.Client\Views\Order\Index.cshtml"
                        Write(line.OrderPaid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 27 "C:\Users\RizwanBashir\Desktop\securing-microservices-asp-dot-net-core\02\demos\start\GloboTicket.Client\Views\Order\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
