#pragma checksum "D:\Visual Studio\AOS-Aquarium-Online-Shop\AOS-Aquarium-Online-Shop\Shop\Views\Orders\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3979faba512938f394c98744de0ec64a86eb44ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Details), @"mvc.1.0.view", @"/Views/Orders/Details.cshtml")]
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
#line 1 "D:\Visual Studio\AOS-Aquarium-Online-Shop\AOS-Aquarium-Online-Shop\Shop\Views\_ViewImports.cshtml"
using Shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Visual Studio\AOS-Aquarium-Online-Shop\AOS-Aquarium-Online-Shop\Shop\Views\_ViewImports.cshtml"
using Shop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3979faba512938f394c98744de0ec64a86eb44ca", @"/Views/Orders/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92e2ba627270339132bff3ddc82f3cdb3fe61485", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Orders_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Shop.Models.OrderDetail>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Product"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("product"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Visual Studio\AOS-Aquarium-Online-Shop\AOS-Aquarium-Online-Shop\Shop\Views\Orders\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 8 "D:\Visual Studio\AOS-Aquarium-Online-Shop\AOS-Aquarium-Online-Shop\Shop\Views\Orders\Details.cshtml"
  
    ViewData["Title"] = "Index";
    var format = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main>
    <!-- breadcrumb area start -->
    <div class=""breadcrumb-area"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""breadcrumb-wrap"">
                        <nav aria-label=""breadcrumb"">
                            <ul class=""breadcrumb"">
                                <li class=""breadcrumb-item""><a href=""index.html""><i class=""fa fa-home""></i></a></li>
                                <li class=""breadcrumb-item""><a href=""shop.html"">shop</a></li>
                                <li class=""breadcrumb-item active"" aria-current=""page"">Order Details</li>
                            </ul>
                        </nav>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- breadcrumb area end -->
    <!-- cart main wrapper start -->
    <div class=""cart-main-wrapper section-padding"">
        <div class=""container"">
            <div class=""section-bg-co");
            WriteLiteral(@"lor"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <!-- Cart Table Area -->
                        <div class=""cart-table table-responsive"">
                            <table class=""table table-bordered"">
                                <thead>
                                    <tr>
                                        <th class=""pro-thumbnail"">Thumbnail</th>
                                        <th class=""pro-title"">Product</th>
                                        <th class=""pro-price"">Price</th>
                                        <th class=""pro-quantity"">Quantity</th>
                                        <th class=""pro-subtotal"">Total</th>
                      
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 53 "D:\Visual Studio\AOS-Aquarium-Online-Shop\AOS-Aquarium-Online-Shop\Shop\Views\Orders\Details.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n");
#nullable restore
#line 56 "D:\Visual Studio\AOS-Aquarium-Online-Shop\AOS-Aquarium-Online-Shop\Shop\Views\Orders\Details.cshtml"
                                              
                                                string[] arrListStr = item.Product.ProductImage.Split(' ');
                                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td class=\"pro-thumbnail\"><a href=\"#\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3979faba512938f394c98744de0ec64a86eb44ca7745", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2592, "~/images/", 2592, 9, true);
#nullable restore
#line 59 "D:\Visual Studio\AOS-Aquarium-Online-Shop\AOS-Aquarium-Online-Shop\Shop\Views\Orders\Details.cshtml"
AddHtmlAttributeValue("", 2601, arrListStr[0], 2601, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a></td>\r\n                                            <td class=\"pro-title\"><a");
            BeginWriteAttribute("href", " href=\"", 2712, "\"", 2752, 2);
            WriteAttributeValue("", 2719, "/Products/Details/", 2719, 18, true);
