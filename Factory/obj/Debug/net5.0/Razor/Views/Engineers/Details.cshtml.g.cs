#pragma checksum "C:\Users\maryl\desktop\Factory.Solution\Factory\Views\Engineers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22a00dfbe68b93beab8475eb31b90cb9f5f7de18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Engineers_Details), @"mvc.1.0.view", @"/Views/Engineers/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22a00dfbe68b93beab8475eb31b90cb9f5f7de18", @"/Views/Engineers/Details.cshtml")]
    public class Views_Engineers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Factory.Models.Engineer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Engineer Details</h2>\r\n<hr />\r\n<h3>");
#nullable restore
#line 5 "C:\Users\maryl\desktop\Factory.Solution\Factory\Views\Engineers\Details.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 5 "C:\Users\maryl\desktop\Factory.Solution\Factory\Views\Engineers\Details.cshtml"
                                          Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n");
#nullable restore
#line 7 "C:\Users\maryl\desktop\Factory.Solution\Factory\Views\Engineers\Details.cshtml"
 if(@Model.JoinEntities.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p>This engineer does not manage any machines yet</p>\r\n");
#nullable restore
#line 10 "C:\Users\maryl\desktop\Factory.Solution\Factory\Views\Engineers\Details.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h4>Machines this engineer manages:</h4>\r\n  <ul>\r\n");
#nullable restore
#line 15 "C:\Users\maryl\desktop\Factory.Solution\Factory\Views\Engineers\Details.cshtml"
   foreach(var join in Model.JoinEntities)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>");
#nullable restore
#line 17 "C:\Users\maryl\desktop\Factory.Solution\Factory\Views\Engineers\Details.cshtml"
   Write(join.Machine.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 18 "C:\Users\maryl\desktop\Factory.Solution\Factory\Views\Engineers\Details.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </ul>\r\n");
#nullable restore
#line 20 "C:\Users\maryl\desktop\Factory.Solution\Factory\Views\Engineers\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>");
#nullable restore
#line 22 "C:\Users\maryl\desktop\Factory.Solution\Factory\Views\Engineers\Details.cshtml"
Write(Html.ActionLink("Back to engineers", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 23 "C:\Users\maryl\desktop\Factory.Solution\Factory\Views\Engineers\Details.cshtml"
Write(Html.ActionLink("Edit Engineer", "Edit", new { id = Model.EngineerId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 24 "C:\Users\maryl\desktop\Factory.Solution\Factory\Views\Engineers\Details.cshtml"
Write(Html.ActionLink("Delete Engineer", "Delete", new { id = Model.EngineerId }));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Factory.Models.Engineer> Html { get; private set; }
    }
}
#pragma warning restore 1591
