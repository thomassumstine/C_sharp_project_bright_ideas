#pragma checksum "/Users/thomassumstine/Desktop/Professional Career/Coding Dojo/C#_and_dotNet Core/gotimemuthafuckaaaaa/BrightIdeas/Views/BrightIdea/AliasDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bef9090aeb2eb3995c35211515fd799cbcc1f268"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BrightIdea_AliasDetails), @"mvc.1.0.view", @"/Views/BrightIdea/AliasDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BrightIdea/AliasDetails.cshtml", typeof(AspNetCore.Views_BrightIdea_AliasDetails))]
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
#line 1 "/Users/thomassumstine/Desktop/Professional Career/Coding Dojo/C#_and_dotNet Core/gotimemuthafuckaaaaa/BrightIdeas/Views/_ViewImports.cshtml"
using BrightIdeas;

#line default
#line hidden
#line 2 "/Users/thomassumstine/Desktop/Professional Career/Coding Dojo/C#_and_dotNet Core/gotimemuthafuckaaaaa/BrightIdeas/Views/_ViewImports.cshtml"
using BrightIdeas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bef9090aeb2eb3995c35211515fd799cbcc1f268", @"/Views/BrightIdea/AliasDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3089d01e8107546353dc71acbeb0ef609963fe45", @"/Views/_ViewImports.cshtml")]
    public class Views_BrightIdea_AliasDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BrightIdea>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "BrightIdea", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "All", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(18, 131, true);
            WriteLiteral("\n<div class=\"card mx-auto text-center mb-3\" style=\"width: 25rem;\">\n  <div class=\"card-header\">\n    <h5 class=\"card-title\">\n        ");
            EndContext();
            BeginContext(150, 23, false);
#line 6 "/Users/thomassumstine/Desktop/Professional Career/Coding Dojo/C#_and_dotNet Core/gotimemuthafuckaaaaa/BrightIdeas/Views/BrightIdea/AliasDetails.cshtml"
   Write(Model.Author.FullName());

#line default
#line hidden
            EndContext();
            BeginContext(173, 47, true);
            WriteLiteral("\n    </h5>\n    <h5 class=\"card-title\">\n        ");
            EndContext();
            BeginContext(221, 18, false);
#line 9 "/Users/thomassumstine/Desktop/Professional Career/Coding Dojo/C#_and_dotNet Core/gotimemuthafuckaaaaa/BrightIdeas/Views/BrightIdea/AliasDetails.cshtml"
   Write(Model.Author.Alias);

#line default
#line hidden
            EndContext();
            BeginContext(239, 47, true);
            WriteLiteral("\n    </h5>\n    <h5 class=\"card-title\">\n        ");
            EndContext();
            BeginContext(287, 18, false);
#line 12 "/Users/thomassumstine/Desktop/Professional Career/Coding Dojo/C#_and_dotNet Core/gotimemuthafuckaaaaa/BrightIdeas/Views/BrightIdea/AliasDetails.cshtml"
   Write(Model.Author.Email);

#line default
#line hidden
            EndContext();
            BeginContext(305, 51, true);
            WriteLiteral("\n    </h5>\n  </div>\n<div class=\"card-footer\">\n\n    ");
            EndContext();
            BeginContext(356, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bef9090aeb2eb3995c35211515fd799cbcc1f2686458", async() => {
                BeginContext(425, 16, true);
                WriteLiteral("\n      Back\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(445, 2, true);
            WriteLiteral("\n\n");
            EndContext();
#line 21 "/Users/thomassumstine/Desktop/Professional Career/Coding Dojo/C#_and_dotNet Core/gotimemuthafuckaaaaa/BrightIdeas/Views/BrightIdea/AliasDetails.cshtml"
     if (ViewBag.Uid == Model.Author.UserId) {

#line default
#line hidden
            BeginContext(494, 6, true);
            WriteLiteral("      ");
            EndContext();
            BeginContext(500, 135, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bef9090aeb2eb3995c35211515fd799cbcc1f2688444", async() => {
                BeginContext(609, 22, true);
                WriteLiteral("\n        Delete\n      ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 22 "/Users/thomassumstine/Desktop/Professional Career/Coding Dojo/C#_and_dotNet Core/gotimemuthafuckaaaaa/BrightIdeas/Views/BrightIdea/AliasDetails.cshtml"
                                                           WriteLiteral(Model.BrightIdeaId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(635, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 25 "/Users/thomassumstine/Desktop/Professional Career/Coding Dojo/C#_and_dotNet Core/gotimemuthafuckaaaaa/BrightIdeas/Views/BrightIdea/AliasDetails.cshtml"
    }

#line default
#line hidden
            BeginContext(642, 13, true);
            WriteLiteral("</div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BrightIdea> Html { get; private set; }
    }
}
#pragma warning restore 1591
