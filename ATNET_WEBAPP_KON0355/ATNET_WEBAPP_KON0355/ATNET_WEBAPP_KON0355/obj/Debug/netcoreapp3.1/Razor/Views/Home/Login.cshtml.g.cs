#pragma checksum "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00b61b0cc7b44b59ff62a69350faf500a620c7a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
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
#line 2 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\Login.cshtml"
using ATNET_WEBAPP_KON0355.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00b61b0cc7b44b59ff62a69350faf500a620c7a7", @"/Views/Home/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e77e96fe29f907886390bb0f85e2e4e15da7f09e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginForm>
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
#line 3 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!DOCTYPE html>
<style>
    .login-container {
        align-content: center;
        margin-top: 5%;
        margin-bottom: 5%;
        margin-left: 32%;
        margin-right: 32%;
        background: #ffffff
    }

    .login-form {
        padding: 10%;
        box-shadow: 0 5px 8px 0 rgba(0, 0, 0, 0.2), 0 9px 26px 0 rgba(0, 0, 0, 0.19);
    }
        .login-form h3 {
            text-align: center;
            color: #333;
        }

    .login-container form {
        padding: 10%;
    }

    .btnSubmit {
        width: 50%;
        border-radius: 1rem;
        padding: 1.5%;
        border: none;
        cursor: pointer;
    }

    .login-form .btnSubmit {
        font-weight: 600;
        color: #000;
        background-color: #ff6a00;
    }

    .login-form .ForgetPwd {
        color: #0062cc;
        font-weight: 600;
        text-decoration: none;
    }

    body{
        background-image: url('../img/loginBackground2.jpg')
    }
</style>
<html>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00b61b0cc7b44b59ff62a69350faf500a620c7a74565", async() => {
                WriteLiteral(@"
    <link href=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
    <script src=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js""></script>
    <script src=""//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00b61b0cc7b44b59ff62a69350faf500a620c7a75839", async() => {
                WriteLiteral("\r\n    <div class=\"login-container\">\r\n        <div>\r\n            <div class=\"login-form\">\r\n                <h3>Login</h3>\r\n");
#nullable restore
#line 65 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\Login.cshtml"
                 using (Html.BeginForm())
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\Login.cshtml"
               Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 69 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\Login.cshtml"
                   Write(Html.ValidationMessageFor(x => x.Username));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 70 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\Login.cshtml"
                   Write(Html.TextBoxFor(x => x.Username, null, new { @class = "form-control", placeholder = "Your Username *" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 73 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\Login.cshtml"
                   Write(Html.ValidationMessageFor(x => x.Password));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 74 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\Login.cshtml"
                   Write(Html.TextBoxFor(x => x.Password, null, new { @class = "form-control", placeholder = "Your Password *" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <input type=\"submit\" class=\"btnSubmit\" value=\"Login\" />\r\n                    </div>\r\n");
#nullable restore
#line 79 "D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\Views\Home\Login.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginForm> Html { get; private set; }
    }
}
#pragma warning restore 1591
