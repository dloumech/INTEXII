#pragma checksum "C:\Users\irvin\source\repos\INTEXII\Views\Home\BurialRecord.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5230fc41f242dd44f692cd1a0f00a9efe6fed00b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_BurialRecord), @"mvc.1.0.view", @"/Views/Home/BurialRecord.cshtml")]
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
#line 1 "C:\Users\irvin\source\repos\INTEXII\Views\_ViewImports.cshtml"
using INTEXII;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\irvin\source\repos\INTEXII\Views\_ViewImports.cshtml"
using INTEXII.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\irvin\source\repos\INTEXII\Views\Home\BurialRecord.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5230fc41f242dd44f692cd1a0f00a9efe6fed00b", @"/Views/Home/BurialRecord.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c1522fea78d1c695bd843bd4a8e0230e57743ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_BurialRecord : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Burialmain>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RecordFilter", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ClearFilters", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\irvin\source\repos\INTEXII\Views\Home\BurialRecord.cshtml"
  
    ViewData["Title"] = "Burial Record";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("    <div class=\"sunshine fricknah\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5230fc41f242dd44f692cd1a0f00a9efe6fed00b5348", async() => {
                WriteLiteral(" Filter");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <div class=\"sunshine fricknah\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5230fc41f242dd44f692cd1a0f00a9efe6fed00b6973", async() => {
                WriteLiteral(" Reset Filter");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n<div class=\"container\">\r\n    <div class=\"row \">\r\n        <div class=\"col font-weight-bold text-center shawty\">\r\n            Burial Records\r\n        </div>\r\n    </div>\r\n    <div class=\"row border\">\r\n");
            WriteLiteral(@"        <div class=""col border font-weight-bold text-center"">
            Burial Number
        </div>
        <div class=""col border font-weight-bold text-center"">
            Sex
        </div>
        <div class=""col border font-weight-bold text-center"">
            Age of Death
        </div>
        <div class=""col border font-weight-bold text-center"">
            Estimated Stature
        </div>
        <div class=""col border font-weight-bold text-center"">
            Depth
        </div>
        <div class=""col border font-weight-bold text-center"">
            Hair Color
        </div>
        <div class=""col border font-weight-bold text-center"">
            Head Direction
        </div>
        <div class=""col border font-weight-bold text-center"">
            Square North South
        </div>
        <div class=""col border font-weight-bold text-center"">
            North South
        </div>
        <div class=""col border font-weight-bold text-center"">
            Square Ea");
            WriteLiteral(@"st West
        </div>
        <div class=""col border font-weight-bold text-center"">
            East West
        </div>
        <div class=""col border font-weight-bold text-center"">
            Area
        </div>
        <div class=""col border font-weight-bold text-center"">
        </div>
    </div>
");
#nullable restore
#line 68 "C:\Users\irvin\source\repos\INTEXII\Views\Home\BurialRecord.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row border\">\r\n");
            WriteLiteral("            <div class=\"col border\">\r\n                ");
#nullable restore
#line 75 "C:\Users\irvin\source\repos\INTEXII\Views\Home\BurialRecord.cshtml"
           Write(x.Burialnumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col border\">\r\n                ");
#nullable restore
#line 78 "C:\Users\irvin\source\repos\INTEXII\Views\Home\BurialRecord.cshtml"
           Write(x.Sex);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col border\">\r\n                ");
#nullable restore
#line 81 "C:\Users\irvin\source\repos\INTEXII\Views\Home\BurialRecord.cshtml"
           Write(x.Ageatdeath);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col border\">\r\n                ");
#nullable restore
#line 84 "C:\Users\irvin\source\repos\INTEXII\Views\Home\BurialRecord.cshtml"
           Write(x.Length);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col border\">\r\n                ");
#nullable restore
#line 87 "C:\Users\irvin\source\repos\INTEXII\Views\Home\BurialRecord.cshtml"
           Write(x.Depth);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col border\">\r\n                ");
#nullable restore
#line 90 "C:\Users\irvin\source\repos\INTEXII\Views\Home\BurialRecord.cshtml"
           Write(x.Haircolor);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col border\">\r\n                ");
#nullable restore
#line 93 "C:\Users\irvin\source\repos\INTEXII\Views\Home\BurialRecord.cshtml"
           Write(x.Headdirection);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col border\">\r\n                ");
#nullable restore
#line 96 "C:\Users\irvin\source\repos\INTEXII\Views\Home\BurialRecord.cshtml"
           Write(x.Squarenorthsouth);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col border\">\r\n                ");
