#pragma checksum "C:\Users\M3ki\source\repos\E-Ticaret\E-Ticaret\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77a7c6ab210826be3e3c9a8c4918cdadde817844"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77a7c6ab210826be3e3c9a8c4918cdadde817844", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52b90afa22f2d39f49481c4d82148e4f59b3a190", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\M3ki\source\repos\E-Ticaret\E-Ticaret\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""row m-t-25"">
    <div class=""col-sm-6 col-lg-3"">
        <div class=""overview-item overview-item--c1"">
            <div class=""overview__inner"">
                <div class=""overview-box clearfix"">
                    <div class=""icon"">
                        <i class=""zmdi zmdi-account-o""></i>
                    </div>
                    <div class=""text"">
                        <h2>");
#nullable restore
#line 18 "C:\Users\M3ki\source\repos\E-Ticaret\E-Ticaret\Views\Admin\Index.cshtml"
                       Write(TempData["musteri"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                        <span>Müşteri</span>
                    </div>
                </div>
                <div class=""overview-chart"">
                    <canvas id=""widgetChart1""></canvas>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-sm-6 col-lg-3"">
        <div class=""overview-item overview-item--c2"">
            <div class=""overview__inner"">
                <div class=""overview-box clearfix"">
                    <div class=""icon"">
                        <i class=""zmdi zmdi-shopping-cart""></i>
                    </div>
                    <div class=""text"">
                        <h2>388,688</h2>
                        <span>Satılan Ürün</span>
                    </div>
                </div>
                <div class=""overview-chart"">
                    <canvas id=""widgetChart2""></canvas>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-sm-6 col-lg-3"">
        <div class=""overvi");
            WriteLiteral(@"ew-item overview-item--c3"">
            <div class=""overview__inner"">
                <div class=""overview-box clearfix"">
                    <div class=""icon"">
                        <i class=""zmdi zmdi-calendar-note""></i>
                    </div>
                    <div class=""text"">
                        <h2>1,086</h2>
                        <span>Sipariş</span>
                    </div>
                </div>
                <div class=""overview-chart"">
                    <canvas id=""widgetChart3""></canvas>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-sm-6 col-lg-3"">
        <div class=""overview-item overview-item--c4"">
            <div class=""overview__inner"">
                <div class=""overview-box clearfix"">
                    <div class=""icon"">
                        <i class=""zmdi zmdi-money""></i>
                    </div>
                    <div class=""text"">
                        <h2>$1,060,386</h2>
               ");
            WriteLiteral(@"         <span>Toplam Satış Tutarı</span>
                    </div>
                </div>
                <div class=""overview-chart"">
                    <canvas id=""widgetChart4""></canvas>
                </div>
            </div>
        </div>
    </div>
</div>

");
#nullable restore
#line 84 "C:\Users\M3ki\source\repos\E-Ticaret\E-Ticaret\Views\Admin\Index.cshtml"
Write(await Component.InvokeAsync("Marka"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n\r\n\r\n");
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
