#pragma checksum "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\Away52WeekHigh.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9dc565601121cbd1746a3f183cae5142662137f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NseData_Away52WeekHigh), @"mvc.1.0.view", @"/Views/NseData/Away52WeekHigh.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/NseData/Away52WeekHigh.cshtml", typeof(AspNetCore.Views_NseData_Away52WeekHigh))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9dc565601121cbd1746a3f183cae5142662137f", @"/Views/NseData/Away52WeekHigh.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f13ff418501201ea8561e1073fbcccc4402bb5dd", @"/Views/_ViewImports.cshtml")]
    public class Views_NseData_Away52WeekHigh : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<APIConsume.Models.SMAT>>
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
#line 3 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\Away52WeekHigh.cshtml"
  
    ViewData["Title"] = "Away52WeekHigh";

#line default
#line hidden
            BeginContext(96, 29, true);
            WriteLiteral("\r\n<h1>Away52WeekHigh</h1>\r\n\r\n");
            EndContext();
            BeginContext(125, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "897876e354184939933e2e07005983e8", async() => {
                BeginContext(147, 20, true);
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
            BeginContext(171, 88, true);
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(260, 38, false);
#line 15 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\Away52WeekHigh.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(298, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(354, 42, false);
#line 18 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\Away52WeekHigh.cshtml"
           Write(Html.DisplayNameFor(model => model.SYMBOL));

#line default
#line hidden
            EndContext();
            BeginContext(396, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(452, 45, false);
#line 21 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\Away52WeekHigh.cshtml"
           Write(Html.DisplayNameFor(model => model.TIMESTAMP));

#line default
#line hidden
            EndContext();
            BeginContext(497, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(553, 41, false);
#line 24 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\Away52WeekHigh.cshtml"
           Write(Html.DisplayNameFor(model => model.CLOSE));

#line default
#line hidden
            EndContext();
            BeginContext(594, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(650, 40, false);
#line 27 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\Away52WeekHigh.cshtml"
           Write(Html.DisplayNameFor(model => model.HIGH));

#line default
#line hidden
            EndContext();
            BeginContext(690, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(746, 39, false);
#line 30 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\Away52WeekHigh.cshtml"
           Write(Html.DisplayNameFor(model => model.LOW));

#line default
#line hidden
            EndContext();
            BeginContext(785, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(841, 42, false);
#line 33 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\Away52WeekHigh.cshtml"
           Write(Html.DisplayNameFor(model => model.Volume));

#line default
#line hidden
            EndContext();
            BeginContext(883, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(939, 41, false);
#line 36 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\Away52WeekHigh.cshtml"
           Write(Html.DisplayNameFor(model => model.sma05));

#line default
#line hidden
            EndContext();
            BeginContext(980, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1036, 41, false);
#line 39 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\Away52WeekHigh.cshtml"
           Write(Html.DisplayNameFor(model => model.sma10));

#line default
#line hidden
            EndContext();
            BeginContext(1077, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1133, 41, false);
#line 42 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\Away52WeekHigh.cshtml"
           Write(Html.DisplayNameFor(model => model.sma15));

#line default
#line hidden
            EndContext();
            BeginContext(1174, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1230, 41, false);
#line 45 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\Away52WeekHigh.cshtml"
           Write(Html.DisplayNameFor(model => model.sma20));

#line default
#line hidden
            EndContext();
            BeginContext(1271, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1327, 41, false);
#line 48 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\Away52WeekHigh.cshtml"
           Write(Html.DisplayNameFor(model => model.sma50));

#line default
#line hidden
            EndContext();
            BeginContext(1368, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1424, 42, false);
#line 51 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\Away52WeekHigh.cshtml"
           Write(Html.DisplayNameFor(model => model.sma200));

#line default
#line hidden
            EndContext();
            BeginContext(1466, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1522, 65, false);
#line 54 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\Away52WeekHigh.cshtml"
           Write(Html.DisplayNameFor(model => model.Percent_of_Price_Change5_days));

#line default
#line hidden
            EndContext();
            BeginContext(1587, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1643, 58, false);
#line 57 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\Away52WeekHigh.cshtml"
           Write(Html.DisplayNameFor(model => model.Volume_changein_20Days));

#line default
#line hidden
            EndContext();
            BeginContext(1701, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1757, 51, false);
#line 60 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\Away52WeekHigh.cshtml"
           Write(Html.DisplayNameFor(model => model.Relative_Volume));

#line default
#line hidden
            EndContext();
            BeginContext(1808, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1864, 46, false);
#line 63 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\Away52WeekHigh.cshtml"
           Write(Html.DisplayNameFor(model => model.WeekHigh52));

#line default
#line hidden
            EndContext();
            BeginContext(1910, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1966, 45, false);
#line 66 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\Away52WeekHigh.cshtml"
           Write(Html.DisplayNameFor(model => model.WeekLow52));

#line default
#line hidden
            EndContext();
            BeginContext(2011, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2067, 56, false);
#line 69 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\Away52WeekHigh.cshtml"
           Write(Html.DisplayNameFor(model => model.Away_From_52WeekHigh));

#line default
#line hidden
            EndContext();
            BeginContext(2123, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2179, 55, false);
#line 72 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\Away52WeekHigh.cshtml"
           Write(Html.DisplayNameFor(model => model.Away_From_52WeekLow));

#line default
#line hidden
            EndContext();
            BeginContext(2234, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 78 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\Away52WeekHigh.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(2352, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2401, 37, false);
#line 81 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\Away52WeekHigh.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2438, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2494, 41, false);
#line 84 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\Away52WeekHigh.cshtml"
           Write(Html.DisplayFor(modelItem => item.SYMBOL));

#line default
#line hidden
            EndContext();
            BeginContext(2535, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2591, 44, false);
#line 87 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\Away52WeekHigh.cshtml"
           Write(Html.DisplayFor(modelItem => item.TIMESTAMP));

#line default
#line hidden
            EndContext();
            BeginContext(2635, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2691, 40, false);
#line 90 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\Away52WeekHigh.cshtml"
           Write(Html.DisplayFor(modelItem => item.CLOSE));

#line default
#line hidden
            EndContext();
            BeginContext(2731, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2787, 39, false);
#line 93 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\Away52WeekHigh.cshtml"
           Write(Html.DisplayFor(modelItem => item.HIGH));

#line default
#line hidden
            EndContext();
            BeginContext(2826, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2882, 38, false);
#line 96 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\Away52WeekHigh.cshtml"
           Write(Html.DisplayFor(modelItem => item.LOW));

#line default
#line hidden
            EndContext();
            BeginContext(2920, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2976, 41, false);
#line 99 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\Away52WeekHigh.cshtml"
           Write(Html.DisplayFor(modelItem => item.Volume));

#line default
#line hidden
            EndContext();
            BeginContext(3017, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3073, 40, false);
#line 102 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\Away52WeekHigh.cshtml"
           Write(Html.DisplayFor(modelItem => item.sma05));

#line default
#line hidden
            EndContext();
            BeginContext(3113, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3169, 40, false);
#line 105 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\Away52WeekHigh.cshtml"
           Write(Html.DisplayFor(modelItem => item.sma10));

#line default
#line hidden
            EndContext();
            BeginContext(3209, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3265, 40, false);
#line 108 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\Away52WeekHigh.cshtml"
           Write(Html.DisplayFor(modelItem => item.sma15));

#line default
#line hidden
            EndContext();
            BeginContext(3305, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3361, 40, false);
#line 111 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\Away52WeekHigh.cshtml"
           Write(Html.DisplayFor(modelItem => item.sma20));

#line default
#line hidden
            EndContext();
            BeginContext(3401, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3457, 40, false);
#line 114 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\Away52WeekHigh.cshtml"
           Write(Html.DisplayFor(modelItem => item.sma50));

#line default
#line hidden
            EndContext();
            BeginContext(3497, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3553, 41, false);
#line 117 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\Away52WeekHigh.cshtml"
           Write(Html.DisplayFor(modelItem => item.sma200));

#line default
#line hidden
            EndContext();
            BeginContext(3594, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3650, 64, false);
#line 120 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\Away52WeekHigh.cshtml"
           Write(Html.DisplayFor(modelItem => item.Percent_of_Price_Change5_days));

#line default
#line hidden
            EndContext();
            BeginContext(3714, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3770, 57, false);
#line 123 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\Away52WeekHigh.cshtml"
           Write(Html.DisplayFor(modelItem => item.Volume_changein_20Days));

#line default
#line hidden
            EndContext();
            BeginContext(3827, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3883, 50, false);
#line 126 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\Away52WeekHigh.cshtml"
           Write(Html.DisplayFor(modelItem => item.Relative_Volume));

#line default
#line hidden
            EndContext();
            BeginContext(3933, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3989, 45, false);
#line 129 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\Away52WeekHigh.cshtml"
           Write(Html.DisplayFor(modelItem => item.WeekHigh52));

#line default
#line hidden
            EndContext();
            BeginContext(4034, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4090, 44, false);
#line 132 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\Away52WeekHigh.cshtml"
           Write(Html.DisplayFor(modelItem => item.WeekLow52));

#line default
#line hidden
            EndContext();
            BeginContext(4134, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4190, 55, false);
#line 135 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\Away52WeekHigh.cshtml"
           Write(Html.DisplayFor(modelItem => item.Away_From_52WeekHigh));

#line default
#line hidden
            EndContext();
            BeginContext(4245, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4301, 54, false);
#line 138 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\Away52WeekHigh.cshtml"
           Write(Html.DisplayFor(modelItem => item.Away_From_52WeekLow));

#line default
#line hidden
            EndContext();
            BeginContext(4355, 50, true);
            WriteLiteral("\r\n            </td>\r\n            \r\n        </tr>\r\n");
            EndContext();
#line 142 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\Away52WeekHigh.cshtml"
}

#line default
#line hidden
            BeginContext(4408, 24, true);
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
