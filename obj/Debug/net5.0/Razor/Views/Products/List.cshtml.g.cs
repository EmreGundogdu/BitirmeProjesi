#pragma checksum "C:\Users\Emre\Desktop\FinalDev\Asp.NET CORE\BitirmeProjesi\ETicaretProje\ETicaret.WebUI\Views\Products\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a631d81d380d969dd160cc2db971649c69afeb3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_List), @"mvc.1.0.view", @"/Views/Products/List.cshtml")]
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
#line 2 "C:\Users\Emre\Desktop\FinalDev\Asp.NET CORE\BitirmeProjesi\ETicaretProje\ETicaret.WebUI\Views\_ViewImports.cshtml"
using ETicaret.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Emre\Desktop\FinalDev\Asp.NET CORE\BitirmeProjesi\ETicaretProje\ETicaret.WebUI\Views\_ViewImports.cshtml"
using ETicaret.WebUI.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a631d81d380d969dd160cc2db971649c69afeb3a", @"/Views/Products/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d536402155f7ecadde3ca60397117d8abef28594", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Emre\Desktop\FinalDev\Asp.NET CORE\BitirmeProjesi\ETicaretProje\ETicaret.WebUI\Views\Products\List.cshtml"
  
    var popularClass = Model.Products.Count > 2 ? "popular" : "";
    var products = Model.Products;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Categories", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 11 "C:\Users\Emre\Desktop\FinalDev\Asp.NET CORE\BitirmeProjesi\ETicaretProje\ETicaret.WebUI\Views\Products\List.cshtml"
Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\Emre\Desktop\FinalDev\Asp.NET CORE\BitirmeProjesi\ETicaretProje\ETicaret.WebUI\Views\Products\List.cshtml"
 if (products.Count == 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Emre\Desktop\FinalDev\Asp.NET CORE\BitirmeProjesi\ETicaretProje\ETicaret.WebUI\Views\Products\List.cshtml"
Write(await Html.PartialAsync("_noproduct"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Emre\Desktop\FinalDev\Asp.NET CORE\BitirmeProjesi\ETicaretProje\ETicaret.WebUI\Views\Products\List.cshtml"
                                          
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n");
#nullable restore
#line 21 "C:\Users\Emre\Desktop\FinalDev\Asp.NET CORE\BitirmeProjesi\ETicaretProje\ETicaret.WebUI\Views\Products\List.cshtml"
         foreach (var product in products)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-3\">\r\n                ");
#nullable restore
#line 24 "C:\Users\Emre\Desktop\FinalDev\Asp.NET CORE\BitirmeProjesi\ETicaretProje\ETicaret.WebUI\Views\Products\List.cshtml"
           Write(await Html.PartialAsync("_product", product));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 26 "C:\Users\Emre\Desktop\FinalDev\Asp.NET CORE\BitirmeProjesi\ETicaretProje\ETicaret.WebUI\Views\Products\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 28 "C:\Users\Emre\Desktop\FinalDev\Asp.NET CORE\BitirmeProjesi\ETicaretProje\ETicaret.WebUI\Views\Products\List.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
