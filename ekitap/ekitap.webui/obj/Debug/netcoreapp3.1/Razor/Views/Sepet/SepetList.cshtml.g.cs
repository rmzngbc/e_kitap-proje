#pragma checksum "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Sepet\SepetList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3176d9b2473a5f08dda9c5e4f5662ccec4a10da7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sepet_SepetList), @"mvc.1.0.view", @"/Views/Sepet/SepetList.cshtml")]
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
#nullable restore
#line 6 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\_ViewImports.cshtml"
using ekitap.webui.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3176d9b2473a5f08dda9c5e4f5662ccec4a10da7", @"/Views/Sepet/SepetList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a04bab9151f10ed451360caa9a204a83b97c21b", @"/Views/_ViewImports.cshtml")]
    public class Views_Sepet_SepetList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SepetModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Sepet", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateToSepet", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteFromSepet", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n<!--\r\n<i class=\"fa fa-times fa-fw\"></i>\r\n-->\r\n\r\n");
#nullable restore
#line 9 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Sepet\SepetList.cshtml"
 if (Model.SepetItems.Count==0)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-12\">\r\n            <div class=\"alert alert-warning\">\r\n                Sepetinizde ??r??n yok.\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 19 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Sepet\SepetList.cshtml"
    
}


else{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1 class=""h3"">Sepetim</h1>
<hr>
<div class=""row"">
    <div class=""col-md-8"">
        <table class=""table hover"">
            <thead>
                <tr>
                    <th></th>
                    <th>Kitap Ad??</th>
                    <th>Fiyat</th>
                    <th>Kitap Adet</th>
                    <th>Toplam Fiyat</th>
                    <th>G??ncelle</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 41 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Sepet\SepetList.cshtml"
                 foreach (var item in Model.SepetItems)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3176d9b2473a5f08dda9c5e4f5662ccec4a10da78152", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 977, "~/img/", 977, 6, true);
#nullable restore
#line 45 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Sepet\SepetList.cshtml"
AddHtmlAttributeValue("", 983, item.kitapresim, 983, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                        <td>");
#nullable restore
#line 47 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Sepet\SepetList.cshtml"
                       Write(item.kitapadi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 48 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Sepet\SepetList.cshtml"
                       Write(item.kitapfiyat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 49 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Sepet\SepetList.cshtml"
                       Write(item.kitapadet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 50 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Sepet\SepetList.cshtml"
                        Write(item.kitapadet*item.kitapfiyat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n\r\n                            <!--\r\n                                --sepete ekleme uapt??tan sonra ,sepet list inde kitap adet g??ncellemesi apma\r\n                            -->\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3176d9b2473a5f08dda9c5e4f5662ccec4a10da711227", async() => {
                WriteLiteral("\r\n\r\n                                    <input type=\"hidden\" name=\"SepetItemId\"");
                BeginWriteAttribute("value", " value=\"", 1676, "\"", 1698, 1);
#nullable restore
#line 58 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Sepet\SepetList.cshtml"
WriteAttributeValue("", 1684, Model.SepetId, 1684, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <input type=\"hidden\" name=\"kitapId\"");
                BeginWriteAttribute("value", " value=\"", 1773, "\"", 1794, 1);
#nullable restore
#line 59 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Sepet\SepetList.cshtml"
WriteAttributeValue("", 1781, item.kitapId, 1781, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    \r\n                                    <div class=\"input-group mb-3\">\r\n                                        <input type=\"number\" name=\"adet\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1997, "\"", 2020, 1);
#nullable restore
#line 62 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Sepet\SepetList.cshtml"
WriteAttributeValue("", 2005, item.kitapadet, 2005, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" min=""1"" step=""1"" style=""width: 100px;"">
                                        <div class=""input-group-append"">
                                            <button type=""submit"" class=""btn btn-primary"">
                                                <i class=""fas fa-shopping-cart""></i>                               
                                            </button>
                                        </div>
                            </div>     
                            
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            \r\n                            <!--\r\n                                --sil iconu:\r\n                            -->\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3176d9b2473a5f08dda9c5e4f5662ccec4a10da715470", async() => {
                WriteLiteral("\r\n                                    <input type=\"hidden\" name=\"SepetItemId\"");
                BeginWriteAttribute("value", " value=\"", 2942, "\"", 2967, 1);
#nullable restore
#line 78 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Sepet\SepetList.cshtml"
WriteAttributeValue("", 2950, item.SepetItemId, 2950, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <input type=\"hidden\" name=\"kitapId\"");
                BeginWriteAttribute("value", " value=\"", 3042, "\"", 3063, 1);
#nullable restore
#line 79 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Sepet\SepetList.cshtml"
WriteAttributeValue("", 3050, item.kitapId, 3050, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <button type=\"submit\" class=\"btn btn-danger btn-sm\">\r\n                                        <i class=\"fas fa-trash-alt\"></i>\r\n                                    </button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n  \r\n                        </td>\r\n\r\n\r\n                     \r\n\r\n                      \r\n                      \r\n                    </tr>\r\n");
#nullable restore
#line 96 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Sepet\SepetList.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
    </div>


    <!--
        --sepetteki kitaplar??n toplam fiyat??:
    -->

     <div class=""col-md-4"">
        <div class=""text-left"">
            <h4>Sepet ??zeti</h4>
        </div>
        <table class=""table"">
            <tbody>

              
                <tr>
                    <th>Sepet Toplam</th>
                    <td>");
#nullable restore
#line 116 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Sepet\SepetList.cshtml"
                   Write(Model.ToplamFiyat().ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                </tr>

                
                <tr>
                    <th>Kargo</th>
                    <th>??cretsiz</th>
                </tr>

              
                 <tr>
                    <th>Sipari?? Toplam</th>
                    <th>");
#nullable restore
#line 128 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Sepet\SepetList.cshtml"
                   Write(Model.ToplamFiyat().ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
                </tr>
            </tbody>
        </table>

       
        <div class=""text-center"">
            <a href=""/"" class=""btn btn-primary"">
                <i class=""fa fa-arrow-circle-left fa-fw""></i>Al????veri??e Devam Et
            </a>

            <a href=""/checkout"" class=""btn btn-primary"">
                <i class=""fa fa-arrow-circle-right fa-fw""></i>Sipari??Ver
            </a>
        </div>
    </div>




</div>
");
#nullable restore
#line 149 "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Sepet\SepetList.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SepetModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
