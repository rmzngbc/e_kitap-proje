#pragma checksum "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ba8b2db08f83fda12b126c921ed1a0711888389"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ba8b2db08f83fda12b126c921ed1a0711888389", @"/Views/Shared/_kitap.cshtml")]
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
            WriteLiteral("\r\n\r\n<div class=\"col-md-8\">\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 5 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
         foreach (var kitap in Model.Kitaplar)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-3\">\r\n                \r\n                \r\n                    <div class=\"card mb-2\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5ba8b2db08f83fda12b126c921ed1a07118883895574", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 286, "~/img/", 286, 6, true);
#nullable restore
#line 11 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
AddHtmlAttributeValue("", 292, kitap.k_resim, 292, 14, false);

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
#line 13 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
                                                  Write(kitap.k_adi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <small class=\"text-muted\">\r\n                                    <i class=\"fas fa-lira-sign\"></i>fiyat:");
#nullable restore
#line 15 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
                                                                     Write(kitap.k_fiyat);

#line default
#line hidden
#nullable disable
            WriteLiteral(" tl\r\n                                </small>\r\n                            </div>\r\n                        \r\n                            <div class=\"card-footer text-center\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ba8b2db08f83fda12b126c921ed1a07118883898258", async() => {
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
#line 20 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
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
            WriteLiteral("\r\n                                <a class=\"btn btn-primary btn-sm\">sepete ekle</a>\r\n                            </div>\r\n                        </div>          \r\n                </div>\r\n");
#nullable restore
#line 25 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n\r\n\r\n             <div class=\"row\">\r\n            <div class=\"col\">\r\n                <nav aria-label=\"Page navigation example\">\r\n                    <ul class=\"pagination\">\r\n                      \r\n");
#nullable restore
#line 35 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
                         for (int i = 0; i < Model.PageInfo.TotalPages(); i++)
                        {
                       
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
                             if(String.IsNullOrEmpty(Model.PageInfo.CurrentCategory))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li");
            BeginWriteAttribute("class", " class=\"", 1619, "\"", 1683, 2);
            WriteAttributeValue("", 1627, "page-item", 1627, 9, true);
#nullable restore
#line 40 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
WriteAttributeValue(" ", 1636, Model.PageInfo.CurrentPage==i+1?"active":"", 1637, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1743, "\"", 1771, 2);
            WriteAttributeValue("", 1750, "/kitaplar?page=", 1750, 15, true);
#nullable restore
#line 41 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
WriteAttributeValue("", 1765, i+1, 1765, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
#nullable restore
#line 42 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
                                    Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </a>\r\n                                </li>  \r\n");
#nullable restore
#line 45 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
                            }

                        
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li");
            BeginWriteAttribute("class", " class=\"", 2065, "\"", 2129, 2);
            WriteAttributeValue("", 2073, "page-item", 2073, 9, true);
#nullable restore
#line 50 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
WriteAttributeValue(" ", 2082, Model.PageInfo.CurrentPage==i+1?"active":"", 2083, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2189, "\"", 2249, 4);
            WriteAttributeValue("", 2196, "/kitaplar/", 2196, 10, true);
#nullable restore
#line 51 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
WriteAttributeValue("", 2206, Model.PageInfo.CurrentCategory, 2206, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2237, "?page=", 2237, 6, true);
#nullable restore
#line 51 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
WriteAttributeValue("", 2243, i+1, 2243, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
#nullable restore
#line 52 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
                                    Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </a>\r\n                                </li> \r\n");
#nullable restore
#line 55 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Shared\_kitap.cshtml"
                             

                                                   
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                      \r\n                    </ul>\r\n                </nav>\r\n\r\n\r\n\r\n\r\n\r\n            </div>\r\n        </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n</div>\t\r\n</div>\r\n\r\n\r\n");
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