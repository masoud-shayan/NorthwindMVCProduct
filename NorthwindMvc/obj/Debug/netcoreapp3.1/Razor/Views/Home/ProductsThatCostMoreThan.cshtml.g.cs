#pragma checksum "C:\Users\Alekhandr0\Desktop\dot-net-core\PracticalApps\NorthwindMvc\NorthwindMvc\Views\Home\ProductsThatCostMoreThan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c52a2622bdf8e6a82df02dbf572eb5bd5f7e90f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ProductsThatCostMoreThan), @"mvc.1.0.view", @"/Views/Home/ProductsThatCostMoreThan.cshtml")]
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
#line 1 "C:\Users\Alekhandr0\Desktop\dot-net-core\PracticalApps\NorthwindMvc\NorthwindMvc\Views\_ViewImports.cshtml"
using NorthwindMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alekhandr0\Desktop\dot-net-core\PracticalApps\NorthwindMvc\NorthwindMvc\Views\_ViewImports.cshtml"
using NorthwindMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c52a2622bdf8e6a82df02dbf572eb5bd5f7e90f", @"/Views/Home/ProductsThatCostMoreThan.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c10324db967624bce2cebb2dbfaf1321bdbfb158", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ProductsThatCostMoreThan : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NorthwindEntitiesLib.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Alekhandr0\Desktop\dot-net-core\PracticalApps\NorthwindMvc\NorthwindMvc\Views\Home\ProductsThatCostMoreThan.cshtml"
  
    ViewData["Title"] = "Products That Cost More Than " + ViewData["MaxPrice"];

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Products That Cost More Than ");
#nullable restore
#line 5 "C:\Users\Alekhandr0\Desktop\dot-net-core\PracticalApps\NorthwindMvc\NorthwindMvc\Views\Home\ProductsThatCostMoreThan.cshtml"
                            Write(ViewData["MaxPrice"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Category Name</th>\r\n        <th>Supplier\'s Company Name</th>\r\n        <th>Product Name</th>\r\n        <th>Unit Price</th>\r\n        <th>Units In Stock</th>\r\n    </tr>\r\n");
#nullable restore
#line 14 "C:\Users\Alekhandr0\Desktop\dot-net-core\PracticalApps\NorthwindMvc\NorthwindMvc\Views\Home\ProductsThatCostMoreThan.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 18 "C:\Users\Alekhandr0\Desktop\dot-net-core\PracticalApps\NorthwindMvc\NorthwindMvc\Views\Home\ProductsThatCostMoreThan.cshtml"
           Write(Html.DisplayFor(modelItem => item.Category.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 21 "C:\Users\Alekhandr0\Desktop\dot-net-core\PracticalApps\NorthwindMvc\NorthwindMvc\Views\Home\ProductsThatCostMoreThan.cshtml"
           Write(Html.DisplayFor(modelItem => item.Supplier.CompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 24 "C:\Users\Alekhandr0\Desktop\dot-net-core\PracticalApps\NorthwindMvc\NorthwindMvc\Views\Home\ProductsThatCostMoreThan.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 27 "C:\Users\Alekhandr0\Desktop\dot-net-core\PracticalApps\NorthwindMvc\NorthwindMvc\Views\Home\ProductsThatCostMoreThan.cshtml"
           Write(Html.DisplayFor(modelItem => item.UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 30 "C:\Users\Alekhandr0\Desktop\dot-net-core\PracticalApps\NorthwindMvc\NorthwindMvc\Views\Home\ProductsThatCostMoreThan.cshtml"
           Write(Html.DisplayFor(modelItem => item.UnitsInStock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 33 "C:\Users\Alekhandr0\Desktop\dot-net-core\PracticalApps\NorthwindMvc\NorthwindMvc\Views\Home\ProductsThatCostMoreThan.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NorthwindEntitiesLib.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
