#pragma checksum "D:\Github\APIConsume\APIConsume\Views\NseData\Momentum.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9acbf794194ebb8578ccf5d8fb79ece752ee690"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NseData_Momentum), @"mvc.1.0.view", @"/Views/NseData/Momentum.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/NseData/Momentum.cshtml", typeof(AspNetCore.Views_NseData_Momentum))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9acbf794194ebb8578ccf5d8fb79ece752ee690", @"/Views/NseData/Momentum.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cdf86589270383d85070db0dfa7c55a4d46ec49", @"/Views/_ViewImports.cshtml")]
    public class Views_NseData_Momentum : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<APIConsume.Models.SMAT>>
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
#line 3 "D:\Github\APIConsume\APIConsume\Views\NseData\Momentum.cshtml"
  
    ViewData["Title"] = "Momentum";

#line default
#line hidden
            BeginContext(90, 23, true);
            WriteLiteral("\r\n<h1>Momentum</h1>\r\n\r\n");
            EndContext();
            BeginContext(113, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "499f2a1504cb4a12b2ca4ed50fc699ac", async() => {
                BeginContext(135, 20, true);
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
            BeginContext(159, 86, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(246, 38, false);
#line 14 "D:\Github\APIConsume\APIConsume\Views\NseData\Momentum.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(284, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(340, 42, false);
#line 17 "D:\Github\APIConsume\APIConsume\Views\NseData\Momentum.cshtml"
           Write(Html.DisplayNameFor(model => model.SYMBOL));

#line default
#line hidden
            EndContext();
            BeginContext(382, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(438, 45, false);
#line 20 "D:\Github\APIConsume\APIConsume\Views\NseData\Momentum.cshtml"
           Write(Html.DisplayNameFor(model => model.TIMESTAMP));

#line default
#line hidden
            EndContext();
            BeginContext(483, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(539, 41, false);
#line 23 "D:\Github\APIConsume\APIConsume\Views\NseData\Momentum.cshtml"
           Write(Html.DisplayNameFor(model => model.CLOSE));

#line default
#line hidden
            EndContext();
            BeginContext(580, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(636, 40, false);
#line 26 "D:\Github\APIConsume\APIConsume\Views\NseData\Momentum.cshtml"
           Write(Html.DisplayNameFor(model => model.HIGH));

#line default
#line hidden
            EndContext();
            BeginContext(676, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(732, 39, false);
#line 29 "D:\Github\APIConsume\APIConsume\Views\NseData\Momentum.cshtml"
           Write(Html.DisplayNameFor(model => model.LOW));

#line default
#line hidden
            EndContext();
            BeginContext(771, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(827, 42, false);
#line 32 "D:\Github\APIConsume\APIConsume\Views\NseData\Momentum.cshtml"
           Write(Html.DisplayNameFor(model => model.Volume));

#line default
#line hidden
            EndContext();
            BeginContext(869, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(925, 41, false);
#line 35 "D:\Github\APIConsume\APIConsume\Views\NseData\Momentum.cshtml"
           Write(Html.DisplayNameFor(model => model.sma05));

#line default
#line hidden
            EndContext();
            BeginContext(966, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1022, 41, false);
#line 38 "D:\Github\APIConsume\APIConsume\Views\NseData\Momentum.cshtml"
           Write(Html.DisplayNameFor(model => model.sma10));

#line default
#line hidden
            EndContext();
            BeginContext(1063, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1119, 41, false);
#line 41 "D:\Github\APIConsume\APIConsume\Views\NseData\Momentum.cshtml"
           Write(Html.DisplayNameFor(model => model.sma15));

#line default
#line hidden
            EndContext();
            BeginContext(1160, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1216, 41, false);
#line 44 "D:\Github\APIConsume\APIConsume\Views\NseData\Momentum.cshtml"
           Write(Html.DisplayNameFor(model => model.sma20));

#line default
#line hidden
            EndContext();
            BeginContext(1257, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1313, 41, false);
#line 47 "D:\Github\APIConsume\APIConsume\Views\NseData\Momentum.cshtml"
           Write(Html.DisplayNameFor(model => model.sma50));

#line default
#line hidden
            EndContext();
            BeginContext(1354, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1410, 42, false);
#line 50 "D:\Github\APIConsume\APIConsume\Views\NseData\Momentum.cshtml"
           Write(Html.DisplayNameFor(model => model.sma200));

#line default
#line hidden
            EndContext();
            BeginContext(1452, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1508, 65, false);
#line 53 "D:\Github\APIConsume\APIConsume\Views\NseData\Momentum.cshtml"
           Write(Html.DisplayNameFor(model => model.Percent_of_Price_Change5_days));

#line default
#line hidden
            EndContext();
            BeginContext(1573, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1629, 58, false);
#line 56 "D:\Github\APIConsume\APIConsume\Views\NseData\Momentum.cshtml"
           Write(Html.DisplayNameFor(model => model.Volume_changein_20Days));

#line default
#line hidden
            EndContext();
            BeginContext(1687, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1743, 51, false);
#line 59 "D:\Github\APIConsume\APIConsume\Views\NseData\Momentum.cshtml"
           Write(Html.DisplayNameFor(model => model.Relative_Volume));

#line default
#line hidden
            EndContext();
            BeginContext(1794, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1850, 46, false);
#line 62 "D:\Github\APIConsume\APIConsume\Views\NseData\Momentum.cshtml"
           Write(Html.DisplayNameFor(model => model.WeekHigh52));

#line default
#line hidden
            EndContext();
            BeginContext(1896, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1952, 45, false);
#line 65 "D:\Github\APIConsume\APIConsume\Views\NseData\Momentum.cshtml"
           Write(Html.DisplayNameFor(model => model.WeekLow52));

#line default
#line hidden
            EndContext();
            BeginContext(1997, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2053, 56, false);
#line 68 "D:\Github\APIConsume\APIConsume\Views\NseData\Momentum.cshtml"
           Write(Html.DisplayNameFor(model => model.Away_From_52WeekHigh));

#line default
#line hidden
            EndContext();
            BeginContext(2109, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2165, 55, false);
#line 71 "D:\Github\APIConsume\APIConsume\Views\NseData\Momentum.cshtml"
           Write(Html.DisplayNameFor(model => model.Away_From_52WeekLow));

#line default
#line hidden
            EndContext();
            BeginContext(2220, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 77 "D:\Github\APIConsume\APIConsume\Views\NseData\Momentum.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(2338, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2387, 37, false);
#line 80 "D:\Github\APIConsume\APIConsume\Views\NseData\Momentum.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2424, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2480, 41, false);
#line 83 "D:\Github\APIConsume\APIConsume\Views\NseData\Momentum.cshtml"
           Write(Html.DisplayFor(modelItem => item.SYMBOL));

#line default
#line hidden
            EndContext();
            BeginContext(2521, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2577, 44, false);
#line 86 "D:\Github\APIConsume\APIConsume\Views\NseData\Momentum.cshtml"
           Write(Html.DisplayFor(modelItem => item.TIMESTAMP));

#line default
#line hidden
            EndContext();
            BeginContext(2621, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2677, 40, false);
#line 89 "D:\Github\APIConsume\APIConsume\Views\NseData\Momentum.cshtml"
           Write(Html.DisplayFor(modelItem => item.CLOSE));

#line default
#line hidden
            EndContext();
            BeginContext(2717, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2773, 39, false);
#line 92 "D:\Github\APIConsume\APIConsume\Views\NseData\Momentum.cshtml"
           Write(Html.DisplayFor(modelItem => item.HIGH));

#line default
#line hidden
            EndContext();
            BeginContext(2812, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2868, 38, false);
#line 95 "D:\Github\APIConsume\APIConsume\Views\NseData\Momentum.cshtml"
           Write(Html.DisplayFor(modelItem => item.LOW));

#line default
#line hidden
            EndContext();
            BeginContext(2906, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2962, 41, false);
#line 98 "D:\Github\APIConsume\APIConsume\Views\NseData\Momentum.cshtml"
           Write(Html.DisplayFor(modelItem => item.Volume));

#line default
#line hidden
            EndContext();
            BeginContext(3003, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3059, 40, false);
#line 101 "D:\Github\APIConsume\APIConsume\Views\NseData\Momentum.cshtml"
           Write(Html.DisplayFor(modelItem => item.sma05));

#line default
#line hidden
            EndContext();
            BeginContext(3099, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3155, 40, false);
#line 104 "D:\Github\APIConsume\APIConsume\Views\NseData\Momentum.cshtml"
           Write(Html.DisplayFor(modelItem => item.sma10));

#line default
#line hidden
            EndContext();
            BeginContext(3195, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3251, 40, false);
#line 107 "D:\Github\APIConsume\APIConsume\Views\NseData\Momentum.cshtml"
           Write(Html.DisplayFor(modelItem => item.sma15));

#line default
#line hidden
            EndContext();
            BeginContext(3291, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3347, 40, false);
#line 110 "D:\Github\APIConsume\APIConsume\Views\NseData\Momentum.cshtml"
           Write(Html.DisplayFor(modelItem => item.sma20));

#line default
#line hidden
            EndContext();
            BeginContext(3387, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3443, 40, false);
#line 113 "D:\Github\APIConsume\APIConsume\Views\NseData\Momentum.cshtml"
           Write(Html.DisplayFor(modelItem => item.sma50));

#line default
#line hidden
            EndContext();
            BeginContext(3483, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3539, 41, false);
#line 116 "D:\Github\APIConsume\APIConsume\Views\NseData\Momentum.cshtml"
           Write(Html.DisplayFor(modelItem => item.sma200));

#line default
#line hidden
            EndContext();
            BeginContext(3580, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3636, 64, false);
#line 119 "D:\Github\APIConsume\APIConsume\Views\NseData\Momentum.cshtml"
           Write(Html.DisplayFor(modelItem => item.Percent_of_Price_Change5_days));

#line default
#line hidden
            EndContext();
            BeginContext(3700, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3756, 57, false);
#line 122 "D:\Github\APIConsume\APIConsume\Views\NseData\Momentum.cshtml"
           Write(Html.DisplayFor(modelItem => item.Volume_changein_20Days));

#line default
#line hidden
            EndContext();
            BeginContext(3813, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3869, 50, false);
#line 125 "D:\Github\APIConsume\APIConsume\Views\NseData\Momentum.cshtml"
           Write(Html.DisplayFor(modelItem => item.Relative_Volume));

#line default
#line hidden
            EndContext();
            BeginContext(3919, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3975, 45, false);
#line 128 "D:\Github\APIConsume\APIConsume\Views\NseData\Momentum.cshtml"
           Write(Html.DisplayFor(modelItem => item.WeekHigh52));

#line default
#line hidden
            EndContext();
            BeginContext(4020, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4076, 44, false);
#line 131 "D:\Github\APIConsume\APIConsume\Views\NseData\Momentum.cshtml"
           Write(Html.DisplayFor(modelItem => item.WeekLow52));

#line default
#line hidden
            EndContext();
            BeginContext(4120, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4176, 55, false);
#line 134 "D:\Github\APIConsume\APIConsume\Views\NseData\Momentum.cshtml"
           Write(Html.DisplayFor(modelItem => item.Away_From_52WeekHigh));

#line default
#line hidden
            EndContext();
            BeginContext(4231, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4287, 54, false);
#line 137 "D:\Github\APIConsume\APIConsume\Views\NseData\Momentum.cshtml"
           Write(Html.DisplayFor(modelItem => item.Away_From_52WeekLow));

#line default
#line hidden
            EndContext();
            BeginContext(4341, 50, true);
            WriteLiteral("\r\n            </td>\r\n            \r\n        </tr>\r\n");
            EndContext();
#line 141 "D:\Github\APIConsume\APIConsume\Views\NseData\Momentum.cshtml"
}

#line default
#line hidden
            BeginContext(4394, 24, true);
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
