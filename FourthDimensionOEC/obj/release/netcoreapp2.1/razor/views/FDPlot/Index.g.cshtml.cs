#pragma checksum "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\Views\FDPlot\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac3ebbe30d5f3d5b671ebc6636553902602c3500"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FDPlot_Index), @"mvc.1.0.view", @"/Views/FDPlot/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/FDPlot/Index.cshtml", typeof(AspNetCore.Views_FDPlot_Index))]
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
#line 1 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\Views\_ViewImports.cshtml"
using FourthDimensionOEC;

#line default
#line hidden
#line 2 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\Views\_ViewImports.cshtml"
using FourthDimensionOEC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac3ebbe30d5f3d5b671ebc6636553902602c3500", @"/Views/FDPlot/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"597b4195c28cb2d42008939eeabdba76ed49408e", @"/Views/_ViewImports.cshtml")]
    public class Views_FDPlot_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FourthDimensionOEC.Models.Plot>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\Views\FDPlot\Index.cshtml"
  
    ViewData["Title"] = "Plots";

#line default
#line hidden
            BeginContext(95, 29, true);
            WriteLiteral("\r\n<h2>Plots</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(124, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac3ebbe30d5f3d5b671ebc6636553902602c35004880", async() => {
                BeginContext(147, 15, true);
                WriteLiteral("Create New Plot");
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
            BeginContext(166, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(259, 47, false);
#line 16 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\Views\FDPlot\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DatePlanted));

#line default
#line hidden
            EndContext();
            BeginContext(306, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(362, 40, false);
#line 19 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\Views\FDPlot\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Farm));

#line default
#line hidden
            EndContext();
            BeginContext(402, 60, true);
            WriteLiteral(" Name\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(463, 48, false);
#line 22 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\Views\FDPlot\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Variety.Crop));

#line default
#line hidden
            EndContext();
            BeginContext(511, 60, true);
            WriteLiteral(" Name\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(572, 43, false);
#line 25 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\Views\FDPlot\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Variety));

#line default
#line hidden
            EndContext();
            BeginContext(615, 60, true);
            WriteLiteral(" Name\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(676, 39, false);
#line 28 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\Views\FDPlot\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cec));

#line default
#line hidden
            EndContext();
            BeginContext(715, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(771, 45, false);
#line 31 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\Views\FDPlot\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Treatment));

#line default
#line hidden
            EndContext();
            BeginContext(816, 63, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 36 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\Views\FDPlot\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(928, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(989, 46, false);
#line 40 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\Views\FDPlot\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DatePlanted));

#line default
#line hidden
            EndContext();
            BeginContext(1035, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1103, 40, false);
#line 43 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\Views\FDPlot\Index.cshtml"
               Write(Html.DisplayFor(model => item.Farm.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1143, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1211, 48, false);
#line 46 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\Views\FDPlot\Index.cshtml"
               Write(Html.DisplayFor(model => item.Variety.Crop.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1259, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1327, 43, false);
#line 49 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\Views\FDPlot\Index.cshtml"
               Write(Html.DisplayFor(model => item.Variety.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1370, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1438, 34, false);
#line 52 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\Views\FDPlot\Index.cshtml"
               Write(Html.DisplayFor(model => item.Cec));

#line default
#line hidden
            EndContext();
            BeginContext(1472, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 55 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\Views\FDPlot\Index.cshtml"
                     foreach (var name in item.Treatment)
                    {
                        

#line default
#line hidden
            BeginContext(1626, 20, false);
#line 57 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\Views\FDPlot\Index.cshtml"
                   Write(name.Name.ToString());

#line default
#line hidden
            EndContext();
#line 57 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\Views\FDPlot\Index.cshtml"
                                             ;

#line default
#line hidden
            BeginContext(1649, 32, true);
            WriteLiteral("                        <br />\r\n");
            EndContext();
#line 59 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\Views\FDPlot\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1704, 65, true);
            WriteLiteral("                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1769, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac3ebbe30d5f3d5b671ebc6636553902602c350013081", async() => {
                BeginContext(1818, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 62 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\Views\FDPlot\Index.cshtml"
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
            BeginContext(1826, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1850, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac3ebbe30d5f3d5b671ebc6636553902602c350015476", async() => {
                BeginContext(1902, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 63 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\Views\FDPlot\Index.cshtml"
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
            BeginContext(1913, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1937, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac3ebbe30d5f3d5b671ebc6636553902602c350017877", async() => {
                BeginContext(1988, 6, true);
                WriteLiteral("Delete");
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
#line 64 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\Views\FDPlot\Index.cshtml"
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
            BeginContext(1998, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 67 "C:\program 2230 MS web techn\Assignment\Assignment 2\FourthDimensionOEC\FourthDimensionOEC\Views\FDPlot\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2053, 24, true);
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
