#pragma checksum "C:\Users\NeslihanAlcglu\source\repos\CoreAndFood\CoreAndFood\Views\Default\Components\FoodGetList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e474cd5b0163574b1902d5bb37efe51459fd10b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_Components_FoodGetList_Default), @"mvc.1.0.view", @"/Views/Default/Components/FoodGetList/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e474cd5b0163574b1902d5bb37efe51459fd10b4", @"/Views/Default/Components/FoodGetList/Default.cshtml")]
    public class Views_Default_Components_FoodGetList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoreAndFood.Data.Models.Food>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"agile_top_brands_grids\">\r\n");
#nullable restore
#line 4 "C:\Users\NeslihanAlcglu\source\repos\CoreAndFood\CoreAndFood\Views\Default\Components\FoodGetList\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div style=""margin-bottom:50px;"" class=""col-md-3 top_brand_left"">
            <div class=""hover14 column"">
                <div class=""agile_top_brand_left_grid"">
                    <div class=""agile_top_brand_left_grid1"">
                        <figure>
                            <div class=""snipcart-item block"">
                                <div class=""snipcart-thumb"">
                                    <a href=""single.html""><img style=""width:250px; height:250px;"" title="" "" alt="" """);
            BeginWriteAttribute("src", " src=\"", 641, "\"", 661, 1);
#nullable restore
#line 13 "C:\Users\NeslihanAlcglu\source\repos\CoreAndFood\CoreAndFood\Views\Default\Components\FoodGetList\Default.cshtml"
WriteAttributeValue("", 647, item.ImageURL, 647, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                                    <p>");
#nullable restore
#line 14 "C:\Users\NeslihanAlcglu\source\repos\CoreAndFood\CoreAndFood\Views\Default\Components\FoodGetList\Default.cshtml"
                                  Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <h4>");
#nullable restore
#line 15 "C:\Users\NeslihanAlcglu\source\repos\CoreAndFood\CoreAndFood\Views\Default\Components\FoodGetList\Default.cshtml"
                                   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</h4><h6>Stok: ");
#nullable restore
#line 15 "C:\Users\NeslihanAlcglu\source\repos\CoreAndFood\CoreAndFood\Views\Default\Components\FoodGetList\Default.cshtml"
                                                               Write(item.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                                </div>
                                <div class=""snipcart-details top_brand_home_details"">
                                    <form action=""checkout.html"" method=""post"">
                                        <fieldset>
                                            <input type=""hidden"" name=""cmd"" value=""_cart"" />
                                            <input type=""hidden"" name=""add"" value=""1"" />
                                            <input type=""hidden"" name=""business"" value="" "" />
                                            <input type=""hidden"" name=""item_name"" value=""Fortune Sunflower Oil"" />
                                            <input type=""hidden"" name=""amount"" value=""7.99"" />
                                            <input type=""hidden"" name=""discount_amount"" value=""1.00"" />
                                            <input type=""hidden"" name=""currency_code"" value=""USD"" />
                                            <input type=""hi");
            WriteLiteral(@"dden"" name=""return"" value="" "" />
                                            <input type=""hidden"" name=""cancel_return"" value="" "" />
                                            <input type=""submit"" name=""submit"" value=""Sepete ekle"" class=""button"" />
                                        </fieldset>

                                    </form>

                                </div>
                            </div>
                        </figure>
                    </div>
                </div>
            </div>
        </div>
");
#nullable restore
#line 41 "C:\Users\NeslihanAlcglu\source\repos\CoreAndFood\CoreAndFood\Views\Default\Components\FoodGetList\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"clearfix\"> </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CoreAndFood.Data.Models.Food>> Html { get; private set; }
    }
}
#pragma warning restore 1591
