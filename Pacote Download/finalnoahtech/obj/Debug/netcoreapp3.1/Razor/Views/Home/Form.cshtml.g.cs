#pragma checksum "C:\Users\loja\Source\Repos\finalnoahtech\Views\Home\Form.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "749fe9e08316e654755b7d9205dd212b013c48d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Form), @"mvc.1.0.view", @"/Views/Home/Form.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"749fe9e08316e654755b7d9205dd212b013c48d0", @"/Views/Home/Form.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"907bc1455aec09b5e7175a922535369b453b695c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Form : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\loja\Source\Repos\finalnoahtech\Views\Home\Form.cshtml"
  

    Layout = "~/Views/Shared/_LayoutSistema.cshtml";
    ViewBag.Title = "Responda o formulário";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\loja\Source\Repos\finalnoahtech\Views\Home\Form.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\loja\Source\Repos\finalnoahtech\Views\Home\Form.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div>
        <h1 class=""text-center"">Qual caminho trilhar?</h1>
        <p class=""text-center"">Nós da NoaTech queremos entender melhor suas vontadades e necessidades!</p>
        <p class=""text-center"">Para melhor orientarmos qual a trilha mais indicada a seguir, por favor responda o questionário abaixo.</p>
        <hr />

        ");
#nullable restore
#line 18 "C:\Users\loja\Source\Repos\finalnoahtech\Views\Home\Form.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


        <iframe class=""center"" src=""https://docs.google.com/forms/d/e/1FAIpQLSfgJ_mCPXNhJTmrStWAvEGpX-LEq8RSB-x5isn9B3nz2YJt7g/viewform?embedded=true""
                width=""1100"" height=""1313"" frameborder=""0"" marginheight=""0"" marginwidth=""0"">
            Carregando…
        </iframe>

    </div>
");
#nullable restore
#line 27 "C:\Users\loja\Source\Repos\finalnoahtech\Views\Home\Form.cshtml"

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
