#pragma checksum "C:\Users\SYM DMR\Desktop\4.hafta_CleanArchitecture_odev\CleanArchitecture.WebUI\Views\Category\CategoryAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "562fb5353fd1f0a914bd12e98ac7fd83bf153bd7"
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
#line 1 "C:\Users\SYM DMR\Desktop\4.hafta_CleanArchitecture_odev\CleanArchitecture.WebUI\Views\_ViewImports.cshtml"
using CleanArchitecture.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SYM DMR\Desktop\4.hafta_CleanArchitecture_odev\CleanArchitecture.WebUI\Views\_ViewImports.cshtml"
using CleanArchitecture.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SYM DMR\Desktop\4.hafta_CleanArchitecture_odev\CleanArchitecture.WebUI\Views\_ViewImports.cshtml"
using CleanArchitecture.Domain.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\SYM DMR\Desktop\4.hafta_CleanArchitecture_odev\CleanArchitecture.WebUI\Views\_ViewImports.cshtml"
using CleanArchitecture.Application.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"562fb5353fd1f0a914bd12e98ac7fd83bf153bd7", @"/Views/Category/CategoryAdd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dfca65546d453ac6f196db23ffc951c27e2fdfd", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_CategoryAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\SYM DMR\Desktop\4.hafta_CleanArchitecture_odev\CleanArchitecture.WebUI\Views\Category\CategoryAdd.cshtml"
  
    ViewData["Title"] = "CategoryAdd";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>CategoryAdd</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\SYM DMR\Desktop\4.hafta_CleanArchitecture_odev\CleanArchitecture.WebUI\Views\Category\CategoryAdd.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\SYM DMR\Desktop\4.hafta_CleanArchitecture_odev\CleanArchitecture.WebUI\Views\Category\CategoryAdd.cshtml"
Write(Html.Label("Kategori Adı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\SYM DMR\Desktop\4.hafta_CleanArchitecture_odev\CleanArchitecture.WebUI\Views\Category\CategoryAdd.cshtml"
Write(Html.TextBoxFor(x => x.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Kaydet\" />\r\n");
#nullable restore
#line 15 "C:\Users\SYM DMR\Desktop\4.hafta_CleanArchitecture_odev\CleanArchitecture.WebUI\Views\Category\CategoryAdd.cshtml"

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