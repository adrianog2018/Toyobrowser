#pragma checksum "Y:\lc101\ToyoBrowser\ToyoBrowser\ToyoBrowser\Views\Vehicle\TrimsLevel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "286b1f59cdba56a96812209d6a80009474704d11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vehicle_TrimsLevel), @"mvc.1.0.view", @"/Views/Vehicle/TrimsLevel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vehicle/TrimsLevel.cshtml", typeof(AspNetCore.Views_Vehicle_TrimsLevel))]
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
#line 1 "Y:\lc101\ToyoBrowser\ToyoBrowser\ToyoBrowser\Views\_ViewImports.cshtml"
using ToyoBrowser;

#line default
#line hidden
#line 2 "Y:\lc101\ToyoBrowser\ToyoBrowser\ToyoBrowser\Views\_ViewImports.cshtml"
using ToyoBrowser.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"286b1f59cdba56a96812209d6a80009474704d11", @"/Views/Vehicle/TrimsLevel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bca837e621f31329aa545cd93ad85b2ea95ad750", @"/Views/_ViewImports.cshtml")]
    public class Views_Vehicle_TrimsLevel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TrimsLevel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "Y:\lc101\ToyoBrowser\ToyoBrowser\ToyoBrowser\Views\Vehicle\TrimsLevel.cshtml"
  
    ViewData["Title"] = "Trims Levels";

#line default
#line hidden
            BeginContext(69, 75, true);
            WriteLiteral("\n<h2 class=\"p-2\">Trim Levels</h2>\n\n<div class=\"d-flex flex-row flex-wrap\">\n");
            EndContext();
#line 9 "Y:\lc101\ToyoBrowser\ToyoBrowser\ToyoBrowser\Views\Vehicle\TrimsLevel.cshtml"
     foreach (var v in Model)
    {

#line default
#line hidden
            BeginContext(180, 90, true);
            WriteLiteral("        <div class=\"card p-4\" style=\"width: 18rem;\">\n            <img class=\"card-img-top\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 270, "\"", 292, 1);
#line 12 "Y:\lc101\ToyoBrowser\ToyoBrowser\ToyoBrowser\Views\Vehicle\TrimsLevel.cshtml"
WriteAttributeValue("", 276, v.TrimPicture, 276, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(293, 98, true);
            WriteLiteral(" alt=\"Card image cap\">\n            <div class=\"card-body\">\n                <h5 class=\"card-title\">");
            EndContext();
            BeginContext(392, 6, false);
#line 14 "Y:\lc101\ToyoBrowser\ToyoBrowser\ToyoBrowser\Views\Vehicle\TrimsLevel.cshtml"
                                  Write(v.Year);

#line default
#line hidden
            EndContext();
            BeginContext(398, 2, true);
            WriteLiteral(" (");
            EndContext();
            BeginContext(401, 13, false);
#line 14 "Y:\lc101\ToyoBrowser\ToyoBrowser\ToyoBrowser\Views\Vehicle\TrimsLevel.cshtml"
                                           Write(v.ModelNumber);

#line default
#line hidden
            EndContext();
            BeginContext(414, 44, true);
            WriteLiteral(")</h5>\n                <p class=\"card-text\">");
            EndContext();
            BeginContext(459, 12, false);
#line 15 "Y:\lc101\ToyoBrowser\ToyoBrowser\ToyoBrowser\Views\Vehicle\TrimsLevel.cshtml"
                                Write(v.Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(471, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(473, 13, false);
#line 15 "Y:\lc101\ToyoBrowser\ToyoBrowser\ToyoBrowser\Views\Vehicle\TrimsLevel.cshtml"
                                              Write(v.Description);

#line default
#line hidden
            EndContext();
            BeginContext(486, 23, true);
            WriteLiteral("</p>\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 509, "\"", 539, 2);
            WriteAttributeValue("", 516, "/Vehicle/Features/", 516, 18, true);
#line 16 "Y:\lc101\ToyoBrowser\ToyoBrowser\ToyoBrowser\Views\Vehicle\TrimsLevel.cshtml"
WriteAttributeValue("", 534, v.Id, 534, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(540, 93, true);
            WriteLiteral(" class=\"btn btn-primary\">See Features</a>\n                \n            </div>\n        </div>\n");
            EndContext();
#line 20 "Y:\lc101\ToyoBrowser\ToyoBrowser\ToyoBrowser\Views\Vehicle\TrimsLevel.cshtml"
    }

#line default
#line hidden
            BeginContext(639, 8, true);
            WriteLiteral("</div>\n\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TrimsLevel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
