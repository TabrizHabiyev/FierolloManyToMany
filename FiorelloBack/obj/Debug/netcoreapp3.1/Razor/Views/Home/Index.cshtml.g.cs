#pragma checksum "C:\Users\Tabriz\Desktop\FierolloManyToMany\FiorelloBack\FiorelloBack\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d2e66d4fe8c19bf131bf871747c2b923513e154"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Tabriz\Desktop\FierolloManyToMany\FiorelloBack\FiorelloBack\Views\_ViewImports.cshtml"
using FiorelloBack;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tabriz\Desktop\FierolloManyToMany\FiorelloBack\FiorelloBack\Views\_ViewImports.cshtml"
using FiorelloBack.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Tabriz\Desktop\FierolloManyToMany\FiorelloBack\FiorelloBack\Views\_ViewImports.cshtml"
using FiorelloBack.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d2e66d4fe8c19bf131bf871747c2b923513e154", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c15b2ec63cc027bd18e29e820bbf24b1f12b23dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("interval"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/h3-slider-background.jpeg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Tabriz\Desktop\FierolloManyToMany\FiorelloBack\FiorelloBack\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section id=\"introduce\" class=\"col-lg-12 col-sm-12 col-12\">\r\n    <div class=\"images\">\r\n\r\n        <i class=\"fas fa-chevron-right clickright\"></i>\r\n        <i class=\"fas fa-chevron-left clickleft\"></i>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0d2e66d4fe8c19bf131bf871747c2b923513e1544844", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <div class=""flowersInfo"">
        <div class=""title"">
            <div class=""st"">
                <span>Send</span><span>flowers</span><span>like</span>
            </div>
            <div class=""nd"">
                <span>you mean it.</span>
            </div>
        </div>
        <div class=""desc"">
            <p>
                Lorem ipsum dolor sit, amet consectetur adipisicing elit. Mollitia rerum beatae totam sunt
                excepturi voluptatum maiores non ex et officia?
            </p>
        </div>
        <div class=""sign"">
            <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/h2-sign-img.png""");
            BeginWriteAttribute("alt", " alt=\"", 1028, "\"", 1034, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        </div>
    </div>
</section>
<section id=""products"">
    <div class=""container"">
        <div class=""row"">
            <div class=""filters-filterbtn d-flex justify-content-between"">
                <div class=""mdfilters"">
                    <span id=""mdcategory"" style=""cursor: pointer;
                            font-size: 12px;
                            letter-spacing: 2px;
                            transition: 0.2s;"">CATEGORY</span><i style=""font-size: 12px;""
                                                                 class=""fas fa-chevron-down""></i>
                    <div class=""mdcategories"" style=""max-width:min-content;"">
                        <span id=""firstfilter"" data-id=""all"">ALL</span>
");
#nullable restore
#line 45 "C:\Users\Tabriz\Desktop\FierolloManyToMany\FiorelloBack\FiorelloBack\Views\Home\Index.cshtml"
                         foreach (var category in Model.Categories)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span data-id=\"");
#nullable restore
#line 47 "C:\Users\Tabriz\Desktop\FierolloManyToMany\FiorelloBack\FiorelloBack\Views\Home\Index.cshtml"
                                      Write(category.Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 47 "C:\Users\Tabriz\Desktop\FierolloManyToMany\FiorelloBack\FiorelloBack\Views\Home\Index.cshtml"
                                                                Write(category.Name.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 48 "C:\Users\Tabriz\Desktop\FierolloManyToMany\FiorelloBack\FiorelloBack\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                    </div>\r\n                </div>\r\n                <div class=\"filters col-lg-10  \">\r\n                    <span id=\"firstfilter\" data-id=\"all\">ALL</span>\r\n");
#nullable restore
#line 56 "C:\Users\Tabriz\Desktop\FierolloManyToMany\FiorelloBack\FiorelloBack\Views\Home\Index.cshtml"
                     foreach (var category in Model.Categories)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span data-id=\"");
#nullable restore
#line 58 "C:\Users\Tabriz\Desktop\FierolloManyToMany\FiorelloBack\FiorelloBack\Views\Home\Index.cshtml"
                                  Write(category.Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\" style=\"margin-left: 20px;\">");
#nullable restore
#line 58 "C:\Users\Tabriz\Desktop\FierolloManyToMany\FiorelloBack\FiorelloBack\Views\Home\Index.cshtml"
                                                                                       Write(category.Name.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 59 "C:\Users\Tabriz\Desktop\FierolloManyToMany\FiorelloBack\FiorelloBack\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


                </div>
                <div class=""filterbtn col-lg-2 d-flex justify-content-end"">
                    <span id=""mdfilterbtn"">FILTER</span><span><i class=""fas fa-chevron-down""></i></span>
                    <div class=""mdfilterLists"" style=""max-width:max-content;max-height: max-content;"">
                        <div class=""sortby"">
                            <h4>Sort By</h4>
                            <ul>
                                <li><a");
            BeginWriteAttribute("href", " href=\"", 2901, "\"", 2908, 0);
            EndWriteAttribute();
            WriteLiteral(">Default</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 2966, "\"", 2973, 0);
            EndWriteAttribute();
            WriteLiteral(">Popularity</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 3034, "\"", 3041, 0);
            EndWriteAttribute();
            WriteLiteral(">Newness</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 3099, "\"", 3106, 0);
            EndWriteAttribute();
            WriteLiteral(">Price : low to higher</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 3178, "\"", 3185, 0);
            EndWriteAttribute();
            WriteLiteral(@">Price : high to lower</a></li>
                            </ul>
                        </div>
                        <div class=""pricerange"">
                            <h4>Price range</h4>
                            <ul>
                                <li><a");
            BeginWriteAttribute("href", " href=\"", 3458, "\"", 3465, 0);
            EndWriteAttribute();
            WriteLiteral(">All</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 3519, "\"", 3526, 0);
            EndWriteAttribute();
            WriteLiteral(">$0 - $10</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 3585, "\"", 3592, 0);
            EndWriteAttribute();
            WriteLiteral(">$10 - $20</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 3652, "\"", 3659, 0);
            EndWriteAttribute();
            WriteLiteral(">$20 - $30</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 3719, "\"", 3726, 0);
            EndWriteAttribute();
            WriteLiteral(">$30 - $40</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 3786, "\"", 3793, 0);
            EndWriteAttribute();
            WriteLiteral(@">$40+</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class=""filterLists"">
                        <div class=""sortby"">
                            <h4>Sort By</h4>
                            <ul>
                                <li><a");
            BeginWriteAttribute("href", " href=\"", 4116, "\"", 4123, 0);
            EndWriteAttribute();
            WriteLiteral(">Default</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 4181, "\"", 4188, 0);
            EndWriteAttribute();
            WriteLiteral(">Popularity</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 4249, "\"", 4256, 0);
            EndWriteAttribute();
            WriteLiteral(">Newness</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 4314, "\"", 4321, 0);
            EndWriteAttribute();
            WriteLiteral(">Price : low to higher</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 4393, "\"", 4400, 0);
            EndWriteAttribute();
            WriteLiteral(@">Price : high to lower</a></li>
                            </ul>
                        </div>
                        <div class=""pricerange"">
                            <h4>Price range</h4>
                            <ul>
                                <li><a");
            BeginWriteAttribute("href", " href=\"", 4673, "\"", 4680, 0);
            EndWriteAttribute();
            WriteLiteral(">All</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 4734, "\"", 4741, 0);
            EndWriteAttribute();
            WriteLiteral(">$0 - $10</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 4800, "\"", 4807, 0);
            EndWriteAttribute();
            WriteLiteral(">$10 - $20</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 4867, "\"", 4874, 0);
            EndWriteAttribute();
            WriteLiteral(">$20 - $30</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 4934, "\"", 4941, 0);
            EndWriteAttribute();
            WriteLiteral(">$30 - $40</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 5001, "\"", 5008, 0);
            EndWriteAttribute();
            WriteLiteral(">$40+</a></li>\r\n                            </ul>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n         ");
#nullable restore
#line 114 "C:\Users\Tabriz\Desktop\FierolloManyToMany\FiorelloBack\FiorelloBack\Views\Home\Index.cshtml"
    Write(await Html.PartialAsync("_FLowerPartialView",Model.Flowers));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


        </div>
    </div>
</section>

<section id=""valentine"">
    <div class=""container"">
        <div class=""row"">
            <div data-aos=""zoom-in-up"" data-aos-duration=""1000"" class=""valentineVideo col-lg-6"">
                <div class=""videoImage "">
                    <img style=""width: 100%;""
                         src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/h3-video-img.jpg""");
            BeginWriteAttribute("alt", "\r\n                         alt=\"", 5662, "\"", 5694, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fas fa-play""></i>
                </div>
            </div>
            <div class=""valentineTexts col-lg-6"">
                <div class=""title"">
                    <h1>Surprise Your <span style=""color: red;"">Valentine!</span></h1>
                    <h1>Let us arrange a smile.</h1>
                </div>
                <div class=""desc"">
                    <p>
                        Where flowers are our inspiration to create lasting memories. Whatever the occasion...

                    </p>
                </div>
                <div class=""icondescs"">
                    <div class=""first"">
                        <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/h1-custom-icon.png""");
            BeginWriteAttribute("alt", "\r\n                             alt=\"", 6447, "\"", 6483, 0);
            EndWriteAttribute();
            WriteLiteral(@"><span>
                            Hand picked just for you.
                        </span>
                    </div>
                    <div class=""sec"">
                        <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/h1-custom-icon.png""");
            BeginWriteAttribute("alt", "\r\n                             alt=\"", 6765, "\"", 6801, 0);
            EndWriteAttribute();
            WriteLiteral("><span>Unique flower arrangements</span>\r\n                    </div>\r\n                    <div class=\"third\">\r\n\r\n                        <img src=\"https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/h1-custom-icon.png\"");
            BeginWriteAttribute("alt", "\r\n                             alt=\"", 7032, "\"", 7068, 0);
            EndWriteAttribute();
            WriteLiteral(@"><span>Best way to say you care.</span>
                    </div>


                </div>
            </div>
        </div>
    </div>

</section>

<section id=""flowerexperts"">
    <div class=""container"">
        <div class=""info col-lg-12"">
            <div class=""title"">
                <h1>Flower Experts</h1>
            </div>
            <div class=""desc"">
                <p>
                    Flower Experts
                    A perfect blend of creativity, energy, communication, happiness and love. Let us arrange a
                    smile for you.
                </p>
            </div>
        </div>
        <div class=""row"">
            <div class=""experts"">
                <div class=""expert col-md-6 col-12 col-lg-3"">
                    <div class=""photo"">
                        <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/h3-team-img-1.png""");
            BeginWriteAttribute("alt", "\r\n                             alt=\"", 7998, "\"", 8034, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""name"">
                        <p>CRYSTAL BROOKS</p>
                    </div>
                    <div class=""job"">
                        <p>Florist</p>
                    </div>
                </div>
                <div class=""expert col-md-6 col-12 col-lg-3"">
                    <div class=""photo"">
                        <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/05/h3-team-img-2.png""");
            BeginWriteAttribute("alt", "\r\n                             alt=\"", 8532, "\"", 8568, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""name"">
                        <p>SHIRLEY HARRIS</p>
                    </div>
                    <div class=""job"">
                        <p>Manager</p>
                    </div>
                </div>
                <div class=""expert col-md-6 col-12 col-lg-3"">
                    <div class=""photo"">
                        <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/h3-team-img-3.png""");
            BeginWriteAttribute("alt", "\r\n                             alt=\"", 9066, "\"", 9102, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""name"">
                        <p>
                            BEVERLY CLARK
                        </p>
                    </div>
                    <div class=""job"">
                        <p>Florist</p>
                    </div>
                </div>
                <div class=""expert col-md-6 col-12 col-lg-3"">
                    <div class=""photo"">
                        <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/h3-team-img-4.png""");
            BeginWriteAttribute("alt", "\r\n                             alt=\"", 9655, "\"", 9691, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""name"">
                        <p>AMANDA WATKINS</p>
                    </div>
                    <div class=""job"">
                        <p>Florist</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<section id=""subscribe"">

    <div class=""parallax-window"" data-parallax=""scroll""
         data-image-src=""  https://fiorello.qodeinteractive.com/wp-content/uploads/2018/05/h3-background-img.jpg"">

        <div class=""container"">
            <div class=""title col-lg-12 col-12 col-md-12"">
                <h1>Join The Colorful Bunch!</h1>
            </div>
            <div class=""subs col-lg-12 col-12 col-md-12"">
                <input type=""email"">
                <button>SUBSCRIBE</button>
            </div>

        </div>
    </div>



</section>

<section id=""blogs"">
    <div class=""container"">
        <div class=""info col-lg-12"">
            <div c");
            WriteLiteral(@"lass=""title"">
                <h1>Form our blog</h1>
            </div>
            <div class=""desc"">
                <p>
                    Flower Experts
                    A perfect blend of creativity, energy, communication, happiness and love. Let us arrange a
                    smile for you.
                </p>
            </div>
        </div>
        <div class=""row"">
            <div class=""blog col-lg-4"">
                <div class=""image"">
                    <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/blog-feature-img-1.jpg""");
            BeginWriteAttribute("alt", "\r\n                         alt=\"", 11308, "\"", 11340, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <span class=""badge bg-light text-dark"">03.08.2018</span>
                </div>
                <div class=""title"">
                    <h4>Flower Power</h4>
                </div>
                <div class=""desc"">
                    <p>Class aptent taciti sociosqu ad litora torquent per conubia nostra, per</p>
                </div>
            </div>
            <div class=""blog col-lg-4"">
                <div class=""image"">
                    <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/05/blog-feature-img-3.jpg""");
            BeginWriteAttribute("alt", "\r\n                         alt=\"", 11925, "\"", 11957, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <span class=""badge bg-light text-dark"">03.08.2018</span>
                </div>
                <div class=""title"">
                    <h4>Local florists</h4>
                </div>
                <div class=""desc"">
                    <p>Class aptent taciti sociosqu ad litora torquent per conubia nostra, per</p>
                </div>
            </div>
            <div class=""blog col-lg-4"">
                <div class=""image"">
                    <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/05/blog-feature-img-4.jpg""");
            BeginWriteAttribute("alt", "\r\n                         alt=\"", 12544, "\"", 12576, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <span class=""badge bg-light text-dark"">03.08.2018</span>
                </div>
                <div class=""title"">
                    <h4>Flower beauty</h4>
                </div>
                <div class=""desc"">
                    <p>Class aptent taciti sociosqu ad litora torquent per conubia nostra, per</p>
                </div>
            </div>
        </div>
    </div>


</section>

<section id=""slideimages"">
    <div class=""container"">
        <div class=""owl-carousel owl-theme"">
            <div class=""item"">
                <div class=""expert col-md-6 col-12 col-lg-7"">
                    <div class=""photo"">
                        <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/h3-team-img-4.png""");
            BeginWriteAttribute("alt", "\r\n                             alt=\"", 13368, "\"", 13404, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""title"">
                        <h3>
                            Lorem ipsum dolor sit amet consectetur adipisicing elit. Quos magnam deleniti neque?
                        </h3>
                    </div>
                    <div class=""name"">
                        <p>AMANDA WATKINS</p>
                    </div>
                    <div class=""job"">
                        <p>Florist</p>
                    </div>
                </div>
            </div>
            <div class=""item"">
                <div class=""expert col-md-6 col-12 col-lg-7"">
                    <div class=""photo"">
                        <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/h3-team-img-3.png""");
            BeginWriteAttribute("alt", "\r\n                             alt=\"", 14198, "\"", 14234, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""title"">
                        <h3>
                            Lorem ipsum dolor sit amet consectetur adipisicing elit. Minima dolorum obcaecati
                            ratione.
                        </h3>
                    </div>
                    <div class=""name"">
                        <p>
                            BEVERLY CLARK
                        </p>
                    </div>
                    <div class=""job"">
                        <p>Florist</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>




");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
