#pragma checksum "C:\Users\Nadezhda\source\repos\BooksRealm\BooksRealm\Views\Books\ById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "260d2308599a840c07a839c26bd7ff40448e95f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_ById), @"mvc.1.0.view", @"/Views/Books/ById.cshtml")]
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
#line 1 "C:\Users\Nadezhda\source\repos\BooksRealm\BooksRealm\Views\_ViewImports.cshtml"
using BooksRealm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nadezhda\source\repos\BooksRealm\BooksRealm\Views\_ViewImports.cshtml"
using BooksRealm.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nadezhda\source\repos\BooksRealm\BooksRealm\Views\_ViewImports.cshtml"
using BooksRealm.Data.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nadezhda\source\repos\BooksRealm\BooksRealm\Views\_ViewImports.cshtml"
using BooksRealm.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nadezhda\source\repos\BooksRealm\BooksRealm\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"260d2308599a840c07a839c26bd7ff40448e95f3", @"/Views/Books/ById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0e50e61e8ae927502030238e62a4308776e7ebb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Books_ById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BooksRealm.Models.Books.BookViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("starRatingsForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/user.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reviews", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddReview", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-bookId", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("antiForgeryForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Nadezhda\source\repos\BooksRealm\BooksRealm\Views\Books\ById.cshtml"
  
    this.ViewData["Title"] = @Model.Title;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""anime-details spad"">
    <div class=""container"">
        <div class=""anime__details__content"">
            <div class=""row"">
                <div class=""col-lg-3"">
                    <div class=""anime__details__pic set-bg"">
                        <img");
            BeginWriteAttribute("src", " src=\"", 372, "\"", 393, 1);
#nullable restore
#line 11 "C:\Users\Nadezhda\source\repos\BooksRealm\BooksRealm\Views\Books\ById.cshtml"
WriteAttributeValue("", 378, Model.CoverUrl, 378, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"300\" img-responsive class=\"img-fluid rounded-start\"");
            BeginWriteAttribute("alt", " alt=\"", 453, "\"", 471, 1);
#nullable restore
#line 11 "C:\Users\Nadezhda\source\repos\BooksRealm\BooksRealm\Views\Books\ById.cshtml"
WriteAttributeValue("", 459, Model.Title, 459, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"comment\"><i class=\"fa fa-comments\"></i>");
#nullable restore
#line 12 "C:\Users\Nadezhda\source\repos\BooksRealm\BooksRealm\Views\Books\ById.cshtml"
                                                                      Write(Model.Reviews.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-9\">\r\n                    <div class=\"anime__details__text\">\r\n                        <div class=\"anime__details__title\">\r\n                            <h3>");
#nullable restore
#line 18 "C:\Users\Nadezhda\source\repos\BooksRealm\BooksRealm\Views\Books\ById.cshtml"
                           Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <span>\r\n                                By:\r\n");
#nullable restore
#line 21 "C:\Users\Nadezhda\source\repos\BooksRealm\BooksRealm\Views\Books\ById.cshtml"
                                 foreach (var auth in @Model.Authors)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span>");
