#pragma checksum "C:\Users\vitor.moreira\git\purchase_list_csharp\purchase_list_csharp\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cce5bafdd7aa86acbcc4607a3d984fcad431725e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Login/Index.cshtml", typeof(AspNetCore.Views_Login_Index))]
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
#line 1 "C:\Users\vitor.moreira\git\purchase_list_csharp\purchase_list_csharp\Views\_ViewImports.cshtml"
using purchase_list_csharp;

#line default
#line hidden
#line 2 "C:\Users\vitor.moreira\git\purchase_list_csharp\purchase_list_csharp\Views\_ViewImports.cshtml"
using purchase_list_csharp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cce5bafdd7aa86acbcc4607a3d984fcad431725e", @"/Views/Login/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdd531d6643d196b5c230783ceda6ce24f94c0b3", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\vitor.moreira\git\purchase_list_csharp\purchase_list_csharp\Views\Login\Index.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
            BeginContext(43, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 7 "C:\Users\vitor.moreira\git\purchase_list_csharp\purchase_list_csharp\Views\Login\Index.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(77, 390, true);
            WriteLiteral(@"    <div class=""login-container"">
        <div class=""login-entry"">
            <p>Login</p>
            <input />
        </div>
        <div class=""login-entry"">
            <p>Password</p>
            <input type=""password"" />
        </div>

        <button id=""login-button"">Entrar</button>
        <div>
            <a>Esqueci minha senha</a>
        </div>
    </div>
");
            EndContext();
#line 24 "C:\Users\vitor.moreira\git\purchase_list_csharp\purchase_list_csharp\Views\Login\Index.cshtml"
}

#line default
#line hidden
            BeginContext(470, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
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