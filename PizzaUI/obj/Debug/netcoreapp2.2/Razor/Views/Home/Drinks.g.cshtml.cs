#pragma checksum "C:\Users\Esibartels\source\repos\PizzaUI\PizzaUI\Views\Home\Drinks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ffecaea0ca8dcb0d1b21a207ecc2fffcb6f66eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Drinks), @"mvc.1.0.view", @"/Views/Home/Drinks.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Drinks.cshtml", typeof(AspNetCore.Views_Home_Drinks))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ffecaea0ca8dcb0d1b21a207ecc2fffcb6f66eb", @"/Views/Home/Drinks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771e515348ebdc70d85a14b8b2fc0ecb74bfe0a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Drinks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.UIHelperModel<List<Entities.Product>, Dictionary<string, string>>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(83, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Esibartels\source\repos\PizzaUI\PizzaUI\Views\Home\Drinks.cshtml"
  
    ViewData["Title"] = "Safari Pizza";
    Layout = "~/Views/Shared/_LayoutWelcome.cshtml";

#line default
#line hidden
            BeginContext(187, 85, true);
            WriteLiteral("\r\n\r\n<div class=\"container\" style=\" padding-top:5%;\">\r\n    <h1>Beverage Options</h1>\r\n");
            EndContext();
#line 11 "C:\Users\Esibartels\source\repos\PizzaUI\PizzaUI\Views\Home\Drinks.cshtml"
     foreach (var product in Model.DataModel)
    {

#line default
#line hidden
            BeginContext(326, 128, true);
            WriteLiteral("        <div class=\"menuitem\">\r\n            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <h3>");
            EndContext();
            BeginContext(455, 42, false);
#line 16 "C:\Users\Esibartels\source\repos\PizzaUI\PizzaUI\Views\Home\Drinks.cshtml"
                   Write(Html.DisplayFor(modelItem => product.Name));

#line default
#line hidden
            EndContext();
            BeginContext(497, 31, true);
            WriteLiteral("</h3>\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 528, "\"", 583, 1);
#line 17 "C:\Users\Esibartels\source\repos\PizzaUI\PizzaUI\Views\Home\Drinks.cshtml"
WriteAttributeValue("", 534, Url.Content(Model.ImageDictionary[product.Name]), 534, 49, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(584, 26, true);
            WriteLiteral(">\r\n                    <p>");
            EndContext();
            BeginContext(611, 49, false);
#line 18 "C:\Users\Esibartels\source\repos\PizzaUI\PizzaUI\Views\Home\Drinks.cshtml"
                  Write(Html.DisplayFor(modelItem => product.Description));

#line default
#line hidden
            EndContext();
            BeginContext(660, 6, true);
            WriteLiteral(" <br> ");
            EndContext();
            BeginContext(667, 41, false);
#line 18 "C:\Users\Esibartels\source\repos\PizzaUI\PizzaUI\Views\Home\Drinks.cshtml"
                                                                          Write(Html.DisplayFor(modelItem => product.Cal));

#line default
#line hidden
            EndContext();
            BeginContext(708, 66, true);
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 22 "C:\Users\Esibartels\source\repos\PizzaUI\PizzaUI\Views\Home\Drinks.cshtml"
    }

#line default
#line hidden
            BeginContext(781, 12, true);
            WriteLiteral("</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities.UIHelperModel<List<Entities.Product>, Dictionary<string, string>>> Html { get; private set; }
    }
}
#pragma warning restore 1591