#pragma checksum "C:\aaaMirChasov2022\MirCasovSln0316\MirChasov\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50542e6f6dfb5db7ffaf3b88cb26d7af6172700c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\aaaMirChasov2022\MirCasovSln0316\MirChasov\Views\_ViewImports.cshtml"
using MirChasov;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\aaaMirChasov2022\MirCasovSln0316\MirChasov\Views\_ViewImports.cshtml"
using MirChasov.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\aaaMirChasov2022\MirCasovSln0316\MirChasov\Views\_ViewImports.cshtml"
using MirChasov.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50542e6f6dfb5db7ffaf3b88cb26d7af6172700c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3a1f741f269bdad5f1e0f29ad7a899d91291732", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\aaaMirChasov2022\MirCasovSln0316\MirChasov\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    var SaleLeader = Model.Where(x => x.FlagSaleLeader);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center col-12\">\r\n    <h1 class=\"display-4\">Главная страница</h1>\r\n\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 13 "C:\aaaMirChasov2022\MirCasovSln0316\MirChasov\Views\Home\Index.cshtml"
         foreach (var p in SaleLeader) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card col-1 mb-3\">\r\n                <h3>");
#nullable restore
#line 15 "C:\aaaMirChasov2022\MirCasovSln0316\MirChasov\Views\Home\Index.cshtml"
               Write(p.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <img src=\"/img/test1.jpg\" alt=\"Alternate Text\" />\r\n                <p>");
#nullable restore
#line 17 "C:\aaaMirChasov2022\MirCasovSln0316\MirChasov\Views\Home\Index.cshtml"
              Write(p.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                ");
#nullable restore
#line 18 "C:\aaaMirChasov2022\MirCasovSln0316\MirChasov\Views\Home\Index.cshtml"
           Write(p.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <p>");
#nullable restore
#line 19 "C:\aaaMirChasov2022\MirCasovSln0316\MirChasov\Views\Home\Index.cshtml"
                  Write(p.dblCaseSize);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <h4>");
#nullable restore
#line 20 "C:\aaaMirChasov2022\MirCasovSln0316\MirChasov\Views\Home\Index.cshtml"
               Write(p.PriceWithDiscount.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            </div>\r\n");
#nullable restore
#line 22 "C:\aaaMirChasov2022\MirCasovSln0316\MirChasov\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <img src=\"https://mirchasov64.ru/assets/img/logo1.png\" alt=\"Alternate Text\" />\r\n\r   \r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
