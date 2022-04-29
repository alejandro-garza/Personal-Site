#pragma checksum "/Users/Testing/Downloads/ Nansen/BETraining/git/Project2 B/Testing - Interface/Views/Education/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b7b7ff8988ef4703edb6748f4f44133103e9d71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Education_Index), @"mvc.1.0.view", @"/Views/Education/Index.cshtml")]
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
#line 1 "/Users/Testing/Downloads/ Nansen/BETraining/git/Project2 B/Testing - Interface/Views/_ViewImports.cshtml"
using ProjectApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/Testing/Downloads/ Nansen/BETraining/git/Project2 B/Testing - Interface/Views/_ViewImports.cshtml"
using ProjectApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b7b7ff8988ef4703edb6748f4f44133103e9d71", @"/Views/Education/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b47a8290b708440abd7ce361357a5619e85ec85", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Education_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EducationViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/Testing/Downloads/ Nansen/BETraining/git/Project2 B/Testing - Interface/Views/Education/Index.cshtml"
  
    ViewData["Company"] = "Education";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 6 "/Users/Testing/Downloads/ Nansen/BETraining/git/Project2 B/Testing - Interface/Views/Education/Index.cshtml"
Write(ViewData["Company"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n<br />\n\n\n<div class=\"container px-4\">\n\n");
            WriteLiteral(@"    <div class=""row justify-content-start gx-5"">
        <div class=""align-self-start"">
            <h2 class=""display-5"">Programs / Training</h2>
        </div>
    </div>
    <br />

    <div class=""row justify-content-start gx-5"">
        <div class=""align-self-start"">
            <ul class=""list-unstyled"">

");
#nullable restore
#line 24 "/Users/Testing/Downloads/ Nansen/BETraining/git/Project2 B/Testing - Interface/Views/Education/Index.cshtml"
                 foreach (var entry in @Model.myEducation)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "/Users/Testing/Downloads/ Nansen/BETraining/git/Project2 B/Testing - Interface/Views/Education/Index.cshtml"
                     if (entry.Institution != null && entry.Program.IndexOf("Program") != -1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li><strong>");
#nullable restore
#line 28 "/Users/Testing/Downloads/ Nansen/BETraining/git/Project2 B/Testing - Interface/Views/Education/Index.cshtml"
                               Write(entry.Institution);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> / ");
#nullable restore
#line 28 "/Users/Testing/Downloads/ Nansen/BETraining/git/Project2 B/Testing - Interface/Views/Education/Index.cshtml"
                                                             Write(entry.Program);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                        <li><small>");
#nullable restore
#line 29 "/Users/Testing/Downloads/ Nansen/BETraining/git/Project2 B/Testing - Interface/Views/Education/Index.cshtml"
                              Write(entry.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></li>\n                        <li><small>");
#nullable restore
#line 30 "/Users/Testing/Downloads/ Nansen/BETraining/git/Project2 B/Testing - Interface/Views/Education/Index.cshtml"
                              Write(string.Format("{0} - {1}", @entry.StartDate.ToShortDateString(), @entry.EndDate.ToShortDateString()));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></li>\n                        <br />\n");
#nullable restore
#line 32 "/Users/Testing/Downloads/ Nansen/BETraining/git/Project2 B/Testing - Interface/Views/Education/Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "/Users/Testing/Downloads/ Nansen/BETraining/git/Project2 B/Testing - Interface/Views/Education/Index.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </ul>\n        </div>\n    </div>\n\n");
            WriteLiteral(@"    <div class=""row justify-content-start gx-5"">
        <div class=""align-self-start"">
            <h2 class=""display-5"">College</h2>
        </div>
    </div>
    <br />

    <div class=""row justify-content-start gx-5"">
        <div class=""align-self-start"">
            <ul class=""list-unstyled"">

");
#nullable restore
#line 52 "/Users/Testing/Downloads/ Nansen/BETraining/git/Project2 B/Testing - Interface/Views/Education/Index.cshtml"
                 foreach (var entry in @Model.myEducation)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "/Users/Testing/Downloads/ Nansen/BETraining/git/Project2 B/Testing - Interface/Views/Education/Index.cshtml"
                     if (entry.Institution != null && entry.Program.IndexOf("Program") == -1)
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "/Users/Testing/Downloads/ Nansen/BETraining/git/Project2 B/Testing - Interface/Views/Education/Index.cshtml"
                                                                    
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li><strong>");
#nullable restore
#line 57 "/Users/Testing/Downloads/ Nansen/BETraining/git/Project2 B/Testing - Interface/Views/Education/Index.cshtml"
                               Write(entry.Institution);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> / ");
#nullable restore
#line 57 "/Users/Testing/Downloads/ Nansen/BETraining/git/Project2 B/Testing - Interface/Views/Education/Index.cshtml"
                                                             Write(entry.Program);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                        <li><small>");
#nullable restore
#line 58 "/Users/Testing/Downloads/ Nansen/BETraining/git/Project2 B/Testing - Interface/Views/Education/Index.cshtml"
                              Write(entry.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></li>\n                        <li><small>");
#nullable restore
#line 59 "/Users/Testing/Downloads/ Nansen/BETraining/git/Project2 B/Testing - Interface/Views/Education/Index.cshtml"
                              Write(string.Format("{0} - {1}", @entry.StartDate.ToShortDateString(), @entry.EndDate.ToShortDateString()));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></li>\n                        <br />\n");
#nullable restore
#line 61 "/Users/Testing/Downloads/ Nansen/BETraining/git/Project2 B/Testing - Interface/Views/Education/Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "/Users/Testing/Downloads/ Nansen/BETraining/git/Project2 B/Testing - Interface/Views/Education/Index.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </ul>
        </div>
    </div>
    <br />
    <br />
    <br />

</div>




<div class=""container border"">
    <div class=""row"">
        <div class=""col"">
            <div class=""container px-4"">
                <div class=""row justify-content-start gx-5"">
                    <div class=""align-self-start"">
                        <br />
                        <h2 class=""display-5""><strong>Contact Information</strong></h2>
                        <br />
                        <p class=""text-primary"">210.705.9596<br />ialexgarza4@gmail.com</p>
                        <p>Chicago, Illinios</p>
                    </div>
                </div>
            </div>
            <br />
            <br />
        </div>
        <div class=""col"">
            <div class=""mb-3"">
                <br />
                <label for=""exampleFormControlInput1"" class=""form-label"">Email Address</label>
                <input type=""email"" class=""form-control"" id=""exampleFormControlInput1"" placeholder=""name@example.c");
            WriteLiteral(@"om"">
            </div>
            <div class=""mb-3"">
                <label for=""exampleFormControlTextarea1"" class=""form-label"">Message</label>
                <textarea class=""form-control"" id=""exampleFormControlTextarea1"" rows=""3""></textarea>
                <br />
            </div>
        </div>
    </div>
</div>
<br />
<br />");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EducationViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
