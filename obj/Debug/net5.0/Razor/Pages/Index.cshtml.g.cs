#pragma checksum "/Users/ryanpfaffman/Desktop/quizGui/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57322bd53ed2c6b04fce074aaeae99a213b26ff2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(quizGui.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace quizGui.Pages
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
#line 1 "/Users/ryanpfaffman/Desktop/quizGui/Pages/_ViewImports.cshtml"
using quizGui;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57322bd53ed2c6b04fce074aaeae99a213b26ff2", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4ef56f52c0344d0109ec8aea5e2557a464dae58", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/ryanpfaffman/Desktop/quizGui/Pages/Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n    <p>");
#nullable restore
#line 10 "/Users/ryanpfaffman/Desktop/quizGui/Pages/Index.cshtml"
  Write(ViewData["Question1"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <input type=\"radio\" value=\"t\" name=\"question1\"><label for=\"question1T\">True</label>\r\n    <input type=\"radio\" value=\"f\" name=\"question1\"><label for=\"question1F\">False</label>\r\n    <br>\r\n    <p>");
#nullable restore
#line 14 "/Users/ryanpfaffman/Desktop/quizGui/Pages/Index.cshtml"
  Write(ViewData["Question2"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <input type=\"radio\" value=\"t\" name=\"question2\"><label for=\"question2T\">True</label>\r\n    <input type=\"radio\" value=\"f\" name=\"question2\"><label for=\"question2F\">False</label>\r\n    <br>\r\n    <p>");
#nullable restore
#line 18 "/Users/ryanpfaffman/Desktop/quizGui/Pages/Index.cshtml"
  Write(ViewData["Question3"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <input type=\"radio\" value=\"t\" name=\"question3\"><label for=\"question3T\">True</label>\r\n    <input type=\"radio\" value=\"f\" name=\"question3\"><label for=\"question3F\">False</label>\r\n    <br>\r\n    <p>");
#nullable restore
#line 22 "/Users/ryanpfaffman/Desktop/quizGui/Pages/Index.cshtml"
  Write(ViewData["Question4"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <input type=\"radio\" value=\"t\" name=\"question4\"><label for=\"question4T\">True</label>\r\n    <input type=\"radio\" value=\"f\" name=\"question4\"><label for=\"question4F\">False</label>\r\n    <br>\r\n    <p>");
#nullable restore
#line 26 "/Users/ryanpfaffman/Desktop/quizGui/Pages/Index.cshtml"
  Write(ViewData["Question5"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
    <input type=""radio"" value=""t"" name=""question5""><label for=""question5T"">True</label>
    <input type=""radio"" value=""f"" name=""question5""><label for=""question5F"">False</label>
    <br>
    <input id=""button"" type=""submit"" value=""submit"">
    <p id=""numCorrect1""> </p>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
