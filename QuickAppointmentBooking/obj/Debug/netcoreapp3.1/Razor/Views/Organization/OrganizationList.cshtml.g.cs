#pragma checksum "C:\Github Projects\QuickAppointmentBooking\QuickAppointmentBooking\Views\Organization\OrganizationList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b645294970d25eb005a216d673ff92ae1b65c055"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Organization_OrganizationList), @"mvc.1.0.view", @"/Views/Organization/OrganizationList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b645294970d25eb005a216d673ff92ae1b65c055", @"/Views/Organization/OrganizationList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"959104f00469dc127a98e377ae106bb8c708dc27", @"/Views/_ViewImports.cshtml")]
    public class Views_Organization_OrganizationList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Organization>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("orglist_crud"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Organization", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Display", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Representatives", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn_orglist"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Github Projects\QuickAppointmentBooking\QuickAppointmentBooking\Views\Organization\OrganizationList.cshtml"
  ViewBag.Title = "Organizations"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"row\">\n    <h2>\n        Organization List\n    </h2>\n</div>\n\n<div class=\"row\">\n    <table class=\"orglist\">\n        <thead>\n            <tr class=\"orglist_tr\">\n");
#nullable restore
#line 14 "C:\Github Projects\QuickAppointmentBooking\QuickAppointmentBooking\Views\Organization\OrganizationList.cshtml"
                 if (User.IsAdmin())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <th class=\"orglist_th\">ID</th>\n");
#nullable restore
#line 17 "C:\Github Projects\QuickAppointmentBooking\QuickAppointmentBooking\Views\Organization\OrganizationList.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <th class=""orglist_th"">Name</th>
                <th class=""orglist_th"">Acronym</th>
                <th class=""orglist_th"">Website</th>
                <th class=""orglist_th"">Actions</th>
            </tr>

        </thead>
        <tbody>
");
#nullable restore
#line 26 "C:\Github Projects\QuickAppointmentBooking\QuickAppointmentBooking\Views\Organization\OrganizationList.cshtml"
             foreach (Organization org in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"orglist_tr\">\n");
#nullable restore
#line 29 "C:\Github Projects\QuickAppointmentBooking\QuickAppointmentBooking\Views\Organization\OrganizationList.cshtml"
                     if (User.IsAdmin())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"orglist_td\">");
#nullable restore
#line 31 "C:\Github Projects\QuickAppointmentBooking\QuickAppointmentBooking\Views\Organization\OrganizationList.cshtml"
                                          Write(org.OrganizationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 32 "C:\Github Projects\QuickAppointmentBooking\QuickAppointmentBooking\Views\Organization\OrganizationList.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td class=\"orglist_td\">");
#nullable restore
#line 33 "C:\Github Projects\QuickAppointmentBooking\QuickAppointmentBooking\Views\Organization\OrganizationList.cshtml"
                                      Write(org.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td class=\"orglist_td\">");
#nullable restore
#line 34 "C:\Github Projects\QuickAppointmentBooking\QuickAppointmentBooking\Views\Organization\OrganizationList.cshtml"
                                      Write(org.Acronym);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td class=\"orglist_td\"><a class=\"orglist_url\"");
            BeginWriteAttribute("href", " href=\"", 1065, "\"", 1087, 1);
#nullable restore
#line 35 "C:\Github Projects\QuickAppointmentBooking\QuickAppointmentBooking\Views\Organization\OrganizationList.cshtml"
WriteAttributeValue("", 1072, org.WebsiteUrl, 1072, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" title=\"Open website in a new tab\">");
#nullable restore
#line 35 "C:\Github Projects\QuickAppointmentBooking\QuickAppointmentBooking\Views\Organization\OrganizationList.cshtml"
                                                                                                                                      Write(org.WebsiteUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\n                    <td class=\"orglist_td\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b645294970d25eb005a216d673ff92ae1b65c0559263", async() => {
                WriteLiteral("View Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-organizationId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "C:\Github Projects\QuickAppointmentBooking\QuickAppointmentBooking\Views\Organization\OrganizationList.cshtml"
                                         WriteLiteral(org.OrganizationId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["organizationId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-organizationId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["organizationId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 40 "C:\Github Projects\QuickAppointmentBooking\QuickAppointmentBooking\Views\Organization\OrganizationList.cshtml"
                         if (User.IsAdmin())
                        {
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("|");
            WriteLiteral("\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b645294970d25eb005a216d673ff92ae1b65c05512181", async() => {
                WriteLiteral("Manage Representatives");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-organizationId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "C:\Github Projects\QuickAppointmentBooking\QuickAppointmentBooking\Views\Organization\OrganizationList.cshtml"
                                             WriteLiteral(org.OrganizationId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["organizationId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-organizationId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["organizationId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            WriteLiteral("|");
            WriteLiteral("\n                            <a class=\"unimplemented\" title=\"Unimplemented\">Delete</a>\n");
#nullable restore
#line 48 "C:\Github Projects\QuickAppointmentBooking\QuickAppointmentBooking\Views\Organization\OrganizationList.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\n                </tr>\n");
#nullable restore
#line 51 "C:\Github Projects\QuickAppointmentBooking\QuickAppointmentBooking\Views\Organization\OrganizationList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n");
#nullable restore
#line 54 "C:\Github Projects\QuickAppointmentBooking\QuickAppointmentBooking\Views\Organization\OrganizationList.cshtml"
     if (User.IsAdmin())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b645294970d25eb005a216d673ff92ae1b65c05515745", async() => {
                WriteLiteral("Create an Organization");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n");
#nullable restore
#line 59 "C:\Github Projects\QuickAppointmentBooking\QuickAppointmentBooking\Views\Organization\OrganizationList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Organization>> Html { get; private set; }
    }
}
#pragma warning restore 1591
