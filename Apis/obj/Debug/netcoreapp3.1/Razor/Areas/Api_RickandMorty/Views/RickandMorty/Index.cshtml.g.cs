#pragma checksum "D:\Visual Studio 2019\Project\Apis\Apis\Areas\Api_RickandMorty\Views\RickandMorty\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e724d2b45ddb255ec1b51d0bb4afce542c30aa6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Api_RickandMorty_Views_RickandMorty_Index), @"mvc.1.0.view", @"/Areas/Api_RickandMorty/Views/RickandMorty/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e724d2b45ddb255ec1b51d0bb4afce542c30aa6", @"/Areas/Api_RickandMorty/Views/RickandMorty/Index.cshtml")]
    public class Areas_Api_RickandMorty_Views_RickandMorty_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Apis.Areas.Api_RickandMorty.Data.Principal>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Visual Studio 2019\Project\Apis\Apis\Areas\Api_RickandMorty\Views\RickandMorty\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-md-12"">
            <img height=""350"" src=""https://occ.a.nflxso.net/dnm/api/v6/E8vDc_W8CLv7-yMQu8KMEC7Rrr8/AAAABQiueWggGi5jRi90-HxWCCR50UQv0Ah8_FlRzbT3hib02J5mvN9-g8YsT8jN9dFdgspCFLSHgc27S-fqRNxBglbwfHexRSKVQWIN.jpg?r=9b9"" />
        </div>
");
#nullable restore
#line 11 "D:\Visual Studio 2019\Project\Apis\Apis\Areas\Api_RickandMorty\Views\RickandMorty\Index.cshtml"
         foreach (var item in Model.Results)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-3 mt-3\">\r\n                <div class=\"card shadow-sm\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 578, "\"", 595, 1);
#nullable restore
#line 15 "D:\Visual Studio 2019\Project\Apis\Apis\Areas\Api_RickandMorty\Views\RickandMorty\Index.cshtml"
WriteAttributeValue("", 584, item.Image, 584, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">");
#nullable restore
#line 17 "D:\Visual Studio 2019\Project\Apis\Apis\Areas\Api_RickandMorty\Views\RickandMorty\Index.cshtml"
                                          Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 21 "D:\Visual Studio 2019\Project\Apis\Apis\Areas\Api_RickandMorty\Views\RickandMorty\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Apis.Areas.Api_RickandMorty.Data.Principal> Html { get; private set; }
    }
}
#pragma warning restore 1591
