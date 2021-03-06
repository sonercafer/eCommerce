#pragma checksum "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminProduct\ProductSpefication\ProductSpefication.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57efddf46a2f7d520bb3285da2aa3181f5057b3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminProduct_ProductSpefication_ProductSpefication), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminProduct/ProductSpefication/ProductSpefication.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57efddf46a2f7d520bb3285da2aa3181f5057b3c", @"/Areas/Admin/Views/AdminProduct/ProductSpefication/ProductSpefication.cshtml")]
    public class Areas_Admin_Views_AdminProduct_ProductSpefication_ProductSpefication : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.ViewModels.Admin.ProductModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminProduct\ProductSpefication\ProductSpefication.cshtml"
  
    ViewData["Title"] = "ProductSpeficationCreate";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminProduct\ProductSpefication\ProductSpefication.cshtml"
Write(Html.Partial("ProductSpefication/_ProductSpeficationCreate", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminProduct\ProductSpefication\ProductSpefication.cshtml"
Write(Html.Partial("ProductSpefication/_ProductSpeficationDataTable", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"





<script>
    var ProductSpeficationTable;
    var BindProductListSpefication = function (response) {
        if ($.fn.DataTable.isDataTable(""#ProductSpeficationList"")) {
            ProductSpeficationTable.draw();
        }
        else {
            ProductSpeficationTable = $(""#ProductSpeficationList"").DataTable({
                ""sAjaxSource"": ""/Admin/AdminProduct/ProductSpeficationJson?Id=""+");
#nullable restore
#line 24 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminProduct\ProductSpefication\ProductSpefication.cshtml"
                                                                           Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
                ""bServerSide"": true,
                ""bProcessing"": true,
                ""bSearchable"": true,
                ""bLengthChange"": false,
                ""searching"": false,
                ""columns"": [
                    { ""data"": ""Id"", ""name"": ""Id"", ""autoWidth"": true },
                    { ""data"": ""SpeficationAtributeTypeName"", ""name"": ""SpecificationAttributeOptionName"", ""autoWidth"": true },
                    { ""data"": ""SpecificationAttributeOptionName"", ""name"": ""SpecificationAttributeOptionName"", ""autoWidth"": true },
                    { ""data"": ""DisplayOrder"", ""name"": ""DisplayOrder"", ""autoWidth"": true },
                    {
                        data: null,
                        render: function (data, type, row) {
                            if (row.AllowFiltering) {
                                return ""<span class='badge badge-success'>Evet</span>"";
                            }
                            else {
                                return ""<sp");
            WriteLiteral(@"an class='badge badge-danger'>Hay??r</span>"";
                            }
                        }, ""orderable"": false
                    },
                    {
                        data: null,
                        render: function (data, type, row) {
                            if (row.ShowOnProductPage) {
                                return ""<span class='badge badge-success'>Evet</span>"";
                            }
                            else {
                                return ""<span class='badge badge-danger'>Hay??r</span>"";
                            }
                        }, ""orderable"": false
                    },
                    {
                        data: null,
                        render: function (data, type, row) {
                            return ""<a onClick='ProductSpeficationDelete(""+row.Id+"")'><i class='fa fa-trash-o datatablesil ' style='font-size:20px;' ></i></a>"" ;
                        }, ""orderable"": false
                 ");
            WriteLiteral(@"   }
                ], ""language"": {
                    ""url"": ""/datatablelanguage.json""
                }
            });

        }

    }
    var FilterRecord = function () {
        BindProductListSpefication();
    }
    $(document).ready(function () {
        FilterRecord();
    });

    function ProductSpeficationDelete(id) {
        $.ajax({
            url: ""/Admin/AdminProduct/ProductSpeficationDelete?id="" + id,
            error : function() {
                swal(""i??lem ba??ar??s??z"", """", ""error"");
            },
            success: function () {
                $(""a[onClick='ProductSpeficationDelete("" + id + "")']"").parent().parent().remove();
                swal(""i??lem ba??ar??l??"", """", ""success"");
            }

        });
    }

    var OptionGetir = function (AttrTypeId) {
        $(""#SpecificationAttributeOptionId"").prop(""disabled"", true);
        $.ajax({
            type: ""post"",
            url: ""/Admin/AdminProduct/GetSpeficationOptionById?speficationAttrI");
            WriteLiteral(@"d="" + AttrTypeId,
            dataType: ""json"",
            success: function (sonuc) {
                $(""#SpecificationAttributeOptionId option"").remove();

                if (sonuc.length > 0) {
                    $(""#SpecificationAttributeOptionId"").prop(""disabled"", false);
                    $.each(sonuc, function (index, item) {
                        var optionhtml = '<option value=""' + item.Id + '"">' + item.Name + '</option>';
                        $(""#SpecificationAttributeOptionId"").append(optionhtml);
                    });
                } else {
                    $.each(sonuc, function (index, item) {
                        var optionhtml = '<option value=""' + item.Id + '"">' + item.Name + '</option>';
                        $(""#SpecificationAttributeOptionId"").append(optionhtml);

                    });
                }
            }
        });
    };

    $(""select[name='ProductSpecificationAttribute.AttributeTypeId']"").on(""change"", function () {
        var");
            WriteLiteral(@" AttrTypeId = $(this).val();
        OptionGetir(AttrTypeId);
    });

    $(""#ProductSpeficationCreate"").submit(function (event) {
        event.preventDefault(); 
        $('input[name=""ProductSpecificationAttribute.ProductId""]').val($(""#Id"").val());
        $('input[name=""ProductSpecificationAttribute.SpeficationAtributeTypeName""]')
            .val($('select[name=""ProductSpecificationAttribute.AttributeTypeId""] option:selected').text());
        $('input[name=""ProductSpecificationAttribute.SpecificationAttributeOptionName""]')
            .val($('select[name=""ProductSpecificationAttribute.SpecificationAttributeOptionId""] option:selected').text());

        var data = $(""#ProductSpeficationCreate"").serialize();
        $.ajax({
            type: ""Post"",
            url: ""/Admin/AdminProduct/ProductSpeficationCreate?"" + data,
            dataType: ""json"",
            success: function (data) {
                swal(""i??lem ba??ar??l??"", """", ""success"");
                console.log(data);
      ");
            WriteLiteral("          $(\"#ProductSpeficationList\").DataTable().row.add(data).draw();\r\n            }\r\n        });\r\n    });\r\n</script>");
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
