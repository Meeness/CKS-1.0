#pragma checksum "C:\Users\LarsV\Documents\GitHub\CKS-1.0\Pages\scoreboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "963230e5ea744d0ea90ec7d19219eb5fd3225fdd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CKS_1._0.Pages.Pages_scoreboard), @"mvc.1.0.razor-page", @"/Pages/scoreboard.cshtml")]
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
#line 1 "C:\Users\LarsV\Documents\GitHub\CKS-1.0\Pages\_ViewImports.cshtml"
using CKS_1._0;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"963230e5ea744d0ea90ec7d19219eb5fd3225fdd", @"/Pages/scoreboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2327d1f079c0608b0ef30e19d4a2c2daeed08556", @"/Pages/_ViewImports.cshtml")]
    public class Pages_scoreboard : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("testmode"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/scoreboard.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/timer.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\LarsV\Documents\GitHub\CKS-1.0\Pages\scoreboard.cshtml"
  
    ViewData["Title"] = "ScoreBoard";

#line default
#line hidden
#nullable disable
            WriteLiteral("<section class=\"main\">\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "963230e5ea744d0ea90ec7d19219eb5fd3225fdd5495", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "963230e5ea744d0ea90ec7d19219eb5fd3225fdd6972", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n  <div class=\"grid-container\">\r\n    <div class=\"Page-name\">\r\n      <p id=\"header\">Score Board</p>\r\n    </div>\r\n\r\n    <div class=\"Timer\">\r\n      <div class=\"container\">\r\n        <!-- form -->\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "963230e5ea744d0ea90ec7d19219eb5fd3225fdd8312", async() => {
                WriteLiteral("\r\n          <!-- countdown time input field -->\r\n");
#nullable restore
#line 19 "C:\Users\LarsV\Documents\GitHub\CKS-1.0\Pages\scoreboard.cshtml"
           if(Model.CK.ActiveGame.State==GameState.Running){

#line default
#line hidden
#nullable disable
                WriteLiteral("            <input id=\"timeremaining\" class=\"timeremaining\" name=\"timeremaining\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 641, "\"", 693, 1);
#nullable restore
#line 20 "C:\Users\LarsV\Documents\GitHub\CKS-1.0\Pages\scoreboard.cshtml"
WriteAttributeValue("", 649, Model.CK.ActiveGame.GetRemainingGameTicks(), 649, 44, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n");
#nullable restore
#line 21 "C:\Users\LarsV\Documents\GitHub\CKS-1.0\Pages\scoreboard.cshtml"
          }else if(Model.CK.ActiveGame.State==GameState.Over){

#line default
#line hidden
#nullable disable
                WriteLiteral("            <input id=\"timeremaining\" class=\"stoppedtimeremaining\" name=\"timeremaining\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 863, "\"", 909, 1);
#nullable restore
#line 22 "C:\Users\LarsV\Documents\GitHub\CKS-1.0\Pages\scoreboard.cshtml"
WriteAttributeValue("", 871, Model.CK.ActiveGame.RemainingGameTime, 871, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n");
#nullable restore
#line 23 "C:\Users\LarsV\Documents\GitHub\CKS-1.0\Pages\scoreboard.cshtml"
          }

#line default
#line hidden
#nullable disable
                WriteLiteral("          <div class=\"timewrap\">\r\n            <label for=\"durationwrapper\" class=\"minlabel\">Duration:</label>\r\n            <div id=\"durationwrapper\" class=\"minwrapper\">\r\n");
#nullable restore
#line 27 "C:\Users\LarsV\Documents\GitHub\CKS-1.0\Pages\scoreboard.cshtml"
               if(Model.CK.ActiveGame.State==GameState.Running||Model.CK.ActiveGame.State==GameState.Over){

#line default
#line hidden
#nullable disable
                WriteLiteral("                <input name=\"gameduration\" type=\"number\" min=\"1\"");
                BeginWriteAttribute("value", " value=\"", 1270, "\"", 1311, 1);
#nullable restore
#line 28 "C:\Users\LarsV\Documents\GitHub\CKS-1.0\Pages\scoreboard.cshtml"
WriteAttributeValue("", 1278, Model.CK.ActiveGame.GameDuration, 1278, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"time-input\" placeholder=\"Enter Game duration\" onfocusout=\"this.form.submit()\" disabled>\r\n");
#nullable restore
#line 29 "C:\Users\LarsV\Documents\GitHub\CKS-1.0\Pages\scoreboard.cshtml"
              }else{

#line default
#line hidden
#nullable disable
                WriteLiteral("                <input name=\"gameduration\" type=\"number\" min=\"1\"");
                BeginWriteAttribute("value", " value=\"", 1495, "\"", 1536, 1);
#nullable restore
#line 30 "C:\Users\LarsV\Documents\GitHub\CKS-1.0\Pages\scoreboard.cshtml"
WriteAttributeValue("", 1503, Model.CK.ActiveGame.GameDuration, 1503, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"time-input\" placeholder=\"Enter Game duration\" onfocusout=\"this.form.submit()\">\r\n");
#nullable restore
#line 31 "C:\Users\LarsV\Documents\GitHub\CKS-1.0\Pages\scoreboard.cshtml"
              }

#line default
#line hidden
#nullable disable
                WriteLiteral("              <b class=\"minutes\">Min</b>\r\n            </div>\r\n          </div>\r\n          <div class=\"timewrap\">\r\n            <label for=\"delaywrapper\" class=\"minlabel\">Delay:</label>\r\n            <div id=\"delaywrapper\" class=\"minwrapper\"> \r\n");
#nullable restore
#line 38 "C:\Users\LarsV\Documents\GitHub\CKS-1.0\Pages\scoreboard.cshtml"
               if(Model.CK.ActiveGame.State==GameState.Running||Model.CK.ActiveGame.State==GameState.Over){

#line default
#line hidden
#nullable disable
                WriteLiteral("                <input name=\"gamedelay\" type=\"number\" min=\"1\"");
                BeginWriteAttribute("value", " value=\"", 2054, "\"", 2092, 1);
#nullable restore
#line 39 "C:\Users\LarsV\Documents\GitHub\CKS-1.0\Pages\scoreboard.cshtml"
WriteAttributeValue("", 2062, Model.CK.ActiveGame.GameDelay, 2062, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"time-input\" placeholder=\"Enter Game delay\" onfocusout=\"this.form.submit()\" disabled>\r\n");
#nullable restore
#line 40 "C:\Users\LarsV\Documents\GitHub\CKS-1.0\Pages\scoreboard.cshtml"
              }else{

#line default
#line hidden
#nullable disable
                WriteLiteral("                <input name=\"gamedelay\" type=\"number\" min=\"1\"");
                BeginWriteAttribute("value", " value=\"", 2270, "\"", 2308, 1);
#nullable restore
#line 41 "C:\Users\LarsV\Documents\GitHub\CKS-1.0\Pages\scoreboard.cshtml"
WriteAttributeValue("", 2278, Model.CK.ActiveGame.GameDelay, 2278, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"time-input\" placeholder=\"Enter Game delay\" onfocusout=\"this.form.submit()\">\r\n");
#nullable restore
#line 42 "C:\Users\LarsV\Documents\GitHub\CKS-1.0\Pages\scoreboard.cshtml"
              }

#line default
#line hidden
#nullable disable
                WriteLiteral("              <b class=\"minutes\">Sec</b>\r\n            </div>\r\n          </div>\r\n          <!-- countdown text -->\r\n          <p class=\"countdown\">00 : 00 : 00</p>\r\n          <!-- buttons -->\r\n          <div class=\"buttons\">\r\n");
#nullable restore
#line 50 "C:\Users\LarsV\Documents\GitHub\CKS-1.0\Pages\scoreboard.cshtml"
             if(Model.CK.ActiveGame.State==GameState.Over){

#line default
#line hidden
#nullable disable
                WriteLiteral("              <button id=\"readybtn\" name=\"gameready\" class=\"startstop\" type=\"submit\" >New Game</button>\r\n");
#nullable restore
#line 52 "C:\Users\LarsV\Documents\GitHub\CKS-1.0\Pages\scoreboard.cshtml"
            }else if(Model.CK.ActiveGame.State==GameState.Ready){

#line default
#line hidden
#nullable disable
                WriteLiteral("              <button id=\"startbtn\" name=\"gamestart\" class=\"startstop\" type=\"submit\" >Start</button>\r\n");
#nullable restore
#line 54 "C:\Users\LarsV\Documents\GitHub\CKS-1.0\Pages\scoreboard.cshtml"
            }else{

#line default
#line hidden
#nullable disable
                WriteLiteral("              <button id=\"stopbtn\" name=\"gamestop\" class=\"startstop\" type=\"submit\" >Stop</button>\r\n");
#nullable restore
#line 56 "C:\Users\LarsV\Documents\GitHub\CKS-1.0\Pages\scoreboard.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("          </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n      </div>\r\n    </div>\r\n  </div>\r\n  <div class=\"grid-container2\">\r\n");
#nullable restore
#line 63 "C:\Users\LarsV\Documents\GitHub\CKS-1.0\Pages\scoreboard.cshtml"
     foreach(var team in Model.CK.ActiveGame.Gamemode.Teams){
      

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\LarsV\Documents\GitHub\CKS-1.0\Pages\scoreboard.cshtml"
       foreach (var player in team.Players)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <div>\r\n        ");
#nullable restore
#line 67 "C:\Users\LarsV\Documents\GitHub\CKS-1.0\Pages\scoreboard.cshtml"
   Write(System.Text.Encoding.UTF8.GetString(player.Client.CKInv.Items[0].Value));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br><div class=\"quickfix\">");
#nullable restore
#line 68 "C:\Users\LarsV\Documents\GitHub\CKS-1.0\Pages\scoreboard.cshtml"
                             Write(team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"stats\">\r\n          \r\n          <br>Hits:&nbsp;");
#nullable restore
#line 71 "C:\Users\LarsV\Documents\GitHub\CKS-1.0\Pages\scoreboard.cshtml"
                    Write(player.Performance.Stats[1].GetValue());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n          <br>Accuracy:&nbsp;");
#nullable restore
#line 72 "C:\Users\LarsV\Documents\GitHub\CKS-1.0\Pages\scoreboard.cshtml"
                        Write(player.Performance.Stats[2].GetValue());

#line default
#line hidden
#nullable disable
            WriteLiteral("%\r\n          <br>Shields Used:&nbsp;");
#nullable restore
#line 73 "C:\Users\LarsV\Documents\GitHub\CKS-1.0\Pages\scoreboard.cshtml"
                            Write(player.Performance.Stats[3].GetValue());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n          <br>Hitpoints:&nbsp;");
#nullable restore
#line 74 "C:\Users\LarsV\Documents\GitHub\CKS-1.0\Pages\scoreboard.cshtml"
                         Write(player.Performance.Stats[4].GetValue());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n          <br>Cartridges:&nbsp;");
#nullable restore
#line 75 "C:\Users\LarsV\Documents\GitHub\CKS-1.0\Pages\scoreboard.cshtml"
                          Write(player.Performance.Stats[5].GetValue());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n          <br>Clips:&nbsp;");
#nullable restore
#line 76 "C:\Users\LarsV\Documents\GitHub\CKS-1.0\Pages\scoreboard.cshtml"
                     Write(player.Performance.Stats[6].GetValue());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n      </div>\r\n");
#nullable restore
#line 79 "C:\Users\LarsV\Documents\GitHub\CKS-1.0\Pages\scoreboard.cshtml"
      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\LarsV\Documents\GitHub\CKS-1.0\Pages\scoreboard.cshtml"
       
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </div>  \r\n  <div class=\"grid-container3\">\r\n    <div>\r\n");
#nullable restore
#line 84 "C:\Users\LarsV\Documents\GitHub\CKS-1.0\Pages\scoreboard.cshtml"
       foreach (var discipline in Model.CK.ActiveGame.Gamemode.Mastery.Disciplines)
      {
        if(discipline.GetChampion()!=null){
          

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\LarsV\Documents\GitHub\CKS-1.0\Pages\scoreboard.cshtml"
     Write(discipline.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>:&nbsp;</span>");
#nullable restore
#line 87 "C:\Users\LarsV\Documents\GitHub\CKS-1.0\Pages\scoreboard.cshtml"
                                         Write(System.Text.Encoding.UTF8.GetString(discipline.GetChampion().Client.CKInv.Items[0].Value));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n");
#nullable restore
#line 88 "C:\Users\LarsV\Documents\GitHub\CKS-1.0\Pages\scoreboard.cshtml"
        }
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n  </div>\r\n</section>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "963230e5ea744d0ea90ec7d19219eb5fd3225fdd21403", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#nullable restore
#line 93 "C:\Users\LarsV\Documents\GitHub\CKS-1.0\Pages\scoreboard.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ScoreboardModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ScoreboardModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ScoreboardModel>)PageContext?.ViewData;
        public ScoreboardModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
