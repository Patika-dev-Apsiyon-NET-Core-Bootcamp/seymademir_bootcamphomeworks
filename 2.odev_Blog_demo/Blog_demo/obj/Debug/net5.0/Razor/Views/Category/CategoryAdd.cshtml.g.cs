#pragma checksum "C:\Users\SYM DMR\source\repos\Blog_demo\Blog_demo\Views\Category\CategoryAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f94fcc622938a5f5bc8e0ad9cb7082d22df38519"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_CategoryAdd), @"mvc.1.0.view", @"/Views/Category/CategoryAdd.cshtml")]
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
#line 1 "C:\Users\SYM DMR\source\repos\Blog_demo\Blog_demo\Views\_ViewImports.cshtml"
using Blog_demo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SYM DMR\source\repos\Blog_demo\Blog_demo\Views\_ViewImports.cshtml"
using Blog_demo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f94fcc622938a5f5bc8e0ad9cb7082d22df38519", @"/Views/Category/CategoryAdd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a5a00a55bac0f9f4dcfda7e3d4ec7207c637e9d", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_CategoryAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\SYM DMR\source\repos\Blog_demo\Blog_demo\Views\Category\CategoryAdd.cshtml"
  
    ViewData["Title"] = "CategoryAdd";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>CategoryAdd</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\SYM DMR\source\repos\Blog_demo\Blog_demo\Views\Category\CategoryAdd.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\SYM DMR\source\repos\Blog_demo\Blog_demo\Views\Category\CategoryAdd.cshtml"
Write(Html.Label("Kategori Adı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\SYM DMR\source\repos\Blog_demo\Blog_demo\Views\Category\CategoryAdd.cshtml"
Write(Html.TextBoxFor(x => x.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Kaydet\" />\r\n");
#nullable restore
#line 14 "C:\Users\SYM DMR\source\repos\Blog_demo\Blog_demo\Views\Category\CategoryAdd.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Category> Html { get; private set; }
    }
}
#pragma warning restore 1591