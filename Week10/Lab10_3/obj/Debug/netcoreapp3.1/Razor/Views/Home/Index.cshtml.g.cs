#pragma checksum "C:\Users\Rmansour2\Documents\GCREPO\htmlrepos\Week10\Lab10_3\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "971c225bac89f4d4cf5ec9a4eb1f9ede6032e840"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Rmansour2\Documents\GCREPO\htmlrepos\Week10\Lab10_3\Views\_ViewImports.cshtml"
using Lab10_3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rmansour2\Documents\GCREPO\htmlrepos\Week10\Lab10_3\Views\_ViewImports.cshtml"
using Lab10_3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"971c225bac89f4d4cf5ec9a4eb1f9ede6032e840", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8f54e9dbaa1954579dcd11a93df27aac1ba3037", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Coffee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Rmansour2\Documents\GCREPO\htmlrepos\Week10\Lab10_3\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""stylesheet"" type=""text/css"" href=""/css/index.css"" />

<div class=""text-center"">
    <h1 class=""display-4"">Hello welcome to the CoffeeShop</h1>

    <h2 class=""sub-head"">Where All Coffee Needs Are Met</h2>
</div>

<div class=""coffs-align"">
");
#nullable restore
#line 15 "C:\Users\Rmansour2\Documents\GCREPO\htmlrepos\Week10\Lab10_3\Views\Home\Index.cshtml"
     foreach (Coffee coff in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"coff\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 414, "\"", 462, 2);
            WriteAttributeValue("", 421, "../Home/CoffeePage?coffID=", 421, 26, true);
#nullable restore
#line 18 "C:\Users\Rmansour2\Documents\GCREPO\htmlrepos\Week10\Lab10_3\Views\Home\Index.cshtml"
WriteAttributeValue("", 447, coff.ProductID, 447, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 18 "C:\Users\Rmansour2\Documents\GCREPO\htmlrepos\Week10\Lab10_3\Views\Home\Index.cshtml"
                                                           Write(coff.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </div>\r\n");
#nullable restore
#line 20 "C:\Users\Rmansour2\Documents\GCREPO\htmlrepos\Week10\Lab10_3\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<a href=\"/Home/Add\" style=\"position:fixed; right: 935px;\"><button>Add</button></a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Coffee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
