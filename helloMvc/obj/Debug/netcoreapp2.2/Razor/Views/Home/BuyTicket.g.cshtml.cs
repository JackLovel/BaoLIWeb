#pragma checksum "/home/gog/codePro/BaoLIWeb/helloMvc/Views/Home/BuyTicket.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4508d65e589b35d5c82dcd79fb9efb9cdf76ebfc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(helloMvc.Pages.Home.Views_Home_BuyTicket), @"mvc.1.0.view", @"/Views/Home/BuyTicket.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/BuyTicket.cshtml", typeof(helloMvc.Pages.Home.Views_Home_BuyTicket))]
namespace helloMvc.Pages.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/home/gog/codePro/BaoLIWeb/helloMvc/Views/_ViewImports.cshtml"
using helloMvc;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4508d65e589b35d5c82dcd79fb9efb9cdf76ebfc", @"/Views/Home/BuyTicket.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60bb6ac9bb3138039bdd269c509e0956fae0d0f3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_BuyTicket : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/home/gog/codePro/BaoLIWeb/helloMvc/Views/Home/BuyTicket.cshtml"
  
    ViewData["Title"] = "购票入口";

#line default
#line hidden
            BeginContext(40, 277, true);
            WriteLiteral(@"

<div>
    <h2>购票</h2>
</div>

<div class=""text-center"">
  <table class=""table table-striped"">
  <thead>
    <tr>
      <th scope=""col"">购买方式</th>
      <th scope=""col"">点击购买</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>喵特网</td>
      <td>
        <a");
            EndContext();
            BeginWriteAttribute("href", " href=", 317, "", 337, 1);
#line 22 "/home/gog/codePro/BaoLIWeb/helloMvc/Views/Home/BuyTicket.cshtml"
WriteAttributeValue("", 323, ViewBag.nyato, 323, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(337, 176, true);
            WriteLiteral(">\r\n            <button type=\"button\" class=\"btn btn-outline-primary\">购买</button>     \r\n        </a>\r\n      </td>\r\n    </tr>\r\n    <tr>\r\n      <td>摩点</td>\r\n      <td>\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=", 513, "", 535, 1);
#line 30 "/home/gog/codePro/BaoLIWeb/helloMvc/Views/Home/BuyTicket.cshtml"
WriteAttributeValue("", 519, ViewBag.mo_dian, 519, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(535, 222, true);
            WriteLiteral(">\r\n            <button type=\"button\" class=\"btn btn-outline-primary\">购买</button>     \r\n        </a>\r\n      </td>\r\n    </tr>\r\n\r\n  </tbody>\r\n</table>\r\n</div>\r\n\r\n\r\n<div>\r\n    <h2>淘宝链接</h2>\r\n</div>\r\n<strong>官方店铺: </strong>\r\n<a");
            EndContext();
            BeginWriteAttribute("href", " href=", 757, "", 779, 1);
#line 45 "/home/gog/codePro/BaoLIWeb/helloMvc/Views/Home/BuyTicket.cshtml"
WriteAttributeValue("", 763, ViewBag.tao_bao, 763, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(779, 85, true);
            WriteLiteral(">\r\n    <button type=\"button\" class=\"btn btn-outline-primary\">点击访问</button>     \r\n</a>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
