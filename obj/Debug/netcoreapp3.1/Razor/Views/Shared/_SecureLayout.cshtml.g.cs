#pragma checksum "C:\Users\Ivan\source\repos\PKWebApp\Views\Shared\_SecureLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c73d6affbb2057590facf5cbb1db1c7f2c4c9e0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SecureLayout), @"mvc.1.0.view", @"/Views/Shared/_SecureLayout.cshtml")]
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
#line 1 "C:\Users\Ivan\source\repos\PKWebApp\Views\_ViewImports.cshtml"
using PKWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ivan\source\repos\PKWebApp\Views\_ViewImports.cshtml"
using PKWebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ivan\source\repos\PKWebApp\Views\_ViewImports.cshtml"
using PKWebApp.Data.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c73d6affbb2057590facf5cbb1db1c7f2c4c9e0b", @"/Views/Shared/_SecureLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d777c7b5eb08e4c4b213812fa627502657d7b7d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__SecureLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Ivan\source\repos\PKWebApp\Views\Shared\_SecureLayout.cshtml"
  
    Layout = "_MasterLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!--   Header  -->
            <header class=""secureLayout"">
                <nav class=""top-nav blue-grey lighten-1"">
                    <div class=""nav-wrapper row valign-wrapper"">
                        <a href=""#"" data-activates=""nav-mobile"" 
                           class=""button-collapse top-nav full 
                           hide-on-large-only white text-accent-1"">
                           <i class=""material-icons"">menu</i>
                        </a>
");
            WriteLiteral(@"                    </div>
                </nav>

        <!--   Sidebar  -->
                <ul id=""nav-mobile"" class=""sidenav-fixed"">
                    <li>Dashboard</li>
                    <li>User Administration</li>
                    <li>Service Requests</li>
                    <li>Service Notifications</li>
                    <li>Promotion</li>
                    <li>Settings</li>
                    <li>Logout</li>
                </ul>
            </header>

            <!--   Content Page  -->
            <main class=""secureLayout"">
                <div class=""row margin-bottom-0px"">
                    <div class=""col s12"">
                        ");
#nullable restore
#line 35 "C:\Users\Ivan\source\repos\PKWebApp\Views\Shared\_SecureLayout.cshtml"
                   Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </main>

            <!--   Footer  -->
            <footer class=""page-footer blue-grey lighten-1 secureLayout"">
                <div class=""row"">
                    <div class=""col l6 s12"">
                        <h4>About Us</h4>
                        <p>Text about company</p>
                    </div>
                    <div class=""col l3 s12"">
                        <h4>Additional Services</h4>
                        <ul>
                            <li>Services</li>
                            <li>Career</li>
                        </ul>
                    </div>
                    <div class=""col l3 s12"">
                        <h4>Connect</h4>
                        <ul>
                            <li>Facebook</li>
                            <li>Linkedin</li>
                            <li>Twitter</li>
                            <li>Youtube</li>
                        </ul>
                    <");
            WriteLiteral(@"/div>
                </div>
                <div class=""footer-copyright row margin-bottom-0px"">
                    <div class=""col s12"">
                        Made by 
                        <a class=""brown-text text-lighten-3"" 
                                   href=""http://materializecss.com"">
                        Materialize
                        </a>
                    </div>
                </div>
            </footer>
");
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
