#pragma checksum "C:\Users\Nathan\OneDrive - Neumont College of Computer Science\Year 3\Quarter 1\Capstone\Capstone\Capstone\Capstone\Views\Items\_ItemPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71301aec9d27af2727b5890e363e3da58d2a48a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items__ItemPartialView), @"mvc.1.0.view", @"/Views/Items/_ItemPartialView.cshtml")]
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
#line 1 "C:\Users\Nathan\OneDrive - Neumont College of Computer Science\Year 3\Quarter 1\Capstone\Capstone\Capstone\Capstone\Views\_ViewImports.cshtml"
using Capstone;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nathan\OneDrive - Neumont College of Computer Science\Year 3\Quarter 1\Capstone\Capstone\Capstone\Capstone\Views\_ViewImports.cshtml"
using Capstone.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71301aec9d27af2727b5890e363e3da58d2a48a7", @"/Views/Items/_ItemPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ce908c0bb45e1fb84be626fd609fe31f3c1bb03", @"/Views/_ViewImports.cshtml")]
    public class Views_Items__ItemPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Capstone.Models.Item>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n    <table class=\"table\">\r\n        <tbody>\r\n");
#nullable restore
#line 6 "C:\Users\Nathan\OneDrive - Neumont College of Computer Science\Year 3\Quarter 1\Capstone\Capstone\Capstone\Capstone\Views\Items\_ItemPartialView.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 10 "C:\Users\Nathan\OneDrive - Neumont College of Computer Science\Year 3\Quarter 1\Capstone\Capstone\Capstone\Capstone\Views\Items\_ItemPartialView.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <h6>Price</h6>\r\n                        $");
#nullable restore
#line 14 "C:\Users\Nathan\OneDrive - Neumont College of Computer Science\Year 3\Quarter 1\Capstone\Capstone\Capstone\Capstone\Views\Items\_ItemPartialView.cshtml"
                    Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <h6>Description</h6>\r\n                        ");
#nullable restore
#line 18 "C:\Users\Nathan\OneDrive - Neumont College of Computer Science\Year 3\Quarter 1\Capstone\Capstone\Capstone\Capstone\Views\Items\_ItemPartialView.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 21 "C:\Users\Nathan\OneDrive - Neumont College of Computer Science\Year 3\Quarter 1\Capstone\Capstone\Capstone\Capstone\Views\Items\_ItemPartialView.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Capstone.Models.Item>> Html { get; private set; }
    }
}
#pragma warning restore 1591
