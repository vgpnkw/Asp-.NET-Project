#pragma checksum "/Users/gapankowwitalik/Projects/WikiPedia/Views/Home/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c65f88e70582d1a17b19de220da61836fb202610"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "/Users/gapankowwitalik/Projects/WikiPedia/Views/_ViewImports.cshtml"
using WikiPedia;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/gapankowwitalik/Projects/WikiPedia/Views/_ViewImports.cshtml"
using WikiPedia.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/gapankowwitalik/Projects/WikiPedia/Views/Home/Details.cshtml"
using System.Net;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c65f88e70582d1a17b19de220da61836fb202610", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"465905ce789ce36220b74026b0164bc93dbb01aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WikiPedia.Models.Publication>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-block btn-outline-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-block btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/gapankowwitalik/Projects/WikiPedia/Views/Home/Details.cshtml"
  
    ViewBag.Title = Model.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"container-fluid\">\n    <div class=\"row\">\n        <div class=\"col-md-12\">\n            <div class=\"page-header\">\n                <h1>\n                    ");
#nullable restore
#line 13 "/Users/gapankowwitalik/Projects/WikiPedia/Views/Home/Details.cshtml"
               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </h1>\n            </div>\n        </div>\n    </div>\n    <div class=\"row\">\n        <div class=\"col-md-9\">\n            <p class=\"text-left\">\n                ");
#nullable restore
#line 21 "/Users/gapankowwitalik/Projects/WikiPedia/Views/Home/Details.cshtml"
           Write(Model.Info);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </p>\n        </div>\n        <div class=\"col-md-1\">\n        </div>\n        <div class=\"col-md-2\" style=\"margin: 0 auto;\">\n");
#nullable restore
#line 27 "/Users/gapankowwitalik/Projects/WikiPedia/Views/Home/Details.cshtml"
             if (string.IsNullOrEmpty(@Model.Image.Path))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img alt=\"Bootstrap Image Preview\"");
            BeginWriteAttribute("src", " src=\"", 705, "\"", 779, 2);
            WriteAttributeValue("", 711, "data:image/jpeg;base64,", 711, 23, true);
#nullable restore
#line 29 "/Users/gapankowwitalik/Projects/WikiPedia/Views/Home/Details.cshtml"
WriteAttributeValue("", 734, Convert.ToBase64String(@Model.Image.Image), 734, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\" width: 350px; margin-bottom: 60px; padding: 45px 45px 70px 45px; display: inline-block; margin-right: 90px; \">\n");
#nullable restore
#line 30 "/Users/gapankowwitalik/Projects/WikiPedia/Views/Home/Details.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img alt=\"Bootstrap Image Preview\"");
            BeginWriteAttribute("src", " src=\"", 995, "\"", 1018, 1);
#nullable restore
#line 33 "/Users/gapankowwitalik/Projects/WikiPedia/Views/Home/Details.cshtml"
WriteAttributeValue("", 1001, Model.Image.Path, 1001, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\" width: 350px; margin-bottom: 60px; padding: 45px 45px 70px 45px; display: inline-block; margin-right: 90px; \">\n");
#nullable restore
#line 34 "/Users/gapankowwitalik/Projects/WikiPedia/Views/Home/Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n\n");
#nullable restore
#line 38 "/Users/gapankowwitalik/Projects/WikiPedia/Views/Home/Details.cshtml"
     foreach (var item in Model.Parts)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\n            <div class=\"col-md-12\">\n                <h2>\n                    ");
#nullable restore
#line 44 "/Users/gapankowwitalik/Projects/WikiPedia/Views/Home/Details.cshtml"
               Write(item.PartName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </h2>\n                <p>\n                    ");
#nullable restore
#line 47 "/Users/gapankowwitalik/Projects/WikiPedia/Views/Home/Details.cshtml"
               Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </p>\n            </div>\n        </div>\n        <div class=\"row\">\n            <div class=\"col-md-4\">\n            </div>\n            <div class=\"col-md-4\">\n");
#nullable restore
#line 55 "/Users/gapankowwitalik/Projects/WikiPedia/Views/Home/Details.cshtml"
                 if (string.IsNullOrEmpty(item.Image.Path))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <img class=\"img-thumbnail\" alt=\"Bootstrap Image Preview\"");
            BeginWriteAttribute("src", " src=\"", 1741, "\"", 1814, 2);
            WriteAttributeValue("", 1747, "data:image/jpeg;base64,", 1747, 23, true);
#nullable restore
#line 57 "/Users/gapankowwitalik/Projects/WikiPedia/Views/Home/Details.cshtml"
WriteAttributeValue("", 1770, Convert.ToBase64String(@item.Image.Image), 1770, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n");
#nullable restore
#line 58 "/Users/gapankowwitalik/Projects/WikiPedia/Views/Home/Details.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <img alt=\"Bootstrap Image Preview\"");
            BeginWriteAttribute("src", " src=\"", 1928, "\"", 1950, 1);
#nullable restore
#line 61 "/Users/gapankowwitalik/Projects/WikiPedia/Views/Home/Details.cshtml"
WriteAttributeValue("", 1934, item.Image.Path, 1934, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail\">\n");
#nullable restore
#line 62 "/Users/gapankowwitalik/Projects/WikiPedia/Views/Home/Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"text-center\">\n                    ");
#nullable restore
#line 64 "/Users/gapankowwitalik/Projects/WikiPedia/Views/Home/Details.cshtml"
               Write(item.Image.PictureText);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </p>\n            </div>\n            <div class=\"col-md-4\">\n            </div>\n        </div>\n");
#nullable restore
#line 70 "/Users/gapankowwitalik/Projects/WikiPedia/Views/Home/Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <div class=\"row\">\n        \n        <div class=\"col-md-8\">\n        </div>\n        <div class=\"col-md-2\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c65f88e70582d1a17b19de220da61836fb20261011405", async() => {
                WriteLiteral("\n                Изменить\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 77 "/Users/gapankowwitalik/Projects/WikiPedia/Views/Home/Details.cshtml"
                                                                                                                 WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c65f88e70582d1a17b19de220da61836fb20261013999", async() => {
                WriteLiteral("\n                Удалить\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 80 "/Users/gapankowwitalik/Projects/WikiPedia/Views/Home/Details.cshtml"
                                                                                                                  WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WikiPedia.Models.Publication> Html { get; private set; }
    }
}
#pragma warning restore 1591
