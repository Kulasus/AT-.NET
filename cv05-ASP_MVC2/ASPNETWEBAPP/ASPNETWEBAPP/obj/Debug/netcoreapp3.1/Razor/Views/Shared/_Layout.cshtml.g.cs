#pragma checksum "D:\Coding\AT-.NET-GIT\cv05-ASP_MVC2\ASPNETWEBAPP\ASPNETWEBAPP\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80f7fa31d982e947bdc35a7526b47443a4371b5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "D:\Coding\AT-.NET-GIT\cv05-ASP_MVC2\ASPNETWEBAPP\ASPNETWEBAPP\Views\_ViewImports.cshtml"
using ASPNETWEBAPP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Coding\AT-.NET-GIT\cv05-ASP_MVC2\ASPNETWEBAPP\ASPNETWEBAPP\Views\_ViewImports.cshtml"
using ASPNETWEBAPP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80f7fa31d982e947bdc35a7526b47443a4371b5a", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db7b9991000507742cafefa78898aa23472c8c65", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80f7fa31d982e947bdc35a7526b47443a4371b5a3294", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
#nullable restore
#line 6 "D:\Coding\AT-.NET-GIT\cv05-ASP_MVC2\ASPNETWEBAPP\ASPNETWEBAPP\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80f7fa31d982e947bdc35a7526b47443a4371b5a4639", async() => {
                WriteLiteral("\r\n    <h1>Můj eshop</h1>\r\n    <ul>\r\n        <li><a");
                BeginWriteAttribute("href", " href=\"", 255, "\"", 289, 1);
#nullable restore
#line 11 "D:\Coding\AT-.NET-GIT\cv05-ASP_MVC2\ASPNETWEBAPP\ASPNETWEBAPP\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 262, Url.Action("Index","Home"), 262, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Úvodní stránka</a></li>\r\n        <li><a");
                BeginWriteAttribute("href", " href=\"", 330, "\"", 370, 1);
#nullable restore
#line 12 "D:\Coding\AT-.NET-GIT\cv05-ASP_MVC2\ASPNETWEBAPP\ASPNETWEBAPP\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 337, Url.Action("ProductList","Home"), 337, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Seznam produktů</a></li>\r\n    </ul>\r\n\r\n    <div>\r\n        <ul>\r\n");
#nullable restore
#line 17 "D:\Coding\AT-.NET-GIT\cv05-ASP_MVC2\ASPNETWEBAPP\ASPNETWEBAPP\Views\Shared\_Layout.cshtml"
         foreach(var item in ViewBag.Basket){

#line default
#line hidden
#nullable disable
                WriteLiteral("            <li>");
#nullable restore
#line 18 "D:\Coding\AT-.NET-GIT\cv05-ASP_MVC2\ASPNETWEBAPP\ASPNETWEBAPP\Views\Shared\_Layout.cshtml"
           Write(item);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 19 "D:\Coding\AT-.NET-GIT\cv05-ASP_MVC2\ASPNETWEBAPP\ASPNETWEBAPP\Views\Shared\_Layout.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </ul>\r\n    </div>\r\n\r\n    <div>\r\n        ");
#nullable restore
#line 24 "D:\Coding\AT-.NET-GIT\cv05-ASP_MVC2\ASPNETWEBAPP\ASPNETWEBAPP\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n\r\n");
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
