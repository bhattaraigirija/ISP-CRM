#pragma checksum "D:\Help\Six Sem\ISPCRM\Views\Employee_emp\Addnew_employee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a10f61e35202c9c8c403f2c8e62687cf1179fd0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_emp_Addnew_employee), @"mvc.1.0.view", @"/Views/Employee_emp/Addnew_employee.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee_emp/Addnew_employee.cshtml", typeof(AspNetCore.Views_Employee_emp_Addnew_employee))]
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
#line 1 "D:\Help\Six Sem\ISPCRM\Views\_ViewImports.cshtml"
using ISPCRM;

#line default
#line hidden
#line 2 "D:\Help\Six Sem\ISPCRM\Views\_ViewImports.cshtml"
using ISPCRM.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a10f61e35202c9c8c403f2c8e62687cf1179fd0", @"/Views/Employee_emp/Addnew_employee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"267c01fb449bf58047abbfc5b21de9c41c0a97d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_emp_Addnew_employee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\Help\Six Sem\ISPCRM\Views\Employee_emp\Addnew_employee.cshtml"
  
    Layout = "~/Views/Shared/_LayoutEmployee.cshtml";


#line default
#line hidden
            BeginContext(64, 307, true);
            WriteLiteral(@"<div class=""main-content"">
    <div class=""section__content section__content--p30"">
        <div class=""container-fluid"">
            <h3 class=""title-3 m-b-30"">
                <i class=""fas fa-plus-square""></i> Add New Employee
            </h3>
            <div class=""container"">
                ");
            EndContext();
            BeginContext(371, 3942, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a3f383c23404a9c8ad766799e9869c3", async() => {
                BeginContext(401, 3905, true);
                WriteLiteral(@"
                    <!-- Name-->
                    <div class=""form-group"">
                        <label class=""control-label col-sm-4"" for=""email"">Employee Name:</label>
                        <div class=""col-sm-12"">
                            <input type=""text"" class=""form-control"" id=""ename"" placeholder=""Enter employee name"" name=""ename"">
                        </div>
                    </div>

                    <!-- Address-->
                    <div class=""form-group"">
                        <label class=""control-label col-sm-4"">Employee Address:</label>
                        <div class=""col-sm-12"">
                            <input type=""text"" class=""form-control"" id=""eaddr"" placeholder=""Enter employee name"" name=""eadr"">
                        </div>
                    </div>

                    <!-- Citizenship Number-->
                    <div class=""form-group"">
                        <label class=""control-label col-sm-4"">Citzenship Number:</label>
           ");
                WriteLiteral(@"             <div class=""col-sm-12"">
                            <input type=""text"" class=""form-control"" id=""cnum"" placeholder=""Enter employee citizenship number"" name=""cnum"">
                        </div>
                    </div>

                    <!--Email-->
                    <div class=""form-group"">
                        <label class=""control-label col-sm-4"">Email:</label>
                        <div class=""col-sm-12"">
                            <input type=""email"" class=""form-control"" id=""email"" placeholder=""Enter email"">
                        </div>
                    </div>
                    <!-- Phone-->
                    <div class=""form-group"">
                        <label class=""control-label col-sm-4"">Employee Phone:</label>
                        <div class=""col-sm-12"">
                            <input type=""text"" class=""form-control"" id=""ephone"" placeholder=""Enter employee phone"" name=""ephone"">
                        </div>
                    </div>
 ");
                WriteLiteral(@"                   <!-- Post-->
                    <div class=""form-group"">
                        <label class=""control-label col-sm-4"" for=""email"">Employee Post:</label>
                        <div class=""col-sm-12"">
                            <input type=""text"" class=""form-control"" id=""epost"" placeholder=""Enter employee post"" name=""epost"">
                        </div>
                    </div>

                    <hr />

                    <!--USER & PASS-->
                    <div class=""form-group"">
                        <label class=""control-label col-sm-4"" for=""email"">Username:</label>
                        <div class=""col-sm-12"">
                            <input type=""text"" class=""form-control"" id=""euser"" placeholder=""Enter Username"">
                        </div>
                    </div>
                    <div class=""form-group"">
                        <label class=""control-label col-sm-4"" for=""pwd"">Password:</label>
                        <div class=""col-sm-");
                WriteLiteral(@"12"">
                            <input type=""password"" class=""form-control"" name=""pwd"" placeholder=""Enter password"">
                        </div>
                    </div>
                    <div class=""form-group"">
                        <label class=""control-label col-sm-4"" for=""pwd"">Confirm Password:</label>
                        <div class=""col-sm-12"">
                            <input type=""password"" class=""form-control"" name=""cpwd"" placeholder=""Confirm password"">
                        </div>
                    </div>


                    <div class=""form-group"">
                        <div class=""col-sm-offset-4 col-sm-10"">
                            <button type=""submit"" class=""btn btn-success"">Submit</button>
                        </div>
                    </div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4313, 56, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
