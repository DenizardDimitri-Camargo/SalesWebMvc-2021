#pragma checksum "C:\TCC\ESTUDO\C# Udemy - Nelio\SalesWebMvc 2021\SalesWebMvcUpdate\Views\SalesRecords\SimpleSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65c003b7be7265e7464af1fbc3d2c83eb7dd72bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SalesRecords_SimpleSearch), @"mvc.1.0.view", @"/Views/SalesRecords/SimpleSearch.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SalesRecords/SimpleSearch.cshtml", typeof(AspNetCore.Views_SalesRecords_SimpleSearch))]
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
#line 1 "C:\TCC\ESTUDO\C# Udemy - Nelio\SalesWebMvc 2021\SalesWebMvcUpdate\Views\_ViewImports.cshtml"
using SalesWebMvcUpdate;

#line default
#line hidden
#line 2 "C:\TCC\ESTUDO\C# Udemy - Nelio\SalesWebMvc 2021\SalesWebMvcUpdate\Views\_ViewImports.cshtml"
using SalesWebMvcUpdate.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65c003b7be7265e7464af1fbc3d2c83eb7dd72bb", @"/Views/SalesRecords/SimpleSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f74c94007e382b8b8ea5e9870e3793fb6bd7da88", @"/Views/_ViewImports.cshtml")]
    public class Views_SalesRecords_SimpleSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SalesWebMvcUpdate.Models.SalesRecord>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form navbar-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\TCC\ESTUDO\C# Udemy - Nelio\SalesWebMvc 2021\SalesWebMvcUpdate\Views\SalesRecords\SimpleSearch.cshtml"
  
    ViewData["Title"] = "Simple Search";

#line default
#line hidden
            BeginContext(109, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(116, 17, false);
#line 7 "C:\TCC\ESTUDO\C# Udemy - Nelio\SalesWebMvc 2021\SalesWebMvcUpdate\Views\SalesRecords\SimpleSearch.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(133, 89, true);
            WriteLiteral("</h2>\r\n\r\n<nav class=\"navbar navbar-inverse\">\r\n    <div class=\"container-fluid\">\r\n        ");
            EndContext();
            BeginContext(222, 748, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eacaf71bc8c643be8be70a6e761c3b19", async() => {
                BeginContext(274, 299, true);
                WriteLiteral(@" <!-- ao não informar uma action para encaminhar, a action se chama a si propria -->
            <div class=""form-group"">
                <div class=""form-group"">
                    <label for=""minDate"">Min Date</label>
                    <input type=""date"" class=""form-control"" name=""minDate""");
                EndContext();
                BeginWriteAttribute("value", " value=", 573, "", 600, 1);
#line 15 "C:\TCC\ESTUDO\C# Udemy - Nelio\SalesWebMvc 2021\SalesWebMvcUpdate\Views\SalesRecords\SimpleSearch.cshtml"
WriteAttributeValue("", 580, ViewData["minDate"], 580, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(600, 204, true);
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"maxDate\">Max Date</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"maxDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 804, "", 831, 1);
#line 19 "C:\TCC\ESTUDO\C# Udemy - Nelio\SalesWebMvc 2021\SalesWebMvcUpdate\Views\SalesRecords\SimpleSearch.cshtml"
WriteAttributeValue("", 811, ViewData["maxDate"], 811, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(831, 132, true);
                WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-primary\">Filter</button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(970, 136, true);
            WriteLiteral("\r\n    </div>\r\n</nav>\r\n<div class=\"panel panel-primary\">\r\n    <div class=\"panel-heading\">\r\n        <h3 class=\"panel-title\">Total sales = ");
            EndContext();
            BeginContext(1107, 43, false);
#line 28 "C:\TCC\ESTUDO\C# Udemy - Nelio\SalesWebMvc 2021\SalesWebMvcUpdate\Views\SalesRecords\SimpleSearch.cshtml"
                                         Write(Model.Sum(obj => obj.Amount).ToString("F2"));

#line default
#line hidden
            EndContext();
            BeginContext(1150, 215, true);
            WriteLiteral("</h3>\r\n    </div>\r\n    <div class=\"panel-body\">\r\n        <table class=\"table table-striped table-hover\">\r\n            <thead>\r\n                <tr class=\"success\">\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1366, 38, false);
#line 35 "C:\TCC\ESTUDO\C# Udemy - Nelio\SalesWebMvc 2021\SalesWebMvcUpdate\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1404, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1484, 40, false);
#line 38 "C:\TCC\ESTUDO\C# Udemy - Nelio\SalesWebMvc 2021\SalesWebMvcUpdate\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1524, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1604, 42, false);
#line 41 "C:\TCC\ESTUDO\C# Udemy - Nelio\SalesWebMvc 2021\SalesWebMvcUpdate\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Seller));

#line default
#line hidden
            EndContext();
            BeginContext(1646, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1726, 53, false);
#line 44 "C:\TCC\ESTUDO\C# Udemy - Nelio\SalesWebMvc 2021\SalesWebMvcUpdate\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Seller.Department));

#line default
#line hidden
            EndContext();
            BeginContext(1779, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1859, 42, false);
#line 47 "C:\TCC\ESTUDO\C# Udemy - Nelio\SalesWebMvc 2021\SalesWebMvcUpdate\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(1901, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1981, 42, false);
#line 50 "C:\TCC\ESTUDO\C# Udemy - Nelio\SalesWebMvc 2021\SalesWebMvcUpdate\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2023, 95, true);
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 55 "C:\TCC\ESTUDO\C# Udemy - Nelio\SalesWebMvc 2021\SalesWebMvcUpdate\Views\SalesRecords\SimpleSearch.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(2183, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2268, 37, false);
#line 59 "C:\TCC\ESTUDO\C# Udemy - Nelio\SalesWebMvc 2021\SalesWebMvcUpdate\Views\SalesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2305, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2397, 39, false);
#line 62 "C:\TCC\ESTUDO\C# Udemy - Nelio\SalesWebMvc 2021\SalesWebMvcUpdate\Views\SalesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(2436, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2528, 46, false);
#line 65 "C:\TCC\ESTUDO\C# Udemy - Nelio\SalesWebMvc 2021\SalesWebMvcUpdate\Views\SalesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Seller.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2574, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2666, 57, false);
#line 68 "C:\TCC\ESTUDO\C# Udemy - Nelio\SalesWebMvc 2021\SalesWebMvcUpdate\Views\SalesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Seller.Department.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2723, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2815, 41, false);
#line 71 "C:\TCC\ESTUDO\C# Udemy - Nelio\SalesWebMvc 2021\SalesWebMvcUpdate\Views\SalesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(2856, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2948, 41, false);
#line 74 "C:\TCC\ESTUDO\C# Udemy - Nelio\SalesWebMvc 2021\SalesWebMvcUpdate\Views\SalesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2989, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 77 "C:\TCC\ESTUDO\C# Udemy - Nelio\SalesWebMvc 2021\SalesWebMvcUpdate\Views\SalesRecords\SimpleSearch.cshtml"
                }

#line default
#line hidden
            BeginContext(3068, 58, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SalesWebMvcUpdate.Models.SalesRecord>> Html { get; private set; }
    }
}
#pragma warning restore 1591
