#pragma checksum "/Users/teeraponguthairat/Desktop/asp-web-app/Vidly/Views/Customers/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22cc2267388f86bfd90c2ea3c1ab9abcd6ee9bdb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_Details), @"mvc.1.0.view", @"/Views/Customers/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customers/Details.cshtml", typeof(AspNetCore.Views_Customers_Details))]
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
#line 1 "/Users/teeraponguthairat/Desktop/asp-web-app/Vidly/Views/_ViewImports.cshtml"
using Vidly;

#line default
#line hidden
#line 2 "/Users/teeraponguthairat/Desktop/asp-web-app/Vidly/Views/_ViewImports.cshtml"
using Vidly.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22cc2267388f86bfd90c2ea3c1ab9abcd6ee9bdb", @"/Views/Customers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5f1cd008877cdb7a8309a52d389048c655f591a", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Vidly.Models.Customer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/teeraponguthairat/Desktop/asp-web-app/Vidly/Views/Customers/Details.cshtml"
  
    ViewBag.Title = Model.Name;
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(119, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(126, 10, false);
#line 8 "/Users/teeraponguthairat/Desktop/asp-web-app/Vidly/Views/Customers/Details.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(136, 7, true);
            WriteLiteral("</h2>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Vidly.Models.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
