#pragma checksum "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminSlider\SliderIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "826328f31b04e30066eaa99bb78d314a6d70ced6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminSlider_SliderIndex), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminSlider/SliderIndex.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"826328f31b04e30066eaa99bb78d314a6d70ced6", @"/Areas/Admin/Views/AdminSlider/SliderIndex.cshtml")]
    public class Areas_Admin_Views_AdminSlider_SliderIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.ViewModels.Admin.SliderModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/AdminSlider/SliderCreate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminSlider\SliderIndex.cshtml"
  
    ViewBag.Title = "SliderIndex";
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
                        <h2 class=""card-title"">Slider Listesi</h2>
                    </div>
                    <div class=""col-md-8"" style=""float:right;"">
                        <div class=""col-md-3"" style=""float:right;"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "826328f31b04e30066eaa99bb78d314a6d70ced63865", async() => {
                WriteLiteral("<button type=\"submit\" class=\"btn btn-outline-default pd10-50\" style=\"text-align:center;\">Ekle</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n                    </div>\r\n                </div>\r\n                <span class=\"card-body\">\r\n                    <table class=\"table tablesorter table-hover\">\r\n                        <thead");
            BeginWriteAttribute("class", " class=\"", 953, "\"", 961, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <tr>
                                <th>??d</th>
                                <th>Ba??l??k</th>
                                <th>Resim</th>
                                <th>Link</th>
                                <th>Yaz??</th>
                                <th> </th>

                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 38 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminSlider\SliderIndex.cshtml"
                             foreach (var item in Model.SliderList)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n\r\n                                    <td>");
#nullable restore
#line 43 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminSlider\SliderIndex.cshtml"
                                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 44 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminSlider\SliderIndex.cshtml"
                                   Write(item.SliderHeading);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td><img");
            BeginWriteAttribute("src", " src=\"", 1690, "\"", 1713, 1);
#nullable restore
#line 45 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminSlider\SliderIndex.cshtml"
WriteAttributeValue("", 1696, item.SliderImage, 1696, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"40px\" height=\"40px\" /></td>\r\n                                    <td>");
#nullable restore
#line 46 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminSlider\SliderIndex.cshtml"
                                   Write(item.SliderLink);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 47 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminSlider\SliderIndex.cshtml"
                                   Write(item.SliderText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td></td>\r\n                                    <td>\r\n\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 2010, "\"", 2039, 2);
            WriteAttributeValue("", 2017, "SliderEdit?id=", 2017, 14, true);
#nullable restore
#line 51 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminSlider\SliderIndex.cshtml"
WriteAttributeValue("", 2031, item.Id, 2031, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\'fa fa-edit datatableduzenle\' style=\'font-size:20px;\'></i></a>\r\n                                        <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2165, "\"", 2199, 3);
            WriteAttributeValue("", 2175, "DeleteFunction(", 2175, 15, true);
#nullable restore
#line 52 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminSlider\SliderIndex.cshtml"
WriteAttributeValue("", 2190, item.Id, 2190, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2198, ")", 2198, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2200, "\"", 2213, 1);
#nullable restore
#line 52 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminSlider\SliderIndex.cshtml"
WriteAttributeValue("", 2205, item.Id, 2205, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fa fa-trash-o datatablesil\" style=\"font-size:20px;\"></i></a>\r\n\r\n\r\n\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 58 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminSlider\SliderIndex.cshtml"


                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>

                </div>
            </div>
        </div>

    </div>
</div>
<script>
                            function DeleteFunction(id) {

                                console.log(id);
                                $.ajax({
                                    type: ""post"",
                                    url: ""SliderDelete?id="" + id,
                                    success: function (result) {
                                        $(""#"" + id).parent().parent().remove();
                                        pushalert(""Kay??t Silindi"",""success"");
                                    },
                                    error: function (result) {
                                        pushalert(""Kay??t Silinemedi"",""Danger"");
                                    }


                                });
                            }

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities.ViewModels.Admin.SliderModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
