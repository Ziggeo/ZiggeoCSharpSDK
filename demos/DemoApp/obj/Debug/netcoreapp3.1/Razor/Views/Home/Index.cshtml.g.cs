#pragma checksum "/Users/rashad/Ziggeo/C#/ZiggeoDemoApp/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b04461c6421c03d4c13b7ba8d1a63122ec8966ef"
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
#line 1 "/Users/rashad/Ziggeo/C#/ZiggeoDemoApp/Views/_ViewImports.cshtml"
using ZiggeoDemoApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/rashad/Ziggeo/C#/ZiggeoDemoApp/Views/_ViewImports.cshtml"
using ZiggeoDemoApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b04461c6421c03d4c13b7ba8d1a63122ec8966ef", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3609ada660c874bc551e124bf541e462ab6e0de", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/rashad/Ziggeo/C#/ZiggeoDemoApp/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\r\n    \r\n    <h1>Available Links with example</h1>\r\n\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 9 "/Users/rashad/Ziggeo/C#/ZiggeoDemoApp/Views/Home/Index.cshtml"
         foreach (var route in @Model.routes)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-12\">\r\n                <p>");
#nullable restore
#line 12 "/Users/rashad/Ziggeo/C#/ZiggeoDemoApp/Views/Home/Index.cshtml"
              Write(route.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <ul class=\"list-group list-group-horizontal\">\r\n");
#nullable restore
#line 14 "/Users/rashad/Ziggeo/C#/ZiggeoDemoApp/Views/Home/Index.cshtml"
                     foreach (var val in @route.Value)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"list-group-item\">\r\n                            <a class=\"btn btn-link\"");
            BeginWriteAttribute("href", " href=\"", 520, "\"", 537, 1);
#nullable restore
#line 17 "/Users/rashad/Ziggeo/C#/ZiggeoDemoApp/Views/Home/Index.cshtml"
WriteAttributeValue("", 527, val.Value, 527, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 17 "/Users/rashad/Ziggeo/C#/ZiggeoDemoApp/Views/Home/Index.cshtml"
                                                                 Write(val.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </li>\r\n");
#nullable restore
#line 19 "/Users/rashad/Ziggeo/C#/ZiggeoDemoApp/Views/Home/Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </div>\r\n");
#nullable restore
#line 22 "/Users/rashad/Ziggeo/C#/ZiggeoDemoApp/Views/Home/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
