#pragma checksum "C:\Users\Fazairi\source\repos\coreproject\coreproject\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed373b9d1e7887e06e410fb881be10f627c4b0a0"
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
#line 1 "C:\Users\Fazairi\source\repos\coreproject\coreproject\Views\_ViewImports.cshtml"
using coreproject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Fazairi\source\repos\coreproject\coreproject\Views\_ViewImports.cshtml"
using coreproject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed373b9d1e7887e06e410fb881be10f627c4b0a0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e9f04917ae8957d969a618e91a94313ca0025dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Categroy>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Fazairi\source\repos\coreproject\coreproject\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<section id=\"featured-services\" class=\"featured-services\">\r\n\r\n   \r\n        <div class=\"container\" data-aos=\"fade-up\">\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 10 "C:\Users\Fazairi\source\repos\coreproject\coreproject\Views\Home\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 301, "\"", 327, 2);
            WriteAttributeValue("", 308, "/Home/News/", 308, 11, true);
#nullable restore
#line 12 "C:\Users\Fazairi\source\repos\coreproject\coreproject\Views\Home\Index.cshtml"
WriteAttributeValue("", 319, item.Id, 319, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">

                    <div class=""col-md-6 col-lg-3 d-flex align-items-stretch mb-5 mb-lg-0"">
                        <div class=""icon-box"" style=""width:100%"" data-aos=""fade-up"" data-aos-delay=""200"">
                            <div class=""icon""><i class=""icofont-drug""></i></div>
                            <h4 class=""title""><a");
            BeginWriteAttribute("href", " href=\"", 663, "\"", 689, 2);
            WriteAttributeValue("", 670, "/Home/News/", 670, 11, true);
#nullable restore
#line 17 "C:\Users\Fazairi\source\repos\coreproject\coreproject\Views\Home\Index.cshtml"
WriteAttributeValue("", 681, item.Id, 681, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 17 "C:\Users\Fazairi\source\repos\coreproject\coreproject\Views\Home\Index.cshtml"
                                                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                            <p class=\"description\">");
#nullable restore
#line 18 "C:\Users\Fazairi\source\repos\coreproject\coreproject\Views\Home\Index.cshtml"
                                              Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n\r\n\r\n                </a>\r\n");
#nullable restore
#line 24 "C:\Users\Fazairi\source\repos\coreproject\coreproject\Views\Home\Index.cshtml"


                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n\r\n        </div>\r\n\r\n            </section><!-- End Featured Services Section -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Categroy>> Html { get; private set; }
    }
}
#pragma warning restore 1591
