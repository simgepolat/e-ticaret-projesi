#pragma checksum "C:\Users\simge.polat\Desktop\documents-project\e-ticaret-projesi\ETICARET\eTicaret\Views\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a46f17c024f33f6fa0c086744db33fc15232ce47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_List), @"mvc.1.0.view", @"/Views/Product/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a46f17c024f33f6fa0c086744db33fc15232ce47", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f943f1e4019805aff856d1fc60d3eac6cbcf1e01", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 5 "C:\Users\simge.polat\Desktop\documents-project\e-ticaret-projesi\ETICARET\eTicaret\Views\Product\List.cshtml"
  
    var popularClass= Model.Products.Count>2? "popular":"";
    var products=Model.Products;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Categories", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 13 "C:\Users\simge.polat\Desktop\documents-project\e-ticaret-projesi\ETICARET\eTicaret\Views\Product\List.cshtml"
Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n\r\n    \r\n\r\n");
#nullable restore
#line 19 "C:\Users\simge.polat\Desktop\documents-project\e-ticaret-projesi\ETICARET\eTicaret\Views\Product\List.cshtml"
 if(products.Count==0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\simge.polat\Desktop\documents-project\e-ticaret-projesi\ETICARET\eTicaret\Views\Product\List.cshtml"
Write(await Html.PartialAsync("_noproduct"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\simge.polat\Desktop\documents-project\e-ticaret-projesi\ETICARET\eTicaret\Views\Product\List.cshtml"
                                          
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n\r\n");
#nullable restore
#line 27 "C:\Users\simge.polat\Desktop\documents-project\e-ticaret-projesi\ETICARET\eTicaret\Views\Product\List.cshtml"
         foreach (var product in products)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-4\">\r\n                    ");
#nullable restore
#line 30 "C:\Users\simge.polat\Desktop\documents-project\e-ticaret-projesi\ETICARET\eTicaret\Views\Product\List.cshtml"
               Write(await Html.PartialAsync("_product",product));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 32 "C:\Users\simge.polat\Desktop\documents-project\e-ticaret-projesi\ETICARET\eTicaret\Views\Product\List.cshtml"
            
            
            
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 37 "C:\Users\simge.polat\Desktop\documents-project\e-ticaret-projesi\ETICARET\eTicaret\Views\Product\List.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
