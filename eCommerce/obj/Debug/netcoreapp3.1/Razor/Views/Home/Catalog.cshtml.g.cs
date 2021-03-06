#pragma checksum "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\Home\Catalog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6322299d0ac20b6178eb3fac1a4926e4a2857529"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Catalog), @"mvc.1.0.view", @"/Views/Home/Catalog.cshtml")]
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
#line 1 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\_ViewImports.cshtml"
using eCommerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\_ViewImports.cshtml"
using Entities.ViewModels.Web;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6322299d0ac20b6178eb3fac1a4926e4a2857529", @"/Views/Home/Catalog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d30ff6fdd824442f6f381f94596e08d04456b7d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Catalog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.ViewModels.Web.Catalog>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/ProductDetail?productid={{product.Id}}&combinationId={{product.ProductAttributeCombination.Id}}"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\Home\Catalog.cshtml"
  
    ViewBag.Title = "Catalog";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- BREADCRUMB -->
<div id=""breadcrumb"">
    <div class=""container"">
        <ul class=""breadcrumb"">
            <li><a href=""#"">Home</a></li>
            <li class=""active"">Products</li>
        </ul>
    </div>
</div>
<!-- /BREADCRUMB -->


<div >

    <div ng-controller=""Catalog"">


        <!-- section -->
        <div class=""section"">
            <!-- container -->
            <div class=""container"">
                <!-- row -->
                <div class=""row"">
                    <!-- ASIDE -->
                    <div id=""aside"" class=""col-md-3"" style=""box-sizing: border-box; margin-right: 0px;padding: 25px;"">
                        <div class=""aside"">
                            <button class=""aside-title btncollapsecatalog"" type=""button"" data-toggle=""collapse""
                                    data-target=""#collapseExamplebrand"" aria-expanded=""false""
                                    aria-controls=""collapseExample"">
                                Markalar <i s");
            WriteLiteral("tyle=\"float:right;\" class=\"fa fa-arrow-down\"></i>\r\n                            </button>\r\n                            <div class=\"collapse collapsehome in\" id=\"collapseExamplebrand\">\r\n                                <div class=\"card card-body\"");
            BeginWriteAttribute("ng-init", " ng-init=\"", 1393, "\"", 1439, 3);
            WriteAttributeValue("", 1403, "GetAllBrandFilter(", 1403, 18, true);
