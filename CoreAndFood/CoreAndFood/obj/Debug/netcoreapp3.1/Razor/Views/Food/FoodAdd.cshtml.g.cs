#pragma checksum "C:\Users\NeslihanAlcglu\source\repos\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "285a71f73331a7cacd764d362bed64304289e60e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Food_FoodAdd), @"mvc.1.0.view", @"/Views/Food/FoodAdd.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"285a71f73331a7cacd764d362bed64304289e60e", @"/Views/Food/FoodAdd.cshtml")]
    public class Views_Food_FoodAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreAndFood.Data.Models.urunekle>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\NeslihanAlcglu\source\repos\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
  
    ViewData["Title"] = "FoodAdd";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Food Add Page</h1>\r\n\r\n<br />\r\n\r\n");
            WriteLiteral("<form class=\"form-group\" action=\"AddFood\" asp-controller=\"Food\" method=\"post\" enctype=\"multipart/form-data\">\r\n    ");
#nullable restore
#line 13 "C:\Users\NeslihanAlcglu\source\repos\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
Write(Html.Label("Food Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 14 "C:\Users\NeslihanAlcglu\source\repos\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    ");
#nullable restore
#line 16 "C:\Users\NeslihanAlcglu\source\repos\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
Write(Html.Label("Stock"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 17 "C:\Users\NeslihanAlcglu\source\repos\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
Write(Html.TextBoxFor(x => x.Stock, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    ");
#nullable restore
#line 19 "C:\Users\NeslihanAlcglu\source\repos\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
Write(Html.Label("Price"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 20 "C:\Users\NeslihanAlcglu\source\repos\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
Write(Html.TextBoxFor(x => x.Price, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    ");
#nullable restore
#line 22 "C:\Users\NeslihanAlcglu\source\repos\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
Write(Html.Label("choose Image"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n   \r\n    <input type=\"file\" name=\"ImageURL\" />\r\n    <br />\r\n    ");
#nullable restore
#line 26 "C:\Users\NeslihanAlcglu\source\repos\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
Write(Html.Label("Category"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 27 "C:\Users\NeslihanAlcglu\source\repos\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
Write(Html.DropDownListFor(x => x.CategoryId, (List<SelectListItem>)ViewBag.v1, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    \r\n    <br />\r\n    <button class=\"btn btn-dark\">Save</button>\r\n\r\n</form>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreAndFood.Data.Models.urunekle> Html { get; private set; }
    }
}
#pragma warning restore 1591