#nullable restore
#line 99 "C:\Users\irvin\source\repos\INTEXII\Views\Home\BurialRecord.cshtml"
           Write(x.Northsouth);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col border\">\r\n                ");
#nullable restore
#line 102 "C:\Users\irvin\source\repos\INTEXII\Views\Home\BurialRecord.cshtml"
           Write(x.Squareeastwest);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col border\">\r\n                ");
#nullable restore
#line 105 "C:\Users\irvin\source\repos\INTEXII\Views\Home\BurialRecord.cshtml"
           Write(x.Eastwest);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col border\">\r\n                ");
#nullable restore
#line 108 "C:\Users\irvin\source\repos\INTEXII\Views\Home\BurialRecord.cshtml"
           Write(x.Area);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n");
#nullable restore
#line 112 "C:\Users\irvin\source\repos\INTEXII\Views\Home\BurialRecord.cshtml"
             if (SignInManager.IsSignedIn(User))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col border sunshine\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5230fc41f242dd44f692cd1a0f00a9efe6fed00b14359", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 115 "C:\Users\irvin\source\repos\INTEXII\Views\Home\BurialRecord.cshtml"
                                                                 WriteLiteral(x.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5230fc41f242dd44f692cd1a0f00a9efe6fed00b16744", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 116 "C:\Users\irvin\source\repos\INTEXII\Views\Home\BurialRecord.cshtml"
                                                                   WriteLiteral(x.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 118 "C:\Users\irvin\source\repos\INTEXII\Views\Home\BurialRecord.cshtml"
            }
            else
            {

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 124 "C:\Users\irvin\source\repos\INTEXII\Views\Home\BurialRecord.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n\r\n    <div class=\"row mt-3\">\r\n        <div class=\"col\">\r\n            <nav aria-label=\"Page navigation example\">\r\n                <ul class=\"pagination justify-content-center\">\r\n\r\n");
#nullable restore
#line 132 "C:\Users\irvin\source\repos\INTEXII\Views\Home\BurialRecord.cshtml"
                     if (ViewBag.CurrentPage > 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"page-item\">\r\n                            <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4628, "\"", 4705, 1);
#nullable restore
#line 135 "C:\Users\irvin\source\repos\INTEXII\Views\Home\BurialRecord.cshtml"
WriteAttributeValue("", 4635, Url.Action("BurialRecord", new { pageNum = ViewBag.CurrentPage - 1 }), 4635, 70, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Previous</a>\r\n                        </li>\r\n");
#nullable restore
#line 137 "C:\Users\irvin\source\repos\INTEXII\Views\Home\BurialRecord.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 139 "C:\Users\irvin\source\repos\INTEXII\Views\Home\BurialRecord.cshtml"
                     for (int i = 1; i <= ViewBag.TotalPages; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li");
            BeginWriteAttribute("class", " class=\"", 4895, "\"", 4956, 2);
            WriteAttributeValue("", 4903, "page-item", 4903, 9, true);
#nullable restore
#line 141 "C:\Users\irvin\source\repos\INTEXII\Views\Home\BurialRecord.cshtml"
WriteAttributeValue(" ", 4912, i == ViewBag.CurrentPage ? "active" : "", 4913, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 5008, "\"", 5063, 1);
#nullable restore
#line 142 "C:\Users\irvin\source\repos\INTEXII\Views\Home\BurialRecord.cshtml"
WriteAttributeValue("", 5015, Url.Action("BurialRecord", new { pageNum = i }), 5015, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 142 "C:\Users\irvin\source\repos\INTEXII\Views\Home\BurialRecord.cshtml"
                                                                                                    Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </li>\r\n");
#nullable restore
#line 144 "C:\Users\irvin\source\repos\INTEXII\Views\Home\BurialRecord.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 146 "C:\Users\irvin\source\repos\INTEXII\Views\Home\BurialRecord.cshtml"
                     if (ViewBag.CurrentPage < ViewBag.TotalPages)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"page-item\">\r\n                            <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 5316, "\"", 5393, 1);
#nullable restore
#line 149 "C:\Users\irvin\source\repos\INTEXII\Views\Home\BurialRecord.cshtml"
WriteAttributeValue("", 5323, Url.Action("BurialRecord", new { pageNum = ViewBag.CurrentPage + 1 }), 5323, 70, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Next</a>\r\n                        </li>\r\n");
#nullable restore
#line 151 "C:\Users\irvin\source\repos\INTEXII\Views\Home\BurialRecord.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </ul>\r\n            </nav>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
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
