#pragma checksum "/Users/Testing/Desktop/ Desktop/BE Training/git/Project2 B/ProjectApp2/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a03614c6c76af8c203ec46879958cfeb3ae4303d"
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
#line 1 "/Users/Testing/Desktop/ Desktop/BE Training/git/Project2 B/ProjectApp2/Views/_ViewImports.cshtml"
using ProjectApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/Testing/Desktop/ Desktop/BE Training/git/Project2 B/ProjectApp2/Views/_ViewImports.cshtml"
using ProjectApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a03614c6c76af8c203ec46879958cfeb3ae4303d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b47a8290b708440abd7ce361357a5619e85ec85", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("<div class=\"container px-4\">\n    <div class=\"row justify-content-start gx-5\">\n        <div class=\"align-self-start\">\n            <h5 class=\"display-10\">");
#nullable restore
#line 8 "/Users/Testing/Desktop/ Desktop/BE Training/git/Project2 B/ProjectApp2/Views/Home/Index.cshtml"
                              Write(Model.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5> ");
            WriteLiteral(@"
        </div>
        <br />
        <br />
    </div>
</div>
<br />
<br />
<br />
<br />

<div class=""container"">
    <div class=""row"">
        <div class=""col"">
            <div class=""container px-4"">
                <div class=""row justify-content-start gx-5"">
");
            WriteLiteral("                    <div class=\"align-self-start\">\n                        <h2 class=\"display-5\"><p class=\"text-primary\">");
#nullable restore
#line 26 "/Users/Testing/Desktop/ Desktop/BE Training/git/Project2 B/ProjectApp2/Views/Home/Index.cshtml"
                                                                 Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></h2> ");
            WriteLiteral("\n                    </div>\n                    <br />\n                    <br />\n\n");
            WriteLiteral(@"                    <div class=""align-self-start"">
                        <br />
                        <p>
                            Results-oriented, dedicated, and personable customer service specialist looking to transition into a career in web development.
                            Prior professional experience in web development quality assurance as well as academic credits in JavaScript and C++.
                            Strong work ethic with an ability to perform efficiently and succeed in time-sensitive assignments and demanding environments.
                        </p>
                    </div>
                    <br />
                    <br />
                    <br />


                    <div class=""container px-4"">
                        <div class=""row justify-content-start gx-5"">
");
            WriteLiteral(@"                            <div class=""align-self-start"">
                                <button type=""button"" class=""btn btn-primary""><a href=""ialexgarza@icloud.com"" class=""text-white"">Email Me</a></button>
                            </div>
                            <br />
                            <br />

");
            WriteLiteral(@"                            <div class=""row align-items-end"">
                                <br />
                                <br />
                                <div class=""col"">
                                    <button type=""button"" class=""btn btn-outline-primary bt-lg""><a href=""https://www.facebook.com/ialexgarza/"">Facebook</a></button>
                                </div>
                                <div class=""col"">
                                    <button type=""button"" class=""btn btn-outline-primary bt-lg""><a href=""https://www.instagram.com/ialexgarza/"">Instagram</a></button>
                                </div>
                                <div class=""col"">
                                    <button type=""button"" class=""btn btn-outline-primary bt-lg""><a href=""https://twitter.com/ialexgarza"">Twitter</a></button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
           ");
            WriteLiteral(" <br />\n            <br />\n        </div>\n        <div class=\"col\">\n            <div class=\"text-center\">\n");
            WriteLiteral("                <img src=\"http://placeimg.com/640/480/people\" class=\"img-thumbnail\">\n                <br />\n                <br />\n                <br />\n            </div>\n        </div>\n    </div>\n</div>\n<br />\n<br />\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591