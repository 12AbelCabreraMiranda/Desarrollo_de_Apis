#pragma checksum "D:\Visual Studio 2019\Project\Apis\Apis\Areas\Api_Pokemon\Views\Pokemon\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5385d73c71ca3ad1b8fd01e9e9f82eb5ff4ceed0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Api_Pokemon_Views_Pokemon_Index), @"mvc.1.0.view", @"/Areas/Api_Pokemon/Views/Pokemon/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5385d73c71ca3ad1b8fd01e9e9f82eb5ff4ceed0", @"/Areas/Api_Pokemon/Views/Pokemon/Index.cshtml")]
    public class Areas_Api_Pokemon_Views_Pokemon_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Apis.Areas.Api_Pokemon.Data.Pokemon>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Visual Studio 2019\Project\Apis\Apis\Areas\Api_Pokemon\Views\Pokemon\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap-icons@1.9.1/font/bootstrap-icons.css"">
<div class=""container"">
    <div class=""row mb-4"">
        <div class=""col-md-12 text-center"">
            <img height=""200"" src=""https://upload.wikimedia.org/wikipedia/commons/thumb/9/98/International_Pok%C3%A9mon_logo.svg/800px-International_Pok%C3%A9mon_logo.svg.png"" />
        </div>
");
#nullable restore
#line 12 "D:\Visual Studio 2019\Project\Apis\Apis\Areas\Api_Pokemon\Views\Pokemon\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-3 mt-4\">\r\n                <div class=\"card shadow-sm\">\r\n                    <div class=\"card-body tamanio-card pointer d-flex align-items-center justify-content-center\"");
            BeginWriteAttribute("style", " style=\"", 747, "\"", 788, 2);
            WriteAttributeValue("", 755, "background-color:", 755, 17, true);
#nullable restore
#line 16 "D:\Visual Studio 2019\Project\Apis\Apis\Areas\Api_Pokemon\Views\Pokemon\Index.cshtml"
WriteAttributeValue("", 772, item.ColorCards, 772, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 820, "\"", 838, 1);
#nullable restore
#line 17 "D:\Visual Studio 2019\Project\Apis\Apis\Areas\Api_Pokemon\Views\Pokemon\Index.cshtml"
WriteAttributeValue("", 826, item.Imagen, 826, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid tamaio-img\" alt=\"...\">\r\n\r\n                    </div>\r\n                    <div class=\"card-footer bg-white\">\r\n");
            WriteLiteral("                        <h5 class=\"card-title mb-0 d-inline-block mt-1\" style=\"text-transform: capitalize;\">");
#nullable restore
#line 22 "D:\Visual Studio 2019\Project\Apis\Apis\Areas\Api_Pokemon\Views\Pokemon\Index.cshtml"
                                                                                                       Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <h3");
            BeginWriteAttribute("class", " class=\"", 1205, "\"", 1256, 4);
            WriteAttributeValue("", 1213, "d-inline-block", 1213, 14, true);
            WriteAttributeValue(" ", 1227, "float-right", 1228, 12, true);
            WriteAttributeValue(" ", 1239, "pointer", 1240, 8, true);
#nullable restore
#line 23 "D:\Visual Studio 2019\Project\Apis\Apis\Areas\Api_Pokemon\Views\Pokemon\Index.cshtml"
WriteAttributeValue(" ", 1247, item.Id, 1248, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onmouseover", " onmouseover=\"", 1257, "\"", 1309, 5);
            WriteAttributeValue("", 1271, "mouseOver(", 1271, 10, true);
#nullable restore
#line 23 "D:\Visual Studio 2019\Project\Apis\Apis\Areas\Api_Pokemon\Views\Pokemon\Index.cshtml"
WriteAttributeValue("", 1281, item.Id, 1281, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1289, ",\'", 1289, 2, true);
#nullable restore
#line 23 "D:\Visual Studio 2019\Project\Apis\Apis\Areas\Api_Pokemon\Views\Pokemon\Index.cshtml"
WriteAttributeValue("", 1291, item.ColorCards, 1291, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1307, "\')", 1307, 2, true);
            EndWriteAttribute();
            BeginWriteAttribute("onmouseout", " onmouseout=\"", 1310, "\"", 1341, 3);
            WriteAttributeValue("", 1323, "mouseOut(", 1323, 9, true);
#nullable restore
#line 23 "D:\Visual Studio 2019\Project\Apis\Apis\Areas\Api_Pokemon\Views\Pokemon\Index.cshtml"
WriteAttributeValue("", 1332, item.Id, 1332, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1340, ")", 1340, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <i class=\"bi bi-heart\"></i>\r\n                        </h3>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 29 "D:\Visual Studio 2019\Project\Apis\Apis\Areas\Api_Pokemon\Views\Pokemon\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
</div>

<style>
    .tamanio-card {
        height: 250px;
    }

    .tamaio-img {
        max-height: 200px;
    }

        .tamaio-img:hover {
            -ms-transform: scale(1.4); /* IE 9 */
            -webkit-transform: scale(1.4); /* Safari 3-8 */
            transform: scale(1.4);
        }

    .pointer {
        cursor: pointer;
    }

    .bi-heart:hover {
    }
</style>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    <script>\r\n        function mouseOver(id, color) {\r\n            $(\".\" + id).css(\"color\", color);\r\n        }\r\n\r\n        function mouseOut(id) {\r\n            $(\".\" + id).css(\"color\", \"#1f1f1f\");\r\n        }\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Apis.Areas.Api_Pokemon.Data.Pokemon>> Html { get; private set; }
    }
}
#pragma warning restore 1591
