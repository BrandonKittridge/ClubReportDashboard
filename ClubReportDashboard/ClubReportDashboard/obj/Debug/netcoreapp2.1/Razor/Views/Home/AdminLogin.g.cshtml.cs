#pragma checksum "C:\Users\n01039829\Source\Repos\BrandonKittridge\ClubReportDashboard\ClubReportDashboard\ClubReportDashboard\Views\Home\AdminLogin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d51f426ab47cd5114985bfe5c3a0a0ff6ee0633"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AdminLogin), @"mvc.1.0.view", @"/Views/Home/AdminLogin.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/AdminLogin.cshtml", typeof(AspNetCore.Views_Home_AdminLogin))]
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
#line 1 "C:\Users\n01039829\Source\Repos\BrandonKittridge\ClubReportDashboard\ClubReportDashboard\ClubReportDashboard\Views\_ViewImports.cshtml"
using ClubReportDashboard;

#line default
#line hidden
#line 2 "C:\Users\n01039829\Source\Repos\BrandonKittridge\ClubReportDashboard\ClubReportDashboard\ClubReportDashboard\Views\_ViewImports.cshtml"
using ClubReportDashboard.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d51f426ab47cd5114985bfe5c3a0a0ff6ee0633", @"/Views/Home/AdminLogin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d079aa465f0d59336a53d001712feb464509e8d7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AdminLogin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\n01039829\Source\Repos\BrandonKittridge\ClubReportDashboard\ClubReportDashboard\ClubReportDashboard\Views\Home\AdminLogin.cshtml"
  
    ViewData["Title"] = "AdminLogin";

#line default
#line hidden
            BeginContext(48, 24, true);
            WriteLiteral("\r\n<h1>Login Below</h1>\r\n");
            EndContext();
            BeginContext(72, 351, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c163c6084724563a41189fcd6c088f6", async() => {
                BeginContext(78, 178, true);
                WriteLiteral("\r\n    Username: <br />\r\n    <input type=\"text\" name=\"username\"><br>\r\n    Password: <br />\r\n    <input type=\"password\" name=\"password\"><br>\r\n    <input type=\"button\" value=\"Login\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 256, "\"", 311, 3);
                WriteAttributeValue("", 266, "location.href=\'", 266, 15, true);
#line 12 "C:\Users\n01039829\Source\Repos\BrandonKittridge\ClubReportDashboard\ClubReportDashboard\ClubReportDashboard\Views\Home\AdminLogin.cshtml"
WriteAttributeValue("", 281, Url.Action("Index", "Admin"), 281, 29, false);

#line default
#line hidden
                WriteAttributeValue("", 310, "\'", 310, 1, true);
                EndWriteAttribute();
                BeginContext(312, 44, true);
                WriteLiteral(" />\r\n    <input type=\"button\" value=\"Cancel\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 356, "\"", 410, 3);
                WriteAttributeValue("", 366, "location.href=\'", 366, 15, true);
#line 13 "C:\Users\n01039829\Source\Repos\BrandonKittridge\ClubReportDashboard\ClubReportDashboard\ClubReportDashboard\Views\Home\AdminLogin.cshtml"
WriteAttributeValue("", 381, Url.Action("Index", "Home"), 381, 28, false);

#line default
#line hidden
                WriteAttributeValue("", 409, "\'", 409, 1, true);
                EndWriteAttribute();
                BeginContext(411, 5, true);
                WriteLiteral(" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(423, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
