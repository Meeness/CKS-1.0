#pragma checksum "C:\Users\Lenovo\Desktop\Combat\CKS-1.0\Pages\DeviceSettings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3eda6cd06babc363e0fecdedcb54ed4bb4d3fc8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CKS_1._0.Pages.Pages_DeviceSettings), @"mvc.1.0.razor-page", @"/Pages/DeviceSettings.cshtml")]
namespace CKS_1._0.Pages
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
#line 1 "C:\Users\Lenovo\Desktop\Combat\CKS-1.0\Pages\_ViewImports.cshtml"
using CKS_1._0;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3eda6cd06babc363e0fecdedcb54ed4bb4d3fc8a", @"/Pages/DeviceSettings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2327d1f079c0608b0ef30e19d4a2c2daeed08556", @"/Pages/_ViewImports.cshtml")]
    public class Pages_DeviceSettings : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Lenovo\Desktop\Combat\CKS-1.0\Pages\DeviceSettings.cshtml"
  
    ViewData["Title"] = "Devices Settings";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""main"">
<div class=""text-center"">
    <h1 class=""display-4"" style=""text-align: left;"">DeESvice settings</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>
<div class=""sidenav"">
  <a href=""/Index"">Home</a>
  <a href=""/GameSettings"">Game Settings</a>
  <a href=""/DeviceSettings"">Devices settings</a>
  <a href=""/Sounds"">Sounds</a>
  <a href=""/Statistics"">Statistics</a>
  <a href=""/AppSettings"">Application Settings</a>
  <a href=""/Privacy"">Privacy</a>
</div>
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DeviceSettingsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DeviceSettingsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DeviceSettingsModel>)PageContext?.ViewData;
        public DeviceSettingsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591