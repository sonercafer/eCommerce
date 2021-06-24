#pragma checksum "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountDatatable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb26f2a338e5eb0a8849cfbab6ec5ffdc73a2fb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Discount_DiscountDatatable), @"mvc.1.0.view", @"/Areas/Admin/Views/Discount/DiscountDatatable.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb26f2a338e5eb0a8849cfbab6ec5ffdc73a2fb8", @"/Areas/Admin/Views/Discount/DiscountDatatable.cshtml")]
    public class Areas_Admin_Views_Discount_DiscountDatatable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"



<br />
<div class=""table-responsive ps ps--active-x"">
    <table id=""DiscountList"" class=""table tablesorter table-hover dt-responsive nowrapr"" width=""100%"" cellspacing=""0"">
        <thead>
            <tr>
                <th>Id</th>
                <th>Başlangıç Tarihi</th>
                <th>Bitiş Tarihi</th>
                <th>Admin Yorumu</th>
                <th> </th>
            </tr>
        </thead>
    </table>

</div>





<script>
    var Discountable;
    var BindDiscount = function (response) {
        if ($.fn.DataTable.isDataTable(""#DiscountList"")) {
            Discountable.draw();

        }
        else {

            Discountable = $(""#DiscountList"").DataTable({
                ""sAjaxSource"": ""/Admin/Discount/DiscountListJson"" ,
                ""bServerSide"": true,
                ""bProcessing"": true,
                ""bSearchable"": true,
                ""bLengthChange"": false,
                ""searching"": false,
                ""columns"": [
  ");
            WriteLiteral(@"                  { ""data"": ""Id"", ""name"": ""Id"", ""autoWidth"": true },
                    { ""data"": ""StartDateUtc"", ""name"": ""StartDateUtc"", ""autoWidth"": true },
                    { ""data"": ""EndDateUtc"", ""name"": ""EndDateUtc"", ""autoWidth"": true },
                    { ""data"": ""AdminComment"", ""name"": ""AdminComment"", ""autoWidth"": true },                   
                    {
                        data: null,
                        render: function (data, type, row) {
                            return ""<a href='/Admin/Discount/DiscountDelete?id="" + row.Id + ""' ><i class='fa fa-trash-o datatablesil ' style='font-size:20px;' ></i></a>"" +
                                ""<a href='/Admin/Discount/DiscountEdit?id="" + row.Id + ""'><i class='fa fa-edit datatableduzenle' style='font-size:20px;'></i></a>"";
                        }, ""orderable"": false
                    }

                ], ""language"": {
                    ""url"": ""/datatablelanguage.json""
                }

            });

   ");
            WriteLiteral("     }\r\n\r\n    }\r\n    var FilterRecord = function () {\r\n        BindDiscount();\r\n    }\r\n    $(document).ready(function () {\r\n        BindDiscount();\r\n\r\n    });\r\n\r\n</script>\r\n\r\n\r\n\r\n\r\n");
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
