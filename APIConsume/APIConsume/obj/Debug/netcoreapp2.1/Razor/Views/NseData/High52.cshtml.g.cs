#pragma checksum "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\High52.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d497e7e146d4a12a0c6fdf029d0382353b800f37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NseData_High52), @"mvc.1.0.view", @"/Views/NseData/High52.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/NseData/High52.cshtml", typeof(AspNetCore.Views_NseData_High52))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d497e7e146d4a12a0c6fdf029d0382353b800f37", @"/Views/NseData/High52.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f13ff418501201ea8561e1073fbcccc4402bb5dd", @"/Views/_ViewImports.cshtml")]
    public class Views_NseData_High52 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<APIConsume.Models.SMAT>>
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
#line 3 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\High52.cshtml"
  
    ViewData["Title"] = "High52";

#line default
#line hidden
            BeginContext(88, 19, true);
            WriteLiteral("\r\n<h2>High52</h2>\r\n");
            EndContext();
            BeginContext(107, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0e0aa176ceb4c8bbf66140db1394bd6", async() => {
                BeginContext(129, 20, true);
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
            BeginContext(153, 88, true);
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(242, 38, false);
#line 14 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\High52.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(280, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(336, 42, false);
#line 17 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\High52.cshtml"
           Write(Html.DisplayNameFor(model => model.SYMBOL));

#line default
#line hidden
            EndContext();
            BeginContext(378, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(434, 45, false);
#line 20 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\High52.cshtml"
           Write(Html.DisplayNameFor(model => model.TIMESTAMP));

#line default
#line hidden
            EndContext();
            BeginContext(479, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(535, 41, false);
#line 23 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\High52.cshtml"
           Write(Html.DisplayNameFor(model => model.CLOSE));

#line default
#line hidden
            EndContext();
            BeginContext(576, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(632, 40, false);
#line 26 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\High52.cshtml"
           Write(Html.DisplayNameFor(model => model.HIGH));

#line default
#line hidden
            EndContext();
            BeginContext(672, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(728, 39, false);
#line 29 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\High52.cshtml"
           Write(Html.DisplayNameFor(model => model.LOW));

#line default
#line hidden
            EndContext();
            BeginContext(767, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(823, 42, false);
#line 32 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\High52.cshtml"
           Write(Html.DisplayNameFor(model => model.Volume));

#line default
#line hidden
            EndContext();
            BeginContext(865, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(921, 41, false);
#line 35 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\High52.cshtml"
           Write(Html.DisplayNameFor(model => model.sma05));

#line default
#line hidden
            EndContext();
            BeginContext(962, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1018, 41, false);
#line 38 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\High52.cshtml"
           Write(Html.DisplayNameFor(model => model.sma10));

#line default
#line hidden
            EndContext();
            BeginContext(1059, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1115, 41, false);
#line 41 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\High52.cshtml"
           Write(Html.DisplayNameFor(model => model.sma15));

#line default
#line hidden
            EndContext();
            BeginContext(1156, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1212, 41, false);
#line 44 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\High52.cshtml"
           Write(Html.DisplayNameFor(model => model.sma20));

#line default
#line hidden
            EndContext();
            BeginContext(1253, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1309, 41, false);
#line 47 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\High52.cshtml"
           Write(Html.DisplayNameFor(model => model.sma50));

#line default
#line hidden
            EndContext();
            BeginContext(1350, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1406, 42, false);
#line 50 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\High52.cshtml"
           Write(Html.DisplayNameFor(model => model.sma200));

#line default
#line hidden
            EndContext();
            BeginContext(1448, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1504, 65, false);
#line 53 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\High52.cshtml"
           Write(Html.DisplayNameFor(model => model.Percent_of_Price_Change5_days));

#line default
#line hidden
            EndContext();
            BeginContext(1569, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1625, 58, false);
#line 56 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\High52.cshtml"
           Write(Html.DisplayNameFor(model => model.Volume_changein_20Days));

#line default
#line hidden
            EndContext();
            BeginContext(1683, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1739, 51, false);
#line 59 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\High52.cshtml"
           Write(Html.DisplayNameFor(model => model.Relative_Volume));

#line default
#line hidden
            EndContext();
            BeginContext(1790, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1846, 46, false);
#line 62 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\High52.cshtml"
           Write(Html.DisplayNameFor(model => model.WeekHigh52));

#line default
#line hidden
            EndContext();
            BeginContext(1892, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1948, 45, false);
#line 65 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\High52.cshtml"
           Write(Html.DisplayNameFor(model => model.WeekLow52));

#line default
#line hidden
            EndContext();
            BeginContext(1993, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2049, 56, false);
#line 68 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\High52.cshtml"
           Write(Html.DisplayNameFor(model => model.Away_From_52WeekHigh));

#line default
#line hidden
            EndContext();
            BeginContext(2105, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2161, 55, false);
#line 71 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\High52.cshtml"
           Write(Html.DisplayNameFor(model => model.Away_From_52WeekLow));

#line default
#line hidden
            EndContext();
            BeginContext(2216, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 77 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\High52.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(2334, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2383, 37, false);
#line 80 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\High52.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2420, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2476, 41, false);
#line 83 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\High52.cshtml"
           Write(Html.DisplayFor(modelItem => item.SYMBOL));

#line default
#line hidden
            EndContext();
            BeginContext(2517, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2573, 44, false);
#line 86 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\High52.cshtml"
           Write(Html.DisplayFor(modelItem => item.TIMESTAMP));

#line default
#line hidden
            EndContext();
            BeginContext(2617, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2673, 40, false);
#line 89 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\High52.cshtml"
           Write(Html.DisplayFor(modelItem => item.CLOSE));

#line default
#line hidden
            EndContext();
            BeginContext(2713, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2769, 39, false);
#line 92 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\High52.cshtml"
           Write(Html.DisplayFor(modelItem => item.HIGH));

#line default
#line hidden
            EndContext();
            BeginContext(2808, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2864, 38, false);
#line 95 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\High52.cshtml"
           Write(Html.DisplayFor(modelItem => item.LOW));

#line default
#line hidden
            EndContext();
            BeginContext(2902, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2958, 41, false);
#line 98 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\High52.cshtml"
           Write(Html.DisplayFor(modelItem => item.Volume));

#line default
#line hidden
            EndContext();
            BeginContext(2999, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3055, 40, false);
#line 101 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\High52.cshtml"
           Write(Html.DisplayFor(modelItem => item.sma05));

#line default
#line hidden
            EndContext();
            BeginContext(3095, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3151, 40, false);
#line 104 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\High52.cshtml"
           Write(Html.DisplayFor(modelItem => item.sma10));

#line default
#line hidden
            EndContext();
            BeginContext(3191, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3247, 40, false);
#line 107 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\High52.cshtml"
           Write(Html.DisplayFor(modelItem => item.sma15));

#line default
#line hidden
            EndContext();
            BeginContext(3287, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3343, 40, false);
#line 110 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\High52.cshtml"
           Write(Html.DisplayFor(modelItem => item.sma20));

#line default
#line hidden
            EndContext();
            BeginContext(3383, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3439, 40, false);
#line 113 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\High52.cshtml"
           Write(Html.DisplayFor(modelItem => item.sma50));

#line default
#line hidden
            EndContext();
            BeginContext(3479, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3535, 41, false);
#line 116 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\High52.cshtml"
           Write(Html.DisplayFor(modelItem => item.sma200));

#line default
#line hidden
            EndContext();
            BeginContext(3576, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3632, 64, false);
#line 119 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\High52.cshtml"
           Write(Html.DisplayFor(modelItem => item.Percent_of_Price_Change5_days));

#line default
#line hidden
            EndContext();
            BeginContext(3696, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3752, 57, false);
#line 122 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\High52.cshtml"
           Write(Html.DisplayFor(modelItem => item.Volume_changein_20Days));

#line default
#line hidden
            EndContext();
            BeginContext(3809, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3865, 50, false);
#line 125 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\High52.cshtml"
           Write(Html.DisplayFor(modelItem => item.Relative_Volume));

#line default
#line hidden
            EndContext();
            BeginContext(3915, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3971, 45, false);
#line 128 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\High52.cshtml"
           Write(Html.DisplayFor(modelItem => item.WeekHigh52));

#line default
#line hidden
            EndContext();
            BeginContext(4016, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4072, 44, false);
#line 131 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\High52.cshtml"
           Write(Html.DisplayFor(modelItem => item.WeekLow52));

#line default
#line hidden
            EndContext();
            BeginContext(4116, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4172, 55, false);
#line 134 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\High52.cshtml"
           Write(Html.DisplayFor(modelItem => item.Away_From_52WeekHigh));

#line default
#line hidden
            EndContext();
            BeginContext(4227, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4283, 54, false);
#line 137 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\High52.cshtml"
           Write(Html.DisplayFor(modelItem => item.Away_From_52WeekLow));

#line default
#line hidden
            EndContext();
            BeginContext(4337, 50, true);
            WriteLiteral("\r\n            </td>\r\n            \r\n        </tr>\r\n");
            EndContext();
#line 141 "D:\Github\FinTech-Flair-NSE-data\APIConsume\APIConsume\Views\NseData\High52.cshtml"
}

#line default
#line hidden
            BeginContext(4390, 24, true);
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
