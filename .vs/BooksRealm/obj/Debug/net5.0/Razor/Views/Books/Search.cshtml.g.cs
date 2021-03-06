#pragma checksum "C:\Users\Nadezhda\source\repos\BooksRealm\BooksRealm\Views\Books\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddf5931f1c69edc8c1583f10f827e88ce00a7fd7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Search), @"mvc.1.0.view", @"/Views/Books/Search.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddf5931f1c69edc8c1583f10f827e88ce00a7fd7", @"/Views/Books/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0e50e61e8ae927502030238e62a4308776e7ebb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Books_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BooksRealm.Models.Books.BookInListViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Books", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ById", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Nadezhda\source\repos\BooksRealm\BooksRealm\Views\Books\Search.cshtml"
  
    this.ViewData["Title"] = $"We found {@Model.Count()} results :" ;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1 class=\"text-info\">");
#nullable restore
#line 7 "C:\Users\Nadezhda\source\repos\BooksRealm\BooksRealm\Views\Books\Search.cshtml"
                 Write(this.ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<hr />\r\n<div class=\"row\">\r\n");
#nullable restore
#line 10 "C:\Users\Nadezhda\source\repos\BooksRealm\BooksRealm\Views\Books\Search.cshtml"
     foreach (var book in this.Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-lg-4 col-md-6 col-sm-6\">\r\n            <div class=\"product__item\">\r\n                <div class=\"product__item__pic set-bg\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 444, "\"", 464, 1);
#nullable restore
#line 15 "C:\Users\Nadezhda\source\repos\BooksRealm\BooksRealm\Views\Books\Search.cshtml"
WriteAttributeValue("", 450, book.CoverUrl, 450, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"200\" img-responsive img-fluid rounded-start border-4\"");
            BeginWriteAttribute("alt", " alt=\"", 526, "\"", 543, 1);
#nullable restore
#line 15 "C:\Users\Nadezhda\source\repos\BooksRealm\BooksRealm\Views\Books\Search.cshtml"
WriteAttributeValue("", 532, book.Title, 532, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"ep\">Rating: ");
#nullable restore
#line 16 "C:\Users\Nadezhda\source\repos\BooksRealm\BooksRealm\Views\Books\Search.cshtml"
                                       Write(book.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                </div>
                <div class=""product__item__text"">
                    <ul>
                        <li>Active</li>
                        <li>Movie</li>
                    </ul>
                    <h5 class=""card-title text-white"">Title: ");
#nullable restore
#line 23 "C:\Users\Nadezhda\source\repos\BooksRealm\BooksRealm\Views\Books\Search.cshtml"
                                                        Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                  <span class=\"text-white\"><h7>Author: \r\n");
#nullable restore
#line 25 "C:\Users\Nadezhda\source\repos\BooksRealm\BooksRealm\Views\Books\Search.cshtml"
                         foreach(var auth in book.Authors)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                           <span>");
#nullable restore
#line 27 "C:\Users\Nadezhda\source\repos\BooksRealm\BooksRealm\Views\Books\Search.cshtml"
                            Write(auth.AuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 28 "C:\Users\Nadezhda\source\repos\BooksRealm\BooksRealm\Views\Books\Search.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </h7>\r\n                    </span>\r\n                    <div class=\"comment text-white\"><i class=\"fa fa-comments\"></i>Date of publish: ");
#nullable restore
#line 31 "C:\Users\Nadezhda\source\repos\BooksRealm\BooksRealm\Views\Books\Search.cshtml"
                                                                                              Write(book.DateOfPublish);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>                  \r\n                    <h5>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddf5931f1c69edc8c1583f10f827e88ce00a7fd78677", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\Nadezhda\source\repos\BooksRealm\BooksRealm\Views\Books\Search.cshtml"
                                                                      WriteLiteral(book.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h5>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 36 "C:\Users\Nadezhda\source\repos\BooksRealm\BooksRealm\Views\Books\Search.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<hr />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BooksRealm.Models.Books.BookInListViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
