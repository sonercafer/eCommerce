#pragma checksum "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Showcase\ShowcaseCreate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3b57c8f26a66ac031fdc78b32cf5cbb6a65da75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Showcase_ShowcaseCreate), @"mvc.1.0.view", @"/Areas/Admin/Views/Showcase/ShowcaseCreate.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3b57c8f26a66ac031fdc78b32cf5cbb6a65da75", @"/Areas/Admin/Views/Showcase/ShowcaseCreate.cshtml")]
    public class Areas_Admin_Views_Showcase_ShowcaseCreate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.ViewModels.Admin.ShowCaseModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Showcase\ShowcaseCreate.cshtml"
  
    ViewBag.Title = "ShowcaseCreate";
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
                        <h2 class=""card-title"">Showcase Ekle</h2>
                    </div>
                    <div class=""col-md-8"" style=""float:right;"">
                      
                    </div>
                </div>
                <div class=""card-body"">
                    <div class=""tab-content"">
                        <div id=""home"" class=""tab-pane  active "">

");
#nullable restore
#line 25 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Showcase\ShowcaseCreate.cshtml"
                             if (ViewBag.Message != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <script>\r\n                                pushalert(\"");
#nullable restore
#line 28 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Showcase\ShowcaseCreate.cshtml"
                                      Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\"");
#nullable restore
#line 28 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Showcase\ShowcaseCreate.cshtml"
                                                         Write(ViewBag.AlertType);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n\r\n                                </script>\r\n");
#nullable restore
#line 31 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Showcase\ShowcaseCreate.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 33 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Showcase\ShowcaseCreate.cshtml"
                             using (Html.BeginForm())
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Showcase\ShowcaseCreate.cshtml"
                           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"form-horizontal\">\r\n                                    <hr />\r\n                                    ");
#nullable restore
#line 39 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Showcase\ShowcaseCreate.cshtml"
                               Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <div class=\"form-group\">\r\n                                        <div class=\"col-md-2\"> Sıra</div>\r\n\r\n                                        <div class=\"col-md-10\">\r\n                                            ");
#nullable restore
#line 44 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Showcase\ShowcaseCreate.cshtml"
                                       Write(Html.EditorFor(model => model.ShowCaseOrder, new { htmlAttributes = new { @class = "form-control col-md-6" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            ");
#nullable restore
#line 45 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Showcase\ShowcaseCreate.cshtml"
                                       Write(Html.ValidationMessageFor(model => model.ShowCaseOrder, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </div>
                                    </div>

                                    <div class=""form-group"">
                                        <div class=""col-md-2""> Başlık</div>
                                        <div class=""col-md-10"">
                                            ");
#nullable restore
#line 52 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Showcase\ShowcaseCreate.cshtml"
                                       Write(Html.EditorFor(model => model.ShowCaseTitle, new { htmlAttributes = new { @class = "form-control col-md-6" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            ");
#nullable restore
#line 53 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Showcase\ShowcaseCreate.cshtml"
                                       Write(Html.ValidationMessageFor(model => model.ShowCaseTitle, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </div>
                                    </div>

                                    <div class=""form-group"">
                                        <div class=""col-md-2""> Show Case Tipi</div>
                                        <div class=""col-md-10"">
                                            ");
#nullable restore
#line 60 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Showcase\ShowcaseCreate.cshtml"
                                       Write(Html.DropDownListFor(x => x.ShowCaseType, Model.ShowCaseTypeList, new {@class = "form-control col-md-6"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                            ");
#nullable restore
#line 62 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Showcase\ShowcaseCreate.cshtml"
                                       Write(Html.ValidationMessageFor(model => model.ShowCaseType, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </div>
                                    </div>

                                    <div class=""form-group"">
                                        <div class=""col-md-offset-2 col-md-10"">
                                            <input type=""submit"" value=""Kaydet"" class=""btn btn-default"" />
                                        </div>
                                    </div>
                                </div>
");
#nullable restore
#line 72 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Showcase\ShowcaseCreate.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <br /> <br />\r\n                            <div>\r\n                                ");
#nullable restore
#line 75 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Showcase\ShowcaseCreate.cshtml"
                           Write(Html.ActionLink("Geri Dön", "ShowcaseList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities.ViewModels.Admin.ShowCaseModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
