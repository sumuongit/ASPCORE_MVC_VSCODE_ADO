#pragma checksum "D:\ASPCORE_MVC_VSCODE_ADO\Views\Employee\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "451430035adb0ea287cf60eaba953107cacb337d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Delete), @"mvc.1.0.view", @"/Views/Employee/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Delete.cshtml", typeof(AspNetCore.Views_Employee_Delete))]
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
#line 1 "D:\ASPCORE_MVC_VSCODE_ADO\Views\_ViewImports.cshtml"
using ASPCORE_MVC_VSCODE_ADO;

#line default
#line hidden
#line 2 "D:\ASPCORE_MVC_VSCODE_ADO\Views\_ViewImports.cshtml"
using ASPCORE_MVC_VSCODE_ADO.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"451430035adb0ea287cf60eaba953107cacb337d", @"/Views/Employee/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f629ea3e6354058fb6d06b4be7c99a9fe551b1d", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASPCORE_MVC_VSCODE_ADO.Models.Employee>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 6, true);
            WriteLiteral("    \r\n");
            EndContext();
#line 3 "D:\ASPCORE_MVC_VSCODE_ADO\Views\Employee\Delete.cshtml"
      
    ViewData["Title"] = "Delete";    

#line default
#line hidden
            BeginContext(111, 194, true);
            WriteLiteral("<h2>Delete</h2>    \r\n<h3>Are you sure you want to delete this?</h3>    \r\n<div>    \r\n    <h4>Employees</h4>    \r\n    <hr />    \r\n    <dl class=\"dl-horizontal\">    \r\n        <dt>    \r\n            ");
            EndContext();
            BeginContext(306, 40, false);
#line 13 "D:\ASPCORE_MVC_VSCODE_ADO\Views\Employee\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(346, 55, true);
            WriteLiteral("    \r\n        </dt>    \r\n        <dd>    \r\n            ");
            EndContext();
            BeginContext(402, 36, false);
#line 16 "D:\ASPCORE_MVC_VSCODE_ADO\Views\Employee\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(438, 55, true);
            WriteLiteral("    \r\n        </dd>    \r\n        <dt>    \r\n            ");
            EndContext();
            BeginContext(494, 42, false);
#line 19 "D:\ASPCORE_MVC_VSCODE_ADO\Views\Employee\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(536, 55, true);
            WriteLiteral("    \r\n        </dt>    \r\n        <dd>    \r\n            ");
            EndContext();
            BeginContext(592, 38, false);
#line 22 "D:\ASPCORE_MVC_VSCODE_ADO\Views\Employee\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(630, 55, true);
            WriteLiteral("    \r\n        </dd>    \r\n        <dt>    \r\n            ");
            EndContext();
            BeginContext(686, 46, false);
#line 25 "D:\ASPCORE_MVC_VSCODE_ADO\Views\Employee\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Department));

#line default
#line hidden
            EndContext();
            BeginContext(732, 55, true);
            WriteLiteral("    \r\n        </dt>    \r\n        <dd>    \r\n            ");
            EndContext();
            BeginContext(788, 42, false);
#line 28 "D:\ASPCORE_MVC_VSCODE_ADO\Views\Employee\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Department));

#line default
#line hidden
            EndContext();
            BeginContext(830, 55, true);
            WriteLiteral("    \r\n        </dd>    \r\n        <dt>    \r\n            ");
            EndContext();
            BeginContext(886, 40, false);
#line 31 "D:\ASPCORE_MVC_VSCODE_ADO\Views\Employee\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(926, 55, true);
            WriteLiteral("    \r\n        </dt>    \r\n        <dd>    \r\n            ");
            EndContext();
            BeginContext(982, 36, false);
#line 34 "D:\ASPCORE_MVC_VSCODE_ADO\Views\Employee\Delete.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(1018, 50, true);
            WriteLiteral("    \r\n        </dd>    \r\n    </dl>    \r\n    \r\n    ");
            EndContext();
            BeginContext(1068, 223, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "451430035adb0ea287cf60eaba953107cacb337d8028", async() => {
                BeginContext(1094, 14, true);
                WriteLiteral("    \r\n        ");
                EndContext();
                BeginContext(1108, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "451430035adb0ea287cf60eaba953107cacb337d8424", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 39 "D:\ASPCORE_MVC_VSCODE_ADO\Views\Employee\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1144, 92, true);
                WriteLiteral("    \r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |    \r\n        ");
                EndContext();
                BeginContext(1236, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "451430035adb0ea287cf60eaba953107cacb337d10313", async() => {
                    BeginContext(1258, 12, true);
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
                BeginContext(1274, 10, true);
                WriteLiteral("    \r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1291, 12, true);
            WriteLiteral("    \r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASPCORE_MVC_VSCODE_ADO.Models.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591