#pragma checksum "C:\Users\Esibartels\source\repos\PizzaUI\PizzaUI\Views\MainMenu\Calzone.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a30fe2ea934b88162704ca29217ddb45a0fb869"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MainMenu_Calzone), @"mvc.1.0.view", @"/Views/MainMenu/Calzone.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MainMenu/Calzone.cshtml", typeof(AspNetCore.Views_MainMenu_Calzone))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a30fe2ea934b88162704ca29217ddb45a0fb869", @"/Views/MainMenu/Calzone.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771e515348ebdc70d85a14b8b2fc0ecb74bfe0a0", @"/Views/_ViewImports.cshtml")]
    public class Views_MainMenu_Calzone : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.UIHelperModel<List<Entities.Product>, Dictionary<string, string>>>
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
            BeginContext(83, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Esibartels\source\repos\PizzaUI\PizzaUI\Views\MainMenu\Calzone.cshtml"
  
    ViewData["Title"] = "Safari Pizza";
    Layout = "~/Views/Shared/_LayoutOrderMenu.cshtml";

#line default
#line hidden
            BeginContext(189, 84, true);
            WriteLiteral("\r\n\r\n<div class=\"container\" style=\" padding-top:5%;\">\r\n    <h1>Calzone Options</h1>\r\n");
            EndContext();
#line 11 "C:\Users\Esibartels\source\repos\PizzaUI\PizzaUI\Views\MainMenu\Calzone.cshtml"
     for (var i = 0; i < Model.DataModel.Count; i++)
    {

#line default
#line hidden
            BeginContext(334, 128, true);
            WriteLiteral("        <div class=\"menuitem\">\r\n            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <h3>");
            EndContext();
            BeginContext(463, 53, false);
#line 16 "C:\Users\Esibartels\source\repos\PizzaUI\PizzaUI\Views\MainMenu\Calzone.cshtml"
                   Write(Html.DisplayFor(modelItem => Model.DataModel[i].Name));

#line default
#line hidden
            EndContext();
            BeginContext(516, 31, true);
            WriteLiteral("</h3>\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 547, "\"", 613, 1);
#line 17 "C:\Users\Esibartels\source\repos\PizzaUI\PizzaUI\Views\MainMenu\Calzone.cshtml"
WriteAttributeValue("", 553, Url.Content(Model.ImageDictionary[Model.DataModel[i].Name]), 553, 60, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(614, 52, true);
            WriteLiteral(">\r\n                    <p>\r\n                        ");
            EndContext();
            BeginContext(667, 60, false);
#line 19 "C:\Users\Esibartels\source\repos\PizzaUI\PizzaUI\Views\MainMenu\Calzone.cshtml"
                   Write(Html.DisplayFor(modelItem => Model.DataModel[i].Description));

#line default
#line hidden
            EndContext();
            BeginContext(727, 41, true);
            WriteLiteral(" <span style=\"color:goldenrod\"> $<strong>");
            EndContext();
            BeginContext(769, 54, false);
#line 19 "C:\Users\Esibartels\source\repos\PizzaUI\PizzaUI\Views\MainMenu\Calzone.cshtml"
                                                                                                                         Write(Html.DisplayFor(modelItem => Model.DataModel[i].Price));

#line default
#line hidden
            EndContext();
            BeginContext(823, 48, true);
            WriteLiteral("</strong> </span>\r\n                        <br> ");
            EndContext();
            BeginContext(872, 52, false);
#line 20 "C:\Users\Esibartels\source\repos\PizzaUI\PizzaUI\Views\MainMenu\Calzone.cshtml"
                        Write(Html.DisplayFor(modelItem => Model.DataModel[i].Cal));

#line default
#line hidden
            EndContext();
            BeginContext(924, 171, true);
            WriteLiteral("\r\n                    </p>\r\n                    <br />\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-1\">\r\n                            ");
            EndContext();
            BeginContext(1095, 776, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a30fe2ea934b88162704ca29217ddb45a0fb8698664", async() => {
                BeginContext(1121, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(1155, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a30fe2ea934b88162704ca29217ddb45a0fb8699080", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 26 "C:\Users\Esibartels\source\repos\PizzaUI\PizzaUI\Views\MainMenu\Calzone.cshtml"
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
                BeginContext(1221, 456, true);
                WriteLiteral(@"
                                <div class=""form-group"">
                                    <label name=""qty"" class=""control-label"">Qty</label>
                                    <input name=""qty""  type=""number"" min=""0"" class=""form-control"" />
                                    <span class=""text-danger""></span>
                                </div>
                                <div class=""form-group"">
                                    ");
                EndContext();
                BeginContext(1677, 117, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8a30fe2ea934b88162704ca29217ddb45a0fb86911338", async() => {
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
#line 33 "C:\Users\Esibartels\source\repos\PizzaUI\PizzaUI\Views\MainMenu\Calzone.cshtml"
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
                BeginContext(1794, 70, true);
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
            BeginContext(1871, 122, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 41 "C:\Users\Esibartels\source\repos\PizzaUI\PizzaUI\Views\MainMenu\Calzone.cshtml"
    }

#line default
#line hidden
            BeginContext(2000, 10, true);
            WriteLiteral("</div>\r\n\r\n");
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
