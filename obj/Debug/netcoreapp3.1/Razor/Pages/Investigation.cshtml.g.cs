#pragma checksum "C:\Repositories\Cambio Climático\Pages\Investigation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c60f7cb72ae6dfd0a689f2a07a369d22c6cf0c75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Cambio_Climático.Pages.Pages_Investigation), @"mvc.1.0.razor-page", @"/Pages/Investigation.cshtml")]
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
#line 1 "C:\Repositories\Cambio Climático\Pages\_ViewImports.cshtml"
using Cambio_Climático;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c60f7cb72ae6dfd0a689f2a07a369d22c6cf0c75", @"/Pages/Investigation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"721340f79598c4ee7cf28de782bf2edbbe64056d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Investigation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Repositories\Cambio Climático\Pages\Investigation.cshtml"
  
    ViewData["Title"] = "Investigation";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <header>
        <div class=""d-flex h-100 align-items-center masthead"">
            <div class=""mx-auto text-center"">
                <h1 class=""text-white mx-auto my-0 text-uppercase"">Sección de investigación</h1>
                <h2 class=""text-white-50 mx-auto mt-2 mb-5"">¡Bienvenidos! </h2>
                <h3 class=""text-white-50 mx-auto mt-2 mb-5"">En esta sección usted podrá añadir sus credenciales y agregar el informe que ha obtenido mediante su observación de la presa</h3>
            </div>
        </div>
    </header>
    <hr>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c60f7cb72ae6dfd0a689f2a07a369d22c6cf0c754129", async() => {
                WriteLiteral("\r\n        <div class=\"form-row\">\r\n            <div class=\"col-md-4 mb-3\">\r\n                <label>Nombre</label>\r\n                <input type=\"text\" class=\"form-control\" placeholder=\"Nombre completo\"");
                BeginWriteAttribute("value", " value=\"", 891, "\"", 899, 0);
                EndWriteAttribute();
                WriteLiteral(" required>\r\n            </div>\r\n            <div class=\"col-md-4 mb-3\">\r\n                <label>Correo electrónico</label>\r\n                <input type=\"text\" class=\"form-control\" placeholder=\"Correo electrónico\"");
                BeginWriteAttribute("value", " value=\"", 1112, "\"", 1120, 0);
                EndWriteAttribute();
                WriteLiteral(" required>\r\n            </div>\r\n            <div class=\"col-md-4 mb-3\">\r\n                <label>Agencia</label>\r\n                <input type=\"text\" class=\"form-control\" placeholder=\"Agencia\"");
                BeginWriteAttribute("value", " value=\"", 1311, "\"", 1319, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
            </div>
        </div>
        <div class=""form-group"">
            <label>Contraseña</label>
            <input type=""password"" class=""form-control"" id=""exampleInputPassword1"" placeholder=""Contraseña"">
        </div>
        <div class=""form-group"">
            <label>Repetir contraseña</label>
            <input type=""password"" class=""form-control"" id=""exampleInputPassword1"" placeholder=""Repetir contraseña"">
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <div class=""form-group container"">
        <label for=""comment"">El siguiente cuadro es por si desea añadir algún comentaro aparte de sobre el archivo anexado:</label>
        <textarea class=""form-control"" rows=""5"" id=""comment""></textarea>
    </div>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c60f7cb72ae6dfd0a689f2a07a369d22c6cf0c757309", async() => {
                WriteLiteral(@"
        <div class=""form-group"">
            <label for=""exampleFormControlFile1"">En esta apartado puedes seleccionar el archivo a subir </label>
            <input type=""file"" class=""form-control-file"" id=""exampleFormControlFile"">
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c60f7cb72ae6dfd0a689f2a07a369d22c6cf0c758891", async() => {
                WriteLiteral("\r\n        <button type=\"button\" class=\"btn btn-primary\">Enviar</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cambio_Climático.Pages.InvestigationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Cambio_Climático.Pages.InvestigationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Cambio_Climático.Pages.InvestigationModel>)PageContext?.ViewData;
        public Cambio_Climático.Pages.InvestigationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
