#pragma checksum "D:\Github\APIConsume\APIConsume\Views\NseData\Away52WeekLow.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4ae59730809ba85dad65dee75c3f9230ce674d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NseData_Away52WeekLow), @"mvc.1.0.view", @"/Views/NseData/Away52WeekLow.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/NseData/Away52WeekLow.cshtml", typeof(AspNetCore.Views_NseData_Away52WeekLow))]
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
#line 1 "D:\Github\APIConsume\APIConsume\Views\_ViewImports.cshtml"
using APIConsume;

#line default
#line hidden
#line 2 "D:\Github\APIConsume\APIConsume\Views\_ViewImports.cshtml"
using APIConsume.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4ae59730809ba85dad65dee75c3f9230ce674d0", @"/Views/NseData/Away52WeekLow.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cdf86589270383d85070db0dfa7c55a4d46ec49", @"/Views/_ViewImports.cshtml")]
    public class Views_NseData_Away52WeekLow : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<APIConsume.Models.SMAT>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Github\APIConsume\APIConsume\Views\NseData\Away52WeekLow.cshtml"
  
    ViewData["Title"] = "Away52WeekLow";

#line default
#line hidden
            BeginContext(95, 26, true);
            WriteLiteral("\r\n<h1>Away52WeekLow</h1>\r\n");
            EndContext();
            BeginContext(121, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7765970da29e4c25999e78509445f7db", async() => {
                BeginContext(143, 20, true);
                WriteLiteral(" Back TO ALL Records");
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
            BeginContext(167, 88, true);
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(256, 38, false);
#line 14 "D:\Github\APIConsume\APIConsume\Views\NseData\Away52WeekLow.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(294, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(350, 42, false);
#line 17 "D:\Github\APIConsume\APIConsume\Views\NseData\Away52WeekLow.cshtml"
           Write(Html.DisplayNameFor(model => model.SYMBOL));

#line default
#line hidden
            EndContext();
            BeginContext(392, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(448, 45, false);
#line 20 "D:\Github\APIConsume\APIConsume\Views\NseData\Away52WeekLow.cshtml"
           Write(Html.DisplayNameFor(model => model.TIMESTAMP));

#line default
#line hidden
            EndContext();
            BeginContext(493, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(549, 41, false);
#line 23 "D:\Github\APIConsume\APIConsume\Views\NseData\Away52WeekLow.cshtml"
           Write(Html.DisplayNameFor(model => model.CLOSE));

#line default
#line hidden
            EndContext();
            BeginContext(590, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(646, 40, false);
#line 26 "D:\Github\APIConsume\APIConsume\Views\NseData\Away52WeekLow.cshtml"
           Write(Html.DisplayNameFor(model => model.HIGH));

#line default
#line hidden
            EndContext();
            BeginContext(686, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(742, 39, false);
#line 29 "D:\Github\APIConsume\APIConsume\Views\NseData\Away52WeekLow.cshtml"
           Write(Html.DisplayNameFor(model => model.LOW));

#line default
#line hidden
            EndContext();
            BeginContext(781, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(837, 42, false);
#line 32 "D:\Github\APIConsume\APIConsume\Views\NseData\Away52WeekLow.cshtml"
           Write(Html.DisplayNameFor(model => model.Volume));

#line default
#line hidden
            EndContext();
            BeginContext(879, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(935, 41, false);
#line 35 "D:\Github\APIConsume\APIConsume\Views\NseData\Away52WeekLow.cshtml"
           Write(Html.DisplayNameFor(model => model.sma05));

#line default
#line hidden
            EndContext();
            BeginContext(976, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1032, 41, false);
#line 38 "D:\Github\APIConsume\APIConsume\Views\NseData\Away52WeekLow.cshtml"
           Write(Html.DisplayNameFor(model => model.sma10));

#line default
#line hidden
            EndContext();
            BeginContext(1073, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1129, 41, false);
#line 41 "D:\Github\APIConsume\APIConsume\Views\NseData\Away52WeekLow.cshtml"
           Write(Html.DisplayNameFor(model => model.sma15));

#line default
#line hidden
            EndContext();
            BeginContext(1170, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1226, 41, false);
#line 44 "D:\Github\APIConsume\APIConsume\Views\NseData\Away52WeekLow.cshtml"
           Write(Html.DisplayNameFor(model => model.sma20));

#line default
#line hidden
            EndContext();
            BeginContext(1267, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1323, 41, false);
#line 47 "D:\Github\APIConsume\APIConsume\Views\NseData\Away52WeekLow.cshtml"
           Write(Html.DisplayNameFor(model => model.sma50));

#line default
#line hidden
            EndContext();
            BeginContext(1364, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1420, 42, false);
#line 50 "D:\Github\APIConsume\APIConsume\Views\NseData\Away52WeekLow.cshtml"
           Write(Html.DisplayNameFor(model => model.sma200));

#line default
#line hidden
            EndContext();
            BeginContext(1462, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1518, 65, false);
#line 53 "D:\Github\APIConsume\APIConsume\Views\NseData\Away52WeekLow.cshtml"
           Write(Html.DisplayNameFor(model => model.Percent_of_Price_Change5_days));

#line default
#line hidden
            EndContext();
            BeginContext(1583, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1639, 58, false);
#line 56 "D:\Github\APIConsume\APIConsume\Views\NseData\Away52WeekLow.cshtml"
           Write(Html.DisplayNameFor(model => model.Volume_changein_20Days));

#line default
#line hidden
            EndContext();
            BeginContext(1697, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1753, 51, false);
#line 59 "D:\Github\APIConsume\APIConsume\Views\NseData\Away52WeekLow.cshtml"
           Write(Html.DisplayNameFor(model => model.Relative_Volume));

#line default
#line hidden
            EndContext();
            BeginContext(1804, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1860, 46, false);
#line 62 "D:\Github\APIConsume\APIConsume\Views\NseData\Away52WeekLow.cshtml"
           Write(Html.DisplayNameFor(model => model.WeekHigh52));

#line default
#line hidden
            EndContext();
            BeginContext(1906, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1962, 45, false);
#line 65 "D:\Github\APIConsume\APIConsume\Views\NseData\Away52WeekLow.cshtml"
           Write(Html.DisplayNameFor(model => model.WeekLow52));

#line default
#line hidden
            EndContext();
            BeginContext(2007, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2063, 56, false);
#line 68 "D:\Github\APIConsume\APIConsume\Views\NseData\Away52WeekLow.cshtml"
           Write(Html.DisplayNameFor(model => model.Away_From_52WeekHigh));

#line default
#line hidden
            EndContext();
            BeginContext(2119, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2175, 55, false);
#line 71 "D:\Github\APIConsume\APIConsume\Views\NseData\Away52WeekLow.cshtml"
           Write(Html.DisplayNameFor(model => model.Away_From_52WeekLow));

#line default
#line hidden
            EndContext();
            BeginContext(2230, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 77 "D:\Github\APIConsume\APIConsume\Views\NseData\Away52WeekLow.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(2348, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2397, 37, false);
#line 80 "D:\Github\APIConsume\APIConsume\Views\NseData\Away52WeekLow.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2434, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2490, 41, false);
#line 83 "D:\Github\APIConsume\APIConsume\Views\NseData\Away52WeekLow.cshtml"
           Write(Html.DisplayFor(modelItem => item.SYMBOL));

#line default
#line hidden
            EndContext();
            BeginContext(2531, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2587, 44, false);
#line 86 "D:\Github\APIConsume\APIConsume\Views\NseData\Away52WeekLow.cshtml"
           Write(Html.DisplayFor(modelItem => item.TIMESTAMP));

#line default
#line hidden
            EndContext();
            BeginContext(2631, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2687, 40, false);
#line 89 "D:\Github\APIConsume\APIConsume\Views\NseData\Away52WeekLow.cshtml"
           Write(Html.DisplayFor(modelItem => item.CLOSE));

#line default
#line hidden
            EndContext();
            BeginContext(2727, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2783, 39, false);
#line 92 "D:\Github\APIConsume\APIConsume\Views\NseData\Away52WeekLow.cshtml"
           Write(Html.DisplayFor(modelItem => item.HIGH));

#line default
#line hidden
            EndContext();
            BeginContext(2822, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2878, 38, false);
#line 95 "D:\Github\APIConsume\APIConsume\Views\NseData\Away52WeekLow.cshtml"
           Write(Html.DisplayFor(modelItem => item.LOW));

#line default
#line hidden
            EndContext();
            BeginContext(2916, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2972, 41, false);
#line 98 "D:\Github\APIConsume\APIConsume\Views\NseData\Away52WeekLow.cshtml"
           Write(Html.DisplayFor(modelItem => item.Volume));

#line default
#line hidden
            EndContext();
            BeginContext(3013, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3069, 40, false);
#line 101 "D:\Github\APIConsume\APIConsume\Views\NseData\Away52WeekLow.cshtml"
           Write(Html.DisplayFor(modelItem => item.sma05));

#line default
#line hidden
            EndContext();
            BeginContext(3109, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3165, 40, false);
#line 104 "D:\Github\APIConsume\APIConsume\Views\NseData\Away52WeekLow.cshtml"
           Write(Html.DisplayFor(modelItem => item.sma10));

#line default
#line hidden
            EndContext();
            BeginContext(3205, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3261, 40, false);
#line 107 "D:\Github\APIConsume\APIConsume\Views\NseData\Away52WeekLow.cshtml"
           Write(Html.DisplayFor(modelItem => item.sma15));

#line default
#line hidden
            EndContext();
            BeginContext(3301, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3357, 40, false);
#line 110 "D:\Github\APIConsume\APIConsume\Views\NseData\Away52WeekLow.cshtml"
           Write(Html.DisplayFor(modelItem => item.sma20));

#line default
#line hidden
            EndContext();
            BeginContext(3397, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3453, 40, false);
#line 113 "D:\Github\APIConsume\APIConsume\Views\NseData\Away52WeekLow.cshtml"
           Write(Html.DisplayFor(modelItem => item.sma50));

#line default
#line hidden
            EndContext();
            BeginContext(3493, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3549, 41, false);
#line 116 "D:\Github\APIConsume\APIConsume\Views\NseData\Away52WeekLow.cshtml"
           Write(Html.DisplayFor(modelItem => item.sma200));

#line default
#line hidden
            EndContext();
            BeginContext(3590, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3646, 64, false);
#line 119 "D:\Github\APIConsume\APIConsume\Views\NseData\Away52WeekLow.cshtml"
           Write(Html.DisplayFor(modelItem => item.Percent_of_Price_Change5_days));

#line default
#line hidden
            EndContext();
            BeginContext(3710, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3766, 57, false);
#line 122 "D:\Github\APIConsume\APIConsume\Views\NseData\Away52WeekLow.cshtml"
           Write(Html.DisplayFor(modelItem => item.Volume_changein_20Days));

#line default
#line hidden
            EndContext();
            BeginContext(3823, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3879, 50, false);
#line 125 "D:\Github\APIConsume\APIConsume\Views\NseData\Away52WeekLow.cshtml"
           Write(Html.DisplayFor(modelItem => item.Relative_Volume));

#line default
#line hidden
            EndContext();
            BeginContext(3929, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3985, 45, false);
#line 128 "D:\Github\APIConsume\APIConsume\Views\NseData\Away52WeekLow.cshtml"
           Write(Html.DisplayFor(modelItem => item.WeekHigh52));

#line default
#line hidden
            EndContext();
            BeginContext(4030, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4086, 44, false);
#line 131 "D:\Github\APIConsume\APIConsume\Views\NseData\Away52WeekLow.cshtml"
           Write(Html.DisplayFor(modelItem => item.WeekLow52));

#line default
#line hidden
            EndContext();
            BeginContext(4130, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4186, 55, false);
#line 134 "D:\Github\APIConsume\APIConsume\Views\NseData\Away52WeekLow.cshtml"
           Write(Html.DisplayFor(modelItem => item.Away_From_52WeekHigh));

#line default
#line hidden
            EndContext();
            BeginContext(4241, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4297, 54, false);
#line 137 "D:\Github\APIConsume\APIConsume\Views\NseData\Away52WeekLow.cshtml"
           Write(Html.DisplayFor(modelItem => item.Away_From_52WeekLow));

#line default
#line hidden
            EndContext();
            BeginContext(4351, 50, true);
            WriteLiteral("\r\n            </td>\r\n            \r\n        </tr>\r\n");
            EndContext();
#line 141 "D:\Github\APIConsume\APIConsume\Views\NseData\Away52WeekLow.cshtml"
}

#line default
#line hidden
            BeginContext(4404, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<APIConsume.Models.SMAT>> Html { get; private set; }
    }
}
#pragma warning restore 1591
