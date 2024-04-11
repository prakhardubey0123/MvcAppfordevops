#pragma checksum "C:\Users\namanbhatia01\source\repos\BookReadingWebApp\BookReadingWebApp\Views\Event\GetEvents.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c81dc75bb3eeda133d0def66c44cad9b976abae50d01197c9cd500d76383224d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_GetEvents), @"mvc.1.0.view", @"/Views/Event/GetEvents.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\namanbhatia01\source\repos\BookReadingWebApp\BookReadingWebApp\Views\_ViewImports.cshtml"
using BookReadingWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\namanbhatia01\source\repos\BookReadingWebApp\BookReadingWebApp\Views\_ViewImports.cshtml"
using BookReadingApp.Core.Modals;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\namanbhatia01\source\repos\BookReadingWebApp\BookReadingWebApp\Views\Event\GetEvents.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c81dc75bb3eeda133d0def66c44cad9b976abae50d01197c9cd500d76383224d", @"/Views/Event/GetEvents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"62e45e6f9a85b6cad62e33fadbf7adb9fe6db2207f3cc442ecec776e1ed045a6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Event_GetEvents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<BookReadingApp.Core.Modals.Event>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_EventFirst", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\namanbhatia01\source\repos\BookReadingWebApp\BookReadingWebApp\Views\Event\GetEvents.cshtml"
  
    var user = await _userManager.GetUserAsync(User);
    var email = "";
    if (user != null)
    {
        email = user.Email;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 15 "C:\Users\namanbhatia01\source\repos\BookReadingWebApp\BookReadingWebApp\Views\Event\GetEvents.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n");
#nullable restore
#line 20 "C:\Users\namanbhatia01\source\repos\BookReadingWebApp\BookReadingWebApp\Views\Event\GetEvents.cshtml"
     if (Model.Count == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <h4 class=\"text-info\">No Events To Display</h4>\r\n        </div>\r\n");
#nullable restore
#line 25 "C:\Users\namanbhatia01\source\repos\BookReadingWebApp\BookReadingWebApp\Views\Event\GetEvents.cshtml"
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\namanbhatia01\source\repos\BookReadingWebApp\BookReadingWebApp\Views\Event\GetEvents.cshtml"
         if (email == "myadmin@bookevents.com")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2 class=\"text-primary\"> All Events</h2>\r\n            <hr class=\"border-dark\" />\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 33 "C:\Users\namanbhatia01\source\repos\BookReadingWebApp\BookReadingWebApp\Views\Event\GetEvents.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c81dc75bb3eeda133d0def66c44cad9b976abae50d01197c9cd500d76383224d5806", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 35 "C:\Users\namanbhatia01\source\repos\BookReadingWebApp\BookReadingWebApp\Views\Event\GetEvents.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 36 "C:\Users\namanbhatia01\source\repos\BookReadingWebApp\BookReadingWebApp\Views\Event\GetEvents.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 38 "C:\Users\namanbhatia01\source\repos\BookReadingWebApp\BookReadingWebApp\Views\Event\GetEvents.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2 class=\"text-primary\">All Public Events</h2>\r\n            <hr class=\"border-dark\" />\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 44 "C:\Users\namanbhatia01\source\repos\BookReadingWebApp\BookReadingWebApp\Views\Event\GetEvents.cshtml"
                 foreach (var item in Model)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\namanbhatia01\source\repos\BookReadingWebApp\BookReadingWebApp\Views\Event\GetEvents.cshtml"
                     if (item.EventType == "Public")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c81dc75bb3eeda133d0def66c44cad9b976abae50d01197c9cd500d76383224d8647", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 48 "C:\Users\namanbhatia01\source\repos\BookReadingWebApp\BookReadingWebApp\Views\Event\GetEvents.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 49 "C:\Users\namanbhatia01\source\repos\BookReadingWebApp\BookReadingWebApp\Views\Event\GetEvents.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\namanbhatia01\source\repos\BookReadingWebApp\BookReadingWebApp\Views\Event\GetEvents.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 52 "C:\Users\namanbhatia01\source\repos\BookReadingWebApp\BookReadingWebApp\Views\Event\GetEvents.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\namanbhatia01\source\repos\BookReadingWebApp\BookReadingWebApp\Views\Event\GetEvents.cshtml"
         if (_signInManager.IsSignedIn(User))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\namanbhatia01\source\repos\BookReadingWebApp\BookReadingWebApp\Views\Event\GetEvents.cshtml"
             if (email != "myadmin@bookevents.com")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""container"">
                    <div class=""container"">
                        <h4> You are Invited in the Events Below :</h4>
                        <hr />
                        <h3 class=""text-success""> Upcoming Events</h3>
                        <hr class=""border-dark"" />

                        <div class=""row"">
");
#nullable restore
#line 66 "C:\Users\namanbhatia01\source\repos\BookReadingWebApp\BookReadingWebApp\Views\Event\GetEvents.cshtml"
                             foreach (var item in Model)
                            {
                                //if (item.Invitees == null)
                                //{

                                //}
                                if (!string.IsNullOrEmpty(item.Invitees) && item.Invitees.Split(',').Contains(email) && item.EventType == "Private" && item.Date > DateTime.Now)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c81dc75bb3eeda133d0def66c44cad9b976abae50d01197c9cd500d76383224d12528", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 74 "C:\Users\namanbhatia01\source\repos\BookReadingWebApp\BookReadingWebApp\Views\Event\GetEvents.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 75 "C:\Users\namanbhatia01\source\repos\BookReadingWebApp\BookReadingWebApp\Views\Event\GetEvents.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""container"">
                        <h3 class=""text-success""> Past Events </h3>
                        <hr class=""border-dark"" />

                        <div class=""row"">
");
#nullable restore
#line 85 "C:\Users\namanbhatia01\source\repos\BookReadingWebApp\BookReadingWebApp\Views\Event\GetEvents.cshtml"
                             foreach (var item in Model)
                            {
                                if (!string.IsNullOrEmpty(item.Invitees) && item.Invitees.Split(',').Contains(email) && item.EventType == "Private" && item.Date < DateTime.Now)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c81dc75bb3eeda133d0def66c44cad9b976abae50d01197c9cd500d76383224d15252", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 89 "C:\Users\namanbhatia01\source\repos\BookReadingWebApp\BookReadingWebApp\Views\Event\GetEvents.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 90 "C:\Users\namanbhatia01\source\repos\BookReadingWebApp\BookReadingWebApp\Views\Event\GetEvents.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 96 "C:\Users\namanbhatia01\source\repos\BookReadingWebApp\BookReadingWebApp\Views\Event\GetEvents.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "C:\Users\namanbhatia01\source\repos\BookReadingWebApp\BookReadingWebApp\Views\Event\GetEvents.cshtml"
             

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "C:\Users\namanbhatia01\source\repos\BookReadingWebApp\BookReadingWebApp\Views\Event\GetEvents.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> _userManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> _signInManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<BookReadingApp.Core.Modals.Event>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591