#nullable restore
#line 60 "D:\Visual Studio\AOS-Aquarium-Online-Shop\AOS-Aquarium-Online-Shop\Shop\Views\Orders\Details.cshtml"
WriteAttributeValue("", 2737, item.ProductId, 2737, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 60 "D:\Visual Studio\AOS-Aquarium-Online-Shop\AOS-Aquarium-Online-Shop\Shop\Views\Orders\Details.cshtml"
                                                                                                         Write(item.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                            <td class=\"pro-price\"><span><input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 2880, "\"", 2943, 1);
#nullable restore
#line 61 "D:\Visual Studio\AOS-Aquarium-Online-Shop\AOS-Aquarium-Online-Shop\Shop\Views\Orders\Details.cshtml"
WriteAttributeValue("", 2888, String.Format(format,"{0:c0}", @item.Product.OutPrice), 2888, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly id=\"price\" /></span></td>\r\n                                            <td class=\"pro-quantity\">\r\n                                                <div class=\"pro-quantity\">\r\n                                                    <div");
            BeginWriteAttribute("class", " class=\"", 3184, "\"", 3192, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        <input size=\"4\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 3279, "\"", 3301, 1);
#nullable restore
#line 65 "D:\Visual Studio\AOS-Aquarium-Online-Shop\AOS-Aquarium-Online-Shop\Shop\Views\Orders\Details.cshtml"
WriteAttributeValue("", 3287, item.Quantity, 3287, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    </div>\r\n                                                    </div>\r\n                                            </td>\r\n");
#nullable restore
#line 69 "D:\Visual Studio\AOS-Aquarium-Online-Shop\AOS-Aquarium-Online-Shop\Shop\Views\Orders\Details.cshtml"
                                              
                                                var pricetotla = item.Quantity * item.Price;
                                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td class=\"pro-subtotal\"><span>");
#nullable restore
#line 72 "D:\Visual Studio\AOS-Aquarium-Online-Shop\AOS-Aquarium-Online-Shop\Shop\Views\Orders\Details.cshtml"
                                                                      Write(String.Format(format, "{0:c0}", @pricetotla));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                                           \r\n                                        </tr>\r\n");
#nullable restore
#line 75 "D:\Visual Studio\AOS-Aquarium-Online-Shop\AOS-Aquarium-Online-Shop\Shop\Views\Orders\Details.cshtml"
                                     
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                        <!-- Cart Update Option -->
                     
                    </div>
                </div>
       
            </div>
        </div>
    </div>
    <!-- cart main wrapper end -->
</main>
<div class=""offcanvas-minicart-wrapper"">
    <div class=""minicart-inner"">
        <div class=""offcanvas-overlay""></div>
        <div class=""minicart-inner-content"">
            <div class=""minicart-close"">
                <i class=""pe-7s-close""></i>
            </div>
            <div class=""minicart-content-box"">
                <div class=""minicart-item-wrapper"">
");
#nullable restore
#line 99 "D:\Visual Studio\AOS-Aquarium-Online-Shop\AOS-Aquarium-Online-Shop\Shop\Views\Orders\Details.cshtml"
                      
                        Double totlalprice = 0;
                        IEnumerable<OrderDetail> orderderail = ViewData["orderdeatail"] as IEnumerable<OrderDetail>;
                        if (orderderail == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"minicart-item\">\r\n\r\n                            </li>\r\n");
#nullable restore
#line 107 "D:\Visual Studio\AOS-Aquarium-Online-Shop\AOS-Aquarium-Online-Shop\Shop\Views\Orders\Details.cshtml"
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "D:\Visual Studio\AOS-Aquarium-Online-Shop\AOS-Aquarium-Online-Shop\Shop\Views\Orders\Details.cshtml"
                             foreach (OrderDetail ord in orderderail)
                            {
                                totlalprice += Convert.ToDouble(ord.Price * ord.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"minicart-item\">\r\n                                    <div class=\"minicart-thumb\">\r\n");
#nullable restore
#line 115 "D:\Visual Studio\AOS-Aquarium-Online-Shop\AOS-Aquarium-Online-Shop\Shop\Views\Orders\Details.cshtml"
                                          
                                            string[] arrListStr = ord.Product.ProductImage.Split(' ');
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a href=\"product-details.html\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3979faba512938f394c98744de0ec64a86eb44ca15795", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5771, "~/images/", 5771, 9, true);
#nullable restore
#line 119 "D:\Visual Studio\AOS-Aquarium-Online-Shop\AOS-Aquarium-Online-Shop\Shop\Views\Orders\Details.cshtml"
AddHtmlAttributeValue("", 5780, arrListStr[0], 5780, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        </a>
                                    </div>
                                    <div class=""minicart-content"">
                                        <h6 class=""product-name"">
                                            <a");
            BeginWriteAttribute("href", " href=\"", 6083, "\"", 6123, 2);
            WriteAttributeValue("", 6090, "/Products/Details/", 6090, 18, true);
#nullable restore
#line 124 "D:\Visual Studio\AOS-Aquarium-Online-Shop\AOS-Aquarium-Online-Shop\Shop\Views\Orders\Details.cshtml"
WriteAttributeValue("", 6108, ord.Product.Id, 6108, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 124 "D:\Visual Studio\AOS-Aquarium-Online-Shop\AOS-Aquarium-Online-Shop\Shop\Views\Orders\Details.cshtml"
                                                                                   Write(ord.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        </h6>\r\n                                        <p>\r\n                                            <span class=\"cart-quantity\">");
#nullable restore
#line 127 "D:\Visual Studio\AOS-Aquarium-Online-Shop\AOS-Aquarium-Online-Shop\Shop\Views\Orders\Details.cshtml"
                                                                   Write(ord.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("<strong>&times;</strong></span>\r\n                                            <span class=\"cart-price\"></span>\r\n                                        </p>\r\n                                    </div>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 6571, "\"", 6602, 2);
            WriteAttributeValue("", 6578, "/AddOrder/Delete/", 6578, 17, true);
#nullable restore
#line 131 "D:\Visual Studio\AOS-Aquarium-Online-Shop\AOS-Aquarium-Online-Shop\Shop\Views\Orders\Details.cshtml"
WriteAttributeValue("", 6595, ord.Id, 6595, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"minicart-remove\"><i class=\"pe-7s-close\"></i></a>\r\n                                </li>\r\n");
#nullable restore
#line 133 "D:\Visual Studio\AOS-Aquarium-Online-Shop\AOS-Aquarium-Online-Shop\Shop\Views\Orders\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 133 "D:\Visual Studio\AOS-Aquarium-Online-Shop\AOS-Aquarium-Online-Shop\Shop\Views\Orders\Details.cshtml"
                             
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n\r\n                <div class=\"minicart-pricing-box\">\r\n                    <ul>\r\n                        <li class=\"total\">\r\n                            <span>total</span>\r\n                            <span><strong>");
#nullable restore
#line 142 "D:\Visual Studio\AOS-Aquarium-Online-Shop\AOS-Aquarium-Online-Shop\Shop\Views\Orders\Details.cshtml"
                                     Write(String.Format(format, "{0:c0}", @totlalprice));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong></span>
                        </li>
                    </ul>
                </div>

                <div class=""minicart-button"">
                    <a href=""/OrderDetails""><i class=""fa fa-shopping-cart""></i> View Cart</a>
                </div>
            </div>
        </div>
    </div>
</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Shop.Models.OrderDetail>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
