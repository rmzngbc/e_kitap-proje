#pragma checksum "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\ekitapislem\yazarlar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "036f1886580d62ff0954c47c3761eb148669f5a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ekitapislem_yazarlar), @"mvc.1.0.view", @"/Views/ekitapislem/yazarlar.cshtml")]
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
#line 2 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\_ViewImports.cshtml"
using ekitap.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\_ViewImports.cshtml"
using ekitap.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"036f1886580d62ff0954c47c3761eb148669f5a8", @"/Views/ekitapislem/yazarlar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"130a22c663f9048194122d688a3a3b14bcb868ac", @"/Views/_ViewImports.cshtml")]
    public class Views_ekitapislem_yazarlar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<YazarModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ekitapislem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm mb-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"

<style>
    li{
        display: inline-block;
        margin-right: 20px;
        color: black;
        font-size: 20px;
    }

    
    

    a:active{
        color:red;
    }


  
  
</style>

<!--
    --harf linklerine tıklanacak ve yazarlar listelenecek:
-->
<ul >
    <li ><a href=""/yazarlar/a"">A</a></li>
    <li ><a");
            BeginWriteAttribute("href", " href=\"", 375, "\"", 382, 0);
            EndWriteAttribute();
            WriteLiteral(">B</a></li>\r\n    <li ><a");
            BeginWriteAttribute("href", " href=\"", 407, "\"", 414, 0);
            EndWriteAttribute();
            WriteLiteral(">C</a></li>\r\n    <li ><a");
            BeginWriteAttribute("href", " href=\"", 439, "\"", 446, 0);
            EndWriteAttribute();
            WriteLiteral(">Ç</a></li>\r\n    <li ><a");
            BeginWriteAttribute("href", " href=\"", 471, "\"", 478, 0);
            EndWriteAttribute();
            WriteLiteral(">D</a></li>\r\n    <li ><a");
            BeginWriteAttribute("href", " href=\"", 503, "\"", 510, 0);
            EndWriteAttribute();
            WriteLiteral(">E</a></li>\r\n    <li ><a");
            BeginWriteAttribute("href", " href=\"", 535, "\"", 542, 0);
            EndWriteAttribute();
            WriteLiteral(">F</a></li>\r\n    <li ><a");
            BeginWriteAttribute("href", " href=\"", 567, "\"", 574, 0);
            EndWriteAttribute();
            WriteLiteral(">G</a></li>\r\n    <li ><a");
            BeginWriteAttribute("href", " href=\"", 599, "\"", 606, 0);
            EndWriteAttribute();
            WriteLiteral(">H</a></li>\r\n    <li ><a");
            BeginWriteAttribute("href", " href=\"", 631, "\"", 638, 0);
            EndWriteAttribute();
            WriteLiteral(">I</a></li>\r\n    <li ><a");
            BeginWriteAttribute("href", " href=\"", 663, "\"", 670, 0);
            EndWriteAttribute();
            WriteLiteral(">İ</a></li>\r\n    <li ><a");
            BeginWriteAttribute("href", " href=\"", 695, "\"", 702, 0);
            EndWriteAttribute();
            WriteLiteral(">J</a></li>\r\n    <li ><a");
            BeginWriteAttribute("href", " href=\"", 727, "\"", 734, 0);
            EndWriteAttribute();
            WriteLiteral(">K</a></li>\r\n    <li ><a");
            BeginWriteAttribute("href", " href=\"", 759, "\"", 766, 0);
            EndWriteAttribute();
            WriteLiteral(">L</a></li>\r\n    <li ><a");
            BeginWriteAttribute("href", " href=\"", 791, "\"", 798, 0);
            EndWriteAttribute();
            WriteLiteral(">M</a></li>\r\n    <li ><a");
            BeginWriteAttribute("href", " href=\"", 823, "\"", 830, 0);
            EndWriteAttribute();
            WriteLiteral(">N</a></li>\r\n    <li ><a");
            BeginWriteAttribute("href", " href=\"", 855, "\"", 862, 0);
            EndWriteAttribute();
            WriteLiteral(">O</a></li>\r\n    <li ><a");
            BeginWriteAttribute("href", " href=\"", 887, "\"", 894, 0);
            EndWriteAttribute();
            WriteLiteral(">Ö</a></li>\r\n    <li ><a");
            BeginWriteAttribute("href", " href=\"", 919, "\"", 926, 0);
            EndWriteAttribute();
            WriteLiteral(">P</a></li>\r\n    <li ><a href=\"/yazarlar/r\">R</a></li>\r\n     <li ><a");
            BeginWriteAttribute("href", " href=\"", 995, "\"", 1002, 0);
            EndWriteAttribute();
            WriteLiteral(">S</a></li>\r\n    <li ><a");
            BeginWriteAttribute("href", " href=\"", 1027, "\"", 1034, 0);
            EndWriteAttribute();
            WriteLiteral(">Ş</a></li>\r\n    <li ><a");
            BeginWriteAttribute("href", " href=\"", 1059, "\"", 1066, 0);
            EndWriteAttribute();
            WriteLiteral(">T</a></li>\r\n    <li ><a");
            BeginWriteAttribute("href", " href=\"", 1091, "\"", 1098, 0);
            EndWriteAttribute();
            WriteLiteral(">U</a></li>\r\n    <li ><a");
            BeginWriteAttribute("href", " href=\"", 1123, "\"", 1130, 0);
            EndWriteAttribute();
            WriteLiteral(">Ü</a></li>\r\n    <li ><a");
            BeginWriteAttribute("href", " href=\"", 1155, "\"", 1162, 0);
            EndWriteAttribute();
            WriteLiteral(">V</a></li>\r\n    <li ><a");
            BeginWriteAttribute("href", " href=\"", 1187, "\"", 1194, 0);
            EndWriteAttribute();
            WriteLiteral(">Y</a></li>\r\n    <li ><a");
            BeginWriteAttribute("href", " href=\"", 1219, "\"", 1226, 0);
            EndWriteAttribute();
            WriteLiteral(">Z</a></li>\r\n    \r\n  \r\n</ul>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n    <!--\r\n        --tıklanan harf linkine göre yazarların listesi ve bu yazarlara ait kitaplar\r\n    -->\r\n   \r\n        <div class=\"col-md-4\">\r\n           \r\n");
