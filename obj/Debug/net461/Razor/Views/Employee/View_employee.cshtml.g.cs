#pragma checksum "D:\Help\Six Sem\ISPCRM\Views\Employee\View_employee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4dd15e1b8ad079131331479a3a4daef1ef357374"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_View_employee), @"mvc.1.0.view", @"/Views/Employee/View_employee.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/View_employee.cshtml", typeof(AspNetCore.Views_Employee_View_employee))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4dd15e1b8ad079131331479a3a4daef1ef357374", @"/Views/Employee/View_employee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"267c01fb449bf58047abbfc5b21de9c41c0a97d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_View_employee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 549, true);
            WriteLiteral(@"
<div class=""main-content"">
    <div class=""section__content section__content--p30"">
        <div class=""container-fluid"">
            <h3 class=""title-3 m-b-30"">
                <i class=""fas fa-desktop""></i>All Employee
            </h3>
            
            <div class=""table-data__tool"">
                <div class=""table-data__tool-left"" style=""margin-left:50px;"">
                    <div class=""rs-select2--light rs-select2--md"">
                        <select class=""js-select2"" name=""property"">
                            ");
            EndContext();
            BeginContext(549, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "521ed922cfce41c8855ab7e86c7f0250", async() => {
                BeginContext(577, 14, true);
                WriteLiteral("All Properties");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(600, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(630, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cfd78ce5bfb426680c1d2cb2569f241", async() => {
                BeginContext(647, 8, true);
                WriteLiteral("Option 1");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(664, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(694, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c001436f2174bf6941419029ceaeda6", async() => {
                BeginContext(711, 8, true);
                WriteLiteral("Option 2");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(728, 287, true);
            WriteLiteral(@"
                        </select>
                        <div class=""dropDownSelect2""></div>
                    </div>
                    <div class=""rs-select2--light rs-select2--sm"">
                        <select class=""js-select2"" name=""time"">
                            ");
            EndContext();
            BeginContext(1015, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ca9bdbaf25f4112acba762caa26b0d1", async() => {
                BeginContext(1043, 5, true);
                WriteLiteral("Today");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1057, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1087, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e83eadcfa7743008bd8a9e1cdcbfd61", async() => {
                BeginContext(1104, 6, true);
                WriteLiteral("3 Days");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1119, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1149, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6f872e4090c4b6d8086e170947d66f8", async() => {
                BeginContext(1166, 6, true);
                WriteLiteral("1 Week");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1181, 1362, true);
            WriteLiteral(@"
                        </select>
                        <div class=""dropDownSelect2""></div>
                    </div>
                    <button class=""au-btn-filter"">
                        <i class=""zmdi zmdi-filter-list""></i>filters
                    </button>
                </div>

            </div>
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""table-responsive table--no-card m-b-30"" style=""margin-left:1px;"">
                        <table class=""table table-borderless table-striped table-earning"">
                            <thead>
                                <tr>
                                    <th>S.No.</th>
                                    <th>Name</th>
                                    <th>Address</th>
                                    <th>Citizenship No.</th>
                                    <th>Email</th>
                                    <th>Phone</th>
                                    <t");
            WriteLiteral(@"h>Post</th>
                                    <th>Username</th>
                                    <th>Password</th>
                                    <th>Confirm Password</th>
                                  

                                </tr>
                            </thead>
                            <tbody>
");
            EndContext();
#line 54 "D:\Help\Six Sem\ISPCRM\Views\Employee\View_employee.cshtml"
                                   
                                  int  i = 1;
                                

#line default
#line hidden
            BeginContext(2662, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 57 "D:\Help\Six Sem\ISPCRM\Views\Employee\View_employee.cshtml"
                                 foreach (var data in ViewBag.data.Rows)
                                {

#line default
#line hidden
            BeginContext(2771, 78, true);
            WriteLiteral("                                <tr>\r\n                                    <td>");
            EndContext();
            BeginContext(2850, 1, false);
#line 60 "D:\Help\Six Sem\ISPCRM\Views\Employee\View_employee.cshtml"
                                   Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(2851, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2899, 13, false);
#line 61 "D:\Help\Six Sem\ISPCRM\Views\Employee\View_employee.cshtml"
                                   Write(data["ename"]);

#line default
#line hidden
            EndContext();
            BeginContext(2912, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2960, 16, false);
#line 62 "D:\Help\Six Sem\ISPCRM\Views\Employee\View_employee.cshtml"
                                   Write(data["eaddress"]);

#line default
#line hidden
            EndContext();
            BeginContext(2976, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(3024, 19, false);
#line 63 "D:\Help\Six Sem\ISPCRM\Views\Employee\View_employee.cshtml"
                                   Write(data["ectizenship"]);

#line default
#line hidden
            EndContext();
            BeginContext(3043, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(3091, 14, false);
#line 64 "D:\Help\Six Sem\ISPCRM\Views\Employee\View_employee.cshtml"
                                   Write(data["eemail"]);

#line default
#line hidden
            EndContext();
            BeginContext(3105, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(3153, 14, false);
#line 65 "D:\Help\Six Sem\ISPCRM\Views\Employee\View_employee.cshtml"
                                   Write(data["ephone"]);

#line default
#line hidden
            EndContext();
            BeginContext(3167, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(3215, 13, false);
#line 66 "D:\Help\Six Sem\ISPCRM\Views\Employee\View_employee.cshtml"
                                   Write(data["epost"]);

#line default
#line hidden
            EndContext();
            BeginContext(3228, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(3276, 17, false);
#line 67 "D:\Help\Six Sem\ISPCRM\Views\Employee\View_employee.cshtml"
                                   Write(data["eusername"]);

#line default
#line hidden
            EndContext();
            BeginContext(3293, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(3341, 17, false);
#line 68 "D:\Help\Six Sem\ISPCRM\Views\Employee\View_employee.cshtml"
                                   Write(data["epassword"]);

#line default
#line hidden
            EndContext();
            BeginContext(3358, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(3406, 18, false);
#line 69 "D:\Help\Six Sem\ISPCRM\Views\Employee\View_employee.cshtml"
                                   Write(data["cepassword"]);

#line default
#line hidden
            EndContext();
            BeginContext(3424, 46, true);
            WriteLiteral("</td>\r\n                                </tr>\r\n");
            EndContext();
#line 71 "D:\Help\Six Sem\ISPCRM\Views\Employee\View_employee.cshtml"
                                    i++;
                                }

#line default
#line hidden
            BeginContext(3547, 196, true);
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        </div>\r\n            </div>\r\n");
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
