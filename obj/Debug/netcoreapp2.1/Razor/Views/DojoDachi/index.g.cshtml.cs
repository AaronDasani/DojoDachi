#pragma checksum "/Users/maad/Desktop/C#_Folder/Web_Section/DojoDachi/Views/DojoDachi/index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d72eabb17a9574cb300d07e064cba4bc4a09b9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DojoDachi_index), @"mvc.1.0.view", @"/Views/DojoDachi/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DojoDachi/index.cshtml", typeof(AspNetCore.Views_DojoDachi_index))]
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
#line 1 "/Users/maad/Desktop/C#_Folder/Web_Section/DojoDachi/Views/_ViewImports.cshtml"
using DojoDachi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d72eabb17a9574cb300d07e064cba4bc4a09b9a", @"/Views/DojoDachi/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a1fe46c8d71e818376cc691d8f6c5819ca8bad1", @"/Views/_ViewImports.cshtml")]
    public class Views_DojoDachi_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pet>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/stylesheet.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(11, 33, true);
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            EndContext();
            BeginContext(44, 674, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b733546a4ca4bdbaba7fd23e3513668", async() => {
                BeginContext(50, 580, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"" integrity=""sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.5.0/css/all.css"" integrity=""sha384-B4dIYHKNBt8Bc12p+WXckhzcICo0wtJAoU8YZTY5qE0Id1GSseTk6S+L3BlXeVIU"" crossorigin=""anonymous"">
    ");
                EndContext();
                BeginContext(630, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0398eacd46e04beb936f715e21ad3b01", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(681, 30, true);
                WriteLiteral("\n    <title>DojoDachi</title>\n");
                EndContext();
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
            EndContext();
            BeginContext(718, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(719, 6590, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "898cd78b617a44149bfc2123d2c2aa75", async() => {
                BeginContext(725, 366, true);
                WriteLiteral(@"
    
    <div class=""container mt-5"">
        <h4 class=""mt-5 text-center"">Your DojoDachi <i class=""fas fa-paw""></i></h4>
        <hr>
        <div class=""row mt-5"">
            <div class=""col-4 mr-3 bg-light rounded-right border border-warning"">
                <div class=""mt-3"">
                    <h6>Energy:  <i class=""fas fa-bolt""></i> <span class=""energy"">");
                EndContext();
                BeginContext(1092, 12, false);
#line 21 "/Users/maad/Desktop/C#_Folder/Web_Section/DojoDachi/Views/DojoDachi/index.cshtml"
                                                                             Write(Model.energy);

#line default
#line hidden
                EndContext();
                BeginContext(1104, 108, true);
                WriteLiteral("</span></h6>\n\n                    <h6>Fullness: <i class=\"fas fa-battery-half\"></i><span class=\"fullness\">  ");
                EndContext();
                BeginContext(1213, 14, false);
#line 23 "/Users/maad/Desktop/C#_Folder/Web_Section/DojoDachi/Views/DojoDachi/index.cshtml"
                                                                                         Write(Model.fullness);

#line default
#line hidden
                EndContext();
                BeginContext(1227, 106, true);
                WriteLiteral("</span></h6>\n                    <h6>Happiness: <span class=\"happiness\"><i class=\"far fa-meh-blank\"></i>  ");
                EndContext();
                BeginContext(1334, 15, false);
#line 24 "/Users/maad/Desktop/C#_Folder/Web_Section/DojoDachi/Views/DojoDachi/index.cshtml"
                                                                                        Write(Model.happiness);

#line default
#line hidden
                EndContext();
                BeginContext(1349, 96, true);
                WriteLiteral("</span></h6>\n\n                    <h6>Meal: <i class=\"fas fa-utensils\"></i> <span class=\"meal\"> ");
                EndContext();
                BeginContext(1446, 11, false);
#line 26 "/Users/maad/Desktop/C#_Folder/Web_Section/DojoDachi/Views/DojoDachi/index.cshtml"
                                                                             Write(Model.meals);

#line default
#line hidden
                EndContext();
                BeginContext(1457, 5845, true);
                WriteLiteral(@"</span></h6>
                </div>
                <hr>
                
                <div class=""petExpression"">
                    <div id=""NeutralPet"" class=""ml-5 mb-4""></div>
                </div>
                <div class=""WinOrDieTag"">
                    
                </div>

                <h6 class=""ml2"">Outcomes:</h6>
                <p class=""mt-4 font-weight-light text""></p>

            </div>
            <div class=""col-6 bg-light rounded-left border border-primary"">
                <h4 class=""mt-3 font-weight-light text-center"">Activities Available for your Dojodachi</h4>
                <hr>
                <div class=""text-right"">
                    <a href=""restart""><i class=""fas fa-undo""></i></a>
                </div>
                <div class=""mt-2 text-center activities col-7"">
                    <a href=""play"" class=""mb-4 btn btn-primary p-3 shadow activity"">Play <i class=""fas fa-football-ball""></i></a>
                    <a href=""feed"" class=""mb-4 btn btn-success p-3 sha");
                WriteLiteral(@"dow activity"">Feed <i class=""fas fa-cookie-bite""></i></a>
                    <a href=""work"" class=""mb-4 btn btn-warning p-3 text-light shadow activity"">Work <i class=""fas fa-suitcase""></i></a>
                    <a href=""sleep"" class=""mb-4 btn btn-secondary p-3  shadow activity"">Sleep <i class=""fas fa-bed""></i></a>
                    <a href=""restart"" class=""btn btn-outline-success btn-3 shadow restart"" > Restart <i class=""fas fa-undo""></i></a>
                    

                </div>
            </div>
        </div>
    </div>
    <script
        src=""https://code.jquery.com/jquery-3.3.1.min.js""
        integrity=""sha256-FgpCb/KJQlLNfOu91ta32o/NMZxltwRo8QtmkMRdAu8=""
        crossorigin=""anonymous"">
    </script>

    <script>
        

    $.ajax({
        method:""GET"",
        url:""petStatus"",
        success:function(response){
            console.log(response);
            if (response==null) {
                $("".activities .restart"").hide();
                $("".activities .activity"").show();
   ");
                WriteLiteral(@"             console.log(""activity show"");

            }
            else{
                console.log(""restart show"");
               $("".activities .restart"").show(); 
               $("".activities .activity"").hide();
            }
        }
    })

    $("".activities .activity"").click(function(e){
        e.preventDefault();
        $.ajax({
            method:""GET"",
            url:$(this).attr(""href""),
            success:function(response){
                $("".energy"").html(response[""energy""]);
                $("".text"").html(response[""text""]);
                $("".fullness"").html(response[""fullness""]);
                $("".meal"").html(response[""meal""]);
                console.log(response[""petHandler""])
                //checking whether to make the buttons disappear or not..
                if (response[""petHandler""]!=null) {
                    $("".activities .activity"").hide();
                    $("".activities .restart"").show();
                }
                else
                {
            ");
                WriteLiteral(@"        $("".activities .activity"").show();
                    $("".activities .restart"").hide();
                }


                if (response[""happiness""]>=90 && response[""fullness""]>=90 && response[""energy""]>=90) {
                    $("".happiness"").html(""<i class='fas fa-kiss-wink-heart'></i> ""+ response[""happiness""]); 
                    $("".petExpression"").html("" <div id='ExcitedPet' class='ml-5  mb-4'></div>"")
                    $("".WinOrDieTag"").html(""<h6 class='tag bg-success text-light p-3 text-center shadow'>YOU WON</h6>"")   
                }
                else if (response[""happiness""]<=0 || response[""fullness""]<=0) {
                    $("".happiness"").html(""<i class='fas fa-dizzy'></i> ""+ response[""happiness""]);
                    $("".petExpression"").html("" <div id='DeadPet' class='ml-5  mb-4'></div>"")  
                    $("".WinOrDieTag"").html(""<h6 class='tag bg-danger text-light p-3 text-center shadow'>DEAD</h6>"")                  
                }
                else if (response");
                WriteLiteral(@"[""happiness""]>=1 && response[""happiness""]<=14) {
                    $("".happiness"").html(""<i class='far fa-sad-tear'></i> ""+ response[""happiness""]); 
                    $("".petExpression"").html("" <div id='ShockedPet' class='ml-5  mb-4'></div>"")                   
                }
                else if (response[""happiness""]>=15 && response[""happiness""]<=29) {
                    $("".happiness"").html(""<i class='far fa-meh-blank'></i> ""+ response[""happiness""]);
                    if (response[""fullness""]<5) {
                        $("".petExpression"").html("" <div id='CryingPet' class='ml-5  mb-4'></div>"")
                    }
                    else{
                        $("".petExpression"").html("" <div id='NeutralPet' class='ml-5  mb-4'></div>"")
                    }
                                        
                }
                else if (response[""happiness""]>=30 && response[""happiness""]<=59) {
                    $("".happiness"").html(""<i class='far fa-smile'></i> ""+ response[""happiness""");
                WriteLiteral(@"]);
                    if (response[""fullness""]<10) {
                        $("".petExpression"").html("" <div id='CryingPet' class='ml-5  mb-4'></div>"")
                    }
                    else{
                        $("".petExpression"").html("" <div id='HappyPet' class='ml-5  mb-4'></div>"") 
                    }               
                }
                else if (response[""happiness""]>=60) {
                    $("".happiness"").html(""<i class='fas fa-laugh'></i> ""+ response[""happiness""]);    
                    $("".petExpression"").html("" <div id='HappyPet' class='ml-5  mb-4'></div>"")                
                }
                
               
            }
        })
    })
    
    </script>

");
                EndContext();
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
            EndContext();
            BeginContext(7309, 8, true);
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pet> Html { get; private set; }
    }
}
#pragma warning restore 1591