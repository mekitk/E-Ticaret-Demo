#pragma checksum "C:\Users\M3ki\source\repos\E-Ticaret\E-Ticaret\Views\Shared\Components\Filtrelemeaside\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10b97aac3f093d4ba4b9f353d1e2b50f7bd6db52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Filtrelemeaside_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Filtrelemeaside/Default.cshtml")]
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
#line 1 "C:\Users\M3ki\source\repos\E-Ticaret\E-Ticaret\Views\_ViewImports.cshtml"
using E_Ticaret;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\M3ki\source\repos\E-Ticaret\E-Ticaret\Views\_ViewImports.cshtml"
using E_Ticaret.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10b97aac3f093d4ba4b9f353d1e2b50f7bd6db52", @"/Views/Shared/Components/Filtrelemeaside/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52b90afa22f2d39f49481c4d82148e4f59b3a190", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Filtrelemeaside_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/AnaTasarim/img/product02.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div id=""aside"" class=""col-md-3"">
    <!-- aside Widget -->
    <div class=""aside"">
        <h3 class=""aside-title"">Categories</h3>
        <div class=""checkbox-filter"">

            <div class=""input-checkbox"">
                <input type=""checkbox"" id=""category-1"">
                <label for=""category-1"">
                    <span></span>
                    Laptops
                    <small>(120)</small>
                </label>
            </div>

            <div class=""input-checkbox"">
                <input type=""checkbox"" id=""category-2"">
                <label for=""category-2"">
                    <span></span>
                    Smartphones
                    <small>(740)</small>
                </label>
            </div>

            <div class=""input-checkbox"">
                <input type=""checkbox"" id=""category-3"">
                <label for=""category-3"">
                    <span></span>
                    Cameras
                    <small>(1450)</small>
     ");
            WriteLiteral(@"           </label>
            </div>
            <div class=""input-checkbox"">
                <input type=""checkbox"" id=""category-4"">
                <label for=""category-4"">
                    <span></span>
                    Accessories
                    <small>(578)</small>
                </label>
            </div>

            <div class=""input-checkbox"">
                <input type=""checkbox"" id=""category-5"">
                <label for=""category-5"">
                    <span></span>
                    Laptops
                    <small>(120)</small>
                </label>
            </div>

            <div class=""input-checkbox"">
                <input type=""checkbox"" id=""category-6"">
                <label for=""category-6"">
                    <span></span>
                    Smartphones
                    <small>(740)</small>
                </label>
            </div>
        </div>
    </div>
    <!-- /aside Widget -->
    <!-- aside Widget -->
    <div ");
            WriteLiteral(@"class=""aside"">
        <h3 class=""aside-title"">Price</h3>
        <div class=""price-filter"">
            <div id=""price-slider""></div>
            <div class=""input-number price-min"">
                <input id=""price-min"" type=""number"">
                <span class=""qty-up"">+</span>
                <span class=""qty-down"">-</span>
            </div>
            <span>-</span>
            <div class=""input-number price-max"">
                <input id=""price-max"" type=""number"">
                <span class=""qty-up"">+</span>
                <span class=""qty-down"">-</span>
            </div>
        </div>
    </div>
    <!-- /aside Widget -->
    <!-- aside Widget -->
    <div class=""aside"">
        <h3 class=""aside-title"">Brand</h3>
        <div class=""checkbox-filter"">
            <div class=""input-checkbox"">
                <input type=""checkbox"" id=""brand-1"">
                <label for=""brand-1"">
                    <span></span>
                    SAMSUNG
                    <small>");
            WriteLiteral(@"(578)</small>
                </label>
            </div>
            <div class=""input-checkbox"">
                <input type=""checkbox"" id=""brand-2"">
                <label for=""brand-2"">
                    <span></span>
                    LG
                    <small>(125)</small>
                </label>
            </div>
            <div class=""input-checkbox"">
                <input type=""checkbox"" id=""brand-3"">
                <label for=""brand-3"">
                    <span></span>
                    SONY
                    <small>(755)</small>
                </label>
            </div>
            <div class=""input-checkbox"">
                <input type=""checkbox"" id=""brand-4"">
                <label for=""brand-4"">
                    <span></span>
                    SAMSUNG
                    <small>(578)</small>
                </label>
            </div>
            <div class=""input-checkbox"">
                <input type=""checkbox"" id=""brand-5"">
              ");
            WriteLiteral(@"  <label for=""brand-5"">
                    <span></span>
                    LG
                    <small>(125)</small>
                </label>
            </div>
            <div  class=""input-checkbox"">
                <input onchange=""filtrelemecheck"" asp-controller=""urunfiltreleme""  asp-action=""filtrelemecheck"" asp-route-id=""1"" value=""true"" type=""checkbox"" id=""brand-6"">
                <label for=""brand-6"">
                    <span></span>
                    SONY
                    <small>(755)</small>
                </label>
            </div>
        </div>

    </div>
    <!-- /aside Widget -->
    <!-- aside Widget -->
    <div class=""aside"">
        <h3 class=""aside-title"">Top selling</h3>
        <div class=""product-widget"">
            <div class=""product-img"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "10b97aac3f093d4ba4b9f353d1e2b50f7bd6db529133", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""product-body"">
                <p class=""product-category"">Category</p>
                <h3 class=""product-name""><a href=""#"">product name goes here</a></h3>
                <h4 class=""product-price"">$980.00 <del class=""product-old-price"">$990.00</del></h4>
            </div>
        </div>

        <div class=""product-widget"">
            <div class=""product-img"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "10b97aac3f093d4ba4b9f353d1e2b50f7bd6db5210698", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""product-body"">
                <p class=""product-category"">Category</p>
                <h3 class=""product-name""><a href=""#"">product name goes here</a></h3>
                <h4 class=""product-price"">$980.00 <del class=""product-old-price"">$990.00</del></h4>
            </div>
        </div>

        <div class=""product-widget"">
            <div class=""product-img"">
                <img src=""./img/product03.png""");
            BeginWriteAttribute("alt", " alt=\"", 5929, "\"", 5935, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            </div>
            <div class=""product-body"">
                <p class=""product-category"">Category</p>
                <h3 class=""product-name""><a href=""#"">product name goes here</a></h3>
                <h4 class=""product-price"">$980.00 <del class=""product-old-price"">$990.00</del></h4>
            </div>
        </div>
    </div>
    <!-- /aside Widget -->
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591