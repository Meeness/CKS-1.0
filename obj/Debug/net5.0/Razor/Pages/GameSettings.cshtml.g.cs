#pragma checksum "C:\Users\Lenovo\Desktop\Combat\CKS-1.0\Pages\GameSettings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0dbad19dcb99db271b3dd486f2c57fe5e91ac61b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CKS_1._0.Pages.Pages_GameSettings), @"mvc.1.0.razor-page", @"/Pages/GameSettings.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dbad19dcb99db271b3dd486f2c57fe5e91ac61b", @"/Pages/GameSettings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2327d1f079c0608b0ef30e19d4a2c2daeed08556", @"/Pages/_ViewImports.cshtml")]
    public class Pages_GameSettings : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "volvo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "saab", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "mercedes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Lenovo\Desktop\Combat\CKS-1.0\Pages\GameSettings.cshtml"
  
    ViewData["Title"] = "Game Settings";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""main"">
<div class=""text-center"">
    <h1 class=""display-4"" style=""text-align: left; font-size:30px; margin-left: -30px; padding-top: 20px;"">Games settings</h1>
    
</div>
<div style=""margin-top: 20px; width: 60%; background-color: #0E234E; padding: 5px; border-radius: 15px 15px 0px 0px"">
        <span class=""dot"" style=""height: 20px; width: 20px; background-color: green; border-radius: 50%; display: inline-block;"">
          <p style=""margin-left: 30px; margin-top:-3px; color:white;"">GAMERS</p></span> 
        </div> 
        <div style=""position: absolute;left: 60%;top: 14%;/* font-size: 14px;""><h2 style=""font-size: 22px;"">Game script</h2>
        <select id=""gamemode"" name=""gamemodes"" style=""background-color:#0E234E; border-radius: 10px; color: white; padding: 0px 6px 2px 20px; text-align: left;"">
  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0dbad19dcb99db271b3dd486f2c57fe5e91ac61b4800", async() => {
                WriteLiteral("Best of the best");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0dbad19dcb99db271b3dd486f2c57fe5e91ac61b5971", async() => {
                WriteLiteral("One on one");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0dbad19dcb99db271b3dd486f2c57fe5e91ac61b7136", async() => {
                WriteLiteral("TDM");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</select>
        </div>
        <div style=""position: absolute;left: 60%;top: 40%;/* font-size: 14px;""><h2 style=""font-size: 22px;"">Game cost</h2>  <input type=""text"" id=""costs"" value=""0"" style=""border-bottom: 2px; border-bottom: solid;border-top: none;border-left: none;border-right: none;border-color: #CC0000;""></div>
 <div style=""width:60%;height:400px; background-color:#0E234E; margin-top: 3px""></div>
 <div style=""position: absolute;left: 60%;top: 56%;/* font-size: 14px;""><h2 style=""font-size: 22px;"">Glow between games</h2> <label class=""switch""><input type=""checkbox""><span class=""slider round""></span></label></div>
<div style=""margin-top: 3px; width: 60%; background-color: #0E234E; padding: 5px; border-radius: 0px 0px 15px 15px; height: 35px""></div>
<div><button id=""start"" onclick=""countDown()"">START GAME</button><div id=""status"">10:00</div></div>
<div class=""sidenav"">
  <a href=""/Index"">Home</a>
  <a href=""/GameSettings"">Game Settings</a>
  <a href=""/DeviceSettings"">Devices settings</a>
  <");
            WriteLiteral(@"a href=""/Sounds"">Sounds</a>
  <a href=""/Statistics"">Statistics</a>
  <a href=""/AppSettings"">Application Settings</a>
  <a href=""/Privacy"">Privacy</a>
</div>
<style>

  #start{
    left: 66%;
    position: absolute;
    font-size: 50px;
    border-radius: 42px;
    padding-left: 27px;
    padding-right: 30px;
    padding-bottom: 7px;
    color: white;
    border: none;
    background-color: #CC0000;
    TOP: 110%
  }

  #status{
        position: absolute;
    left: 69%;
    top: 77%;
    font-size: 100px;
    color: #CC0000;
  }

  .slider {
  position: absolute;
  cursor: pointer;
  top: 0;
  left: 0;
  right: 0;
  bottom: 0;
  background-color: #ccc;
  -webkit-transition: .4s;
  transition: .4s;
}

.slider:before {
  position: absolute;
  content: """";
  height: 26px;
  width: 26px;
  left: 4px;
  bottom: 4px;
  background-color: white;
  -webkit-transition: .4s;
  transition: .4s;
}

input:checked + .slider {
  background-color: #CC0000;
}

input:focu");
            WriteLiteral(@"s + .slider {
  box-shadow: 0 0 1px #CC0000;
}

input:checked + .slider:before {
  -webkit-transform: translateX(26px);
  -ms-transform: translateX(26px);
  transform: translateX(26px);
}

/* Rounded sliders */
.slider.round {
  border-radius: 34px;
  width: 28%;
    height: 50%;
    top: 55%;
    left: -4%;
}

.slider.round:before {
  border-radius: 50%;
}
</style>
<script>
  function countDown() {
    var secs = 600;
    var mins;
    var element = document.getElementById('status');
    
    setInterval(function(){
      mins = secs / 60;
      element.innerHTML = mins.toFixed(2);
      if(secs < 1) {
          element.innerHTML = '<h2>You have no time left!</h2>';
      }  
      secs--;
    }, 1000)  

}
</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GameSettingsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GameSettingsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GameSettingsModel>)PageContext?.ViewData;
        public GameSettingsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591