#pragma checksum "D:\Help\Six Sem\ISPCRM\Views\Pie\ComplainReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48c121d4f449353727c94f1b78d1a9b49ca91db6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pie_ComplainReport), @"mvc.1.0.view", @"/Views/Pie/ComplainReport.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pie/ComplainReport.cshtml", typeof(AspNetCore.Views_Pie_ComplainReport))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48c121d4f449353727c94f1b78d1a9b49ca91db6", @"/Views/Pie/ComplainReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"267c01fb449bf58047abbfc5b21de9c41c0a97d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Pie_ComplainReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2818, true);
            WriteLiteral(@"

<div class=""main-content"">
    <div class=""section__content section__content--p30"">
        <div class=""container-fluid"">

            <div class=""container"">
                <div class=""row"">


                    <div class=""col-md-6"">

                        <div class=""main_box"">

                            <h1>Dially Complain Report</h1>

                            <canvas id=""myChart""></canvas>

                        </div>
                    </div>


                    <div class=""col-md-6"">

                        <div class=""count_box"">




                            <div class=""form-group"">
                                <label for=""coronavirus-input"">Total Number Of Complain :</label>
                                <input type=""text"" class=""total-input form-control"" />
                            </div>

                            <div class=""form-group"">
                                <label for=""coronavirus-input"">Solved Complain :</label>
      ");
            WriteLiteral(@"                          <input type=""text"" name=""coronavirus-input"" class=""coronavirus-input form-control"" />
                            </div>

                            <div class=""form-group"">
                                <label for=""deaths-input"">Remaining Complain :</label>
                                <input type=""text"" name=""deaths-input"" class=""deaths-input form-control"" />
                            </div>

                            <div class=""form-group"">
                                <label for=""recovered-input"">UnSolved</label>
                                <input type=""text"" name=""recovered-input"" class=""recovered-input form-control"" />
                            </div>
                            <div class=""form-group"">
                                <label class=""control-label col-sm-4"" for=""pwd"">Report Date:</label>
                                <div class=""col-sm-12"">

                                    <h5 id=""date""></h5>
                            ");
            WriteLiteral(@"        <script>
                                        document.getElementById(""date"").innerHTML = Date();
                                    </script>
                                </div>
                            </div>
                          

                            <br />
                            <div class=""form-group"">
                                <div class=""col-sm-offset-2 col-sm-10"">
                                    <button type=""submit"" class=""btn btn-success"">Submit</button>
                                </div>
                            </div>

                        </div>





                    </div>

                </div>
            </div>

        </div>
        </div>

</div>



");
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
