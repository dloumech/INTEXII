#pragma checksum "C:\Users\irvin\Source\Repos\INTEXII\Views\Home\Summary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c56812d6f66db5dbb5b3b4b574142799e0852a31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Summary), @"mvc.1.0.view", @"/Views/Home/Summary.cshtml")]
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
#line 1 "C:\Users\irvin\Source\Repos\INTEXII\Views\_ViewImports.cshtml"
using INTEXII;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\irvin\Source\Repos\INTEXII\Views\_ViewImports.cshtml"
using INTEXII.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\irvin\Source\Repos\INTEXII\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c56812d6f66db5dbb5b3b4b574142799e0852a31", @"/Views/Home/Summary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c1522fea78d1c695bd843bd4a8e0230e57743ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Summary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Burialmain>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\irvin\Source\Repos\INTEXII\Views\Home\Summary.cshtml"
  
    ViewData["Title"] = "Record Summary";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\irvin\Source\Repos\INTEXII\Views\Home\Summary.cshtml"
 foreach (var x in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Burial ID: ");
#nullable restore
#line 9 "C:\Users\irvin\Source\Repos\INTEXII\Views\Home\Summary.cshtml"
             Write(x.Burialid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Burial Number: ");
#nullable restore
#line 10 "C:\Users\irvin\Source\Repos\INTEXII\Views\Home\Summary.cshtml"
                 Write(x.Burialnumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Sex: ");
#nullable restore
#line 11 "C:\Users\irvin\Source\Repos\INTEXII\Views\Home\Summary.cshtml"
       Write(x.Sex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Age at Death: ");
#nullable restore
#line 12 "C:\Users\irvin\Source\Repos\INTEXII\Views\Home\Summary.cshtml"
                Write(x.Ageatdeath);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Length: ");
#nullable restore
#line 13 "C:\Users\irvin\Source\Repos\INTEXII\Views\Home\Summary.cshtml"
          Write(x.Length);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Burial Depth: ");
#nullable restore
#line 14 "C:\Users\irvin\Source\Repos\INTEXII\Views\Home\Summary.cshtml"
                Write(x.Depth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Hair Color: ");
#nullable restore
#line 15 "C:\Users\irvin\Source\Repos\INTEXII\Views\Home\Summary.cshtml"
              Write(x.Haircolor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Head Direction: ");
#nullable restore
#line 16 "C:\Users\irvin\Source\Repos\INTEXII\Views\Home\Summary.cshtml"
                  Write(x.Headdirection);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Square North South: ");
#nullable restore
#line 17 "C:\Users\irvin\Source\Repos\INTEXII\Views\Home\Summary.cshtml"
                      Write(x.Squarenorthsouth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>North South: ");
#nullable restore
#line 18 "C:\Users\irvin\Source\Repos\INTEXII\Views\Home\Summary.cshtml"
               Write(x.Northsouth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Square East West: ");
#nullable restore
#line 19 "C:\Users\irvin\Source\Repos\INTEXII\Views\Home\Summary.cshtml"
                    Write(x.Squareeastwest);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>East West: ");
#nullable restore
#line 20 "C:\Users\irvin\Source\Repos\INTEXII\Views\Home\Summary.cshtml"
             Write(x.Eastwest);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Area: ");
#nullable restore
#line 21 "C:\Users\irvin\Source\Repos\INTEXII\Views\Home\Summary.cshtml"
        Write(x.Area);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 22 "C:\Users\irvin\Source\Repos\INTEXII\Views\Home\Summary.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Burialmain>> Html { get; private set; }
    }
}
#pragma warning restore 1591
