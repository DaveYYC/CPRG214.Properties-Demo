#pragma checksum "C:\Users\hahne\Desktop\ASP_Demos\CPRG214.Properties Demo\CPRG214.Properties.Presentation\Views\Shared\Components\RentalsByType\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99ae2e7814b2f69dffe647bdd9413ee548e5ac7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_RentalsByType_Default), @"mvc.1.0.view", @"/Views/Shared/Components/RentalsByType/Default.cshtml")]
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
#line 1 "C:\Users\hahne\Desktop\ASP_Demos\CPRG214.Properties Demo\CPRG214.Properties.Presentation\Views\_ViewImports.cshtml"
using CPRG214.Properties.Presentation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hahne\Desktop\ASP_Demos\CPRG214.Properties Demo\CPRG214.Properties.Presentation\Views\_ViewImports.cshtml"
using CPRG214.Properties.Presentation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99ae2e7814b2f69dffe647bdd9413ee548e5ac7f", @"/Views/Shared/Components/RentalsByType/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef57917ebfa4e5e12d21c4591befd3d204d3b1dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_RentalsByType_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CPRG214.Properties.Presentation.Models.RentalViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h3>Rental Properties</h3>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 9 "C:\Users\hahne\Desktop\ASP_Demos\CPRG214.Properties Demo\CPRG214.Properties.Presentation\Views\Shared\Components\RentalsByType\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 12 "C:\Users\hahne\Desktop\ASP_Demos\CPRG214.Properties Demo\CPRG214.Properties.Presentation\Views\Shared\Components\RentalsByType\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "C:\Users\hahne\Desktop\ASP_Demos\CPRG214.Properties Demo\CPRG214.Properties.Presentation\Views\Shared\Components\RentalsByType\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.Province));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\hahne\Desktop\ASP_Demos\CPRG214.Properties Demo\CPRG214.Properties.Presentation\Views\Shared\Components\RentalsByType\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.Rent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\hahne\Desktop\ASP_Demos\CPRG214.Properties Demo\CPRG214.Properties.Presentation\Views\Shared\Components\RentalsByType\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.PropertyType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\hahne\Desktop\ASP_Demos\CPRG214.Properties Demo\CPRG214.Properties.Presentation\Views\Shared\Components\RentalsByType\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.Owner));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 29 "C:\Users\hahne\Desktop\ASP_Demos\CPRG214.Properties Demo\CPRG214.Properties.Presentation\Views\Shared\Components\RentalsByType\Default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 33 "C:\Users\hahne\Desktop\ASP_Demos\CPRG214.Properties Demo\CPRG214.Properties.Presentation\Views\Shared\Components\RentalsByType\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 36 "C:\Users\hahne\Desktop\ASP_Demos\CPRG214.Properties Demo\CPRG214.Properties.Presentation\Views\Shared\Components\RentalsByType\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\Users\hahne\Desktop\ASP_Demos\CPRG214.Properties Demo\CPRG214.Properties.Presentation\Views\Shared\Components\RentalsByType\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.Province));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n               $");
#nullable restore
#line 42 "C:\Users\hahne\Desktop\ASP_Demos\CPRG214.Properties Demo\CPRG214.Properties.Presentation\Views\Shared\Components\RentalsByType\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.Rent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "C:\Users\hahne\Desktop\ASP_Demos\CPRG214.Properties Demo\CPRG214.Properties.Presentation\Views\Shared\Components\RentalsByType\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.PropertyType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "C:\Users\hahne\Desktop\ASP_Demos\CPRG214.Properties Demo\CPRG214.Properties.Presentation\Views\Shared\Components\RentalsByType\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.Owner));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 51 "C:\Users\hahne\Desktop\ASP_Demos\CPRG214.Properties Demo\CPRG214.Properties.Presentation\Views\Shared\Components\RentalsByType\Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("   </tbody>\r\n</table>\r\n");
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
