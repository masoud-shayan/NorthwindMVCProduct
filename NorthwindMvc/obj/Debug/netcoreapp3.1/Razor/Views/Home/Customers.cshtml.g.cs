#pragma checksum "C:\Users\Alekhandr0\Desktop\dot-net-core\PracticalApps\NorthwindMvc\NorthwindMvc\Views\Home\Customers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "202cfcddeceb2c61f52f015b2e2431092536f762"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Customers), @"mvc.1.0.view", @"/Views/Home/Customers.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"202cfcddeceb2c61f52f015b2e2431092536f762", @"/Views/Home/Customers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c10324db967624bce2cebb2dbfaf1321bdbfb158", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Customers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NorthwindEntitiesLib.Customer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>");
#nullable restore
#line 2 "C:\Users\Alekhandr0\Desktop\dot-net-core\PracticalApps\NorthwindMvc\NorthwindMvc\Views\Home\Customers.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Company Name</th>\r\n        <th>Contact Name</th>\r\n        <th>Address</th>\r\n        <th>Phone</th>\r\n    </tr>\r\n");
#nullable restore
#line 10 "C:\Users\Alekhandr0\Desktop\dot-net-core\PracticalApps\NorthwindMvc\NorthwindMvc\Views\Home\Customers.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 14 "C:\Users\Alekhandr0\Desktop\dot-net-core\PracticalApps\NorthwindMvc\NorthwindMvc\Views\Home\Customers.cshtml"
           Write(Html.DisplayFor(modelItem => item.CompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 17 "C:\Users\Alekhandr0\Desktop\dot-net-core\PracticalApps\NorthwindMvc\NorthwindMvc\Views\Home\Customers.cshtml"
           Write(Html.DisplayFor(modelItem => item.ContactName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 20 "C:\Users\Alekhandr0\Desktop\dot-net-core\PracticalApps\NorthwindMvc\NorthwindMvc\Views\Home\Customers.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 21 "C:\Users\Alekhandr0\Desktop\dot-net-core\PracticalApps\NorthwindMvc\NorthwindMvc\Views\Home\Customers.cshtml"
           Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 22 "C:\Users\Alekhandr0\Desktop\dot-net-core\PracticalApps\NorthwindMvc\NorthwindMvc\Views\Home\Customers.cshtml"
           Write(Html.DisplayFor(modelItem => item.Region));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 23 "C:\Users\Alekhandr0\Desktop\dot-net-core\PracticalApps\NorthwindMvc\NorthwindMvc\Views\Home\Customers.cshtml"
           Write(Html.DisplayFor(modelItem => item.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 24 "C:\Users\Alekhandr0\Desktop\dot-net-core\PracticalApps\NorthwindMvc\NorthwindMvc\Views\Home\Customers.cshtml"
           Write(Html.DisplayFor(modelItem => item.PostalCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 27 "C:\Users\Alekhandr0\Desktop\dot-net-core\PracticalApps\NorthwindMvc\NorthwindMvc\Views\Home\Customers.cshtml"
           Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 30 "C:\Users\Alekhandr0\Desktop\dot-net-core\PracticalApps\NorthwindMvc\NorthwindMvc\Views\Home\Customers.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NorthwindEntitiesLib.Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
