#pragma checksum "C:\Users\asus\Documents\GitHub\ASP.NET-CORE-MVC-SAMPLE-PROJECT\MTS\MTS.Northwind.AspMvcCoreUI\Views\Shared\Components\UserSummary\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee78e5a9fe5dce3a9aa657ec7a2ea24052079fd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_UserSummary_Default), @"mvc.1.0.view", @"/Views/Shared/Components/UserSummary/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/UserSummary/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_UserSummary_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee78e5a9fe5dce3a9aa657ec7a2ea24052079fd8", @"/Views/Shared/Components/UserSummary/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85455b96b5d508e4dd40e0aac0819b4644c5a631", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_UserSummary_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MTS.Northwind.AspMvcCoreUI.Models.UserSummaryViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LogOff", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\asus\Documents\GitHub\ASP.NET-CORE-MVC-SAMPLE-PROJECT\MTS\MTS.Northwind.AspMvcCoreUI\Views\Shared\Components\UserSummary\Default.cshtml"
  
    ViewData["Title"] = "Default";

#line default
#line hidden
            BeginContext(106, 30, true);
            WriteLiteral("\r\n<ul class=\"dropdown-menu\">\r\n");
            EndContext();
#line 7 "C:\Users\asus\Documents\GitHub\ASP.NET-CORE-MVC-SAMPLE-PROJECT\MTS\MTS.Northwind.AspMvcCoreUI\Views\Shared\Components\UserSummary\Default.cshtml"
     if (!String.IsNullOrEmpty(@Model.User))
    {


#line default
#line hidden
            BeginContext(191, 37, true);
            WriteLiteral("        <li>\r\n            <a>welcome ");
            EndContext();
            BeginContext(229, 10, false);
#line 11 "C:\Users\asus\Documents\GitHub\ASP.NET-CORE-MVC-SAMPLE-PROJECT\MTS\MTS.Northwind.AspMvcCoreUI\Views\Shared\Components\UserSummary\Default.cshtml"
                  Write(Model.User);

#line default
#line hidden
            EndContext();
            BeginContext(239, 35, true);
            WriteLiteral("</a>\r\n        </li>\r\n        <li > ");
            EndContext();
            BeginContext(274, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee78e5a9fe5dce3a9aa657ec7a2ea24052079fd84838", async() => {
                BeginContext(322, 6, true);
                WriteLiteral("LogOut");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(332, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 14 "C:\Users\asus\Documents\GitHub\ASP.NET-CORE-MVC-SAMPLE-PROJECT\MTS\MTS.Northwind.AspMvcCoreUI\Views\Shared\Components\UserSummary\Default.cshtml"

    }

#line default
#line hidden
            BeginContext(348, 11, true);
            WriteLiteral("</ul>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MTS.Northwind.AspMvcCoreUI.Models.UserSummaryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591