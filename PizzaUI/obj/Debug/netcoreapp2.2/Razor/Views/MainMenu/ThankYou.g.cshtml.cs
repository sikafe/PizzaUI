#pragma checksum "C:\Users\Esibartels\source\repos\PizzaUI\PizzaUI\Views\MainMenu\ThankYou.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcf5a22211efe6b073ed1a338072527572874b7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MainMenu_ThankYou), @"mvc.1.0.view", @"/Views/MainMenu/ThankYou.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MainMenu/ThankYou.cshtml", typeof(AspNetCore.Views_MainMenu_ThankYou))]
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
#line 1 "C:\Users\Esibartels\source\repos\PizzaUI\PizzaUI\Views\_ViewImports.cshtml"
using PizzaUI;

#line default
#line hidden
#line 2 "C:\Users\Esibartels\source\repos\PizzaUI\PizzaUI\Views\_ViewImports.cshtml"
using PizzaUI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcf5a22211efe6b073ed1a338072527572874b7f", @"/Views/MainMenu/ThankYou.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771e515348ebdc70d85a14b8b2fc0ecb74bfe0a0", @"/Views/_ViewImports.cshtml")]
    public class Views_MainMenu_ThankYou : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Esibartels\source\repos\PizzaUI\PizzaUI\Views\MainMenu\ThankYou.cshtml"
  
    ViewData["Title"] = "Safari Pizza";
    Layout = "~/Views/Shared/_LayoutOrderMenu.cshtml";;

#line default
#line hidden
            BeginContext(107, 370, true);
            WriteLiteral(@"

<div class=""text-center"">

    <div class=""centered"" style=""Font-Family:Playball; color: lightseagreen; font-size:100px"">Thank you for your ordering from us! Your Order will be ready for pick up in 30 mminutes</div>

    <div>
        <img src=http://buckspizza.com/wp-content/uploads/2017/05/BP_combined-image-1.jpg style=""width:100%;"">
    </div>
</div>

");
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