#pragma checksum "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\Nse\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae98496cbe4adc0f68fa78bed86f3276a6ba31f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Nse_Index), @"mvc.1.0.view", @"/Views/Nse/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Nse/Index.cshtml", typeof(AspNetCore.Views_Nse_Index))]
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
#line 1 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\_ViewImports.cshtml"
using APIConsume;

#line default
#line hidden
#line 2 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\_ViewImports.cshtml"
using APIConsume.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae98496cbe4adc0f68fa78bed86f3276a6ba31f1", @"/Views/Nse/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f13ff418501201ea8561e1073fbcccc4402bb5dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Nse_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<APIConsume.Models.Nse>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\Nse\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(86, 33, true);
            WriteLiteral("\r\n<h2>WatchList</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(119, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dad45f74e6b44c2fb83a7ba04e866f22", async() => {
                BeginContext(142, 20, true);
                WriteLiteral("Create New Watchlist");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(166, 108, true);
            WriteLiteral("\r\n</p>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            \r\n            <th>\r\n                ");
            EndContext();
            BeginContext(275, 50, false);
#line 18 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\Nse\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Watchlist_name));

#line default
#line hidden
            EndContext();
            BeginContext(325, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(381, 42, false);
#line 21 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\Nse\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Symbol));

#line default
#line hidden
            EndContext();
            BeginContext(423, 23, true);
            WriteLiteral("\r\n            </th>\r\n\r\n");
            EndContext();
            BeginContext(657, 65, true);
            WriteLiteral("            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 34 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\Nse\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(754, 62, true);
            WriteLiteral("        <tr>\r\n            \r\n            <td>\r\n                ");
            EndContext();
            BeginContext(817, 49, false);
#line 38 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\Nse\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Watchlist_name));

#line default
#line hidden
            EndContext();
            BeginContext(866, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(922, 41, false);
#line 41 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\Nse\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Symbol));

#line default
#line hidden
            EndContext();
            BeginContext(963, 21, true);
            WriteLiteral("\r\n            </td>\r\n");
            EndContext();
            BeginContext(1193, 34, true);
            WriteLiteral("            <td>\r\n                ");
            EndContext();
            BeginContext(1228, 53, false);
#line 50 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\Nse\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1281, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1302, 59, false);
#line 51 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\Nse\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1361, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1382, 57, false);
#line 52 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\Nse\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1439, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 55 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\Nse\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1478, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<APIConsume.Models.Nse>> Html { get; private set; }
    }
}
#pragma warning restore 1591
