#pragma checksum "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39fee2e8eb9d7e67f6885bc666e4f769d7d2a507"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CaseProfiles_Index), @"mvc.1.0.view", @"/Views/CaseProfiles/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CaseProfiles/Index.cshtml", typeof(AspNetCore.Views_CaseProfiles_Index))]
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
#line 1 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\_ViewImports.cshtml"
using AdvocatePersonalAssistant_APA_System;

#line default
#line hidden
#line 2 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\_ViewImports.cshtml"
using AdvocatePersonalAssistant_APA_System.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39fee2e8eb9d7e67f6885bc666e4f769d7d2a507", @"/Views/CaseProfiles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3540a498f392ad9da72a35ae39cf7c01548420ef", @"/Views/_ViewImports.cshtml")]
    public class Views_CaseProfiles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AdvocatePersonalAssistantSystem.Models.CaseProfile>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(72, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(115, 736, true);
            WriteLiteral(@"    <style>
        body {
            font-family: 'raleway';
        }

        table {
            width: 100%;
            border-collapse: collapse;
            font-size: 18px;
            color: #04311d;
            text-align: justify;
            padding: 20px;
            font-family: raleway;
        }

        th {
            background-color: #76D7C4;
            color: #fff;
            padding: 10px;
            border: 1px solid #d8dada;
        }

        td {
            background-color: #d1f5e8;
            padding: 10px;
            border: 1px solid #d8dada;
        }
    </style>
    <div style=""font-family:Arial"">

        <h2>Case Profile</h2>

        <p>
            ");
            EndContext();
            BeginContext(851, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf170e233355431e8dcca3fefe44f9c6", async() => {
                BeginContext(874, 14, true);
                WriteLiteral("Create Profile");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(892, 29, true);
            WriteLiteral("\r\n        </p>\r\n        <p>\r\n");
            EndContext();
#line 42 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Index.cshtml"
             using(Html.BeginForm("Index","CaseProfiles",FormMethod.Get))
            {

#line default
#line hidden
            BeginContext(1011, 34, true);
            WriteLiteral("                <b>Search By:</b> ");
            EndContext();
            BeginContext(1046, 43, false);
#line 44 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Index.cshtml"
                             Write(Html.RadioButton("searchBy","Case_Id",true));

#line default
#line hidden
            EndContext();
            BeginContext(1095, 9, true);
            WriteLiteral("Case ID  ");
            EndContext();
            BeginContext(1134, 39, false);
#line 45 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Index.cshtml"
             Write(Html.RadioButton("searchBy","CaseName"));

#line default
#line hidden
            EndContext();
            BeginContext(1179, 9, true);
            WriteLiteral("Case Name");
            EndContext();
            BeginContext(1195, 6, true);
            WriteLiteral("<br>\r\n");
            EndContext();
            BeginContext(1218, 22, false);
#line 46 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Index.cshtml"
           Write(Html.TextBox("search"));

#line default
#line hidden
            EndContext();
            BeginContext(1240, 40, true);
            WriteLiteral("<input type=\"submit\" value=\" Search\"/>\r\n");
            EndContext();
#line 47 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1295, 149, true);
            WriteLiteral("        </p>\r\n        <table border=\"1\" class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1445, 43, false);
#line 53 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Case_Id));

#line default
#line hidden
            EndContext();
            BeginContext(1488, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1568, 47, false);
#line 56 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.CaseHistory));

#line default
#line hidden
            EndContext();
            BeginContext(1615, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1695, 44, false);
#line 59 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.CaseName));

#line default
#line hidden
            EndContext();
            BeginContext(1739, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1819, 46, false);
#line 62 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ClientName));

#line default
#line hidden
            EndContext();
            BeginContext(1865, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1945, 45, false);
#line 65 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Plaintiff));

#line default
#line hidden
            EndContext();
            BeginContext(1990, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(2070, 45, false);
#line 68 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Defendant));

#line default
#line hidden
            EndContext();
            BeginContext(2115, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(2195, 41, false);
#line 71 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(2236, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(2316, 43, false);
#line 74 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(2359, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(2439, 39, false);
#line 77 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Fee));

#line default
#line hidden
            EndContext();
            BeginContext(2478, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(2558, 41, false);
#line 80 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Idate));

#line default
#line hidden
            EndContext();
            BeginContext(2599, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(2679, 41, false);
#line 83 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Hdate));

#line default
#line hidden
            EndContext();
            BeginContext(2720, 132, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>Action</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 89 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Index.cshtml"
                 if (Model.Count() == 0)
                {

#line default
#line hidden
            BeginContext(2913, 129, true);
            WriteLiteral("                    <tr>\r\n                        <td colspan=\"11\">No row match search criteria</td>\r\n                    </tr>\r\n");
            EndContext();
#line 94 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Index.cshtml"
                }
                else
                {
                foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(3166, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3227, 42, false);
#line 101 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Case_Id));

#line default
#line hidden
            EndContext();
            BeginContext(3269, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3337, 46, false);
#line 104 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CaseHistory));

#line default
#line hidden
            EndContext();
            BeginContext(3383, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3451, 43, false);
#line 107 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CaseName));

#line default
#line hidden
            EndContext();
            BeginContext(3494, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3562, 45, false);
#line 110 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ClientName));

#line default
#line hidden
            EndContext();
            BeginContext(3607, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3675, 44, false);
#line 113 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Plaintiff));

#line default
#line hidden
            EndContext();
            BeginContext(3719, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3787, 44, false);
#line 116 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Defendant));

#line default
#line hidden
            EndContext();
            BeginContext(3831, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3899, 40, false);
#line 119 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(3939, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(4007, 42, false);
#line 122 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
            EndContext();
            BeginContext(4049, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(4117, 38, false);
#line 125 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Fee));

#line default
#line hidden
            EndContext();
            BeginContext(4155, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(4223, 40, false);
#line 128 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Idate));

#line default
#line hidden
            EndContext();
            BeginContext(4263, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(4331, 40, false);
#line 131 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Hdate));

#line default
#line hidden
            EndContext();
            BeginContext(4371, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(4438, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeb90a7c44684ae1905379464df30ac2", async() => {
                BeginContext(4488, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 134 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Index.cshtml"
                                           WriteLiteral(item.Case_Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4496, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(4520, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81b08274a827462a90bfc2fcbda044fc", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 135 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Index.cshtml"
                                              WriteLiteral(item.Case_Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4577, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(4599, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f946c2013b30488da6080499e52b8a2f", async() => {
                BeginContext(4651, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 136 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Index.cshtml"
                                             WriteLiteral(item.Case_Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4661, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 139 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Index.cshtml"
                }
                }

#line default
#line hidden
            BeginContext(4743, 72, true);
            WriteLiteral("            </tbody>\r\n                \r\n        </table>\r\n        </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AdvocatePersonalAssistantSystem.Models.CaseProfile>> Html { get; private set; }
    }
}
#pragma warning restore 1591