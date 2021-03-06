#pragma checksum "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminProduct\ProductEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6e769fb629d02d9fffe8f1fe75a56a42d7b8b33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminProduct_ProductEdit), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminProduct/ProductEdit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6e769fb629d02d9fffe8f1fe75a56a42d7b8b33", @"/Areas/Admin/Views/AdminProduct/ProductEdit.cshtml")]
    public class Areas_Admin_Views_AdminProduct_ProductEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.ViewModels.Admin.ProductModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminProduct\ProductEdit.cshtml"
  
    ViewBag.Title = "ProductEdit";
    Layout = "~/Views/Shared/_AdminLayoutPage1.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



<div class=""content"">
    <div class=""row"">
        <div class=""col-md-12"">

            <div class=""card "">
                <div class=""d-flex"">

                    <div class=""card-header col-md-10"">
                        <div class=""col-md-4"" style=""float:left;"">
                            <h1 class=""card-title"" style=""margin-top: 8px;"">

                                Ürün Bilgisi

                            </h1>
                        </div>
                    </div>

                </div><br /><br />

                <div class=""card-body"">

                    <div style=""display:flex"">

                        <div class=""col-md-2"" style=""float:right;"">
                            <br />
                            <ul class=""nav"" style=""display:block;"" id=""mainProductTap"">
                                <li class=""tapli""><a data-toggle=""tab"" href=""#tap1"" class=""tab tap1"">Ürün Bilgisi</a></li>
                                <li class=""tapli""><a data-toggl");
            WriteLiteral(@"e=""tab"" href=""#tap4"" class=""tab tap4"">Seo</a></li>
                                <li class=""tapli""><a data-toggle=""tab"" href=""#tap2"" class=""tab tap2"">Ürün Varyasyon</a></li>
                                <li class=""tapli""><a data-toggle=""tab"" href=""#tap3"" class=""tab tap3"">Resim</a></li>
                                <li class=""tapli""><a data-toggle=""tab"" href=""#tap5"" class=""tab tap5"">Ürün Özellik</a></li>
                                <li class=""tapli""><a data-toggle=""tab"" href=""#tap6"" class=""tab tap6"">Ürün Stok</a></li>
                                <li class=""tapli""><a data-toggle=""tab"" href=""#tap7"" class=""tab tap7"">Ürün Kargo Bilgisi</a></li>

                            </ul>
                        </div>
                        <div class=""tab-content col-md-10"" style=""padding-left: 10px;"">

                            <div id=""tap1"" class=""tab-pane active "">
");
#nullable restore
#line 49 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminProduct\ProductEdit.cshtml"
                                 using (Html.BeginForm("ProductEdit", "AdminProduct", FormMethod.Post, new { enctype = "multipart/form-data", @id = "ProductInfoCreateOrUpdate" }))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminProduct\ProductEdit.cshtml"
                               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminProduct\ProductEdit.cshtml"
                                                            ;
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminProduct\ProductEdit.cshtml"
                               Write(Html.HiddenFor(x => x.Tap, new { @class = "tabsaklayici" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminProduct\ProductEdit.cshtml"
                               Write(Html.HiddenFor(x => x.CreatedOnUtc));

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminProduct\ProductEdit.cshtml"
                               Write(Html.HiddenFor(model => model.Id, new { @class = " form-control  " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div style=\"display: flex; flex-wrap: wrap;\">\r\n\r\n\r\n                                        <div class=\"form-group col-md-12 row\">\r\n                                            ");
#nullable restore
#line 60 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminProduct\ProductEdit.cshtml"
                                       Write(Html.LabelFor(x => x.ProductShow, "Ürün Gösterilsinmi?", new { @class = "control-label col-md-2 " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                            <div class=\"col-md-10\">\r\n                                                ");
#nullable restore
#line 63 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminProduct\ProductEdit.cshtml"
                                           Write(Html.CheckBoxFor(model => model.ProductShow, new { @class = "formelement" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </div>\r\n                                        </div>\r\n\r\n                                        <div class=\"form-group col-md-12 row\">\r\n                                            ");
#nullable restore
#line 68 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminProduct\ProductEdit.cshtml"
                                       Write(Html.LabelFor(x => x.ProductStockTypeId, "Ürün Stok Tipi", new { @class = "control-label col-md-2 " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                            <div class=\"col-md-10\">\r\n                                                ");
#nullable restore
#line 71 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminProduct\ProductEdit.cshtml"
                                           Write(Html.DropDownListFor(model => model.ProductStockTypeId, Model.ProductStockTypeSelectList, new { @class = "form-control col-md-8" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </div>\r\n                                        </div>\r\n\r\n                                        <div class=\"form-group col-md-12 row\">\r\n                                            ");
#nullable restore
#line 76 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminProduct\ProductEdit.cshtml"
                                       Write(Html.LabelFor(x => x.ProductName, "Ürün İsmi", new { @class = "control-label col-md-2 " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                            <div class=\"col-md-10 \">\r\n                                                ");
#nullable restore
#line 79 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminProduct\ProductEdit.cshtml"
                                           Write(Html.TextBoxFor(model => model.ProductName, new { @class = " form-control  col-md-8 " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                            </div>\r\n                                        </div>\r\n\r\n                                        <div class=\"form-group col-md-12 row\">\r\n                                            ");
#nullable restore
#line 85 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminProduct\ProductEdit.cshtml"
                                       Write(Html.LabelFor(x => x.BrandId, "Ürün Markası", new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                            <div class=\"col-md-10\">\r\n                                                ");
#nullable restore
#line 88 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminProduct\ProductEdit.cshtml"
                                           Write(Html.DropDownListFor(model => model.BrandId, Model.BrandSelectListItems, new { @class = " form-control col-md-8  " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                            </div>\r\n                                        </div>\r\n\r\n                                        <div class=\"form-group col-md-12 row\">\r\n                                            ");
#nullable restore
#line 94 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminProduct\ProductEdit.cshtml"
                                       Write(Html.LabelFor(x => x.CategoryId, "Ürün Kategorisi", new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                            <div class=\"col-md-10\">\r\n                                                ");
#nullable restore
#line 97 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminProduct\ProductEdit.cshtml"
                                           Write(Html.DropDownListFor(model => model.CategoryId, Model.CategorySelectListItems, new { @class = " form-control col-md-8  " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                            </div>\r\n                                        </div>\r\n\r\n                                        <div class=\"form-group col-md-12 row\">\r\n                                            ");
#nullable restore
#line 103 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminProduct\ProductEdit.cshtml"
                                       Write(Html.LabelFor(x => x.Id, "Sku =", new { @class = "control-label col-md-2 " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                            <div class=\"col-md-10\">\r\n                                                ");
#nullable restore
#line 106 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminProduct\ProductEdit.cshtml"
                                           Write(Html.TextBoxFor(model => model.Sku, new { @class = "form-control  col-md-8" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </div>\r\n                                        </div>\r\n\r\n                                        <div class=\"form-group col-md-12 row\">\r\n\r\n                                            ");
#nullable restore
#line 112 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminProduct\ProductEdit.cshtml"
                                       Write(Html.LabelFor(x => x.Id, "Gtin =", new { @class = "control-label col-md-2 " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                            <div class=\"col-md-10\">\r\n                                                ");
#nullable restore
#line 115 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminProduct\ProductEdit.cshtml"
                                           Write(Html.TextBoxFor(model => model.Gtin, new { @class = "form-control  col-md-8" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </div>\r\n                                        </div>\r\n\r\n                                        <div class=\"form-group col-md-12 row\">\r\n                                            ");
#nullable restore
#line 120 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminProduct\ProductEdit.cshtml"
                                       Write(Html.LabelFor(x => x.CategoryId, "Ürün Açıklaması", new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                            <div class=\"col-md-10\">\r\n\r\n                                                <div class=\"col-md-8 p-0\">\r\n                                                    <textarea id=\"ProductContent\" name=\"ProductContent\">");
#nullable restore
#line 125 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminProduct\ProductEdit.cshtml"
                                                                                                   Write(Html.Raw(@Model.ProductContent));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</textarea>
                                                </div>

                                            </div>
                                        </div>
                                        <div>
                                            <input type=""submit"" value=""Kaydet"" class=""btn btn-outline-default"" />
                                        </div>

                                    </div>
                                    <div class=""clearfix""></div><br />
");
#nullable restore
#line 136 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminProduct\ProductEdit.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n\r\n                            <div id=\"tap4\" class=\"tab-pane\">\r\n                                ");
#nullable restore
#line 140 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminProduct\ProductEdit.cshtml"
                           Write(Html.Partial("ProductSeo/_ProductSeo", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n\r\n                            <div id=\"tap2\" class=\"tab-pane\">\r\n                                <br />\r\n                                ");
#nullable restore
#line 145 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminProduct\ProductEdit.cshtml"
                           Write(Html.Partial("AttrMaping/AttrMapping", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                ");
#nullable restore
#line 147 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminProduct\ProductEdit.cshtml"
                           Write(Html.Partial("AttrCombination/AttrCombination", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                            </div>\r\n\r\n                            <div id=\"tap3\" class=\"tab-pane\">\r\n                                <div class=\"col-md-12\">\r\n                                    ");
#nullable restore
#line 154 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminProduct\ProductEdit.cshtml"
                               Write(Html.Partial("ProductPhoto/ProductPhoto", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n\r\n                            <div id=\"tap5\" class=\"tab-pane\">\r\n                                <div class=\"col-md-12\">\r\n                                    ");
#nullable restore
#line 160 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminProduct\ProductEdit.cshtml"
                               Write(Html.Partial("ProductSpefication/ProductSpefication", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n\r\n                            <div id=\"tap6\" class=\"tab-pane\">\r\n                                <div class=\"col-md-12\">\r\n                                    ");
#nullable restore
#line 166 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminProduct\ProductEdit.cshtml"
                               Write(Html.Partial("StockPrice/ProductStockPrice", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n\r\n                            </div>\r\n\r\n                            <div id=\"tap7\" class=\"tab-pane\">\r\n                                <div class=\"col-md-12\">\r\n                                    ");
#nullable restore
#line 173 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminProduct\ProductEdit.cshtml"
                               Write(Html.Partial("ProductShipment/ProductShipment", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>

                            </div>
                        </div>
                    </div>







                </div>
            </div>
        </div>
    </div>
</div>





<style>
    .tapDisabled {
        color: currentColor;
        cursor: not-allowed;
        opacity: 0.5;
        text-decoration: none;
    }
</style>

<script>
    $(document).ready(function () {

        if ($(""#Id"").val() == 0) {
            $(""#mainProductTap li:not(:first-child) a"").each(function (index) {
                $(this).prop('disabled', true);
                $(this).addClass(""tapDisabled"");
            });
        }
        function allTapliEnabled() {
            $(""#mainProductTap li:not(:first-child) a"").each(function (index) {
                $(this).prop('disabled', false);
                $(this).removeClass(""tapDisabled"");
            });
        }

        $(""#ProductInfoCreateOrUpdate"").submit(function (e) {
         ");
            WriteLiteral(@"   e.preventDefault();
            var data = $(this).serialize();
            $.ajax({
                url: ""/Admin/AdminProduct/ProductInfoCreateOrUpdate?"" + data,
                method: ""POST"",
                type: ""json"",
                success: function (data) {
                    $(""#Id"").val(data.Id);
                    const url = new URL(window.location);
                    url.searchParams.set('Id', data.Id);
                    window.history.pushState({}, '', url);

                    allTapliEnabled();
                    swal(""İşlem Başarılı"", """", ""success"");
                },
                error: function (data) {
                    swal(""İşlem Başarısız"", """", ""success"");
                }
            });
        });
        function tapDegistir(data) {
            const url = new URL(window.location);
            url.searchParams.set('Tap', data);
            window.history.pushState({}, '', url);
        }
        //Tap Başlangıç ayarı
        var tappost ");
            WriteLiteral(@"= $("".tabsaklayici"").val();
        if (tappost == null || tappost == """") {
            tapDegistir(""tap1"");
        }
        else {
            $("".tab-pane"").removeClass(""active"");
            $(""#"" + tappost).addClass(""active"");
            var selectedhead = $(""."" + tappost).text();
            $("".card-title"").text(selectedhead);
        }
        //Tap Değiştikçe
        $("".tab"").click(function (e) {
            if ($(this).prop(""disabled"")) {
                e.preventDefault();
            } else {
                //Başlık değiştir
                var tapid = $(this).attr(""href"");
                tapid = tapid.replace(""#"", """");
                var selectedhead = $(""."" + tapid).text();
                $("".card-title"").text(selectedhead);
                //Url Değiştir
                tapDegistir(tapid);
            }
        });
    });
</script>








<script>
    tinymce.init({
        selector: 'textarea#ProductContent',
        automatic_uploads: true,
     ");
            WriteLiteral(@"   images_upload_url: '/Admin/AdminProduct/FileUpload',
        images_reuse_filename: true,
        plugins: 'print preview paste importcss searchreplace autolink autosave save directionality code visualblocks visualchars fullscreen image link media template codesample table charmap hr pagebreak nonbreaking anchor toc insertdatetime advlist lists wordcount imagetools textpattern noneditable help charmap quickbars emoticons',
        imagetools_cors_hosts: ['picsum.photos'],
        menubar: 'file edit view insert format tools table help',
        toolbar: 'undo redo | bold italic underline strikethrough | fontselect fontsizeselect formatselect | alignleft aligncenter alignright alignjustify | outdent indent |  numlist bullist | forecolor backcolor removeformat | pagebreak | charmap emoticons | fullscreen  preview save print | insertfile image media template link anchor codesample | ltr rtl',
        toolbar_sticky: true,
        language: 'tr',
        autosave_ask_before_unload: true,
        autos");
            WriteLiteral(@"ave_interval: ""30s"",
        autosave_prefix: ""{path}{query}-{id}-"",
        autosave_restore_when_empty: false,
        autosave_retention: ""2m"",
        image_advtab: true,
        content_css: '//www.tiny.cloud/css/codepen.min.css',
        importcss_append: true,
        height: 400,
        file_picker_callback: function (callback, value, meta) {
            /* Provide file and text for the link dialog */
            if (meta.filetype === 'file') {
                callback('https://www.google.com/logos/google.jpg', { text: 'My text' });
            }

            /* Provide image and alt text for the image dialog */
            if (meta.filetype === 'image') {
                callback('https://www.google.com/logos/google.jpg', { alt: 'My alt text' });
            }

            /* Provide alternative source and posted for the media dialog */
            if (meta.filetype === 'media') {
                callback('movie.mp4', { source2: 'alt.ogg', poster: 'https://www.google.com/logos/g");
            WriteLiteral(@"oogle.jpg' });
            }
        },
        entity_encoding: ""raw"",
        template_cdate_format: '[Date Created (CDATE): %m/%d/%Y : %H:%M:%S]',
        template_mdate_format: '[Date Modified (MDATE): %m/%d/%Y : %H:%M:%S]',
        height: 600,
        image_caption: true,
        quickbars_selection_toolbar: 'bold italic | quicklink h2 h3 blockquote quickimage quicktable',
        noneditable_noneditable_class: ""mceNonEditable"",
        toolbar_mode: 'sliding',
        contextmenu: ""link image imagetools table"",
    });
</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities.ViewModels.Admin.ProductModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
