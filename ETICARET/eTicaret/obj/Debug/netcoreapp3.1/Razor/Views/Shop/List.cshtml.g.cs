#pragma checksum "C:\Users\simge.polat\Desktop\documents-project\e-ticaret-projesi\ETICARET\eTicaret\Views\Shop\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c1d9e901415f493a1dc265260b209d9f56375ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_List), @"mvc.1.0.view", @"/Views/Shop/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c1d9e901415f493a1dc265260b209d9f56375ad", @"/Views/Shop/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c7372bea7f8a92f696427ae703afc290e64d1fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        ");
#nullable restore
#line 6 "C:\Users\simge.polat\Desktop\documents-project\e-ticaret-projesi\ETICARET\eTicaret\Views\Shop\List.cshtml"
   Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-9\">\r\n        <div class=\"row\">                  \r\n");
#nullable restore
#line 10 "C:\Users\simge.polat\Desktop\documents-project\e-ticaret-projesi\ETICARET\eTicaret\Views\Shop\List.cshtml"
             foreach (var product in Model.Products)
            {    

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4\">\r\n                    ");
#nullable restore
#line 13 "C:\Users\simge.polat\Desktop\documents-project\e-ticaret-projesi\ETICARET\eTicaret\Views\Shop\List.cshtml"
               Write(await Html.PartialAsync("_product", product));

#line default
#line hidden
#nullable disable
            WriteLiteral("   \r\n                </div>       \r\n");
#nullable restore
#line 15 "C:\Users\simge.polat\Desktop\documents-project\e-ticaret-projesi\ETICARET\eTicaret\Views\Shop\List.cshtml"
            }           

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n\r\n\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                <nav aria-label=\"Page navigation example\">\r\n                    <ul class=\"pagination\">\r\n");
#nullable restore
#line 25 "C:\Users\simge.polat\Desktop\documents-project\e-ticaret-projesi\ETICARET\eTicaret\Views\Shop\List.cshtml"
                         for (int i = 0; i <Model.PageInfo.TotalPages()  ; i++)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\simge.polat\Desktop\documents-project\e-ticaret-projesi\ETICARET\eTicaret\Views\Shop\List.cshtml"
                             if(String.IsNullOrEmpty(Model.PageInfo.CurrentCategory))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li");
            BeginWriteAttribute("class", " class=\"", 905, "\"", 969, 2);
            WriteAttributeValue("", 913, "page-item", 913, 9, true);
#nullable restore
#line 29 "C:\Users\simge.polat\Desktop\documents-project\e-ticaret-projesi\ETICARET\eTicaret\Views\Shop\List.cshtml"
WriteAttributeValue(" ", 922, Model.PageInfo.CurrentPage==i+1?"active":"", 923, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1029, "\"", 1057, 2);
            WriteAttributeValue("", 1036, "/products?page=", 1036, 15, true);
#nullable restore
#line 30 "C:\Users\simge.polat\Desktop\documents-project\e-ticaret-projesi\ETICARET\eTicaret\Views\Shop\List.cshtml"
WriteAttributeValue("", 1051, i+1, 1051, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
#nullable restore
#line 31 "C:\Users\simge.polat\Desktop\documents-project\e-ticaret-projesi\ETICARET\eTicaret\Views\Shop\List.cshtml"
                                    Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </a>\r\n                                </li>  \r\n");
#nullable restore
#line 34 "C:\Users\simge.polat\Desktop\documents-project\e-ticaret-projesi\ETICARET\eTicaret\Views\Shop\List.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li");
            BeginWriteAttribute("class", " class=\"", 1323, "\"", 1387, 2);
            WriteAttributeValue("", 1331, "page-item", 1331, 9, true);
#nullable restore
#line 37 "C:\Users\simge.polat\Desktop\documents-project\e-ticaret-projesi\ETICARET\eTicaret\Views\Shop\List.cshtml"
WriteAttributeValue(" ", 1340, Model.PageInfo.CurrentPage==i+1?"active":"", 1341, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1447, "\"", 1507, 4);
            WriteAttributeValue("", 1454, "/products/", 1454, 10, true);
#nullable restore
#line 38 "C:\Users\simge.polat\Desktop\documents-project\e-ticaret-projesi\ETICARET\eTicaret\Views\Shop\List.cshtml"
WriteAttributeValue("", 1464, Model.PageInfo.CurrentCategory, 1464, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1495, "?page=", 1495, 6, true);
#nullable restore
#line 38 "C:\Users\simge.polat\Desktop\documents-project\e-ticaret-projesi\ETICARET\eTicaret\Views\Shop\List.cshtml"
WriteAttributeValue("", 1501, i+1, 1501, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
#nullable restore
#line 39 "C:\Users\simge.polat\Desktop\documents-project\e-ticaret-projesi\ETICARET\eTicaret\Views\Shop\List.cshtml"
                                    Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </a>\r\n                                </li> \r\n");
#nullable restore
#line 42 "C:\Users\simge.polat\Desktop\documents-project\e-ticaret-projesi\ETICARET\eTicaret\Views\Shop\List.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\simge.polat\Desktop\documents-project\e-ticaret-projesi\ETICARET\eTicaret\Views\Shop\List.cshtml"
                             

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        \r\n                        \r\n                </nav>\r\n            </div>\r\n        </div>\r\n\r\n\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"" integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"" crossorigin=""anonymous""></script>
");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
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
