#pragma checksum "/Users/Guest/Desktop/Animal_Shelter.Solution/Animal_Shelter/Views/Pets/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a14a2c5d579fd3be74d0af032e5be8effd1cb8f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pets_Index), @"mvc.1.0.view", @"/Views/Pets/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pets/Index.cshtml", typeof(AspNetCore.Views_Pets_Index))]
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
#line 1 "/Users/Guest/Desktop/Animal_Shelter.Solution/Animal_Shelter/Views/Pets/Index.cshtml"
using AnimalShelter.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a14a2c5d579fd3be74d0af032e5be8effd1cb8f2", @"/Views/Pets/Index.cshtml")]
    public class Views_Pets_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AnimalShelter.Models.Pets>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(69, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "/Users/Guest/Desktop/Animal_Shelter.Solution/Animal_Shelter/Views/Pets/Index.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
            BeginContext(95, 33, true);
            WriteLiteral("    <h3>No animals in list </h3>\n");
            EndContext();
#line 7 "/Users/Guest/Desktop/Animal_Shelter.Solution/Animal_Shelter/Views/Pets/Index.cshtml"
}

#line default
#line hidden
            BeginContext(130, 5, true);
            WriteLiteral("<ul>\n");
            EndContext();
#line 9 "/Users/Guest/Desktop/Animal_Shelter.Solution/Animal_Shelter/Views/Pets/Index.cshtml"
 foreach (Pets pet in Model)
{

#line default
#line hidden
            BeginContext(166, 8, true);
            WriteLiteral("    <li>");
            EndContext();
            BeginContext(175, 66, false);
#line 11 "/Users/Guest/Desktop/Animal_Shelter.Solution/Animal_Shelter/Views/Pets/Index.cshtml"
   Write(Html.ActionLink($"{pet.AnimalType}" ,"Details", new {id = pet.Id}));

#line default
#line hidden
            EndContext();
            BeginContext(241, 7, true);
            WriteLiteral(" </li>\n");
            EndContext();
#line 12 "/Users/Guest/Desktop/Animal_Shelter.Solution/Animal_Shelter/Views/Pets/Index.cshtml"
}

#line default
#line hidden
            BeginContext(250, 5, true);
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AnimalShelter.Models.Pets>> Html { get; private set; }
    }
}
#pragma warning restore 1591