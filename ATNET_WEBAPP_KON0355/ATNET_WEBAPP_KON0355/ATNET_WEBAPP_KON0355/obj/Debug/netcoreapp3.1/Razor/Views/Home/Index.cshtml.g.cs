#pragma checksum "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cfd8b21edc0d6d6c576f7d0084171c4e0227392"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 2 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\_ViewImports.cshtml"
using ATNET_WEBAPP_KON0355.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cfd8b21edc0d6d6c576f7d0084171c4e0227392", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e77e96fe29f907886390bb0f85e2e4e15da7f09e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Úvodní stránka";

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

    .main-text {
        align-content: center;
        text-align: left;
        padding: 2% 25% 0% 25%;
    }
    .main-title {
        text-align: center;
        padding: 5% 25% 0% 25%;
    }
</style>
<html lang=""en"">
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1cfd8b21edc0d6d6c576f7d0084171c4e02273924282", async() => {
                WriteLiteral(@"
    <link href=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
    <script src=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js""></script>
    <script src=""//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
    <title>");
#nullable restore
#line 47 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\Index.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1cfd8b21edc0d6d6c576f7d0084171c4e02273925860", async() => {
                WriteLiteral("\r\n    <nav class=\"navbar navbar-expand-lg\">\r\n\r\n        <ul class=\"navbar-nav\">\r\n            <li class=\"nav-item\">\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 1292, "\"", 1326, 1);
#nullable restore
#line 54 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\Index.cshtml"
WriteAttributeValue("", 1299, Url.Action("Index","Home"), 1299, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-link\">Home</a>\r\n            </li>\r\n            <li class=\"nav-item\">\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 1427, "\"", 1461, 1);
#nullable restore
#line 57 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\Index.cshtml"
WriteAttributeValue("", 1434, Url.Action("Login","Home"), 1434, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""nav-link"">Data</a>
            </li>
        </ul>
    </nav>

    <div class=""main-title"">
        <h1 class=""title"">Intro text</h1>
    </div>
    <div class=""main-text"">
        <p>
            Aenean non ornare augue. Phasellus ac orci neque. In sed velit leo. Class aptent 
            taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. 
            Donec tristique tempus felis, sit amet euismod elit venenatis et. Vivamus molestie, ligula a pretium condimentum, purus 
            mi cursus sem, dictum rhoncus elit turpis eu dolor. In hac habitasse platea dictumst. Ut vulputate lacus metus, in accumsan 
            magna viverra id. Nam eget ex justo. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis
            egestas. Mauris leo nibh, sodales sed feugiat eu, iaculis eu magna. Integer id congue justo. Sed maximus tempus 
            sem in tempus. Nulla ac condimentum ante.
        </p>    
    </div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
