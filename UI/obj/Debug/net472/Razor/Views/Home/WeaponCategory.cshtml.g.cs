#pragma checksum "D:\School\Fresh Start\Program\40kCampaignFramework\UI\Views\Home\WeaponCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7300c933a329f7a1c3af3d856bd44ea2c45e086f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_WeaponCategory), @"mvc.1.0.view", @"/Views/Home/WeaponCategory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/WeaponCategory.cshtml", typeof(AspNetCore.Views_Home_WeaponCategory))]
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
#line 1 "D:\School\Fresh Start\Program\40kCampaignFramework\UI\Views\_ViewImports.cshtml"
using UI;

#line default
#line hidden
#line 2 "D:\School\Fresh Start\Program\40kCampaignFramework\UI\Views\_ViewImports.cshtml"
using UI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7300c933a329f7a1c3af3d856bd44ea2c45e086f", @"/Views/Home/WeaponCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52d79ad08d11418ded2b13adb4a9b2619d15bb23", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_WeaponCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WeaponCategoryModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateWeaponCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateWeaponCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(28, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\School\Fresh Start\Program\40kCampaignFramework\UI\Views\Home\WeaponCategory.cshtml"
  
    ViewData["Title"] = "WeaponCategory";

#line default
#line hidden
            BeginContext(80, 8, true);
            WriteLiteral("\r\n\r\n<h2>");
            EndContext();
            BeginContext(89, 17, false);
#line 8 "D:\School\Fresh Start\Program\40kCampaignFramework\UI\Views\Home\WeaponCategory.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(106, 43, true);
            WriteLiteral("</h2>\r\n\r\n\r\n\r\n<div class=\"main-container\">\r\n");
            EndContext();
#line 13 "D:\School\Fresh Start\Program\40kCampaignFramework\UI\Views\Home\WeaponCategory.cshtml"
      
        foreach (WeaponCategoryModel weaponCategory in ViewBag.WeaponCategorys)
        {

#line default
#line hidden
            BeginContext(249, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(261, 379, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37ed73f771d64eb287b2c0c77f718093", async() => {
                BeginContext(301, 67, true);
                WriteLiteral("\r\n                <input name=\"weaponCategoryNameOld\" type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 368, "\"", 410, 1);
#line 17 "D:\School\Fresh Start\Program\40kCampaignFramework\UI\Views\Home\WeaponCategory.cshtml"
WriteAttributeValue("", 376, weaponCategory.WeaponCategoryName, 376, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(411, 66, true);
                WriteLiteral(">\r\n                <input name=\"weaponCategoryNameNew\" type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 477, "\"", 519, 1);
#line 18 "D:\School\Fresh Start\Program\40kCampaignFramework\UI\Views\Home\WeaponCategory.cshtml"
WriteAttributeValue("", 485, weaponCategory.WeaponCategoryName, 485, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(520, 113, true);
                WriteLiteral("/>\r\n                <input id=\"Submit\" type=\"submit\" value=\"Update WeaponCategory WeaponCategory\"/>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(640, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 21 "D:\School\Fresh Start\Program\40kCampaignFramework\UI\Views\Home\WeaponCategory.cshtml"
        }
    

#line default
#line hidden
            BeginContext(660, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(664, 181, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2228cff5160c4eee90114f1a15a03113", async() => {
                BeginContext(704, 134, true);
                WriteLiteral("\r\n        <input name=\"weaponCategoryName\" type=\"text\"/>\r\n        <input id=\"Submit\" type=\"submit\" value=\"Add WeaponCategory\" />\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(845, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WeaponCategoryModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
