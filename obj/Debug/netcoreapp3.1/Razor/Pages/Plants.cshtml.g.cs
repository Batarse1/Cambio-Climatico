#pragma checksum "C:\Repositories\Cambio-Climatico\Pages\Plants.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f1c22923afe6f55f8b5d96388a17f03509987c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Cambio_Climático.Pages.Pages_Plants), @"mvc.1.0.razor-page", @"/Pages/Plants.cshtml")]
namespace Cambio_Climático.Pages
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
#line 1 "C:\Repositories\Cambio-Climatico\Pages\_ViewImports.cshtml"
using Cambio_Climático;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Repositories\Cambio-Climatico\Pages\Plants.cshtml"
using Components;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f1c22923afe6f55f8b5d96388a17f03509987c0", @"/Pages/Plants.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"721340f79598c4ee7cf28de782bf2edbbe64056d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Plants : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Repositories\Cambio-Climatico\Pages\Plants.cshtml"
  
    ViewData["Title"] = "Plants";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Repositories\Cambio-Climatico\Pages\Plants.cshtml"
Write(await Html.RenderComponentAsync<PlantsBlazor>(RenderMode.ServerPrerendered));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<script src=\"_framework/blazor.server.js\"></script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cambio_Climático.Pages.PlantsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Cambio_Climático.Pages.PlantsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Cambio_Climático.Pages.PlantsModel>)PageContext?.ViewData;
        public Cambio_Climático.Pages.PlantsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
