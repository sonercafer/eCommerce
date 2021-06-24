#pragma checksum "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0f1eca0222bc85660d2cb8ad72e3370b21e23ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Discount_DiscountEdit), @"mvc.1.0.view", @"/Areas/Admin/Views/Discount/DiscountEdit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0f1eca0222bc85660d2cb8ad72e3370b21e23ba", @"/Areas/Admin/Views/Discount/DiscountEdit.cshtml")]
    public class Areas_Admin_Views_Discount_DiscountEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.ViewModels.Admin.DiscountModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountEdit.cshtml"
  
    ViewData["Title"] = "DiscountEdit";
    Layout = "~/Views/Shared/_AdminLayoutPage1.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""content"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card "">
                <div class=""card-header"">
                    <div class=""col-md-4"" style=""float:left;"">
                        <h2 class=""card-title"">İndirim Düzenle</h2>
                    </div>

                </div>
                <div class=""card-body"">

");
#nullable restore
#line 20 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountEdit.cshtml"
                     using (Html.BeginForm("DiscountEdit", "Discount", FormMethod.Post))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div style=\"display: flex; flex-wrap: wrap;\">\r\n                            ");
#nullable restore
#line 23 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountEdit.cshtml"
                       Write(Html.HiddenFor(x=>x.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <div class=\"form-group col-md-12\">\r\n                                ");
#nullable restore
#line 25 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountEdit.cshtml"
                           Write(Html.LabelFor(x => x.Name, "İsmi", new {@class = "control-label col-md-2"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                <div class=\"col-md-10\">\r\n                                    ");
#nullable restore
#line 28 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountEdit.cshtml"
                               Write(Html.TextBoxFor(x => x.Name, new {@class = "form-control  col-md-7"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n\r\n\r\n                            <div class=\"form-group col-md-12\">\r\n                                ");
#nullable restore
#line 34 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountEdit.cshtml"
                           Write(Html.LabelFor(x => x.AdminComment, "Admin Açıklaması", new {@class = "control-label col-md-2"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                <div class=\"col-md-10\">\r\n                                    ");
#nullable restore
#line 37 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountEdit.cshtml"
                               Write(Html.TextBoxFor(x => x.AdminComment, new {@class = "form-control  col-md-7"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n\r\n                            <div class=\"form-group col-md-12\">\r\n                                ");
#nullable restore
#line 42 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountEdit.cshtml"
                           Write(Html.LabelFor(x => x.DiscountTypeId, "Discount Tipi", new {@class = "control-label col-md-2"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                <div class=\"col-md-10\">\r\n                                    ");
#nullable restore
#line 45 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountEdit.cshtml"
                               Write(Html.DropDownListFor(model => model.DiscountTypeId, Model.DiscountTypeList, new { @class = " form-control col-md-7 " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n\r\n\r\n                            <div class=\"form-group col-md-12\" id=\"subcategoryshowhide\">\r\n                                ");
#nullable restore
#line 51 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountEdit.cshtml"
                           Write(Html.LabelFor(x => x.AppliedToSubCategories, "Alt Kategorilere Uygula", new {@class = "control-label col-md-2"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                <div class=\"col-md-10\">\r\n                                    ");
#nullable restore
#line 54 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountEdit.cshtml"
                               Write(Html.CheckBoxFor(x => x.AppliedToSubCategories));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n\r\n\r\n                            <div class=\"form-group col-md-12\" id=\"MaximumDiscountedQuantityshowhide\">\r\n                                ");
#nullable restore
#line 60 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountEdit.cshtml"
                           Write(Html.LabelFor(x => x.MaximumDiscountedQuantity, "Maximum indirim adeti", new {@class = "control-label col-md-2"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                <div class=\"col-md-10\">\r\n                                    ");
#nullable restore
#line 63 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountEdit.cshtml"
                               Write(Html.TextBoxFor(x => x.MaximumDiscountedQuantity, new {@class = "form-control  col-md-7"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n\r\n\r\n\r\n\r\n\r\n                            <div class=\"form-group col-md-12\" id=\"DiscountAmountshowhide\">\r\n                                ");
#nullable restore
#line 72 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountEdit.cshtml"
                           Write(Html.LabelFor(x => x.DiscountAmount, "İndirim Miktarı", new {@class = "control-label col-md-2"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                <div class=\"col-md-10\">\r\n                                    ");
#nullable restore
#line 75 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountEdit.cshtml"
                               Write(Html.TextBoxFor(x => x.DiscountAmount, new {@class = "form-control  col-md-7", @type = "number", @min = "0", @step = "0.01", @value = "0.00"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n\r\n\r\n\r\n\r\n\r\n                            <div class=\"form-group col-md-12\">\r\n                                ");
#nullable restore
#line 84 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountEdit.cshtml"
                           Write(Html.LabelFor(x => x.UsePercentage, "Kullanım Yüzdesi", new {@class = "control-label col-md-2"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                <div class=\"col-md-10\">\r\n                                    ");
#nullable restore
#line 87 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountEdit.cshtml"
                               Write(Html.CheckBoxFor(x => x.UsePercentage));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>

                            <div id=""percentagetruefalse"" class=""col-md-12"">

                                <div class=""form-group col-md-12"">
                                    ");
#nullable restore
#line 94 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountEdit.cshtml"
                               Write(Html.LabelFor(x => x.DiscountPercentage, "İndirim Yüzdesi", new {@class = "control-label col-md-2"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                    <div class=\"col-md-10\">\r\n                                        ");
#nullable restore
#line 97 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountEdit.cshtml"
                                   Write(Html.TextBoxFor(x => x.DiscountPercentage, new {@class = "form-control  col-md-7", @type = "number", @min = "0", @step = "0.01", @value = "0.00"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n\r\n                                <div class=\"form-group col-md-12\">\r\n                                    ");
#nullable restore
#line 102 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountEdit.cshtml"
                               Write(Html.LabelFor(x => x.MaximumDiscountAmount, "Maximum İndirim miktarı", new {@class = "control-label col-md-2"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                    <div class=\"col-md-10\">\r\n                                        ");
#nullable restore
#line 105 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountEdit.cshtml"
                                   Write(Html.TextBoxFor(x => x.MaximumDiscountAmount, new {@class = "form-control  col-md-7", @type = "number", @min = "0", @step = "0.01", @value = "0.00"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n\r\n                            <div class=\"form-group col-md-12\">\r\n                                ");
#nullable restore
#line 111 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountEdit.cshtml"
                           Write(Html.LabelFor(x => x.StartDateUtcFormat, "Başlangıç tarihi", new {@class = "control-label col-md-2"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                <div class=\"col-md-10\">\r\n                                    ");
#nullable restore
#line 114 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountEdit.cshtml"
                               Write(Html.TextBoxFor(x => x.StartDateUtcFormat, new {@class = "form-control  col-md-7", @type = "datetime-local"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n\r\n                            <div class=\"form-group col-md-12\">\r\n                                ");
#nullable restore
#line 119 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountEdit.cshtml"
                           Write(Html.LabelFor(x => x.EndDateUtcFormat, "Bitiş tarihi", new {@class = "control-label col-md-2"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                <div class=\"col-md-10\">\r\n                                    ");
#nullable restore
#line 122 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountEdit.cshtml"
                               Write(Html.TextBoxFor(x => x.EndDateUtcFormat, new {@class = "form-control  col-md-7", @type = "datetime-local"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n\r\n\r\n\r\n                            <div class=\"form-group col-md-12\">\r\n                                ");
#nullable restore
#line 129 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountEdit.cshtml"
                           Write(Html.LabelFor(x => x.RequiresCouponCode, "Kupon Kodu kullanılsınmı", new {@class = "control-label col-md-2"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                <div class=\"col-md-10\">\r\n                                    ");
#nullable restore
#line 132 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountEdit.cshtml"
                               Write(Html.CheckBoxFor(x => x.RequiresCouponCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n\r\n                            <div class=\"form-group col-md-12\" id=\"Kuponkodushowhide\">\r\n\r\n                                ");
#nullable restore
#line 138 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountEdit.cshtml"
                           Write(Html.LabelFor(x => x.CouponCode, "Kupon Kodu ", new {@class = "control-label col-md-2"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                <div class=\"col-md-10\">\r\n                                    ");
#nullable restore
#line 141 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountEdit.cshtml"
                               Write(Html.TextBoxFor(x => x.CouponCode, new {@class = "form-control  col-md-7"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n\r\n\r\n\r\n\r\n\r\n                            <div class=\"form-group col-md-12\">\r\n                                ");
#nullable restore
#line 150 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountEdit.cshtml"
                           Write(Html.LabelFor(x => x.DiscountLimitationId, "İndirim limit", new {@class = "control-label col-md-2"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                <div class=\"col-md-10\">\r\n                                    ");
#nullable restore
#line 153 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountEdit.cshtml"
                               Write(Html.DropDownList("DiscountLimitationId", Model.DiscountLimitationList, new {@class = "form-control col-md-7"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n\r\n                            <div class=\"form-group col-md-12\" id=\"LimitationTimesshowhide\">\r\n                                ");
#nullable restore
#line 158 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountEdit.cshtml"
                           Write(Html.LabelFor(x => x.LimitationTimes, "LimitationTimes", new {@class = "control-label col-md-2"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                <div class=\"col-md-10\">\r\n                                    ");
#nullable restore
#line 161 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountEdit.cshtml"
                               Write(Html.TextBoxFor(x => x.LimitationTimes, new {@class = "form-control  col-md-7"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>







                            <div class=""form-group col-md-12"">


                                <div class=""col-md-10"">
                                    <input type=""submit"" class=""btn btn-default""/>
                                </div>
                            </div>


                        </div>
");
#nullable restore
#line 181 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountEdit.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</div>

<script>
    $(document).ready(function () {

        if ($(""#UsePercentage"").is("":checked"") == false)
            $(""#percentagetruefalse"").hide();
        if ($(""#UsePercentage"").is("":checked"") == true)
            $(""#DiscountAmountshowhide"").hide();
        if ($(""#RequiresCouponCode"").is("":checked"") == false)
            $(""#Kuponkodushowhide"").hide();
        if ($(""#DiscountLimitationId"").val() == 0)
            $(""#LimitationTimesshowhide"").hide();
        if ($(""#DiscountTypeId"").val() != 5)
            $(""#subcategoryshowhide"").hide();
        if ($(""#DiscountTypeId"").val() != 5 || (""#DiscountTypeId"").val() !=6  || (""#DiscountTypeId"").val() != 2)
            $(""#MaximumDiscountedQuantityshowhide"").hide();


    })

    $(""#UsePercentage"").change(function () {

        if ($(this).is("":checked"")) {
            $(""#percentagetruefalse"").show();
            $(""#DiscountAmountshowhide"").hide();
    ");
            WriteLiteral(@"    }
        else {
            $(""#percentagetruefalse"").hide();
            $(""#DiscountAmountshowhide"").show();
        }
    });

    $(""#RequiresCouponCode"").change(function () {
        if ($(this).is("":checked"")) {
            $(""#Kuponkodushowhide"").show();
        }
        else {

            $(""#Kuponkodushowhide"").hide();
        }
    });

    $(""#DiscountLimitationId"").change(function () {
        if ($(this).val() != 0) {
            $(""#LimitationTimesshowhide"").show();
        }
        else {
            $(""#LimitationTimesshowhide"").hide();
        }
    });


    $(""#DiscountTypeId"").change(function () {
        if ($(this).val() == 5) {
            $(""#subcategoryshowhide"").show();
        }
        else {
            $(""#subcategoryshowhide"").hide();
        }


        if ($(""#DiscountTypeId"").val() == 5 || (""#DiscountTypeId"").val() == 6 || (""#DiscountTypeId"").val() == 2) {
            $(""#MaximumDiscountedQuantityshowhide"").show();
        }
    ");
            WriteLiteral("    else {\r\n            $(\"#MaximumDiscountedQuantityshowhide\").hide();\r\n        }\r\n\r\n\r\n\r\n\r\n    });\r\n\r\n\r\n\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities.ViewModels.Admin.DiscountModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
