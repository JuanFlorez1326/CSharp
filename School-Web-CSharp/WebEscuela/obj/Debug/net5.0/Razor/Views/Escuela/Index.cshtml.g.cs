#pragma checksum "C:\Users\Juan\Desktop\C#\WebEscuela\WebEscuela\Views\Escuela\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8ac17c87e0fee32fcd10f22be9a16b353f4139b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Escuela_Index), @"mvc.1.0.view", @"/Views/Escuela/Index.cshtml")]
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
#line 1 "C:\Users\Juan\Desktop\C#\WebEscuela\WebEscuela\Views\_ViewImports.cshtml"
using WebEscuela;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Juan\Desktop\C#\WebEscuela\WebEscuela\Views\_ViewImports.cshtml"
using WebEscuela.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8ac17c87e0fee32fcd10f22be9a16b353f4139b", @"/Views/Escuela/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"605ad409ed7b63d06a1515007ee71991213047b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Escuela_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Escuela>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Juan\Desktop\C#\WebEscuela\WebEscuela\Views\Escuela\Index.cshtml"
  
    ViewData["Title"] = "Info Escuela";
    Layout = "Simple";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Escuela: ");
#nullable restore
#line 8 "C:\Users\Juan\Desktop\C#\WebEscuela\WebEscuela\Views\Escuela\Index.cshtml"
        Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n<h2>Nombre: ");
#nullable restore
#line 9 "C:\Users\Juan\Desktop\C#\WebEscuela\WebEscuela\Views\Escuela\Index.cshtml"
       Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h3>Tipo de Escuel: ");
#nullable restore
#line 10 "C:\Users\Juan\Desktop\C#\WebEscuela\WebEscuela\Views\Escuela\Index.cshtml"
               Write(Model.TipoEscuela);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<address>\r\n    <p>Direccion: ");
#nullable restore
#line 12 "C:\Users\Juan\Desktop\C#\WebEscuela\WebEscuela\Views\Escuela\Index.cshtml"
             Write(Model.Dirección);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Pais: ");
#nullable restore
#line 13 "C:\Users\Juan\Desktop\C#\WebEscuela\WebEscuela\Views\Escuela\Index.cshtml"
        Write(Model.Pais);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Ciudad: ");
#nullable restore
#line 14 "C:\Users\Juan\Desktop\C#\WebEscuela\WebEscuela\Views\Escuela\Index.cshtml"
          Write(Model.Ciudad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</address>\r\n<p>Año de fundacion: ");
#nullable restore
#line 16 "C:\Users\Juan\Desktop\C#\WebEscuela\WebEscuela\Views\Escuela\Index.cshtml"
                Write(Model.AñoDeCreacion);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n\r\n<p>");
#nullable restore
#line 18 "C:\Users\Juan\Desktop\C#\WebEscuela\WebEscuela\Views\Escuela\Index.cshtml"
Write(ViewBag.DatoDinamico);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Escuela> Html { get; private set; }
    }
}
#pragma warning restore 1591