#nullable restore
#line 40 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\Home\Catalog.cshtml"
WriteAttributeValue("", 1421, Model.CategoryId, 1421, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1438, ")", 1438, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">

                                    <ul ng-repeat=""Brand in BrandData"">
                                        <li class=""filter-list"">
                                            <input class=""pixel-radio"" type=""checkbox"" ng-model=""Brand.checked""
                                                   value=""{{Brand.Id}}"" ng-change=""BrandFilter(Brand)""> &nbsp;
                                            {{Brand.BrandName}}
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>

                        <div class=""aside"">
                            <button class=""aside-title btncollapsecatalog"" type=""button"" data-toggle=""collapse""
                                    data-target=""#collapseExampleprice"" aria-expanded=""false""
                                    aria-controls=""collapseExample"">
                                Fiyat <i style=""float:right;"" class");
            WriteLiteral(@"=""fa fa-arrow-down""></i>
                            </button>
                            <div class=""collapse in"" id=""collapseExampleprice"">
                                <div class=""value-wrapper d-flex price-range-area"" style=""display:flex;"">
                                    <div class=""minPrice"">
                                        <input type=""text"" placeholder=""En Az"" class=""form-control""
                                               name=""minPrice"" ng-model=""minPrice"" />
                                    </div>
                                    <div class=""pricecenter"">&nbsp;</div>
                                    <div class=""maxPrice"">
                                        <input type=""text"" placeholder=""En ??ok"" class=""form-control"" ng-true-value=""9999999""
                                               name=""maxPrice"" ng-model=""maxPrice"" />
                                    </div>&nbsp;

                                    <div class=""search"">
                     ");
            WriteLiteral("                   <input type=\"button\" value=\"Ara\"\r\n                                               class=\"pricesearch btn btn-default\"");
            BeginWriteAttribute("ng-click", "\r\n                                               ng-click=\"", 3623, "\"", 3713, 3);
            WriteAttributeValue("", 3682, "GetAllData(", 3682, 11, true);
#nullable restore
#line 74 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\Home\Catalog.cshtml"
WriteAttributeValue("", 3693, Model.CategoryId, 3693, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3710, ",1)", 3710, 3, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n\r\n\r\n                        <div");
            BeginWriteAttribute("ng-init", " ng-init=\"", 3903, "\"", 3952, 3);
            WriteAttributeValue("", 3913, "GetAllCategoryFilter(", 3913, 21, true);
#nullable restore
#line 81 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\Home\Catalog.cshtml"
WriteAttributeValue("", 3934, Model.CategoryId, 3934, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3951, ")", 3951, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                            <div ng-repeat=""Filter in CatalogFilterData "">
                                <div class=""aside"">
                                    <button class=""aside-title btncollapsecatalog"" type=""button"" data-toggle=""collapse""
                                            data-target="".{{Filter.Name}}"" aria-expanded=""false"" aria-controls=""collapseExample"">
                                                {{Filter.Name}}
                                                <i style=""float:right;"" class=""fa fa-arrow-down""></i>
                                    </button>
                                    <div class=""filter-list collapse in collapsehome {{Filter.Name}}"">

                                        <div class=""sidebar-categories""
                                             ng-repeat=""Option in Filter.SpecificationAttributeOptionList"">
                                            <div class=""main-categories"">
                                                <div class=""fi");
            WriteLiteral(@"lter-list"">
                                                    <input class=""pixel-radio"" type=""checkbox"" ng-model=""Option.checked""
                                                           value=""{{Option.Name}}""
                                                           ng-change=""SpeficationFilter(Option)"">
                                                    &nbsp;{{Option.Name}}
                                                </div>
                                            </div>
                                        </div>

                                    </div>
                                </div>
                            </div>
                        </div>




                    </div>
                    <!-- /ASIDE -->
                    <!-- MAIN -->
                    <div id=""main"" class=""col-md-9"">
                        <!-- store top filter -->
                        <div class=""store-filter clearfix "">
                            <div class=""pull-r");
            WriteLiteral("ight\">\r\n");
            WriteLiteral("                                <div class=\"sort-filter\">\r\n                                    <span class=\"text-uppercase\">Sort By:</span>\r\n                                    ");
#nullable restore
#line 124 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\Home\Catalog.cshtml"
                               Write(Html.DropDownListFor(model => model.Sortingenum,
                                                               (List<SelectListItem>)ViewBag.Sortingenum, new
                                                                    {
                                                                        ng_model = "Sortingenum",
                                                                        ng_change
                                                                    = "GetAllData(" + @Model.CategoryId + ",1)",
                                                                        @class = "input"
                                                                    }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                </div>
                            </div>

                        </div>
                        <!-- /store top filter -->
                        <!-- STORE -->
                        <div id=""store"">
                            <!-- row -->
                            <div style=""display:flex;flex-wrap:wrap;"" class=""row""");
            BeginWriteAttribute("ng-init", " ng-init=\"", 7531, "\"", 7588, 5);
            WriteAttributeValue("", 7541, "GetAllData(", 7541, 11, true);
#nullable restore
#line 141 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\Home\Catalog.cshtml"
WriteAttributeValue("", 7552, Model.CategoryId, 7552, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7569, ",", 7569, 1, true);
#nullable restore
#line 141 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\Home\Catalog.cshtml"
WriteAttributeValue("", 7570, Model.pageNumber, 7570, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7587, ")", 7587, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                <div ng-repeat=""product in ProductData"" class=""col-md-4 col-sm-6 col-xs-6"">
                                    <div class=""product product-single"">

                                        <div class=""product-thumb"">
                                            <div class=""product-label"">
                                                <span>New</span>
                                                <span class=""sale""
                                                      ng-if=""product.ProductDiscount > 0"">-{{(((product.ProductPrice-product.ProductDiscount)-product.ProductPrice)/product.ProductPrice)*-100  | number:0}}%</span>
                                            </div>
                                            <button class=""main-btn quick-view"">
                                                
                                                <i class=""fa fa-search-plus""></i>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6322299d0ac20b6178eb3fac1a4926e4a285752914692", async() => {
                WriteLiteral("??r??n?? ??ncele");
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
            WriteLiteral(@"
                                            </button>
                                            <img src=""{{product.ProductPhotoModel.ProductPhotoName}}"" width=""253""
                                            height=""350"">
                                        </div>
                                            <div class=""product-body"">
                                                <h3 class=""product-price"" ng-if=""product.ProductDiscount===0"">
                                                    {{product.ProductPrice | number }} TL <del class=""product-old-price"">$45.00</del>
                                                </h3>
                                                <h3 class=""product-price"" ng-if=""product.ProductDiscount > 0"">
                                                    {{product.ProductPrice-product.ProductDiscount}} TL <del class=""product-old-price"">
                                                        {{product.ProductPrice | number }}
                              ");
            WriteLiteral(@"                          TL
                                                    </del>
                                                </h3>

                                                <h2 class=""product-name""><a href=""#"">{{product.ProductName}}</a></h2>
                                            </div>
                                        </div>
                                    </div>



                                </div>
                                <!-- /row -->
                            </div>
                            <!-- /STORE -->
                            <!-- store bottom filter -->
                            <div class=""store-filter clearfix"">
                                <div class=""pagging"">
                                    <p>{{CurrentPage}} of {{TotalPages}} pages</p>
                                    <ul class=""pagination"">
                                        <li>
                                            <a href=""#""");
            BeginWriteAttribute("ng-click", " ng-click=\"", 10693, "\"", 10745, 3);
            WriteAttributeValue("", 10704, "GetAllData(", 10704, 11, true);
#nullable restore
#line 186 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\Home\Catalog.cshtml"
WriteAttributeValue("", 10715, Model.CategoryId, 10715, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 10732, ",BackwardOne)", 10732, 13, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                                <i class=""fa fa-fast-backward""></i>
                                            </a>
                                            <a class=""page-number active page-item"" ng-repeat=""data in PageNumberArray""");
            BeginWriteAttribute("ng-click", "\r\n                                               ng-click=\"", 11003, "\"", 11096, 3);
            WriteAttributeValue("", 11062, "GetAllData(", 11062, 11, true);
#nullable restore
#line 190 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\Home\Catalog.cshtml"
WriteAttributeValue("", 11073, Model.CategoryId, 11073, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 11090, ",data)", 11090, 6, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\">\r\n                                                {{data}}\r\n                                                &nbsp;&nbsp;\r\n                                            </a>\r\n                                            <a href=\"#\"");
            BeginWriteAttribute("ng-click", " ng-click=\"", 11334, "\"", 11385, 3);
            WriteAttributeValue("", 11345, "GetAllData(", 11345, 11, true);
#nullable restore
#line 194 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\Home\Catalog.cshtml"
WriteAttributeValue("", 11356, Model.CategoryId, 11356, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 11373, ",ForwardOne)", 11373, 12, true);
            EndWriteAttribute();
            WriteLiteral(@"
                                               ng-show=""showForwardBtn""><i class=""fa fa-fast-forward""></i></a>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                            <!-- /store bottom filter -->
                        </div>
                        <!-- /MAIN -->
                    </div>
                    <!-- /row -->
                </div>
                <!-- /container -->
            </div>
            <!-- /section -->
        </div>
    </div>


    <script type=""text/javascript"">
        $("".card-product__browsebtn"").hide();
        $("".catalogcard"").mouseover(function () {
            $(this).find("".card-product__browsebtn"").show();
        });
        $("".catalogcard"").mouseout(function () {
            $(this).find("".card-product__browsebtn"").hide();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities.ViewModels.Web.Catalog> Html { get; private set; }
    }
}
#pragma warning restore 1591
