#pragma checksum "C:\Users\vycch\OneDrive\Documentos\Netcore3.1\Biblioteca\Views\Usuario\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f31ea62e70ba2c243c6765d8cf45f7ca987dc1ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Listagem), @"mvc.1.0.view", @"/Views/Usuario/Listagem.cshtml")]
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
#line 1 "C:\Users\vycch\OneDrive\Documentos\Netcore3.1\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vycch\OneDrive\Documentos\Netcore3.1\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f31ea62e70ba2c243c6765d8cf45f7ca987dc1ac", @"/Views/Usuario/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\vycch\OneDrive\Documentos\Netcore3.1\Biblioteca\Views\Usuario\Listagem.cshtml"
  
    ViewData["Title"] = "Listagem de Usuário";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
<script>
    $(document).ready(function () {
        $('#tabelaPagin').DataTable({
            ""language"": {
                ""lengthMenu"": ""Mostrando _MENU_ registros por página"",
                ""zeroRecords"": ""Nenhum registro encontrado"",
                ""info"": ""Mostrando página _PAGE_ de _PAGES_"",
                ""infoEmpty"": ""Nenhum registro encontrado"",
                ""infoFiltered"": ""(filtrado de _MAX_ registros no total)""
            }
        });
    });
</script>

<script type=""text/javascript"" src=""https://cdn.datatables.net/1.10.24/js/dataTables.bootstrap4.min.js""></script>

");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n<link rel=\"Stylesheet\" href=\"https://cdn.datatables.net/1.10.24/css/dataTables.bootstrap4.min.css\" />\r\n");
            }
            );
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"">
        <table class=""table table-striped"" id=""tabelaPagin"">
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Nome</th>
                    <th>Login</th>
                    <th>Senha</th>
                    <th></th>
                    <th></th>

                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 44 "C:\Users\vycch\OneDrive\Documentos\Netcore3.1\Biblioteca\Views\Usuario\Listagem.cshtml"
                 foreach (Usuario u in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 47 "C:\Users\vycch\OneDrive\Documentos\Netcore3.1\Biblioteca\Views\Usuario\Listagem.cshtml"
                       Write(u.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 48 "C:\Users\vycch\OneDrive\Documentos\Netcore3.1\Biblioteca\Views\Usuario\Listagem.cshtml"
                       Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 49 "C:\Users\vycch\OneDrive\Documentos\Netcore3.1\Biblioteca\Views\Usuario\Listagem.cshtml"
                       Write(u.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 50 "C:\Users\vycch\OneDrive\Documentos\Netcore3.1\Biblioteca\Views\Usuario\Listagem.cshtml"
                       Write(u.Senha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 1554, "\"", 1582, 2);
            WriteAttributeValue("", 1561, "/Usuario/Edicao/", 1561, 16, true);
#nullable restore
#line 51 "C:\Users\vycch\OneDrive\Documentos\Netcore3.1\Biblioteca\Views\Usuario\Listagem.cshtml"
WriteAttributeValue("", 1577, u.Id, 1577, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></td>\r\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 1631, "\"", 1660, 2);
            WriteAttributeValue("", 1638, "/Usuario/Remover/", 1638, 17, true);
#nullable restore
#line 52 "C:\Users\vycch\OneDrive\Documentos\Netcore3.1\Biblioteca\Views\Usuario\Listagem.cshtml"
WriteAttributeValue("", 1655, u.Id, 1655, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Remover</a></td>\r\n                    </tr>\r\n");
#nullable restore
#line 54 "C:\Users\vycch\OneDrive\Documentos\Netcore3.1\Biblioteca\Views\Usuario\Listagem.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