#nullable restore
#line 76 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\ekitapislem\yazarlar.cshtml"
             if (ViewBag.yazarlar.Count>0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h2>Yazarlar:</h2>\r\n");
#nullable restore
#line 79 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\ekitapislem\yazarlar.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n\r\n");
#nullable restore
#line 82 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\ekitapislem\yazarlar.cshtml"
             foreach (var item in (List<yazar>)ViewBag.yazarlar)
            {   
                
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 1762, "\"", 1809, 4);
            WriteAttributeValue("", 1769, "/yazarlar/", 1769, 10, true);
#nullable restore
#line 86 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\ekitapislem\yazarlar.cshtml"
WriteAttributeValue("", 1779, item.yazarad[0], 1779, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1795, "/", 1795, 1, true);
#nullable restore
#line 86 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\ekitapislem\yazarlar.cshtml"
WriteAttributeValue("", 1796, item.yazarId, 1796, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", "\r\n                    class=\"", 1810, "\"", 1939, 3);
            WriteAttributeValue("", 1839, "list-group-item", 1839, 15, true);
            WriteAttributeValue(" ", 1854, "list-group-item-action", 1855, 23, true);
#nullable restore
#line 87 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\ekitapislem\yazarlar.cshtml"
WriteAttributeValue(" ", 1877, Model.yazarlar.Any(i=>i.yazarId==item.yazarId)?"active":"", 1878, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                     ");
#nullable restore
#line 88 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\ekitapislem\yazarlar.cshtml"
                Write(item.yazarad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 88 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\ekitapislem\yazarlar.cshtml"
                              Write(item.yazarsoyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </a>\r\n");
#nullable restore
#line 90 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\ekitapislem\yazarlar.cshtml"
                

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </div>\r\n\r\n\r\n        \r\n        <div class=\"col-md-8\">\r\n\r\n\r\n            <div class=\"row\">\r\n\r\n");
#nullable restore
#line 103 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\ekitapislem\yazarlar.cshtml"
                     if (Model.yazarlar.Count>0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h1>Kitapları:</h1>\r\n");
#nullable restore
#line 106 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\ekitapislem\yazarlar.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 108 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\ekitapislem\yazarlar.cshtml"
                     foreach (var item in @Model.yazarlar)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\ekitapislem\yazarlar.cshtml"
                         foreach (var itemA in item.kitapyazarlar)
                        {   


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-md-3\">\r\n                                <div class=\"card mb-2\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "036f1886580d62ff0954c47c3761eb148669f5a814516", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2672, "~/img/", 2672, 6, true);
#nullable restore
#line 115 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\ekitapislem\yazarlar.cshtml"
AddHtmlAttributeValue("", 2678, itemA.kitap.k_resim, 2678, 20, false);

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
            WriteLiteral("\r\n                                        <div class=\"card-body\">\r\n                                            <h5 class=\"card-title\">");
#nullable restore
#line 117 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\ekitapislem\yazarlar.cshtml"
                                                              Write(itemA.kitap.k_adi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                            <small class=\"text-muted\">\r\n                                                <i class=\"fas fa-lira-sign\"></i>fiyat:");
#nullable restore
#line 119 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\ekitapislem\yazarlar.cshtml"
                                                                                 Write(itemA.kitap.k_fiyat);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" tl
                                            </small>
                                        </div>
                                    
                                        <div class=""card-footer text-center"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "036f1886580d62ff0954c47c3761eb148669f5a817370", async() => {
                WriteLiteral("incele");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-url", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 124 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\ekitapislem\yazarlar.cshtml"
                                                                                                    WriteLiteral(itemA.kitap.Url);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["url"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-url", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["url"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            <a class=\"btn btn-primary btn-sm\">sepete ekle</a>\r\n                                        </div>\r\n                                    </div>\r\n                            </div>\r\n");
#nullable restore
#line 129 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\ekitapislem\yazarlar.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 129 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\ekitapislem\yazarlar.cshtml"
                         

                    }   

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n           \r\n             </div>\r\n        </div>\r\n        \r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<YazarModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