#nullable restore
#line 23 "C:\Users\Nadezhda\source\repos\BooksRealm\BooksRealm\Views\Books\ById.cshtml"
                                     Write(auth.AuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 24 "C:\Users\Nadezhda\source\repos\BooksRealm\BooksRealm\Views\Books\ById.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </span>\r\n                        </div>\r\n\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "260d2308599a840c07a839c26bd7ff40448e95f39770", async() => {
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
            WriteLiteral(@"
                        <div class=""anime__details__rating"">
                            <ul class=""rating d-inline"">
                                <li class=""star-fill"" data-vote=""1""><i class=""fas fa-star""></i></li>
                                <li class=""star-fill"" data-vote=""2""><i class=""fas fa-star""></i></li>
                                <li class=""star-fill"" data-vote=""3""><i class=""fas fa-star""></i></li>
                                <li class=""star-fill"" data-vote=""4""><i class=""fas fa-star""></i></li>
                                <li class=""star-fill"" data-vote=""5""><i class=""fas fa-star""></i></li>
                                <li><span id=""averageVoteValue"">");
#nullable restore
#line 36 "C:\Users\Nadezhda\source\repos\BooksRealm\BooksRealm\Views\Books\ById.cshtml"
                                                           Write(Model.AverageVote.ToString("0.0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span> </li>\r\n                                <li><span>/");
#nullable restore
#line 37 "C:\Users\Nadezhda\source\repos\BooksRealm\BooksRealm\Views\Books\ById.cshtml"
                                      Write(Model.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                            </ul>\r\n                           \r\n                        </div>\r\n\r\n\r\n                        <p>");
#nullable restore
#line 43 "C:\Users\Nadezhda\source\repos\BooksRealm\BooksRealm\Views\Books\ById.cshtml"
                      Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        <div class=""anime__details__widget"">
                            <div class=""row"">
                                <div class=""col-lg-9 col-md-9"">
                                    <ul>
                                        <li><span>Date of publish:</span>");
#nullable restore
#line 48 "C:\Users\Nadezhda\source\repos\BooksRealm\BooksRealm\Views\Books\ById.cshtml"
                                                                    Write(Model.DateOfPublish.ToString("Y"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                                    </ul>
                                    <div class=""col-lg-8 col-md-8"">
                                        <ul>
                                            <li>
                                                <span>Genres:</span>
");
#nullable restore
#line 54 "C:\Users\Nadezhda\source\repos\BooksRealm\BooksRealm\Views\Books\ById.cshtml"
                                                 foreach (var auth in @Model.Genres)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li>\r\n                                                    ");
#nullable restore
#line 57 "C:\Users\Nadezhda\source\repos\BooksRealm\BooksRealm\Views\Books\ById.cshtml"
                                               Write(auth.GenreName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </li>\r\n");
#nullable restore
#line 59 "C:\Users\Nadezhda\source\repos\BooksRealm\BooksRealm\Views\Books\ById.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </ul>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-lg-8 col-md-8"">
                        <div class=""anime__details__review"">
                            <div class=""section-title"">
                                <h5>Reviews</h5>
                            </div>
");
#nullable restore
#line 74 "C:\Users\Nadezhda\source\repos\BooksRealm\BooksRealm\Views\Books\ById.cshtml"
                             foreach (var review in @Model.Reviews)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"anime__review__item\">\r\n                                    <div class=\"anime__review__item__pic\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "260d2308599a840c07a839c26bd7ff40448e95f315932", async() => {
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
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"anime__review__item__text\">\r\n                                        <h6>\r\n                                            ");
#nullable restore
#line 82 "C:\Users\Nadezhda\source\repos\BooksRealm\BooksRealm\Views\Books\ById.cshtml"
                                       Write(review.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("!=null ? ");
#nullable restore
#line 82 "C:\Users\Nadezhda\source\repos\BooksRealm\BooksRealm\Views\Books\ById.cshtml"
                                                                Write(review.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : \"Anonimous\";\r\n\r\n                                        </h6>\r\n                                        <h7>\r\n                                            <p>");
#nullable restore
#line 86 "C:\Users\Nadezhda\source\repos\BooksRealm\BooksRealm\Views\Books\ById.cshtml"
                                          Write(review.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </h7>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 90 "C:\Users\Nadezhda\source\repos\BooksRealm\BooksRealm\Views\Books\ById.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                        <div class=""anime__details__form"">
                            <div class=""section-title"">
                                <h5>Your Comment</h5>
                            </div>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "260d2308599a840c07a839c26bd7ff40448e95f318867", async() => {
                WriteLiteral("\r\n                                <textarea placeholder=\"Your Comment\"></textarea>\r\n                                <button type=\"submit\"><i class=\"fa fa-location-arrow\"></i> Review</button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-bookId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["bookId"] = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "260d2308599a840c07a839c26bd7ff40448e95f321607", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n        <script>\r\n        $(\"li[data-vote]\").each(function (el) {\r\n            $(this).click(function () {\r\n                var value = $(this).attr(\"data-vote\");\r\n                var bookId = ");
#nullable restore
#line 116 "C:\Users\Nadezhda\source\repos\BooksRealm\BooksRealm\Views\Books\ById.cshtml"
                        Write(Model.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
                var antiForgeryToken = $('#antiForgeryForm input[name=__RequestVerificationToken]').val();
                var data = { bookId: bookId, value: value };
                $.ajax({
                    type: ""POST"",
                    url: ""/api/Votes"",
                    data: JSON.stringify(data),
                    headers: {
                        'X-CSRF-TOKEN': antiForgeryToken
                    },
                    success: function (data) {
                        $('#averageVoteValue').html(data.averageVote.toFixed(1));
                        showRating(""star - fill"",data.averageVote);
                    },
                    contentType: 'application/json',
                });
            })
        });
        </script>
");
            }
            );
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BooksRealm.Models.Books.BookViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
