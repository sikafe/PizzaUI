#pragma checksum "C:\Users\Esibartels\source\repos\PizzaUI\PizzaUI\Views\MainMenu\Drinks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4afe35ccdad9345fd5a3a778d6058c32e738183f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MainMenu_Drinks), @"mvc.1.0.view", @"/Views/MainMenu/Drinks.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MainMenu/Drinks.cshtml", typeof(AspNetCore.Views_MainMenu_Drinks))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4afe35ccdad9345fd5a3a778d6058c32e738183f", @"/Views/MainMenu/Drinks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771e515348ebdc70d85a14b8b2fc0ecb74bfe0a0", @"/Views/_ViewImports.cshtml")]
    public class Views_MainMenu_Drinks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.UIHelperModel<List<Entities.Product>, Dictionary<string, string>>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Order Now"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Drinks", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(85, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Esibartels\source\repos\PizzaUI\PizzaUI\Views\MainMenu\Drinks.cshtml"
  
    ViewData["Title"] = "Safari Pizza";
    Layout = "~/Views/Shared/_LayoutOrderMenu.cshtml";

#line default
#line hidden
            BeginContext(191, 255, true);
            WriteLiteral("\r\n<div  style=\"  background-size: cover; background-image:url(https://www.rachaelraymag.com/.image/t_share/MTU2NDUwODUwNjE5Nzk1MTYy/jalapeno-citrus-rickey-5e942422.jpg);\">\r\n<div class=\"container\" style=\" padding-top:5%; \">\r\n    <h1>Beverage Options</h1>\r\n");
            EndContext();
#line 12 "C:\Users\Esibartels\source\repos\PizzaUI\PizzaUI\Views\MainMenu\Drinks.cshtml"
     for (var i = 0; i < Model.DataModel.Count; i++)
    {

#line default
#line hidden
            BeginContext(507, 128, true);
            WriteLiteral("        <div class=\"menuitem\">\r\n            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <h3>");
            EndContext();
            BeginContext(636, 53, false);
#line 17 "C:\Users\Esibartels\source\repos\PizzaUI\PizzaUI\Views\MainMenu\Drinks.cshtml"
                   Write(Html.DisplayFor(modelItem => Model.DataModel[i].Name));

#line default
#line hidden
            EndContext();
            BeginContext(689, 31, true);
            WriteLiteral("</h3>\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 720, "\"", 786, 1);
#line 18 "C:\Users\Esibartels\source\repos\PizzaUI\PizzaUI\Views\MainMenu\Drinks.cshtml"
WriteAttributeValue("", 726, Url.Content(Model.ImageDictionary[Model.DataModel[i].Name]), 726, 60, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(787, 52, true);
            WriteLiteral(">\r\n                    <p>\r\n                        ");
            EndContext();
            BeginContext(840, 60, false);
#line 20 "C:\Users\Esibartels\source\repos\PizzaUI\PizzaUI\Views\MainMenu\Drinks.cshtml"
                   Write(Html.DisplayFor(modelItem => Model.DataModel[i].Description));

#line default
#line hidden
            EndContext();
            BeginContext(900, 41, true);
            WriteLiteral(" <span style=\"color:goldenrod\"> $<strong>");
            EndContext();
            BeginContext(942, 54, false);
#line 20 "C:\Users\Esibartels\source\repos\PizzaUI\PizzaUI\Views\MainMenu\Drinks.cshtml"
                                                                                                                         Write(Html.DisplayFor(modelItem => Model.DataModel[i].Price));

#line default
#line hidden
            EndContext();
            BeginContext(996, 48, true);
            WriteLiteral("</strong> </span>\r\n                        <br> ");
            EndContext();
            BeginContext(1045, 52, false);
#line 21 "C:\Users\Esibartels\source\repos\PizzaUI\PizzaUI\Views\MainMenu\Drinks.cshtml"
                        Write(Html.DisplayFor(modelItem => Model.DataModel[i].Cal));

#line default
#line hidden
            EndContext();
            BeginContext(1097, 171, true);
            WriteLiteral("\r\n                    </p>\r\n                    <br />\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-1\">\r\n                            ");
            EndContext();
            BeginContext(1268, 775, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4afe35ccdad9345fd5a3a778d6058c32e738183f8927", async() => {
                BeginContext(1294, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(1328, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4afe35ccdad9345fd5a3a778d6058c32e738183f9343", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 27 "C:\Users\Esibartels\source\repos\PizzaUI\PizzaUI\Views\MainMenu\Drinks.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1394, 455, true);
                WriteLiteral(@"
                                <div class=""form-group"">
                                    <label name=""qty"" class=""control-label"">Qty</label>
                                    <input name=""qty"" type=""number"" min=""0"" class=""form-control"" />
                                    <span class=""text-danger""></span>
                                </div>
                                <div class=""form-group"">
                                    ");
                EndContext();
                BeginContext(1849, 117, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4afe35ccdad9345fd5a3a778d6058c32e738183f11599", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 34 "C:\Users\Esibartels\source\repos\PizzaUI\PizzaUI\Views\MainMenu\Drinks.cshtml"
                                                                                                            WriteLiteral(Model.DataModel[i].ProductId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1966, 70, true);
                WriteLiteral("\r\n                                </div>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2043, 122, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 42 "C:\Users\Esibartels\source\repos\PizzaUI\PizzaUI\Views\MainMenu\Drinks.cshtml"
    }

#line default
#line hidden
            BeginContext(2172, 16, true);
            WriteLiteral("</div>\r\n</div>\r\n");
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
