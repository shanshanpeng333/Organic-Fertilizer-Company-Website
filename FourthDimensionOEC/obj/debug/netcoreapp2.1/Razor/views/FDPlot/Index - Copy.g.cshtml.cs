#pragma checksum "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68d45f28f16328e42eb3b7b02c2dfbed85a8321d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.views_FDPlot_Index___Copy), @"mvc.1.0.view", @"/views/FDPlot/Index - Copy.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/views/FDPlot/Index - Copy.cshtml", typeof(AspNetCore.views_FDPlot_Index___Copy))]
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
#line 1 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\_ViewImports.cshtml"
using FourthDimensionOEC;

#line default
#line hidden
#line 2 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\_ViewImports.cshtml"
using FourthDimensionOEC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68d45f28f16328e42eb3b7b02c2dfbed85a8321d", @"/views/FDPlot/Index - Copy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"597b4195c28cb2d42008939eeabdba76ed49408e", @"/views/_ViewImports.cshtml")]
    public class views_FDPlot_Index___Copy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FourthDimensionOEC.Models.Plot>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Add Plot"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
  
    ViewData["Title"] = "Plot List";

#line default
#line hidden
            BeginContext(99, 79, true);
            WriteLiteral("\r\n<h2>Plot List</h2>\r\n\r\n<p>\r\n    <!--a asp-action=\"Create\">Add Plot</a-->\r\n    ");
            EndContext();
            BeginContext(178, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68f70e05f19945e392933f782a0b873f", async() => {
                BeginContext(242, 8, true);
                WriteLiteral("Add Plot");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(254, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(347, 47, false);
#line 17 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
           Write(Html.DisplayNameFor(model => model.DatePlanted));

#line default
#line hidden
            EndContext();
            BeginContext(394, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(450, 49, false);
#line 20 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
           Write(Html.DisplayNameFor(model => model.DateHarvested));

#line default
#line hidden
            EndContext();
            BeginContext(499, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(555, 48, false);
#line 23 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
           Write(Html.DisplayNameFor(model => model.PlantingRate));

#line default
#line hidden
            EndContext();
            BeginContext(603, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(659, 56, false);
#line 26 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
           Write(Html.DisplayNameFor(model => model.PlantingRateByPounds));

#line default
#line hidden
            EndContext();
            BeginContext(715, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(771, 44, false);
#line 29 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
           Write(Html.DisplayNameFor(model => model.RowWidth));

#line default
#line hidden
            EndContext();
            BeginContext(815, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(871, 50, false);
#line 32 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
           Write(Html.DisplayNameFor(model => model.PatternRepeats));

#line default
#line hidden
            EndContext();
            BeginContext(921, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(977, 49, false);
#line 35 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
           Write(Html.DisplayNameFor(model => model.OrganicMatter));

#line default
#line hidden
            EndContext();
            BeginContext(1026, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1082, 43, false);
#line 38 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
           Write(Html.DisplayNameFor(model => model.BicarbP));

#line default
#line hidden
            EndContext();
            BeginContext(1125, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1181, 45, false);
#line 41 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
           Write(Html.DisplayNameFor(model => model.Potassium));

#line default
#line hidden
            EndContext();
            BeginContext(1226, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1282, 45, false);
#line 44 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
           Write(Html.DisplayNameFor(model => model.Magnesium));

#line default
#line hidden
            EndContext();
            BeginContext(1327, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1383, 43, false);
#line 47 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
           Write(Html.DisplayNameFor(model => model.Calcium));

#line default
#line hidden
            EndContext();
            BeginContext(1426, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1482, 42, false);
#line 50 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
           Write(Html.DisplayNameFor(model => model.PHsoil));

#line default
#line hidden
            EndContext();
            BeginContext(1524, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1580, 44, false);
#line 53 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
           Write(Html.DisplayNameFor(model => model.PHbuffer));

#line default
#line hidden
            EndContext();
            BeginContext(1624, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1680, 39, false);
#line 56 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
           Write(Html.DisplayNameFor(model => model.Cec));

#line default
#line hidden
            EndContext();
            BeginContext(1719, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1775, 58, false);
#line 59 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
           Write(Html.DisplayNameFor(model => model.PercentBaseSaturationK));

#line default
#line hidden
            EndContext();
            BeginContext(1833, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1889, 59, false);
#line 62 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
           Write(Html.DisplayNameFor(model => model.PercentBaseSaturationMg));

#line default
#line hidden
            EndContext();
            BeginContext(1948, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2004, 59, false);
#line 65 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
           Write(Html.DisplayNameFor(model => model.PercentBaseSaturationCa));

#line default
#line hidden
            EndContext();
            BeginContext(2063, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2119, 58, false);
#line 68 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
           Write(Html.DisplayNameFor(model => model.PercentBaseSaturationH));

#line default
#line hidden
            EndContext();
            BeginContext(2177, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2233, 44, false);
#line 71 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
           Write(Html.DisplayNameFor(model => model.Comments));

#line default
#line hidden
            EndContext();
            BeginContext(2277, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2333, 40, false);
#line 74 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
           Write(Html.DisplayNameFor(model => model.Farm));

#line default
#line hidden
            EndContext();
            BeginContext(2373, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2429, 43, false);
#line 77 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
           Write(Html.DisplayNameFor(model => model.Variety));

#line default
#line hidden
            EndContext();
            BeginContext(2472, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 83 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(2590, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2639, 46, false);
#line 86 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
           Write(Html.DisplayFor(modelItem => item.DatePlanted));

#line default
#line hidden
            EndContext();
            BeginContext(2685, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2741, 48, false);
#line 89 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateHarvested));

#line default
#line hidden
            EndContext();
            BeginContext(2789, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2845, 47, false);
#line 92 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
           Write(Html.DisplayFor(modelItem => item.PlantingRate));

#line default
#line hidden
            EndContext();
            BeginContext(2892, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2948, 55, false);
#line 95 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
           Write(Html.DisplayFor(modelItem => item.PlantingRateByPounds));

#line default
#line hidden
            EndContext();
            BeginContext(3003, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3059, 43, false);
#line 98 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
           Write(Html.DisplayFor(modelItem => item.RowWidth));

#line default
#line hidden
            EndContext();
            BeginContext(3102, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3158, 49, false);
#line 101 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
           Write(Html.DisplayFor(modelItem => item.PatternRepeats));

#line default
#line hidden
            EndContext();
            BeginContext(3207, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3263, 48, false);
#line 104 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrganicMatter));

#line default
#line hidden
            EndContext();
            BeginContext(3311, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3367, 42, false);
#line 107 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
           Write(Html.DisplayFor(modelItem => item.BicarbP));

#line default
#line hidden
            EndContext();
            BeginContext(3409, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3465, 44, false);
#line 110 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
           Write(Html.DisplayFor(modelItem => item.Potassium));

#line default
#line hidden
            EndContext();
            BeginContext(3509, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3565, 44, false);
#line 113 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
           Write(Html.DisplayFor(modelItem => item.Magnesium));

#line default
#line hidden
            EndContext();
            BeginContext(3609, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3665, 42, false);
#line 116 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
           Write(Html.DisplayFor(modelItem => item.Calcium));

#line default
#line hidden
            EndContext();
            BeginContext(3707, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3763, 41, false);
#line 119 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
           Write(Html.DisplayFor(modelItem => item.PHsoil));

#line default
#line hidden
            EndContext();
            BeginContext(3804, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3860, 43, false);
#line 122 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
           Write(Html.DisplayFor(modelItem => item.PHbuffer));

#line default
#line hidden
            EndContext();
            BeginContext(3903, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3959, 38, false);
#line 125 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cec));

#line default
#line hidden
            EndContext();
            BeginContext(3997, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4053, 57, false);
#line 128 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
           Write(Html.DisplayFor(modelItem => item.PercentBaseSaturationK));

#line default
#line hidden
            EndContext();
            BeginContext(4110, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4166, 58, false);
#line 131 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
           Write(Html.DisplayFor(modelItem => item.PercentBaseSaturationMg));

#line default
#line hidden
            EndContext();
            BeginContext(4224, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4280, 58, false);
#line 134 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
           Write(Html.DisplayFor(modelItem => item.PercentBaseSaturationCa));

#line default
#line hidden
            EndContext();
            BeginContext(4338, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4394, 57, false);
#line 137 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
           Write(Html.DisplayFor(modelItem => item.PercentBaseSaturationH));

#line default
#line hidden
            EndContext();
            BeginContext(4451, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4507, 43, false);
#line 140 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
           Write(Html.DisplayFor(modelItem => item.Comments));

#line default
#line hidden
            EndContext();
            BeginContext(4550, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4606, 52, false);
#line 143 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
           Write(Html.DisplayFor(modelItem => item.Farm.ProvinceCode));

#line default
#line hidden
            EndContext();
            BeginContext(4658, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4714, 52, false);
#line 146 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
           Write(Html.DisplayFor(modelItem => item.Variety.VarietyId));

#line default
#line hidden
            EndContext();
            BeginContext(4766, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4821, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "325f55e714bb4f02ac351db27b6c068f", async() => {
                BeginContext(4870, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 149 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
                                       WriteLiteral(item.PlotId);

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
            BeginContext(4878, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(4898, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c0c85d578d34374a6e7e7f498542e37", async() => {
                BeginContext(4950, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 150 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
                                          WriteLiteral(item.PlotId);

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
            BeginContext(4961, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(4981, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9df2da9b92ef46cb89dc1bfbd0d73fc5", async() => {
                BeginContext(5032, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 151 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
                                         WriteLiteral(item.PlotId);

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
            BeginContext(5042, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 154 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\views\FDPlot\Index - Copy.cshtml"
}

#line default
#line hidden
            BeginContext(5081, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FourthDimensionOEC.Models.Plot>> Html { get; private set; }
    }
}
#pragma warning restore 1591
