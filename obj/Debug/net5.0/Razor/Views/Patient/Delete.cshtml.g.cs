#pragma checksum "/Users/Admin/Desktop/Epicodus/week-11/DoctorOffice.Solution/DoctorOffice/Views/Patient/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4cbe90e13d47869e61a84cf81367c5f0ca9ea3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patient_Delete), @"mvc.1.0.view", @"/Views/Patient/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4cbe90e13d47869e61a84cf81367c5f0ca9ea3f", @"/Views/Patient/Delete.cshtml")]
    public class Views_Patient_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DoctorOffice.Models.Patient>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/Admin/Desktop/Epicodus/week-11/DoctorOffice.Solution/DoctorOffice/Views/Patient/Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h2>Are you sure you want to delete this patient?</h2>\n\n");
#nullable restore
#line 9 "/Users/Admin/Desktop/Epicodus/week-11/DoctorOffice.Solution/DoctorOffice/Views/Patient/Delete.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 9 "/Users/Admin/Desktop/Epicodus/week-11/DoctorOffice.Solution/DoctorOffice/Views/Patient/Delete.cshtml"
                                      Write(Html.DisplayFor(model=> model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\n");
#nullable restore
#line 10 "/Users/Admin/Desktop/Epicodus/week-11/DoctorOffice.Solution/DoctorOffice/Views/Patient/Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Delete\" />\n");
#nullable restore
#line 13 "/Users/Admin/Desktop/Epicodus/week-11/DoctorOffice.Solution/DoctorOffice/Views/Patient/Delete.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 15 "/Users/Admin/Desktop/Epicodus/week-11/DoctorOffice.Solution/DoctorOffice/Views/Patient/Delete.cshtml"
Write(Html.ActionLink("Back to Patients", "Index"));

#line default
#line hidden
#nullable disable
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