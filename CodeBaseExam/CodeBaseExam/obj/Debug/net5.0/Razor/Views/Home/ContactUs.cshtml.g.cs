#pragma checksum "C:\CodeBase\CodeBaseExam\CodeBaseExam\Views\Home\ContactUs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59be2b52ba54291b9a96cb1cbb1572388edb24d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ContactUs), @"mvc.1.0.view", @"/Views/Home/ContactUs.cshtml")]
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
#line 1 "C:\CodeBase\CodeBaseExam\CodeBaseExam\Views\_ViewImports.cshtml"
using CodeBaseExam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\CodeBase\CodeBaseExam\CodeBaseExam\Views\_ViewImports.cshtml"
using CodeBaseExam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59be2b52ba54291b9a96cb1cbb1572388edb24d5", @"/Views/Home/ContactUs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c74a57f4825fa0cb41065421bac1329c1a22169e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ContactUs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h1>ContactUs</h1>
<div>
    <label style=""color:royalblue"">
        Enter Your Name:
    </label>
    <br />
    <input type=""text"" />
    <br />
    <label style=""color:mediumvioletred"">
        Enter Your Number:
    </label>
    <br />
    <input type=""text"" />
    <br />
    <label style=""color:blueviolet"">
        Enter Your Address:
    </label>
    <br />
    <input type=""text"" />
    <br />
    Type of Query : &nbsp;&nbsp;&nbsp;&nbsp;<input type=""radio"" name=""Query"" value=""m"" />Application Related&nbsp;&nbsp;&nbsp;
    <input type=""radio"" name=""Query"" value=""f"" />Login Related&nbsp;&nbsp;&nbsp;
    <input type=""radio"" name=""Query"" value=""o"" />Others<br /><br />
    <label style=""color:forestgreen"">
        Reason to Contact Us
    </label>
    <br />
    <textarea style=""height:300px "">
    </textarea>
    <br />
    <input type=""submit"" style=""border-color :cornflowerblue"" />
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
