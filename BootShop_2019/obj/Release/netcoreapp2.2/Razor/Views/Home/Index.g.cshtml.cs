#pragma checksum "C:\Users\CalebWS\source\TechCollection\BootShop_2019\BootShop_2019\BootShop_2019\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb40bacd1989f269e1c6d03250b47c302d21dd50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb40bacd1989f269e1c6d03250b47c302d21dd50", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc6d4f309af9d66726e3ec591b2019ddd1da6f4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BootShop_2019.Models.ViewModels.ProductViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 85%; height: 265px !important"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail rounded mx-auto d-block img-fluid homeImage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/logo-thumb.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Product Pic"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(70, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\CalebWS\source\TechCollection\BootShop_2019\BootShop_2019\BootShop_2019\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(160, 209, true);
            WriteLiteral("\r\n<style>\r\n    .homeImage:hover{\r\n        background-color: rebeccapurple;\r\n    }\r\n\r\n    h4{\r\n        color: red;\r\n    }\r\n</style>\r\n\r\n<h1 class=\"text-center\">Point of Sale</h1>\r\n    \r\n<div class=\"col-md-12\">\r\n");
            EndContext();
#line 21 "C:\Users\CalebWS\source\TechCollection\BootShop_2019\BootShop_2019\BootShop_2019\Views\Home\Index.cshtml"
     if (Model.Count() == 0)
    {

#line default
#line hidden
            BeginContext(406, 57, true);
            WriteLiteral("        <h4 class=\"text-center\">No Product to sell</h4>\r\n");
            EndContext();
#line 24 "C:\Users\CalebWS\source\TechCollection\BootShop_2019\BootShop_2019\BootShop_2019\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(470, 25, true);
            WriteLiteral("    <div class=\"row\">\r\n\r\n");
            EndContext();
#line 27 "C:\Users\CalebWS\source\TechCollection\BootShop_2019\BootShop_2019\BootShop_2019\Views\Home\Index.cshtml"
         foreach (var item in Model)
	    {

#line default
#line hidden
            BeginContext(541, 104, true);
            WriteLiteral("\t\t    <div style=\"margin-bottom: 16px;\" class=\"col-md-4\">\r\n                <div>\r\n                    \r\n");
            EndContext();
#line 32 "C:\Users\CalebWS\source\TechCollection\BootShop_2019\BootShop_2019\BootShop_2019\Views\Home\Index.cshtml"
                     if (item.Picture == null)
                    {

#line default
#line hidden
            BeginContext(716, 26, true);
            WriteLiteral("                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 742, "\"", 806, 1);
#line 34 "C:\Users\CalebWS\source\TechCollection\BootShop_2019\BootShop_2019\BootShop_2019\Views\Home\Index.cshtml"
WriteAttributeValue("", 749, Url.Action("Create", "ProductSale", new { id = item.Id}), 749, 57, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(807, 31, true);
            WriteLiteral(">\r\n                            ");
            EndContext();
            BeginContext(838, 163, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "eb40bacd1989f269e1c6d03250b47c302d21dd507270", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1001, 32, true);
            WriteLiteral("\r\n                        </a>\r\n");
            EndContext();
#line 37 "C:\Users\CalebWS\source\TechCollection\BootShop_2019\BootShop_2019\BootShop_2019\Views\Home\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1105, 26, true);
            WriteLiteral("                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1131, "\"", 1195, 1);
#line 40 "C:\Users\CalebWS\source\TechCollection\BootShop_2019\BootShop_2019\BootShop_2019\Views\Home\Index.cshtml"
WriteAttributeValue("", 1138, Url.Action("Create", "ProductSale", new { id = item.Id}), 1138, 57, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1196, 146, true);
            WriteLiteral(">\r\n                            <img style=\"width: 85%; height: 265px !important\" class=\"img-thumbnail rounded mx-auto d-block img-fluid homeImage\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1342, "\"", 1419, 2);
            WriteAttributeValue("", 1348, "data:image/jpg;base64,", 1348, 22, true);
#line 41 "C:\Users\CalebWS\source\TechCollection\BootShop_2019\BootShop_2019\BootShop_2019\Views\Home\Index.cshtml"
WriteAttributeValue("", 1370, Html.Raw(Convert.ToBase64String(item.Picture)), 1370, 49, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1420, 53, true);
            WriteLiteral(" alt=\"Product Pic\" />\r\n                        </a>\r\n");
            EndContext();
#line 43 "C:\Users\CalebWS\source\TechCollection\BootShop_2019\BootShop_2019\BootShop_2019\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1496, 93, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"text-center\">\r\n                    <h6>");
            EndContext();
            BeginContext(1590, 16, false);
#line 47 "C:\Users\CalebWS\source\TechCollection\BootShop_2019\BootShop_2019\BootShop_2019\Views\Home\Index.cshtml"
                   Write(item.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(1606, 35, true);
            WriteLiteral("</h6>\r\n                    <h6>GH¢ ");
            EndContext();
            BeginContext(1642, 10, false);
#line 48 "C:\Users\CalebWS\source\TechCollection\BootShop_2019\BootShop_2019\BootShop_2019\Views\Home\Index.cshtml"
                       Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1652, 51, true);
            WriteLiteral("</h6>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 51 "C:\Users\CalebWS\source\TechCollection\BootShop_2019\BootShop_2019\BootShop_2019\Views\Home\Index.cshtml"
	    }

#line default
#line hidden
            BeginContext(1711, 22, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BootShop_2019.Models.ViewModels.ProductViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
