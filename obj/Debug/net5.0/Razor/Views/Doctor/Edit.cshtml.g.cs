#pragma checksum "/Users/Admin/Desktop/Epicodus/week-11/DoctorOffice.Solution/DoctorOffice/Views/Doctor/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3182f315759742cc85e9fd26efcc917b197f2b4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctor_Edit), @"mvc.1.0.view", @"/Views/Doctor/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3182f315759742cc85e9fd26efcc917b197f2b4a", @"/Views/Doctor/Edit.cshtml")]
    public class Views_Doctor_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DoctorOffice.Models.Doctor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/Admin/Desktop/Epicodus/week-11/DoctorOffice.Solution/DoctorOffice/Views/Doctor/Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h2>Edit</h2>\n\n<h4>Edit this doctor: ");
#nullable restore
#line 9 "/Users/Admin/Desktop/Epicodus/week-11/DoctorOffice.Solution/DoctorOffice/Views/Doctor/Edit.cshtml"
                 Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n\n");
#nullable restore
#line 11 "/Users/Admin/Desktop/Epicodus/week-11/DoctorOffice.Solution/DoctorOffice/Views/Doctor/Edit.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/Admin/Desktop/Epicodus/week-11/DoctorOffice.Solution/DoctorOffice/Views/Doctor/Edit.cshtml"
Write(Html.HiddenFor(model => model.DoctorId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/Admin/Desktop/Epicodus/week-11/DoctorOffice.Solution/DoctorOffice/Views/Doctor/Edit.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/Admin/Desktop/Epicodus/week-11/DoctorOffice.Solution/DoctorOffice/Views/Doctor/Edit.cshtml"
Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "/Users/Admin/Desktop/Epicodus/week-11/DoctorOffice.Solution/DoctorOffice/Views/Doctor/Edit.cshtml"
Write(Html.LabelFor(model=> model.Specialty));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "/Users/Admin/Desktop/Epicodus/week-11/DoctorOffice.Solution/DoctorOffice/Views/Doctor/Edit.cshtml"
Write(Html.TextBoxFor(model => model.Specialty));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Save\" />\n");
#nullable restore
#line 21 "/Users/Admin/Desktop/Epicodus/week-11/DoctorOffice.Solution/DoctorOffice/Views/Doctor/Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<p>");
#nullable restore
#line 23 "/Users/Admin/Desktop/Epicodus/week-11/DoctorOffice.Solution/DoctorOffice/Views/Doctor/Edit.cshtml"
Write(Html.ActionLink("Back to doctors", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoctorOffice.Models.Doctor> Html { get; private set; }
    }
}
#pragma warning restore 1591
