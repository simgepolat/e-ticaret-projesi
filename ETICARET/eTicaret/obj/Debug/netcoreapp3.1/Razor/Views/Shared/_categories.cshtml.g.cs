#pragma checksum "C:\Users\simge.polat\Desktop\documents-project\e-ticaret-projesi\ETICARET\eTicaret\Views\Shared\_categories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b75d2d720dc2caa028a182c3e63b8f0a866d9be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__categories), @"mvc.1.0.view", @"/Views/Shared/_categories.cshtml")]
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
#line 2 "C:\Users\simge.polat\Desktop\documents-project\e-ticaret-projesi\ETICARET\eTicaret\Views\_ViewImports.cshtml"
using eTicaret.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\simge.polat\Desktop\documents-project\e-ticaret-projesi\ETICARET\eTicaret\Views\_ViewImports.cshtml"
using eTicaret.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\simge.polat\Desktop\documents-project\e-ticaret-projesi\ETICARET\eTicaret\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\simge.polat\Desktop\documents-project\e-ticaret-projesi\ETICARET\eTicaret\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\simge.polat\Desktop\documents-project\e-ticaret-projesi\ETICARET\eTicaret\Views\_ViewImports.cshtml"
using eTicaret.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b75d2d720dc2caa028a182c3e63b8f0a866d9be", @"/Views/Shared/_categories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f943f1e4019805aff856d1fc60d3eac6cbcf1e01", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__categories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"list-group list-group-flush \">\r\n");
#nullable restore
#line 3 "C:\Users\simge.polat\Desktop\documents-project\e-ticaret-projesi\ETICARET\eTicaret\Views\Shared\_categories.cshtml"
     foreach (var category in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a href=\"#\" class=\"list-group-item list-group-item-action\">");
#nullable restore
#line 5 "C:\Users\simge.polat\Desktop\documents-project\e-ticaret-projesi\ETICARET\eTicaret\Views\Shared\_categories.cshtml"
                                                              Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 6 "C:\Users\simge.polat\Desktop\documents-project\e-ticaret-projesi\ETICARET\eTicaret\Views\Shared\_categories.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
