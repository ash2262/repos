#pragma checksum "C:\Users\91984\source\repos\WebApplication1\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c885f9bcdbeee402bf0cae6ed4ec7838001a759"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApplication1.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace WebApplication1.Pages
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
#line 1 "C:\Users\91984\source\repos\WebApplication1\Pages\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c885f9bcdbeee402bf0cae6ed4ec7838001a759", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd66e6c0b2d0593b97c0d67f6f506054866fe040", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/app/Contacts.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/polyfill.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/angular-1.7.8.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/app/Contacts.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/site.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\91984\source\repos\WebApplication1\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



<h4 class=""panel-title"" style=""padding-left:9%"">Enter Contact Information</h4>

<div class=""container container-fluid ng-cloak"" ng-app=""tpoApp"" ng-controller=""ContactsController"" style=""background-color: rgb(210,215,215,0.22) !important;"">

    <div id=""left"" style=""float:left; width:50%;""> 
        <div class=""panel panel-default "">

            <div class=""panel-heading""> </div>

            <div class=""panel-body"">

                <div id=""primaryContactContainer"">

                    <span class=""panel-title"">PRIMARY CONTACT</span>

                    <div class=""row contact-row"">



                        <div class=""col-sm-3"">

                            <span class=""required"" ng-show=""IsPrimaryContactsMandatory"">*</span> <label for=""txtprimarycontactName"">Name</label>

                        </div>

                        <div class=""col-sm-4"">

                            <input type=""text"" id=""txtprimarycontactName"" ng-model=""contactsModel.MainModel.PrimaryCo");
            WriteLiteral(@"ntactModel.Name"" />

                        </div>

                    </div>

                    <div class=""row contact-row"">



                        <div class=""col-sm-3"">

                            <span class=""required"" ng-show=""IsPrimaryContactsMandatory"">*</span> <label for=""txtprimarycontactPhone"">Phone Number</label>

                        </div>

                        <div class=""col-sm-4"">

                            <input type=""text"" id=""txtprimarycontactPhone"" phone-input ng-model=""contactsModel.MainModel.PrimaryContactModel.Phone"" />

                        </div>

                    </div>

                    <div class=""row contact-row"">



                        <div class=""col-sm-3"">

                            <span class=""required"" ng-show=""IsPrimaryContactsMandatory"">*</span> <label for=""txtprimarycontactEmail"">Email Address</label>

                        </div>

                        <div class=""col-sm-4"">

                      ");
            WriteLiteral(@"      <input type=""text"" id=""txtprimarycontactEmail"" ng-model=""contactsModel.MainModel.PrimaryContactModel.Email"" />

                        </div>

                    </div>

                </div>

                <hr />

                <div id=""secondoryContactContainer"">

                    <span class=""panel-title"">SECONDARY CONTACT</span>

                    <div class=""row contact-row"">



                        <div class=""col-sm-3"">

                            <label for=""txtsecondorycontactName"">Name</label>

                        </div>

                        <div class=""col-sm-4"">

                            <input type=""text"" id=""txtsecondorycontactName"" ng-model=""contactsModel.MainModel.SecondoryContactModel.Name"" />

                        </div>

                    </div>

                    <div class=""row contact-row"">



                        <div class=""col-sm-3"">

                            <label for=""txtsecondorycontactPhone"">Phone");
            WriteLiteral(@" Number</label>

                        </div>

                        <div class=""col-sm-4"">

                            <input type=""text"" id=""txtsecondorycontactPhone"" phone-input ng-model=""contactsModel.MainModel.SecondoryContactModel.Phone"" />

                        </div>

                    </div>

                    <div class=""row contact-row"">



                        <div class=""col-sm-3"">

                            <label for=""txtsecondorycontactEmail"">Email Address</label>

                        </div>

                        <div class=""col-sm-4"">

                            <input type=""text"" id=""txtsecondorycontactEmail"" ng-model=""contactsModel.MainModel.SecondoryContactModel.Email"" />

                        </div>

                    </div>

                </div>

                <hr />

                <div id=""postClosingContactContainer"">

                    <span class=""panel-title"">POST-CLOSING CONTACT</span>

                    ");
            WriteLiteral(@"<div class=""row contact-row"">



                        <div class=""col-sm-3"">

                            <span class=""required"" ng-show=""IsPostClosingCotactMandatory"">*</span>  <label for=""txtpostClosingcontactName"">Name</label>

                        </div>

                        <div class=""col-sm-4"">

                            <input type=""text"" id=""txtpostClosingcontactName"" ng-model=""contactsModel.MainModel.PostClosingContactModel.Name"" />

                        </div>

                    </div>

                    <div class=""row contact-row"">



                        <div class=""col-sm-3"">

                            <span class=""required"" ng-show=""IsPostClosingCotactMandatory"">*</span> <label for=""txtpostClosingcontactPhone"">Phone Number</label>

                        </div>

                        <div class=""col-sm-4"">

                            <input type=""text"" id=""txtpostClosingcontactPhone"" phone-input ng-model=""contactsModel.MainModel.PostClo");
            WriteLiteral(@"singContactModel.Phone"" />

                        </div>

                    </div>

                    <div class=""row contact-row"">



                        <div class=""col-sm-3"">

                            <span class=""required"" ng-show=""IsPostClosingCotactMandatory"">*</span> <label for=""txtpostClosingcontactEmail"">Email Address</label>

                        </div>

                        <div class=""col-sm-4"">

                            <input type=""text"" id=""txtpostClosingcontactEmail"" ng-model=""contactsModel.MainModel.PostClosingContactModel.Email"" />

                        </div>

                    </div>

                </div>

                <hr />



                <div class=""row"" style=""margin-top:2% !important"">

                    <div class=""col-sm-3""></div>



                    <div class=""col-sm-4"" style=""float:right;margin-right: 30%;"">

                        <button class=""btn btn-primary ng-binding"" ng-click=""OnSaveContactsCli");
            WriteLiteral(@"ck()"">Save</button>



                    </div>

                </div>

            </div>



        </div>
    </div>
    <div id=""right"" style=""float:right; width:50%;""> 
        <div id=""postClosingContactContainer"">

            <span class=""panel-title"">ADDITIONAL INFORMATION - AUS Findings</span>

            <div class=""row contact-row"">



                <div class=""col-sm-5"">

                    <span class=""optional"" ng-show=""IsPostClosingCotactMandatory"">*</span>  <label for=""txtpostClosingcontactName"">Encompass 1543</label>

                </div>

                <div class=""col-sm-6"">

                    <input type=""text"" id=""txtpostClosingcontact"" ng-model=""contactsModel.MainModel.AdditionalInformationModel.Encompass1543"" />

                </div>

            </div>

            <div class=""row contact-row"">



                <div class=""col-sm-5"">

                    <span class=""optional"" ng-show=""IsPostClosingCotactMandatory"">*</span> <l");
            WriteLiteral(@"abel for=""txtpostClosingcontactPhone"">Encompass 1003</label>

                </div>

                <div class=""col-sm-6"">

                    <input type=""text"" id=""txtpostClosingcontact"" ng-model=""contactsModel.MainModel.AdditionalInformationModel.Encompass1003"" />

                </div>

            </div>

        </div>

    </div>

    

    <div class=""modal fade"" id=""alertDialog"" role=""dialog"" data-backdrop=""static"" data-keyboard=""false"">

        <div class=""modal-dialog"">



            <!-- Modal content-->

            <div class=""modal-content"">

                <div class=""modal-header"">

                    <h4 class=""modal-title"">Alert</h4> <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>



                </div>

                <div class=""modal-body"">

                    <p id=""modalAlertMessage"" class=""lert  alert alert-danger"">.</p>

                </div>

                <div class=""modal-footer"">

              ");
            WriteLiteral(@"      <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>

                </div>

            </div>



        </div>

    </div>

    <div id=""spinnerContainer"" class=""modal fade"" role=""dialog"" data-backdrop=""static"" data-keyboard=""false"" style=""display:none;height: 177px;width: 161px;margin-left: 600px;margin-top: 300px;overflow-y:hidden"">

        <div id=""spinner"">

            <p id=""svg-message-text""></p>

            <svg id=""spinnersvg"" data-name=""Layer 1"" xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 48 48"">



                <defs>

                    <style>

                        .a {
                            fill: #fff;
                        }



                        .b {
                            fill: #e4e4e4;
                        }



                        .c {
                            fill: #1394e5;
                        }



                        #Layer_1 {
                            wid");
            WriteLiteral(@"th: 48px;
                            margin: auto;
                        }
                    </style>

                </defs>



                <g id=""rotateSquare"">

                    <animateTransform attributeType=""XML""
                                      attributeName=""transform""
                                      type=""rotate""
                                      from=""0,22,22"" to=""360,22,22""
                                      begin=""0s"" dur=""0.8s""
                                      repeatCount=""indefinite"" />

                    <circle class=""a"" cx=""22"" cy=""22"" r=""22"" />

                    <path class=""b"" d=""M22,10A12,12,0,1,1,10,22,12,12,0,0,1,22,10m0-2A14,14,0,1,0,36,22,14,14,0,0,0,22,8h0Z"" />

                    <path class=""c"" d=""M22,8v2A12,12,0,0,1,34,22h2A14,14,0,0,0,22,8Z"" />



                </g>

            </svg>



        </div>

    </div>



</div>



<link href='https://fonts.googleapis.com/css?family=Montserrat' rel='");
            WriteLiteral("stylesheet\'>\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3c885f9bcdbeee402bf0cae6ed4ec7838001a75916126", async() => {
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
            WriteLiteral("\r\n\r\n<script src=\"https://3967562275.encompasstpoconnect.com/scripts/elli-ssf-guest.js\"></script>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c885f9bcdbeee402bf0cae6ed4ec7838001a75917347", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c885f9bcdbeee402bf0cae6ed4ec7838001a75918399", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c885f9bcdbeee402bf0cae6ed4ec7838001a75919443", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c885f9bcdbeee402bf0cae6ed4ec7838001a75920487", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
