#pragma checksum "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Admin\KitapList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49ed70a9d42cb2ec17ed1a92cde7cecb71fca4df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_KitapList), @"mvc.1.0.view", @"/Views/Admin/KitapList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49ed70a9d42cb2ec17ed1a92cde7cecb71fca4df", @"/Views/Admin/KitapList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"130a22c663f9048194122d688a3a3b14bcb868ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_KitapList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<kitapListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "KitapEkle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm mb-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/KitapDelete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <h1>Admin Kitaplar</h1>\r\n        <hr>\r\n         ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49ed70a9d42cb2ec17ed1a92cde7cecb71fca4df6185", async() => {
                WriteLiteral("Kitap Ekle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <table class=""table table-bordered"">
            <thead>
                <tr>
                    <td style=""width: 30px;"">Id</td>
                    <td style=""width: 100px;"">Kitap Adı</td>
                    <td>Name</td>
                    <td style=""width: 20px;"">Kitap Fiyat</td>
                    <td style=""width: 20px;"">Kitap Sayfa</td>
                    <td style=""width: 20px;"">Anasayfadamı</td>
                    <td style=""width: 20px;"">Onaylımı</td>

                    <td style=""width: 150px;""></td>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 24 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Admin\KitapList.cshtml"
                 if(Model.Kitaplar.Count>0)
                {
                       

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Admin\KitapList.cshtml"
                        foreach (var item in Model.Kitaplar)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 29 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Admin\KitapList.cshtml"
                               Write(item.kitapId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "49ed70a9d42cb2ec17ed1a92cde7cecb71fca4df9170", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1136, "~/img/", 1136, 6, true);
#nullable restore
#line 30 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Admin\KitapList.cshtml"
AddHtmlAttributeValue("", 1142, item.k_resim, 1142, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 31 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Admin\KitapList.cshtml"
                               Write(item.k_adi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 32 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Admin\KitapList.cshtml"
                               Write(item.k_fiyat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 33 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Admin\KitapList.cshtml"
                               Write(item.k_sayfa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n");
#nullable restore
#line 35 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Admin\KitapList.cshtml"
                                     if(item.k_anasayfa)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i class=\"fas fa-check-circle\"></i>\r\n");
#nullable restore
#line 38 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Admin\KitapList.cshtml"
                                    }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i class=\"fas fa-times-circle\"></i>\r\n");
#nullable restore
#line 40 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Admin\KitapList.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                                <td>\r\n");
#nullable restore
#line 43 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Admin\KitapList.cshtml"
                                     if(item.k_onay)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i class=\"fas fa-check-circle\"></i>\r\n");
#nullable restore
#line 46 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Admin\KitapList.cshtml"
                                    }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i class=\"fas fa-times-circle\"></i>\r\n");
#nullable restore
#line 48 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Admin\KitapList.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                                <td>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2235, "\"", 2271, 2);
            WriteAttributeValue("", 2242, "/admin/kitaplar/", 2242, 16, true);
#nullable restore
#line 51 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Admin\KitapList.cshtml"
WriteAttributeValue("", 2258, item.kitapId, 2258, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm mr-2\">Edit</a>\r\n                                 \r\n                                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49ed70a9d42cb2ec17ed1a92cde7cecb71fca4df14309", async() => {
                WriteLiteral("\r\n                                        <input type=\"hidden\" name=\"kitapId\"");
                BeginWriteAttribute("value", " value=\"", 2538, "\"", 2559, 1);
#nullable restore
#line 54 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Admin\KitapList.cshtml"
WriteAttributeValue("", 2546, item.kitapId, 2546, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        <button type=\"submit\" class=\"btn btn-danger btn-sm\">Sil</button>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("                   \r\n\r\n\r\n\r\n                                   \r\n                                </td>\r\n                        </tr>\r\n");
#nullable restore
#line 63 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Admin\KitapList.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Admin\KitapList.cshtml"
                         
                }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-warning\">\r\n                        <h3>No Products</h3>\r\n                    </div>\r\n");
#nullable restore
#line 68 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Admin\KitapList.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n             \r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<kitapListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
