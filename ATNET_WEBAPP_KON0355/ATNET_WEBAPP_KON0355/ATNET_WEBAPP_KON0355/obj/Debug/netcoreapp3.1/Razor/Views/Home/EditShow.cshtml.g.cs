#pragma checksum "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\EditShow.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c66f537eb77b95dadf01667912535d1fe062430b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EditShow), @"mvc.1.0.view", @"/Views/Home/EditShow.cshtml")]
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
#line 1 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\_ViewImports.cshtml"
using ATNET_WEBAPP_KON0355;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\EditShow.cshtml"
using ATNET_WEBAPP_KON0355.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c66f537eb77b95dadf01667912535d1fe062430b", @"/Views/Home/EditShow.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e77e96fe29f907886390bb0f85e2e4e15da7f09e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_EditShow : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShowForm>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\EditShow.cshtml"
  
    ViewData["Title"] = "Úvodní stránka";
    Show editedShow = ViewBag.editedShow as Show;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!DOCTYPE html>
<style>
    .nav-item::after {
        content: '';
        display: block;
        width: 0px;
        height: 4px;
        background: #ff0000;
        transition: 0.2s;
        margin-top: -10px;
    }

    .nav-item:hover::after {
        width: 100%;
    }


    .nav-link {
        padding: 15px 5px;
        transition: 0.2s;
    }

    .navbar-nav .nav-link {
        color: #000;
        font-weight: bold;
        font-size: 18px;
    }

    .table {
        align-content: center;
        text-align: center;
        padding: 5% 25% 0% 25%;
    }
</style>
<html lang=""en"">
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c66f537eb77b95dadf01667912535d1fe062430b4263", async() => {
                WriteLiteral(@"
    <link href=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
    <script src=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js""></script>
    <script src=""//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
    <title>");
#nullable restore
#line 46 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\EditShow.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ATNET_WEBAPP_KON0355</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c66f537eb77b95dadf01667912535d1fe062430b5844", async() => {
                WriteLiteral("\r\n    <nav class=\"navbar navbar-expand-lg\">\r\n\r\n        <ul class=\"navbar-nav\">\r\n            <li class=\"nav-item\">\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 1306, "\"", 1340, 1);
#nullable restore
#line 53 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\EditShow.cshtml"
WriteAttributeValue("", 1313, Url.Action("Index","Home"), 1313, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-link\">");
#nullable restore
#line 53 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\EditShow.cshtml"
                                                                  Write(GlobalizationResources.Resources.Home);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n            </li>\r\n            <li class=\"nav-item\">\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 1475, "\"", 1509, 1);
#nullable restore
#line 56 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\EditShow.cshtml"
WriteAttributeValue("", 1482, Url.Action("Login","Home"), 1482, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-link\">");
#nullable restore
#line 56 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\EditShow.cshtml"
                                                                  Write(GlobalizationResources.Resources.Data);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n            </li>\r\n        </ul>\r\n    </nav>\r\n\r\n    <div class=\"table\">\r\n");
#nullable restore
#line 62 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\EditShow.cshtml"
         using (Html.BeginForm())
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <table>\r\n                <caption>");
#nullable restore
#line 65 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\EditShow.cshtml"
                    Write(GlobalizationResources.Resources.EditMessage);

#line default
#line hidden
#nullable disable
                WriteLiteral("</caption>\r\n                <tr>\r\n                    <th>Id</th>\r\n                    <th>");
#nullable restore
#line 68 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\EditShow.cshtml"
                   Write(GlobalizationResources.Resources.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 69 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\EditShow.cshtml"
                   Write(GlobalizationResources.Resources.Series);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 70 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\EditShow.cshtml"
                   Write(GlobalizationResources.Resources.Episodes);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 71 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\EditShow.cshtml"
                   Write(GlobalizationResources.Resources.FavChar);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 72 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\EditShow.cshtml"
                   Write(GlobalizationResources.Resources.Edit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 73 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\EditShow.cshtml"
                   Write(GlobalizationResources.Resources.Delete);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                </tr>\r\n");
#nullable restore
#line 75 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\EditShow.cshtml"
                 foreach (Show s in Show.showsList)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n\r\n");
#nullable restore
#line 79 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\EditShow.cshtml"
                         if (s.ID == editedShow.ID)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <td>");
#nullable restore
#line 81 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\EditShow.cshtml"
                           Write(Html.TextBoxFor(s => s.ID, null, new { @class = "form-control", @Value = editedShow.ID, placeholder = editedShow.ID, type = "number" , @readonly="readonly"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 82 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\EditShow.cshtml"
                           Write(Html.TextBoxFor(s => s.Name, null, new { @class = "form-control", placeholder = editedShow.Name }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 83 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\EditShow.cshtml"
                           Write(Html.TextBoxFor(s => s.Series, null, new { @class = "form-control", placeholder = editedShow.Series, type = "number" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 84 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\EditShow.cshtml"
                           Write(Html.TextBoxFor(s => s.Episodes, null, new { @class = "form-control", placeholder = editedShow.Episodes, type = "number" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 85 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\EditShow.cshtml"
                           Write(Html.TextBoxFor(s => s.Character, null, new { @class = "form-control", placeholder = editedShow.Character }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td><input type=\"submit\"");
                BeginWriteAttribute("value", " value=\"", 3334, "\"", 3382, 1);
#nullable restore
#line 86 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\EditShow.cshtml"
WriteAttributeValue("", 3342, GlobalizationResources.Resources.Update, 3342, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n");
#nullable restore
#line 87 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\EditShow.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <td>");
#nullable restore
#line 90 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\EditShow.cshtml"
                           Write(s.ID);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 91 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\EditShow.cshtml"
                           Write(s.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 92 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\EditShow.cshtml"
                           Write(s.Series);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 93 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\EditShow.cshtml"
                           Write(s.Episodes);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 94 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\EditShow.cshtml"
                           Write(s.Character);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td><a");
                BeginWriteAttribute("href", " href=\"", 3750, "\"", 3788, 1);
#nullable restore
#line 95 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\EditShow.cshtml"
WriteAttributeValue("", 3757, Url.Action("EditShow", "Home"), 3757, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 95 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\EditShow.cshtml"
                                                                     Write(GlobalizationResources.Resources.Edit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\r\n");
#nullable restore
#line 96 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\EditShow.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <td><a");
                BeginWriteAttribute("href", " href=\"", 3896, "\"", 3955, 1);
#nullable restore
#line 97 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\EditShow.cshtml"
WriteAttributeValue("", 3903, Url.Action("DeleteShow", "Home", new { id = s.ID }), 3903, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 97 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\EditShow.cshtml"
                                                                                      Write(GlobalizationResources.Resources.Delete);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                        <td>\r\n                    </tr>\r\n");
#nullable restore
#line 100 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\EditShow.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </table>\r\n");
#nullable restore
#line 102 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\EditShow.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShowForm> Html { get; private set; }
    }
}
#pragma warning restore 1591
