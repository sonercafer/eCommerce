#pragma checksum "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminProduct\ProductPhoto\_ProductPhotoList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "076dcfa19032b3cf7e73d16707f0e093dfe2eb1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminProduct_ProductPhoto__ProductPhotoList), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminProduct/ProductPhoto/_ProductPhotoList.cshtml")]
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
#line 1 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminProduct\ProductPhoto\_ProductPhotoList.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminProduct\ProductPhoto\_ProductPhotoList.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"076dcfa19032b3cf7e73d16707f0e093dfe2eb1a", @"/Areas/Admin/Views/AdminProduct/ProductPhoto/_ProductPhotoList.cshtml")]
    public class Areas_Admin_Views_AdminProduct_ProductPhoto__ProductPhotoList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.ViewModels.Admin.ProductModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" <!--import to get HTML Helper-->\r\n");
            WriteLiteral(@"<br />






<div class=""table-responsive ps ps--active-x"" id=""ProductPhotoListTable"">


    <table id=""ProductPhotoTable"" class=""table tablesorter table-hover dt-responsive nowrapr"" width=""100%"" cellspacing=""0"">
        <thead>
            <tr>
                <th>Id</th>
                <th>resim yolu</th>
                <th>resim görseli</th>
                <th>btn</th>
                <th>btn</th>
            </tr>
        </thead>
    </table>
</div>


<div class=""content"">

    <input type=""hidden"" name=""photoid"" id=""photoid"">
    ");
#nullable restore
#line 31 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminProduct\ProductPhoto\_ProductPhotoList.cshtml"
Write(Html.HiddenFor(x => x.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <!-- Modal -->
    <div class=""modal fade"" id=""ProductPhotoTableModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"" style=""position:absolute;top:0px;"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Seçebileceğiniz kombinasyonlar</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">


                    <div id=""combination"">

                    </div>


                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">İptl Et</button>
                    <button type=""button"" class=""btn btn-default"" id=""");
            WriteLiteral("ProductPhotoCombinationModalSave\">Kaydet</button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities.ViewModels.Admin.ProductModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
