#pragma checksum "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\SOReceipts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8145917d2f6f85aac57c856e9a3625d80670f4a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Finance_SOReceipts), @"mvc.1.0.view", @"/Views/Finance/SOReceipts.cshtml")]
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
#nullable restore
#line 1 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\_ViewImports.cshtml"
using SCASA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\_ViewImports.cshtml"
using SCASA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8145917d2f6f85aac57c856e9a3625d80670f4a1", @"/Views/Finance/SOReceipts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61f59c02fdbf6895e021479e28253e13dd514c2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Finance_SOReceipts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SCASA.Models.ModelClasses.SalesReceiptsModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Finance/OpenOrders"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \r\n");
#nullable restore
#line 3 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\SOReceipts.cshtml"
  
    int rCnt = 1;
    System.Globalization.CultureInfo Indian = new System.Globalization.CultureInfo("hi-IN");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .hideloader {
        display: none;
    }
</style>
<script>
//const { Toast } = require(""../../wwwroot/lib/bootstrap/dist/js/bootstrap.bundle"");

    $(document).ready(function () {
       
    });

    function ShowReceipt(trid, soid) {

        $(""#ReceiptPanel"").load(""/Finance/GetSOReceiptPartial?trid="" + trid + ""&soid="" + soid);


    }
    function PostToFinance(trid) {
      
        $('#loaderPost_' + trid).attr(""style"", ""display:block"")
        $.ajax({
            url: GlobalUrl + ""Finance/PostToFinance?trid="" + trid,
            method: 'post',
            data: '{}',
            success: function (res) {
                if (res.result.statusCode == 1) {
                    toastr[""success""](""Successuflly posted!"");
                    window.location.href = window.location.href;
                }
            }
        });
    }
</script>
<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <section class=""content-header"">
    ");
            WriteLiteral("    <div class=\"header-icon\">\r\n            <i class=\"fa fa-users\"></i>\r\n        </div>\r\n        <div class=\"header-title\">\r\n            <h1>Receipts of Sale Order</h1>\r\n            <small>");
            WriteLiteral(@"</small>
        </div>
    </section>
    <!-- Main content -->
    <section class=""content"">
        <div class=""row"">
            <div class=""col-lg-12 pinpin"">
                <div class=""card"" data-sortable=""true"">
                    <div class=""card-header"">
                        <div class=""card-title custom_title"">
                            <div class=""row"">
                                <div class=""col-md-9"">
");
            WriteLiteral(@"                                </div>

                                <div class=""col-md-3"">
                                    <div class=""btn-group float-right"" role=""group"">
                                        <div class=""buttonexport"" id=""buttonlist"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8145917d2f6f85aac57c856e9a3625d80670f4a16263", async() => {
                WriteLiteral("\r\n                                                <i class=\"fa fa-reply mr-2\"></i> Back\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                    </div>
                    <div class=""card-body"">
                        <!-- Plugin content:powerpoint,txt,pdf,png,word,xl -->
                        <div class=""table-responsive"">
                            <table id=""dataTableExample1"" class=""table table-bordered table-striped table-hover"">
                                <thead class=""back_table_color"">
                                    <tr class=""info"">
                                        <th>#</th>
                                        <th>Customer Name</th>
                                        <th>Sales Executive</th>
                                        <th>Received By</th>
                                        <th>Received On</th>
                                        <th>Amount</th>
            ");
            WriteLiteral(@"                            <th>Method</th>
                                        <th>Instrument Details</th>
                                        <th>Posted to Accounts ?</th>
                                        <th>Actions</th>

                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 113 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\SOReceipts.cshtml"
                                     if (Model != null)
                                    {
                                        foreach (var c in Model)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td>");
#nullable restore
#line 118 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\SOReceipts.cshtml"
                                                Write(rCnt++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <th>");
#nullable restore
#line 119 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\SOReceipts.cshtml"
                                               Write(c.CustomerDetails);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                <th>");
#nullable restore
#line 120 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\SOReceipts.cshtml"
                                               Write(c.StaffDetails);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                <th>");
#nullable restore
#line 121 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\SOReceipts.cshtml"
                                               Write(c.RecievedBy_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                <th>");
#nullable restore
#line 122 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\SOReceipts.cshtml"
                                                Write(Convert.ToDateTime(c.RecievedOn).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                                                <th>Rs. ");
#nullable restore
#line 124 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\SOReceipts.cshtml"
                                                    Write(String.Format(Indian,"{0:N}", c.AmountReceived));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                <th>");
#nullable restore
#line 125 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\SOReceipts.cshtml"
                                               Write(c.PaymentMode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                <th>");
#nullable restore
#line 126 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\SOReceipts.cshtml"
                                               Write(c.InstrumentNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />");
#nullable restore
#line 126 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\SOReceipts.cshtml"
                                                                         Write(c.InstrumentDetails);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                <th>\r\n                                                    <div class=\"row\" style=\"padding-left:20px;\">\r\n");
#nullable restore
#line 129 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\SOReceipts.cshtml"
                                                         if (c.IsPostedToFinance == true)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <span class=\"text-success\">Yes</span>\r\n");
#nullable restore
#line 132 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\SOReceipts.cshtml"

                                                        }
                                                        else
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <span class=\"text-danger\">No</span>\r\n                                                            <a class=\"btn btn-primary\" style=\"padding-left:20px;\" href=\"javscript:void(0);\"");
            BeginWriteAttribute("onclick", " onclick=\"", 6600, "\"", 6632, 3);
            WriteAttributeValue("", 6610, "PostToFinance(", 6610, 14, true);
#nullable restore
#line 137 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\SOReceipts.cshtml"
WriteAttributeValue("", 6624, c.TRId, 6624, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6631, ")", 6631, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Post</a>\r\n");
#nullable restore
#line 138 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\SOReceipts.cshtml"

                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <span class=\"spinner-border text-primary hideloader\"");
            BeginWriteAttribute("id", " id=\"", 6813, "\"", 6836, 2);
            WriteAttributeValue("", 6818, "loaderPost_", 6818, 11, true);
#nullable restore
#line 140 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\SOReceipts.cshtml"
WriteAttributeValue("", 6829, c.TRId, 6829, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></span>
                                                    </div>
                                                   
                                                </th>
                                                <td>
                                                    <a class=""btn btn-success"" href=""javascript:void(0);""");
            BeginWriteAttribute("onclick", " onclick=\"", 7174, "\"", 7212, 5);
            WriteAttributeValue("", 7184, "ShowReceipt(", 7184, 12, true);
#nullable restore
#line 145 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\SOReceipts.cshtml"
WriteAttributeValue("", 7196, c.TRId, 7196, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7203, ",", 7203, 1, true);
#nullable restore
#line 145 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\SOReceipts.cshtml"
WriteAttributeValue("", 7204, c.SOId, 7204, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7211, ")", 7211, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Print</a>\r\n                                                </td>\r\n                                            </tr>\r\n");
#nullable restore
#line 148 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\SOReceipts.cshtml"
                                        }
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>


    </section>

    <section class=""content"" id=""ReceiptPanel"">
      


    </section>
    <!-- /.content -->
</div>

 ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SCASA.Models.ModelClasses.SalesReceiptsModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
