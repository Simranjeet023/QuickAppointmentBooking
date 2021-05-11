#pragma checksum "C:\Users\John\source\repos\COMP 231\Comp231Group6\GetAccredited\GetAccredited\Views\Appointment\UserAppointments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c11a4da8840e14ba5470709944ef3bd358db81c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Appointment_UserAppointments), @"mvc.1.0.view", @"/Views/Appointment/UserAppointments.cshtml")]
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
#line 2 "C:\Users\John\source\repos\COMP 231\Comp231Group6\GetAccredited\GetAccredited\Views\_ViewImports.cshtml"
using GetAccredited.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\John\source\repos\COMP 231\Comp231Group6\GetAccredited\GetAccredited\Views\_ViewImports.cshtml"
using GetAccredited.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c11a4da8840e14ba5470709944ef3bd358db81c1", @"/Views/Appointment/UserAppointments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83f88453f07de852fdcb686b23048a4a471490bd", @"/Views/_ViewImports.cshtml")]
    public class Views_Appointment_UserAppointments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Booking>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Appointment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RequestReschedule", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RequestCancellation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\John\source\repos\COMP 231\Comp231Group6\GetAccredited\GetAccredited\Views\Appointment\UserAppointments.cshtml"
   ViewBag.Title = "My Appointments"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <h2>\r\n        My Appointments\r\n    </h2>\r\n</div>\r\n\r\n<div class=\"row\">\r\n");
#nullable restore
#line 12 "C:\Users\John\source\repos\COMP 231\Comp231Group6\GetAccredited\GetAccredited\Views\Appointment\UserAppointments.cshtml"
     if (Model.Any())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""myappointlist"">
            <thead>
                <tr class=""myappointlist_tr"">
                    <th class=""myappointlist_th"">Date</th>
                    <th class=""myappointlist_th"">Start Time</th>
                    <th class=""myappointlist_th"">End Time</th>
                    <th class=""myappointlist_th"">Organization</th>
                    <th class=""myappointlist_th"">Accreditation</th>
                    <th class=""myappointlist_th"">Actions</th>
                </tr>
            </thead>

            <tbody>
");
#nullable restore
#line 27 "C:\Users\John\source\repos\COMP 231\Comp231Group6\GetAccredited\GetAccredited\Views\Appointment\UserAppointments.cshtml"
                 foreach (var booking in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"myappointlist_tr\">\r\n                        <td class=\"myappointlist_td\">");
#nullable restore
#line 30 "C:\Users\John\source\repos\COMP 231\Comp231Group6\GetAccredited\GetAccredited\Views\Appointment\UserAppointments.cshtml"
                                                 Write($"{booking.Appointment.Date:MMMM d, yyyy}");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"myappointlist_td\">");
#nullable restore
#line 31 "C:\Users\John\source\repos\COMP 231\Comp231Group6\GetAccredited\GetAccredited\Views\Appointment\UserAppointments.cshtml"
                                                 Write($"{booking.Appointment.Start:h:mm tt}");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"myappointlist_td\">");
#nullable restore
#line 32 "C:\Users\John\source\repos\COMP 231\Comp231Group6\GetAccredited\GetAccredited\Views\Appointment\UserAppointments.cshtml"
                                                 Write($"{booking.Appointment.End:h:mm tt}");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"myappointlist_td\">");
#nullable restore
#line 33 "C:\Users\John\source\repos\COMP 231\Comp231Group6\GetAccredited\GetAccredited\Views\Appointment\UserAppointments.cshtml"
                                                Write(booking.Accreditation.Organization.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"myappointlist_td\">");
#nullable restore
#line 34 "C:\Users\John\source\repos\COMP 231\Comp231Group6\GetAccredited\GetAccredited\Views\Appointment\UserAppointments.cshtml"
                                                Write(booking.Accreditation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n");
#nullable restore
#line 36 "C:\Users\John\source\repos\COMP 231\Comp231Group6\GetAccredited\GetAccredited\Views\Appointment\UserAppointments.cshtml"
                             if (booking.IsCancelled)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i>CANCELLED</i>\r\n");
#nullable restore
#line 39 "C:\Users\John\source\repos\COMP 231\Comp231Group6\GetAccredited\GetAccredited\Views\Appointment\UserAppointments.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c11a4da8840e14ba5470709944ef3bd358db81c18508", async() => {
                WriteLiteral("Reschedule");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-bookingId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "C:\Users\John\source\repos\COMP 231\Comp231Group6\GetAccredited\GetAccredited\Views\Appointment\UserAppointments.cshtml"
                                                WriteLiteral(booking.BookingId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["bookingId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-bookingId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["bookingId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" | ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c11a4da8840e14ba5470709944ef3bd358db81c110953", async() => {
                WriteLiteral("Cancel");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-bookingId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\John\source\repos\COMP 231\Comp231Group6\GetAccredited\GetAccredited\Views\Appointment\UserAppointments.cshtml"
                                                                                                             WriteLiteral(booking.BookingId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["bookingId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-bookingId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["bookingId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </span>\r\n");
#nullable restore
#line 49 "C:\Users\John\source\repos\COMP 231\Comp231Group6\GetAccredited\GetAccredited\Views\Appointment\UserAppointments.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 52 "C:\Users\John\source\repos\COMP 231\Comp231Group6\GetAccredited\GetAccredited\Views\Appointment\UserAppointments.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 55 "C:\Users\John\source\repos\COMP 231\Comp231Group6\GetAccredited\GetAccredited\Views\Appointment\UserAppointments.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <center>You have no appointments booked at the moment.</center>\r\n");
#nullable restore
#line 59 "C:\Users\John\source\repos\COMP 231\Comp231Group6\GetAccredited\GetAccredited\Views\Appointment\UserAppointments.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Booking>> Html { get; private set; }
    }
}
#pragma warning restore 1591
