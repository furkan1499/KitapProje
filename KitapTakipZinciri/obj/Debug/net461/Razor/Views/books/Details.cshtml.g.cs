#pragma checksum "C:\Users\furkan\source\repos\KitapTakipZinciri\KitapTakipZinciri\Views\books\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "664acfa42906ced960a8700fc4b5f4c0727aac5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_books_Details), @"mvc.1.0.view", @"/Views/books/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/books/Details.cshtml", typeof(AspNetCore.Views_books_Details))]
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
#line 1 "C:\Users\furkan\source\repos\KitapTakipZinciri\KitapTakipZinciri\Views\_ViewImports.cshtml"
using KitapTakipZinciri;

#line default
#line hidden
#line 2 "C:\Users\furkan\source\repos\KitapTakipZinciri\KitapTakipZinciri\Views\_ViewImports.cshtml"
using KitapTakipZinciri.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"664acfa42906ced960a8700fc4b5f4c0727aac5f", @"/Views/books/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf81fa60d81a132f7e6a97f574de82307eaaa829", @"/Views/_ViewImports.cshtml")]
    public class Views_books_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KitapTakipZinciri.Models.book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\furkan\source\repos\KitapTakipZinciri\KitapTakipZinciri\Views\books\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(83, 127, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>book</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(211, 40, false);
#line 14 "C:\Users\furkan\source\repos\KitapTakipZinciri\KitapTakipZinciri\Views\books\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.name));

#line default
#line hidden
            EndContext();
            BeginContext(251, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(315, 36, false);
#line 17 "C:\Users\furkan\source\repos\KitapTakipZinciri\KitapTakipZinciri\Views\books\Details.cshtml"
       Write(Html.DisplayFor(model => model.name));

#line default
#line hidden
            EndContext();
            BeginContext(351, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(414, 46, false);
#line 20 "C:\Users\furkan\source\repos\KitapTakipZinciri\KitapTakipZinciri\Views\books\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.authorName));

#line default
#line hidden
            EndContext();
            BeginContext(460, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(524, 42, false);
#line 23 "C:\Users\furkan\source\repos\KitapTakipZinciri\KitapTakipZinciri\Views\books\Details.cshtml"
       Write(Html.DisplayFor(model => model.authorName));

#line default
#line hidden
            EndContext();
            BeginContext(566, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(629, 41, false);
#line 26 "C:\Users\furkan\source\repos\KitapTakipZinciri\KitapTakipZinciri\Views\books\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.price));

#line default
#line hidden
            EndContext();
            BeginContext(670, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(734, 37, false);
#line 29 "C:\Users\furkan\source\repos\KitapTakipZinciri\KitapTakipZinciri\Views\books\Details.cshtml"
       Write(Html.DisplayFor(model => model.price));

#line default
#line hidden
            EndContext();
            BeginContext(771, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(834, 44, false);
#line 32 "C:\Users\furkan\source\repos\KitapTakipZinciri\KitapTakipZinciri\Views\books\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.discount));

#line default
#line hidden
            EndContext();
            BeginContext(878, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(942, 40, false);
#line 35 "C:\Users\furkan\source\repos\KitapTakipZinciri\KitapTakipZinciri\Views\books\Details.cshtml"
       Write(Html.DisplayFor(model => model.discount));

#line default
#line hidden
            EndContext();
            BeginContext(982, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1045, 43, false);
#line 38 "C:\Users\furkan\source\repos\KitapTakipZinciri\KitapTakipZinciri\Views\books\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.edition));

#line default
#line hidden
            EndContext();
            BeginContext(1088, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1152, 39, false);
#line 41 "C:\Users\furkan\source\repos\KitapTakipZinciri\KitapTakipZinciri\Views\books\Details.cshtml"
       Write(Html.DisplayFor(model => model.edition));

#line default
#line hidden
            EndContext();
            BeginContext(1191, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1254, 40, false);
#line 44 "C:\Users\furkan\source\repos\KitapTakipZinciri\KitapTakipZinciri\Views\books\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ISBN));

#line default
#line hidden
            EndContext();
            BeginContext(1294, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1358, 36, false);
#line 47 "C:\Users\furkan\source\repos\KitapTakipZinciri\KitapTakipZinciri\Views\books\Details.cshtml"
       Write(Html.DisplayFor(model => model.ISBN));

#line default
#line hidden
            EndContext();
            BeginContext(1394, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1457, 45, false);
#line 50 "C:\Users\furkan\source\repos\KitapTakipZinciri\KitapTakipZinciri\Views\books\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.languages));

#line default
#line hidden
            EndContext();
            BeginContext(1502, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1566, 41, false);
#line 53 "C:\Users\furkan\source\repos\KitapTakipZinciri\KitapTakipZinciri\Views\books\Details.cshtml"
       Write(Html.DisplayFor(model => model.languages));

#line default
#line hidden
            EndContext();
            BeginContext(1607, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1670, 46, false);
#line 56 "C:\Users\furkan\source\repos\KitapTakipZinciri\KitapTakipZinciri\Views\books\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.createDate));

#line default
#line hidden
            EndContext();
            BeginContext(1716, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1780, 42, false);
#line 59 "C:\Users\furkan\source\repos\KitapTakipZinciri\KitapTakipZinciri\Views\books\Details.cshtml"
       Write(Html.DisplayFor(model => model.createDate));

#line default
#line hidden
            EndContext();
            BeginContext(1822, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1885, 40, false);
#line 62 "C:\Users\furkan\source\repos\KitapTakipZinciri\KitapTakipZinciri\Views\books\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.size));

#line default
#line hidden
            EndContext();
            BeginContext(1925, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1989, 36, false);
#line 65 "C:\Users\furkan\source\repos\KitapTakipZinciri\KitapTakipZinciri\Views\books\Details.cshtml"
       Write(Html.DisplayFor(model => model.size));

#line default
#line hidden
            EndContext();
            BeginContext(2025, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2088, 46, false);
#line 68 "C:\Users\furkan\source\repos\KitapTakipZinciri\KitapTakipZinciri\Views\books\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.pageNumber));

#line default
#line hidden
            EndContext();
            BeginContext(2134, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2198, 42, false);
#line 71 "C:\Users\furkan\source\repos\KitapTakipZinciri\KitapTakipZinciri\Views\books\Details.cshtml"
       Write(Html.DisplayFor(model => model.pageNumber));

#line default
#line hidden
            EndContext();
            BeginContext(2240, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2303, 44, false);
#line 74 "C:\Users\furkan\source\repos\KitapTakipZinciri\KitapTakipZinciri\Views\books\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.category));

#line default
#line hidden
            EndContext();
            BeginContext(2347, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2411, 40, false);
#line 77 "C:\Users\furkan\source\repos\KitapTakipZinciri\KitapTakipZinciri\Views\books\Details.cshtml"
       Write(Html.DisplayFor(model => model.category));

#line default
#line hidden
            EndContext();
            BeginContext(2451, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2514, 48, false);
#line 80 "C:\Users\furkan\source\repos\KitapTakipZinciri\KitapTakipZinciri\Views\books\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.paperQuality));

#line default
#line hidden
            EndContext();
            BeginContext(2562, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2626, 44, false);
#line 83 "C:\Users\furkan\source\repos\KitapTakipZinciri\KitapTakipZinciri\Views\books\Details.cshtml"
       Write(Html.DisplayFor(model => model.paperQuality));

#line default
#line hidden
            EndContext();
            BeginContext(2670, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2717, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "664acfa42906ced960a8700fc4b5f4c0727aac5f14715", async() => {
                BeginContext(2763, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 88 "C:\Users\furkan\source\repos\KitapTakipZinciri\KitapTakipZinciri\Views\books\Details.cshtml"
                           WriteLiteral(Model.id);

#line default
#line hidden
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
            EndContext();
            BeginContext(2771, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2779, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "664acfa42906ced960a8700fc4b5f4c0727aac5f17049", async() => {
                BeginContext(2801, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2817, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KitapTakipZinciri.Models.book> Html { get; private set; }
    }
}
#pragma warning restore 1591