#pragma checksum "/Users/ales/www/AspHomework2/AspHomework2/Views/JobApplication/Answer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4417b107f64348fbec1c38020be61543e6d1e78a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_JobApplication_Answer), @"mvc.1.0.view", @"/Views/JobApplication/Answer.cshtml")]
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
#line 1 "/Users/ales/www/AspHomework2/AspHomework2/Views/_ViewImports.cshtml"
using AspHomework2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/ales/www/AspHomework2/AspHomework2/Views/_ViewImports.cshtml"
using AspHomework2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4417b107f64348fbec1c38020be61543e6d1e78a", @"/Views/JobApplication/Answer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ee4a2e8e91113823129adb3f2a8927068285b9f", @"/Views/_ViewImports.cshtml")]
    public class Views_JobApplication_Answer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JobApplicationAnswerViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "JobApplication", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/ales/www/AspHomework2/AspHomework2/Views/JobApplication/Answer.cshtml"
  
    ViewData["Title"] = "Přihláška";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4417b107f64348fbec1c38020be61543e6d1e78a3881", async() => {
                WriteLiteral("Zpět");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n<div class=\"row\">\n    <div class=\"col-md-12\">\n        <div>Číslo: ");
#nullable restore
#line 11 "/Users/ales/www/AspHomework2/AspHomework2/Views/JobApplication/Answer.cshtml"
               Write(Model.JobApplication.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n        <div>Vytvořeno: ");
#nullable restore
#line 12 "/Users/ales/www/AspHomework2/AspHomework2/Views/JobApplication/Answer.cshtml"
                   Write(Model.JobApplication.Created.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n        <div>Email: ");
#nullable restore
#line 13 "/Users/ales/www/AspHomework2/AspHomework2/Views/JobApplication/Answer.cshtml"
               Write(Model.JobApplication.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n        <div>Telefon: ");
#nullable restore
#line 14 "/Users/ales/www/AspHomework2/AspHomework2/Views/JobApplication/Answer.cshtml"
                 Write(Model.JobApplication.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n        <div>Text přihlášky:</div>\n        <p>");
#nullable restore
#line 16 "/Users/ales/www/AspHomework2/AspHomework2/Views/JobApplication/Answer.cshtml"
      Write(Model.JobApplication.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        <div>\n        <a");
            BeginWriteAttribute("href", " href=\"", 527, "\"", 573, 2);
            WriteAttributeValue("", 534, "/files/", 534, 7, true);
#nullable restore
#line 18 "/Users/ales/www/AspHomework2/AspHomework2/Views/JobApplication/Answer.cshtml"
WriteAttributeValue("", 541, Model.JobApplication.CvFilePath, 541, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Zobrazit soubor</a>    \n        </div>\n    </div>\n</div>\n\n");
#nullable restore
#line 23 "/Users/ales/www/AspHomework2/AspHomework2/Views/JobApplication/Answer.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\n        <div class=\"form-group\">\n            <div>");
#nullable restore
#line 27 "/Users/ales/www/AspHomework2/AspHomework2/Views/JobApplication/Answer.cshtml"
            Write(Html.LabelFor(a => a.Answer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n            <div>");
#nullable restore
#line 28 "/Users/ales/www/AspHomework2/AspHomework2/Views/JobApplication/Answer.cshtml"
            Write(Html.EditorFor(a => a.Answer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n        </div>\n        \n        <div class=\"form-group\">\n            <div>");
#nullable restore
#line 32 "/Users/ales/www/AspHomework2/AspHomework2/Views/JobApplication/Answer.cshtml"
            Write(Html.LabelFor(a => a.Accepted));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n            <div>");
#nullable restore
#line 33 "/Users/ales/www/AspHomework2/AspHomework2/Views/JobApplication/Answer.cshtml"
            Write(Html.CheckBoxFor(a => a.Accepted));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n        </div>\n        \n        <div class=\"form-group\">\n            ");
#nullable restore
#line 37 "/Users/ales/www/AspHomework2/AspHomework2/Views/JobApplication/Answer.cshtml"
       Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        \n        <div class=\"form-group\">\n            <input type=\"submit\" class=\"btn btn-primary\" value=\"Odeslat\">\n        </div>\n    </div>\n");
#nullable restore
#line 44 "/Users/ales/www/AspHomework2/AspHomework2/Views/JobApplication/Answer.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JobApplicationAnswerViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591