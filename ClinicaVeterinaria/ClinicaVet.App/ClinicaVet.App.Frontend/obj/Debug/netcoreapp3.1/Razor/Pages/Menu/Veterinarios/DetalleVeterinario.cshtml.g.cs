#pragma checksum "C:\Users\LENOVO\ClinicaVeterinaria\ClinicaVeterinaria\ClinicaVet.App\ClinicaVet.App.Frontend\Pages\Menu\Veterinarios\DetalleVeterinario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4bfefe63eb1cfbffba43d6f0ced5b6fd293b128"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ClinicaVet.App.Frontend.Pages.Menu.Veterinarios.Pages_Menu_Veterinarios_DetalleVeterinario), @"mvc.1.0.razor-page", @"/Pages/Menu/Veterinarios/DetalleVeterinario.cshtml")]
namespace ClinicaVet.App.Frontend.Pages.Menu.Veterinarios
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
#line 1 "C:\Users\LENOVO\ClinicaVeterinaria\ClinicaVeterinaria\ClinicaVet.App\ClinicaVet.App.Frontend\Pages\_ViewImports.cshtml"
using ClinicaVet.App.Frontend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\LENOVO\ClinicaVeterinaria\ClinicaVeterinaria\ClinicaVet.App\ClinicaVet.App.Frontend\Pages\Menu\Veterinarios\DetalleVeterinario.cshtml"
using ClinicaVet.App.Dominio;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4bfefe63eb1cfbffba43d6f0ced5b6fd293b128", @"/Pages/Menu/Veterinarios/DetalleVeterinario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69a9b19bf23dd3a07ff990a921811dbb5fe8b97a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Menu_Veterinarios_DetalleVeterinario : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Detalle del veterinario ");
#nullable restore
#line 6 "C:\Users\LENOVO\ClinicaVeterinaria\ClinicaVeterinaria\ClinicaVet.App\ClinicaVet.App.Frontend\Pages\Menu\Veterinarios\DetalleVeterinario.cshtml"
                       Write(Model.veterinario.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<ul>\r\n    <li>Cedula: ");
#nullable restore
#line 8 "C:\Users\LENOVO\ClinicaVeterinaria\ClinicaVeterinaria\ClinicaVet.App\ClinicaVet.App.Frontend\Pages\Menu\Veterinarios\DetalleVeterinario.cshtml"
           Write(Model.veterinario.cedula);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Nombre: ");
#nullable restore
#line 9 "C:\Users\LENOVO\ClinicaVeterinaria\ClinicaVeterinaria\ClinicaVet.App\ClinicaVet.App.Frontend\Pages\Menu\Veterinarios\DetalleVeterinario.cshtml"
           Write(Model.veterinario.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Apellido: ");
#nullable restore
#line 10 "C:\Users\LENOVO\ClinicaVeterinaria\ClinicaVeterinaria\ClinicaVet.App\ClinicaVet.App.Frontend\Pages\Menu\Veterinarios\DetalleVeterinario.cshtml"
             Write(Model.veterinario.apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Celular: ");
#nullable restore
#line 11 "C:\Users\LENOVO\ClinicaVeterinaria\ClinicaVeterinaria\ClinicaVet.App\ClinicaVet.App.Frontend\Pages\Menu\Veterinarios\DetalleVeterinario.cshtml"
            Write(Model.veterinario.celular);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Dirección: ");
#nullable restore
#line 12 "C:\Users\LENOVO\ClinicaVeterinaria\ClinicaVeterinaria\ClinicaVet.App\ClinicaVet.App.Frontend\Pages\Menu\Veterinarios\DetalleVeterinario.cshtml"
              Write(Model.veterinario.direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Ciudad: ");
#nullable restore
#line 13 "C:\Users\LENOVO\ClinicaVeterinaria\ClinicaVeterinaria\ClinicaVet.App\ClinicaVet.App.Frontend\Pages\Menu\Veterinarios\DetalleVeterinario.cshtml"
           Write(Model.veterinario.ciudad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Correl Electronico: ");
#nullable restore
#line 14 "C:\Users\LENOVO\ClinicaVeterinaria\ClinicaVeterinaria\ClinicaVet.App\ClinicaVet.App.Frontend\Pages\Menu\Veterinarios\DetalleVeterinario.cshtml"
                       Write(Model.veterinario.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClinicaVet.App.Frontend.Pages.DetalleVeterinarioModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ClinicaVet.App.Frontend.Pages.DetalleVeterinarioModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ClinicaVet.App.Frontend.Pages.DetalleVeterinarioModel>)PageContext?.ViewData;
        public ClinicaVet.App.Frontend.Pages.DetalleVeterinarioModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
