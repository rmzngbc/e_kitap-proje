#pragma checksum "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\ekitapislem\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d165ee3b2ac0ad7ed24a0a41f1f31ab5f8551086"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ekitapislem_Details), @"mvc.1.0.view", @"/Views/ekitapislem/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d165ee3b2ac0ad7ed24a0a41f1f31ab5f8551086", @"/Views/ekitapislem/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"130a22c663f9048194122d688a3a3b14bcb868ac", @"/Views/_ViewImports.cshtml")]
    public class Views_ekitapislem_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<kitap>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d165ee3b2ac0ad7ed24a0a41f1f31ab5f85510863786", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 87, "~/img/", 87, 6, true);
#nullable restore
#line 8 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\ekitapislem\Details.cshtml"
AddHtmlAttributeValue("", 93, Model.k_resim, 93, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-9\">                \r\n            <h1 class=\"mb-3\">Kitap Adı:");
#nullable restore
#line 11 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\ekitapislem\Details.cshtml"
                                  Write(Model.k_adi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1> <hr>\r\n");
#nullable restore
#line 12 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\ekitapislem\Details.cshtml"
             foreach (var item in Model.kitapyazarlar)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h4 class=\"mb-3\">Kitap Yazar:");
#nullable restore
#line 14 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\ekitapislem\Details.cshtml"
                                        Write(item.yazar.yazarad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 14 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\ekitapislem\Details.cshtml"
                                                            Write(item.yazar.yazarsoyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4> \r\n");
#nullable restore
#line 15 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\ekitapislem\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n            <a");
            BeginWriteAttribute("href", " href=\"", 457, "\"", 493, 2);
            WriteAttributeValue("", 464, "/kitaplar/", 464, 10, true);
#nullable restore
#line 17 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\ekitapislem\Details.cshtml"
WriteAttributeValue("", 474, Model.kategori.Url, 474, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-link p-0 mb-3\">Kategori:");
#nullable restore
#line 17 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\ekitapislem\Details.cshtml"
                                                                                      Write(Model.kategori.ka_adi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>                  \r\n            <div class=\"mb-3\">\r\n                <h4 class=\"text-primary mb-3\">\r\n                    <i class=\"fas fa-lira-sign\"></i>Fiyat:");
#nullable restore
#line 20 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\ekitapislem\Details.cshtml"
                                                     Write(Model.k_fiyat);

#line default
#line hidden
#nullable disable
            WriteLiteral(" tl\r\n                </h4>\r\n                <button type=\"submit\" class=\"btn btn-primary btn-lg\">Sepete Ekle</button>\r\n            </h6>\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <p class=\"p-3\">Açıklama:");
#nullable restore
#line 28 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\ekitapislem\Details.cshtml"
                           Write(Model.k_aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<kitap> Html { get; private set; }
    }
}
#pragma warning restore 1591
