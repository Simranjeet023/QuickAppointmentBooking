#pragma checksum "C:\Github Projects\QuickAppointmentBooking\QuickAppointmentBooking\Views\Accreditation\Eligibility.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "677f932ddb9e6a4c01198b48dccecf0ebd64ebf0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accreditation_Eligibility), @"mvc.1.0.view", @"/Views/Accreditation/Eligibility.cshtml")]
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
#line 2 "C:\Github Projects\QuickAppointmentBooking\QuickAppointmentBooking\Views\_ViewImports.cshtml"
using GetAccredited.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Github Projects\QuickAppointmentBooking\QuickAppointmentBooking\Views\_ViewImports.cshtml"
using GetAccredited.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"677f932ddb9e6a4c01198b48dccecf0ebd64ebf0", @"/Views/Accreditation/Eligibility.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"959104f00469dc127a98e377ae106bb8c708dc27", @"/Views/_ViewImports.cshtml")]
    public class Views_Accreditation_Eligibility : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Accreditation>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Github Projects\QuickAppointmentBooking\QuickAppointmentBooking\Views\Accreditation\Eligibility.cshtml"
   ViewBag.Title = "Eligiblity Page"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"row\">\n    <h2>\n        ");
#nullable restore
#line 6 "C:\Github Projects\QuickAppointmentBooking\QuickAppointmentBooking\Views\Accreditation\Eligibility.cshtml"
   Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </h2>\n</div>\n\n<div class=\"row\">\n    <div class=\"col span-1-of-1\">\n        <div class=\"eligibility_box\">\n            <h1 class=\"eligibility_title\">\n                ");
#nullable restore
#line 14 "C:\Github Projects\QuickAppointmentBooking\QuickAppointmentBooking\Views\Accreditation\Eligibility.cshtml"
           Write(Model.Organization);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </h1><br>\n            <p>Eligibility Requirements List:</p>\n            <p>");
#nullable restore
#line 17 "C:\Github Projects\QuickAppointmentBooking\QuickAppointmentBooking\Views\Accreditation\Eligibility.cshtml"
          Write(Model.Eligibility);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        </div>\n    </div>\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Identity.UserManager<ApplicationUser> userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Accreditation> Html { get; private set; }
    }
}
#pragma warning restore 1591