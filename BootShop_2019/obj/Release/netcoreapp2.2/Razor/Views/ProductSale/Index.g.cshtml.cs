#pragma checksum "C:\Users\CalebWS\source\TechCollection\BootShop_2019\BootShop_2019\BootShop_2019\Views\ProductSale\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07b37d0661861549a6ece6865a29ec9ef5c7fe2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductSale_Index), @"mvc.1.0.view", @"/Views/ProductSale/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ProductSale/Index.cshtml", typeof(AspNetCore.Views_ProductSale_Index))]
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
#line 1 "C:\Users\CalebWS\source\TechCollection\BootShop_2019\BootShop_2019\BootShop_2019\Views\_ViewImports.cshtml"
using BootShop_2019;

#line default
#line hidden
#line 2 "C:\Users\CalebWS\source\TechCollection\BootShop_2019\BootShop_2019\BootShop_2019\Views\_ViewImports.cshtml"
using BootShop_2019.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07b37d0661861549a6ece6865a29ec9ef5c7fe2b", @"/Views/ProductSale/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc6d4f309af9d66726e3ec591b2019ddd1da6f4c", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductSale_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BootShop_2019.Models.ViewModels.ProductSaleViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/logo-thumb.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Product Pic"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(74, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\CalebWS\source\TechCollection\BootShop_2019\BootShop_2019\BootShop_2019\Views\ProductSale\Index.cshtml"
  
    ViewData["Title"] = "Sales";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(164, 112, true);
            WriteLiteral("\r\n<h1>Sold Products</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(277, 43, false);
#line 14 "C:\Users\CalebWS\source\TechCollection\BootShop_2019\BootShop_2019\BootShop_2019\Views\ProductSale\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Picture));

#line default
#line hidden
            EndContext();
            BeginContext(320, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(376, 47, false);
#line 17 "C:\Users\CalebWS\source\TechCollection\BootShop_2019\BootShop_2019\BootShop_2019\Views\ProductSale\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(423, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(479, 50, false);
#line 20 "C:\Users\CalebWS\source\TechCollection\BootShop_2019\BootShop_2019\BootShop_2019\Views\ProductSale\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SalePersonName));

#line default
#line hidden
            EndContext();
            BeginContext(529, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(585, 44, false);
#line 23 "C:\Users\CalebWS\source\TechCollection\BootShop_2019\BootShop_2019\BootShop_2019\Views\ProductSale\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TimeSold));

#line default
#line hidden
            EndContext();
            BeginContext(629, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 29 "C:\Users\CalebWS\source\TechCollection\BootShop_2019\BootShop_2019\BootShop_2019\Views\ProductSale\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(747, 32, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n");
            EndContext();
#line 32 "C:\Users\CalebWS\source\TechCollection\BootShop_2019\BootShop_2019\BootShop_2019\Views\ProductSale\Index.cshtml"
                 if (item.Picture == null)
                {

#line default
#line hidden
            BeginContext(842, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(862, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "07b37d0661861549a6ece6865a29ec9ef5c7fe2b8545", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(961, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 35 "C:\Users\CalebWS\source\TechCollection\BootShop_2019\BootShop_2019\BootShop_2019\Views\ProductSale\Index.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1023, 71, true);
            WriteLiteral("                    <img height=\"150\" width=\"150\" class=\"img-thumbnail\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1094, "\"", 1171, 2);
            WriteAttributeValue("", 1100, "data:image/jpg;base64,", 1100, 22, true);
#line 38 "C:\Users\CalebWS\source\TechCollection\BootShop_2019\BootShop_2019\BootShop_2019\Views\ProductSale\Index.cshtml"
WriteAttributeValue("", 1122, Html.Raw(Convert.ToBase64String(item.Picture)), 1122, 49, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1172, 23, true);
            WriteLiteral(" alt=\"Product Pic\" />\r\n");
            EndContext();
#line 39 "C:\Users\CalebWS\source\TechCollection\BootShop_2019\BootShop_2019\BootShop_2019\Views\ProductSale\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1214, 53, true);
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1268, 46, false);
#line 42 "C:\Users\CalebWS\source\TechCollection\BootShop_2019\BootShop_2019\BootShop_2019\Views\ProductSale\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(1314, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1370, 49, false);
#line 45 "C:\Users\CalebWS\source\TechCollection\BootShop_2019\BootShop_2019\BootShop_2019\Views\ProductSale\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SalePersonName));

#line default
#line hidden
            EndContext();
            BeginContext(1419, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1475, 32, false);
#line 48 "C:\Users\CalebWS\source\TechCollection\BootShop_2019\BootShop_2019\BootShop_2019\Views\ProductSale\Index.cshtml"
           Write(item.TimeSold.ToLongDateString());

#line default
#line hidden
            EndContext();
            BeginContext(1507, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(1511, 32, false);
#line 48 "C:\Users\CalebWS\source\TechCollection\BootShop_2019\BootShop_2019\BootShop_2019\Views\ProductSale\Index.cshtml"
                                               Write(item.TimeSold.ToLongTimeString());

#line default
#line hidden
            EndContext();
            BeginContext(1543, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1598, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07b37d0661861549a6ece6865a29ec9ef5c7fe2b13116", async() => {
                BeginContext(1645, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 51 "C:\Users\CalebWS\source\TechCollection\BootShop_2019\BootShop_2019\BootShop_2019\Views\ProductSale\Index.cshtml"
                                         WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1655, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 54 "C:\Users\CalebWS\source\TechCollection\BootShop_2019\BootShop_2019\BootShop_2019\Views\ProductSale\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1694, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BootShop_2019.Models.ViewModels.ProductSaleViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591