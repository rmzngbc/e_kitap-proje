#pragma checksum "C:\Users\ramaz\Desktop\proje_e-kitap\ekitap\ekitap.webui\Views\Admin\AdminPanel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d171fcb8aca0fd5dbe423fd44ed3e32228bc7285"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AdminPanel), @"mvc.1.0.view", @"/Views/Admin/AdminPanel.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d171fcb8aca0fd5dbe423fd44ed3e32228bc7285", @"/Views/Admin/AdminPanel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"130a22c663f9048194122d688a3a3b14bcb868ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AdminPanel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"



<ul>
    <li><a href=""/admin/kitaplar"" class=""nav-link"">Admin Kitaplar</a></li>
    <li><a href=""/admin/kategoriler/list"" class=""nav-link"">Admin Kategoriler</a></li>
    <li><a href=""/admin/yazarlar/list"" class=""nav-link"">Admin Yazar</a></li>
</ul>

");
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
