#pragma checksum "C:\Users\loja\Source\Repos\finalnoahtech\Views\Home\Eventos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "518e79f72459fb7ddf7ef19a4e502016ee8c93f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Eventos), @"mvc.1.0.view", @"/Views/Home/Eventos.cshtml")]
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
#line 1 "C:\Users\loja\Source\Repos\finalnoahtech\Views\_ViewImports.cshtml"
using Noahtech;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\loja\Source\Repos\finalnoahtech\Views\_ViewImports.cshtml"
using Noahtech.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"518e79f72459fb7ddf7ef19a4e502016ee8c93f9", @"/Views/Home/Eventos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"907bc1455aec09b5e7175a922535369b453b695c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Eventos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\loja\Source\Repos\finalnoahtech\Views\Home\Eventos.cshtml"
  

    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.Title = "Eventos";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\loja\Source\Repos\finalnoahtech\Views\Home\Eventos.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\loja\Source\Repos\finalnoahtech\Views\Home\Eventos.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <h1 class=\"text-center\">");
#nullable restore
#line 12 "C:\Users\loja\Source\Repos\finalnoahtech\Views\Home\Eventos.cshtml"
                           Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n        ");
#nullable restore
#line 14 "C:\Users\loja\Source\Repos\finalnoahtech\Views\Home\Eventos.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <p>\r\n\r\n            Datas e informações de eventos da área da tecnologia\r\n        </p>\r\n    </div>\r\n");
#nullable restore
#line 21 "C:\Users\loja\Source\Repos\finalnoahtech\Views\Home\Eventos.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
