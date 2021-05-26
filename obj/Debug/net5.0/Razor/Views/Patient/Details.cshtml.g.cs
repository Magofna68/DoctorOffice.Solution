#pragma checksum "/Users/Admin/Desktop/Epicodus/week-11/DoctorOffice.Solution/DoctorOffice/Views/Patient/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b79bcfc0b2b4a2fe711dd87d5f8aa692b554dccc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patient_Details), @"mvc.1.0.view", @"/Views/Patient/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b79bcfc0b2b4a2fe711dd87d5f8aa692b554dccc", @"/Views/Patient/Details.cshtml")]
    public class Views_Patient_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DoctorOffice.Models.Patient>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/Admin/Desktop/Epicodus/week-11/DoctorOffice.Solution/DoctorOffice/Views/Patient/Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h2>Patient Details</h2>\n<hr />\n<h3>");
#nullable restore
#line 9 "/Users/Admin/Desktop/Epicodus/week-11/DoctorOffice.Solution/DoctorOffice/Views/Patient/Details.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 9 "/Users/Admin/Desktop/Epicodus/week-11/DoctorOffice.Solution/DoctorOffice/Views/Patient/Details.cshtml"
                                          Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n\n");
#nullable restore
#line 11 "/Users/Admin/Desktop/Epicodus/week-11/DoctorOffice.Solution/DoctorOffice/Views/Patient/Details.cshtml"
 if (@Model.JoinEntities.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p>this patient does not belong to any doctors</p>\n");
#nullable restore
#line 14 "/Users/Admin/Desktop/Epicodus/week-11/DoctorOffice.Solution/DoctorOffice/Views/Patient/Details.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h4>Doctors the patient belongs to:</h4>\n  <ul>\n");
#nullable restore
#line 19 "/Users/Admin/Desktop/Epicodus/week-11/DoctorOffice.Solution/DoctorOffice/Views/Patient/Details.cshtml"
   foreach (var join in Model.JoinEntities)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <li>");
#nullable restore
#line 21 "/Users/Admin/Desktop/Epicodus/week-11/DoctorOffice.Solution/DoctorOffice/Views/Patient/Details.cshtml"
     Write(join.Doctor.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 22 "/Users/Admin/Desktop/Epicodus/week-11/DoctorOffice.Solution/DoctorOffice/Views/Patient/Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </ul>\n");
#nullable restore
#line 24 "/Users/Admin/Desktop/Epicodus/week-11/DoctorOffice.Solution/DoctorOffice/Views/Patient/Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<p>");
#nullable restore
#line 26 "/Users/Admin/Desktop/Epicodus/week-11/DoctorOffice.Solution/DoctorOffice/Views/Patient/Details.cshtml"
Write(Html.ActionLink("Add a Doctor", "AddDoctor", new { id = Model.PatientId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n<p>");
#nullable restore
#line 28 "/Users/Admin/Desktop/Epicodus/week-11/DoctorOffice.Solution/DoctorOffice/Views/Patient/Details.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>");
#nullable restore
#line 29 "/Users/Admin/Desktop/Epicodus/week-11/DoctorOffice.Solution/DoctorOffice/Views/Patient/Details.cshtml"
Write(Html.ActionLink("Edit Patient", "Edit", new { id = Model.PatientId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>");
#nullable restore
#line 30 "/Users/Admin/Desktop/Epicodus/week-11/DoctorOffice.Solution/DoctorOffice/Views/Patient/Details.cshtml"
Write(Html.ActionLink("Delete Patient", "Delete", new { id = Model.PatientId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoctorOffice.Models.Patient> Html { get; private set; }
    }
}
#pragma warning restore 1591
