#pragma checksum "C:\Users\hahne\Desktop\ASP_Demos\CPRG214.Properties D7\CPRG214.Properties.Presentation\Views\Rentals\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfbe86e5e433fb228dbd659cc997b47c8600b25b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rentals_Index), @"mvc.1.0.view", @"/Views/Rentals/Index.cshtml")]
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
#line 1 "C:\Users\hahne\Desktop\ASP_Demos\CPRG214.Properties D7\CPRG214.Properties.Presentation\Views\_ViewImports.cshtml"
using CPRG214.Properties.Presentation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hahne\Desktop\ASP_Demos\CPRG214.Properties D7\CPRG214.Properties.Presentation\Views\_ViewImports.cshtml"
using CPRG214.Properties.Presentation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfbe86e5e433fb228dbd659cc997b47c8600b25b", @"/Views/Rentals/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef57917ebfa4e5e12d21c4591befd3d204d3b1dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Rentals_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CPRG214.Properties.Presentation.Models.RentalViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\hahne\Desktop\ASP_Demos\CPRG214.Properties D7\CPRG214.Properties.Presentation\Views\Rentals\Index.cshtml"
  
    ViewData["Title"] = "Rentals List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>List of Rental Properties</h3>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfbe86e5e433fb228dbd659cc997b47c8600b25b3905", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\hahne\Desktop\ASP_Demos\CPRG214.Properties D7\CPRG214.Properties.Presentation\Views\Rentals\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\hahne\Desktop\ASP_Demos\CPRG214.Properties D7\CPRG214.Properties.Presentation\Views\Rentals\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\hahne\Desktop\ASP_Demos\CPRG214.Properties D7\CPRG214.Properties.Presentation\Views\Rentals\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.Province));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\hahne\Desktop\ASP_Demos\CPRG214.Properties D7\CPRG214.Properties.Presentation\Views\Rentals\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.Rent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\hahne\Desktop\ASP_Demos\CPRG214.Properties D7\CPRG214.Properties.Presentation\Views\Rentals\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.PropertyType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\hahne\Desktop\ASP_Demos\CPRG214.Properties D7\CPRG214.Properties.Presentation\Views\Rentals\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.Owner));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 37 "C:\Users\hahne\Desktop\ASP_Demos\CPRG214.Properties D7\CPRG214.Properties.Presentation\Views\Rentals\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "C:\Users\hahne\Desktop\ASP_Demos\CPRG214.Properties D7\CPRG214.Properties.Presentation\Views\Rentals\Index.cshtml"
               Write(Html.DisplayFor(m => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "C:\Users\hahne\Desktop\ASP_Demos\CPRG214.Properties D7\CPRG214.Properties.Presentation\Views\Rentals\Index.cshtml"
               Write(Html.DisplayFor(m => item.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "C:\Users\hahne\Desktop\ASP_Demos\CPRG214.Properties D7\CPRG214.Properties.Presentation\Views\Rentals\Index.cshtml"
               Write(Html.DisplayFor(m => item.Province));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    $");
#nullable restore
#line 50 "C:\Users\hahne\Desktop\ASP_Demos\CPRG214.Properties D7\CPRG214.Properties.Presentation\Views\Rentals\Index.cshtml"
                Write(Html.DisplayFor(m => item.Rent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "C:\Users\hahne\Desktop\ASP_Demos\CPRG214.Properties D7\CPRG214.Properties.Presentation\Views\Rentals\Index.cshtml"
               Write(Html.DisplayFor(m => item.PropertyType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "C:\Users\hahne\Desktop\ASP_Demos\CPRG214.Properties D7\CPRG214.Properties.Presentation\Views\Rentals\Index.cshtml"
               Write(Html.DisplayFor(m => item.Owner));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 59 "C:\Users\hahne\Desktop\ASP_Demos\CPRG214.Properties D7\CPRG214.Properties.Presentation\Views\Rentals\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 60 "C:\Users\hahne\Desktop\ASP_Demos\CPRG214.Properties D7\CPRG214.Properties.Presentation\Views\Rentals\Index.cshtml"
               Write(Html.ActionLink("Details", "Details", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 63 "C:\Users\hahne\Desktop\ASP_Demos\CPRG214.Properties D7\CPRG214.Properties.Presentation\Views\Rentals\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    <script>\r\n        $(document).ready(function () {\r\n            //alert(\'loaded\');\r\n        });\r\n    </script>\r\n\r\n");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CPRG214.Properties.Presentation.Models.RentalViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
