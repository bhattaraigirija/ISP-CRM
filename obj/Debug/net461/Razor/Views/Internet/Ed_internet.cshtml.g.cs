#pragma checksum "D:\Help\Six Sem\ISPCRM\Views\Internet\Ed_internet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9447172fefa6fce16643df4f2905958c60a1237"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Internet_Ed_internet), @"mvc.1.0.view", @"/Views/Internet/Ed_internet.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Internet/Ed_internet.cshtml", typeof(AspNetCore.Views_Internet_Ed_internet))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9447172fefa6fce16643df4f2905958c60a1237", @"/Views/Internet/Ed_internet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"267c01fb449bf58047abbfc5b21de9c41c0a97d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Internet_Ed_internet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 688, true);
            WriteLiteral(@"
<div class=""main-content"">
    <div class=""section__content section__content--p30"">
        <div class=""container-fluid"">
            <h3 class=""title-3 m-b-30"">
                <i class=""fas fa-edit""></i> Edit & Delete
            </h3>
            <div class=""row"" style=""margin-left:5px;"">
                <div class=""col-md-11"">
                    <!-- DATA TABLE -->

                    <div class=""table-data__tool"">
                        <div class=""table-data__tool-left"">
                            <div class=""rs-select2--light rs-select2--md"">
                                <select class=""js-select2"" name=""property"">
                                    ");
            EndContext();
            BeginContext(688, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "715f193315a44619a32c79b75cf78704", async() => {
                BeginContext(716, 14, true);
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
            BeginContext(739, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(777, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0227d859e8d4dc78e2f6bac44361f2b", async() => {
                BeginContext(794, 8, true);
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
            BeginContext(811, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(849, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73e94ebce1ee4dd0942f8187f4e2bb2b", async() => {
                BeginContext(866, 8, true);
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
            BeginContext(883, 335, true);
            WriteLiteral(@"
                                </select>
                                <div class=""dropDownSelect2""></div>
                            </div>
                            <div class=""rs-select2--light rs-select2--sm"">
                                <select class=""js-select2"" name=""time"">
                                    ");
            EndContext();
            BeginContext(1218, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2de95ed353bd4eeb9c1ea0984e26c0c2", async() => {
                BeginContext(1246, 5, true);
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
            BeginContext(1260, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(1298, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "624f63d1695544b597799924f1a98711", async() => {
                BeginContext(1315, 6, true);
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
            BeginContext(1330, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(1368, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bc1eb655c14464f85ace40235a1c555", async() => {
                BeginContext(1385, 6, true);
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
            BeginContext(1400, 826, true);
            WriteLiteral(@"
                                </select>
                                <div class=""dropDownSelect2""></div>
                            </div>
                            <button class=""au-btn-filter"">
                                <i class=""zmdi zmdi-filter-list""></i>filters
                            </button>
                        </div>
                        <div class=""table-data__tool-right"">
                            <button class=""au-btn au-btn-icon au-btn--green au-btn--small"">
                                <i class=""zmdi zmdi-plus""></i>add new
                            </button>
                            <div class=""rs-select2--dark rs-select2--sm rs-select2--dark2"">
                                <select class=""js-select2"" name=""type"">
                                    ");
            EndContext();
            BeginContext(2226, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2783f5520e8642999e8320f688832792", async() => {
                BeginContext(2254, 6, true);
                WriteLiteral("Export");
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
            BeginContext(2269, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(2307, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e404abd415e445f482ca9be21f1cd26b", async() => {
                BeginContext(2324, 8, true);
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
            BeginContext(2341, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(2379, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73d485760fda4711b298add60878b067", async() => {
                BeginContext(2396, 8, true);
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
            BeginContext(2413, 886, true);
            WriteLiteral(@"
                                </select>
                                <div class=""dropDownSelect2""></div>
                            </div>
                        </div>
                    </div>
                    <div class=""table-responsive table-responsive-data2"">
                        <table class=""table table-data2"">
                            <thead>
                                <tr>
                                    <th>S.No.</th>
                                    <th>Name Of Plan</th>
                                    <th>Speed(Mb/sec)</th>
                                    <th>Duration</th>
                                    <th>Price</th>
                                    <th class=""text-center"">Action</th>

                                </tr>
                            </thead>
                            <tbody>
");
            EndContext();
#line 62 "D:\Help\Six Sem\ISPCRM\Views\Internet\Ed_internet.cshtml"
                                  
                                    int i = 1;
                                

#line default
#line hidden
            BeginContext(3418, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 65 "D:\Help\Six Sem\ISPCRM\Views\Internet\Ed_internet.cshtml"
                                 foreach (var dt in ViewBag.data.Rows)
                                {

#line default
#line hidden
            BeginContext(3525, 86, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>");
            EndContext();
            BeginContext(3612, 1, false);
#line 68 "D:\Help\Six Sem\ISPCRM\Views\Internet\Ed_internet.cshtml"
                                       Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(3613, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(3665, 11, false);
#line 69 "D:\Help\Six Sem\ISPCRM\Views\Internet\Ed_internet.cshtml"
                                       Write(dt["iname"]);

#line default
#line hidden
            EndContext();
            BeginContext(3676, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(3728, 12, false);
#line 70 "D:\Help\Six Sem\ISPCRM\Views\Internet\Ed_internet.cshtml"
                                       Write(dt["ispeed"]);

#line default
#line hidden
            EndContext();
            BeginContext(3740, 70, true);
            WriteLiteral("</td>\r\n                                        <td class=\"text-right\">");
            EndContext();
            BeginContext(3811, 15, false);
#line 71 "D:\Help\Six Sem\ISPCRM\Views\Internet\Ed_internet.cshtml"
                                                          Write(dt["iduration"]);

#line default
#line hidden
            EndContext();
            BeginContext(3826, 70, true);
            WriteLiteral("</td>\r\n                                        <td class=\"text-right\">");
            EndContext();
            BeginContext(3897, 11, false);
#line 72 "D:\Help\Six Sem\ISPCRM\Views\Internet\Ed_internet.cshtml"
                                                          Write(dt["icost"]);

#line default
#line hidden
            EndContext();
            BeginContext(3908, 181, true);
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            <div class=\"table-data-feature\">\r\n                                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4089, "\"", 4138, 2);
            WriteAttributeValue("", 4096, "/Internet/Update_internet?S_No=", 4096, 31, true);
#line 75 "D:\Help\Six Sem\ISPCRM\Views\Internet\Ed_internet.cshtml"
WriteAttributeValue("", 4127, dt["S_No"], 4127, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4139, 158, true);
            WriteLiteral(" class=\"item\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Edit\">  <i class=\"zmdi zmdi-edit\"></i></a>\r\n                                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4297, "\"", 4337, 2);
            WriteAttributeValue("", 4304, "/Internet/Delete?S_No=", 4304, 22, true);
#line 76 "D:\Help\Six Sem\ISPCRM\Views\Internet\Ed_internet.cshtml"
WriteAttributeValue("", 4326, dt["S_No"], 4326, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4338, 829, true);
            WriteLiteral(@" class=""item"" data-toggle=""tooltip"" data-placement=""top"" title=""Delete"">  <i class=""zmdi zmdi-delete""></i></a>

                                                <!--<button class=""item"" data-toggle=""tooltip"" data-placement=""top"" title=""Edit"" >
                                                    <i class=""zmdi zmdi-edit""></i>
                                                </button>
                                                <button class=""item"" data-toggle=""tooltip"" data-placement=""top"" title=""Delete"" Onclick=""Delete"">
                                                    <i class=""zmdi zmdi-delete""></i>
                                                </button>-->


                                            </div>
                                        </td>
                                    </tr>
");
            EndContext();
#line 89 "D:\Help\Six Sem\ISPCRM\Views\Internet\Ed_internet.cshtml"
                                    i++;
                                }

#line default
#line hidden
            BeginContext(5244, 235, true);
            WriteLiteral("\r\n\r\n\r\n\r\n                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                    <!-- END DATA TABLE -->\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
