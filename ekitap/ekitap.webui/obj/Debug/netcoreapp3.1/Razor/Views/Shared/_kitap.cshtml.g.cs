#pragma checksum "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ae322fbf67ab089088065296dc12048cb5d1946"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__kitap), @"mvc.1.0.view", @"/Views/Shared/_kitap.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ae322fbf67ab089088065296dc12048cb5d1946", @"/Views/Shared/_kitap.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"130a22c663f9048194122d688a3a3b14bcb868ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__kitap : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("\r\n\r\n<div class=\"col-md-8\" >\r\n    \r\n    <div class=\"row\">\r\n");
#nullable restore
#line 6 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
         if (ViewBag.kategoriadi==null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h6>Toplam kitap adet: ");
#nullable restore
#line 8 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
                              Write(ViewBag.kitapadet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n");
#nullable restore
#line 9 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h6>");
#nullable restore
#line 12 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
           Write(ViewBag.kategoriadi);

#line default
#line hidden
#nullable disable
            WriteLiteral(" türü kitap adet: ");
#nullable restore
#line 12 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
                                                 Write(ViewBag.kitapadet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n");
#nullable restore
#line 13 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n        \r\n        <h1 style=\"visibility: hidden;\">--------------------------</h1>\r\n        \r\n         ");
#nullable restore
#line 18 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
    Write(await Html.PartialAsync("_dropdown"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"row\">\r\n       \r\n");
#nullable restore
#line 22 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
         foreach (var kitap in Model.Kitaplar)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-3\">\r\n                \r\n                \r\n                    <div class=\"card mb-2\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2ae322fbf67ab089088065296dc12048cb5d19467540", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 726, "~/img/", 726, 6, true);
#nullable restore
#line 28 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
AddHtmlAttributeValue("", 732, kitap.k_resim, 732, 14, false);

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
            WriteLiteral("\r\n                            <div class=\"card-body\">\r\n                                <h5 class=\"card-title\">");
#nullable restore
#line 30 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
                                                  Write(kitap.k_adi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                               \r\n                                <small class=\"text-muted\">\r\n                                    <i class=\"fas fa-lira-sign\"></i>fiyat:");
#nullable restore
#line 33 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
                                                                     Write(kitap.k_fiyat);

#line default
#line hidden
#nullable disable
            WriteLiteral(" tl\r\n                                </small>\r\n                            </div>\r\n                        \r\n                            <div class=\"card-footer text-center\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ae322fbf67ab089088065296dc12048cb5d194610259", async() => {
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
#line 38 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
                                                                                        WriteLiteral(kitap.Url);

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
            WriteLiteral("\r\n                                <a class=\"btn btn-primary btn-sm\" >sepete ekle</a>\r\n                            </div>\r\n                        </div>          \r\n                </div>\r\n");
#nullable restore
#line 43 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n\r\n\r\n             <div class=\"row\">\r\n                    <div class=\"col\">\r\n                        <nav aria-label=\"Page navigation example\">\r\n                            <ul class=\"pagination\">\r\n                            \r\n");
#nullable restore
#line 53 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
                                 for (int i = 0; i < Model.PageInfo.TotalPages(); i++)
                                {
                            
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
                                     if(String.IsNullOrEmpty(Model.PageInfo.CurrentCategory))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li");
            BeginWriteAttribute("class", " class=\"", 2168, "\"", 2232, 2);
            WriteAttributeValue("", 2176, "page-item", 2176, 9, true);
#nullable restore
#line 58 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
WriteAttributeValue(" ", 2185, Model.PageInfo.CurrentPage==i+1?"active":"", 2186, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2300, "\"", 2344, 4);
            WriteAttributeValue("", 2307, "/kitaplar/", 2307, 10, true);
#nullable restore
#line 59 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
WriteAttributeValue("", 2317, ViewBag.sirala, 2317, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2332, "?page=", 2332, 6, true);
#nullable restore
#line 59 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
WriteAttributeValue("", 2338, i+1, 2338, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                ");
#nullable restore
#line 60 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
                                            Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </a>\r\n                                        </li>  \r\n");
#nullable restore
#line 63 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
                                    }

                                
                                    else
                                    {
                                        if (ViewBag.siralamalar==null)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li");
            BeginWriteAttribute("class", " class=\"", 2821, "\"", 2885, 2);
            WriteAttributeValue("", 2829, "page-item", 2829, 9, true);
#nullable restore
#line 70 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
WriteAttributeValue(" ", 2838, Model.PageInfo.CurrentPage==i+1?"active":"", 2839, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2957, "\"", 3017, 4);
            WriteAttributeValue("", 2964, "/kitaplar/", 2964, 10, true);
#nullable restore
#line 71 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
WriteAttributeValue("", 2974, Model.PageInfo.CurrentCategory, 2974, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3005, "?page=", 3005, 6, true);
#nullable restore
#line 71 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
WriteAttributeValue("", 3011, i+1, 3011, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    ");
#nullable restore
#line 72 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
                                                Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </a>\r\n                                            </li> \r\n");
#nullable restore
#line 75 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                             <li");
            BeginWriteAttribute("class", " class=\"", 3367, "\"", 3431, 2);
            WriteAttributeValue("", 3375, "page-item", 3375, 9, true);
#nullable restore
#line 78 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
WriteAttributeValue(" ", 3384, Model.PageInfo.CurrentPage==i+1?"active":"", 3385, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 3503, "\"", 3584, 6);
            WriteAttributeValue("", 3510, "/kitaplar/", 3510, 10, true);
#nullable restore
#line 79 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
WriteAttributeValue("", 3520, Model.PageInfo.CurrentCategory, 3520, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3551, "/", 3551, 1, true);
#nullable restore
#line 79 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
WriteAttributeValue("", 3552, ViewBag.siralamalar, 3552, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3572, "?page=", 3572, 6, true);
#nullable restore
#line 79 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
WriteAttributeValue("", 3578, i+1, 3578, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    ");
#nullable restore
#line 80 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
                                                Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </a>\r\n                                            </li> \r\n");
#nullable restore
#line 83 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
                                        }
                                       
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
                                     

                                                        
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            \r\n                            </ul>\r\n                        </nav>\r\n\r\n\r\n\r\n\r\n\r\n                    </div>\r\n            </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n</div>\t\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
