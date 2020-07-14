#pragma checksum "C:\Repositories\Cambio-Climatico\Pages\Graphics.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "043cd9c50fe14c401e00d4c64878f012804a2589"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Cambio_Climático.Pages.Pages_Graphics), @"mvc.1.0.razor-page", @"/Pages/Graphics.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"043cd9c50fe14c401e00d4c64878f012804a2589", @"/Pages/Graphics.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"721340f79598c4ee7cf28de782bf2edbbe64056d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Graphics : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Repositories\Cambio-Climatico\Pages\Graphics.cshtml"
  
    ViewData["Title"] = "Graphics";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<header>
    <div class=""d-flex h-100 align-items-center GraphHead"">
        <div class=""mx-auto text-center"">
            <h1 class=""text-white mx-auto my-0 text-uppercase"">Gráficos sobre energía eléctrica</h1>
            <h2 class=""text-white-50 mx-auto mt-2 mb-5"">En esta sección encontrarás gráficos sobre los datos relacionados a energía de las represas hidroeléctricas</h2>
        </div>
    </div>
</header>

<div class=""fluid-container"">
    <div class=""row"" style=""margin-left:1rem; margin-right:1rem;"">
        <div class=""col-12 col-sm-12 col-md-12 col-lg-6"" style=""margin-top:3rem;"">
            <div class=""card"" style=""width:100%;height:100%;"">
                <div style=""margin:1rem;"">
                    <canvas id=""myChart""></canvas>
                    <script>
                        let myChart = document.getElementById('myChart').getContext('2d');

                        // Global Options
                        Chart.defaults.global.defaultFontFamily = 'Arial';
         ");
            WriteLiteral(@"               Chart.defaults.global.defaultFontSize = 12;
                        Chart.defaults.global.defaultFontColor = '#777';

                        let massPopChart = new Chart(myChart, {
                            type: 'bar', // bar, horizontalBar, pie, line, doughnut, radar, polarArea
                            data: {
                                labels: ['Guajoyo', 'Cerrón Grande', '5 de Noviembre', '15 de Septiembre'],
                                datasets: [{
                                    label: 'KW',
                                    data: [
                                        10,
                                        20,
                                        40,
                                        5,
                                        0
                                    ],
                                    //backgroundColor:'green',
                                    backgroundColor: [
                                        '#57a0ff',");
            WriteLiteral(@"
                                        '#6fa2f1',
                                        '#80a3e3',
                                        '#8ea5d5'
                                    ],
                                }]
                            },
                            options: {
                                responsive: true,
                                legend: {
                                    display: true,
                                    position: 'right',
                                    labels: {
                                        fontColor: '#000'
                                    }
                                },
                                layout: {
                                    padding: {
                                        left: 0,
                                        right: 0,
                                        bottom: 0,
                                        top: 0
                                    }
      ");
            WriteLiteral(@"                          },
                                tooltips: {
                                    enabled: false
                                }
                            }
                        });
                    </script>
                </div>
                <div class=""card-body"">
                    <h4 class=""card-title"">Gráfica de Distribución Anual</h4>
                </div>
            </div>
        </div>
        <div class=""col-12 col-md-6"" style=""margin-top:3rem;"">
            <div class=""card"">
                <div style=""margin:1rem;"">
                    <canvas id=""myChart2""></canvas>
                    <script>
                        let myChart2 = document.getElementById('myChart2').getContext('2d');
                        let massPopChart1 = new Chart(myChart2, {
                            type: 'bar', // bar, horizontalBar, pie, line, doughnut, radar, polarArea
                            data: {
                                labels: ['G");
            WriteLiteral(@"uajoyo', 'Cerrón Grande', '5 de Noviembre', '15 de Septiembre'],
                                datasets: [{
                                    label: 'KW',
                                    data: [
                                        10,
                                        20,
                                        40,
                                        5,
                                        0
                                    ],
                                    //backgroundColor:'green',
                                    backgroundColor: [
                                        '#9aff8f',
                                        '#a4f699',
                                        '#adeda3',
                                        '#b5e4ac'
                                    ],
                                }]
                            },
                            options: {
                                legend: {
                                    d");
            WriteLiteral(@"isplay: true,
                                    position: 'right',
                                    labels: {
                                        fontColor: '#000'
                                    }
                                },
                                layout: {
                                    padding: {
                                        left: 0,
                                        right: 0,
                                        bottom: 0,
                                        top: 0
                                    }
                                },
                                tooltips: {
                                    enabled: true
                                }
                            }
                        });
                    </script>
                </div>
                <div class=""card-body"">
                    <h4 class=""card-title"">Gráfica de Distribución Mensual</h4>
                </div>
            <");
            WriteLiteral(@"/div>
        </div>
    </div>
    <div class=""row"" style=""margin-left:1rem; margin-right:1rem;"">
        <div class=""col-12 col-md-12"" style=""margin-top:3rem;"">
            <div class=""card"">
                <div style=""margin:1rem;"">
                    <canvas id=""myChart3""></canvas>
                    <script>
                        let myChart3 = document.getElementById('myChart3').getContext('2d');

                        let massPopChart3 = new Chart(myChart3, {
                            type: 'bar', // bar, horizontalBar, pie, line, doughnut, radar, polarArea
                            data: {
                                labels: ['Guajoyo', 'Cerrón Grande', '5 de Noviembre', '15 de Septiembre'],
                                datasets: [{
                                    label: 'KW',
                                    data: [
                                        10,
                                        20,
                                        40,
         ");
            WriteLiteral(@"                               5,
                                        0
                                    ],
                                    //backgroundColor:'green',
                                    backgroundColor: [
                                        '#76ffd8',
                                        '#88f4d3',
                                        '#96e9ce',
                                        '#a1ddc9'
                                    ],
                                }]
                            },
                            options: {
                                legend: {
                                    display: true,
                                    position: 'right',
                                    labels: {
                                        fontColor: '#000'
                                    }
                                },
                                layout: {
                                    padding: {
        ");
            WriteLiteral(@"                                left: 0,
                                        right: 0,
                                        bottom: 0,
                                        top: 0
                                    }
                                },
                                tooltips: {
                                    enabled: true
                                }
                            }
                        });
                    </script>
                </div>
                <div class=""card-body"">
                    <h4 class=""card-title"">Gráfica de Distribución Semanal</h4>
                </div>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cambio_Climático.Pages.GraphicsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Cambio_Climático.Pages.GraphicsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Cambio_Climático.Pages.GraphicsModel>)PageContext?.ViewData;
        public Cambio_Climático.Pages.GraphicsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
