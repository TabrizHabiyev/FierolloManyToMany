#pragma checksum "C:\Users\Tabriz\Desktop\FierolloManyToMany\FiorelloBack\FiorelloBack\Views\Flower\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffc572f66173f23504468e3b9605686fc392d4fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flower_Details), @"mvc.1.0.view", @"/Views/Flower/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffc572f66173f23504468e3b9605686fc392d4fe", @"/Views/Flower/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c15b2ec63cc027bd18e29e820bbf24b1f12b23dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Flower_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Flower>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/orangeamarylls.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Tabriz\Desktop\FierolloManyToMany\FiorelloBack\FiorelloBack\Views\Flower\Details.cshtml"
  
    ViewData["Title"] = "Details";
    List<Flower> related = ViewBag.RelatedFlower;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section id=""secondpageintroduce"">
    <div class=""container"">
        <div class=""col-lg-12 info"">
            <div class=""title"">
                <h1>
                    Product List
                </h1>
            </div>
            <div class=""desc"">
                <p>Where flowers are our inspiration</p>
            </div>
        </div>
    </div>
</section>

<section id=""orangeamarylls"">
    <div class=""container"">
        <div class=""row"">
            <div class=""images col-lg-6 col-md-12 col-12"">
                <div class=""littleImages"">
");
#nullable restore
#line 26 "C:\Users\Tabriz\Desktop\FierolloManyToMany\FiorelloBack\FiorelloBack\Views\Flower\Details.cshtml"
                     foreach (var img in Model.FlowerImages.Where(i=>i.IsMain==false))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"littleimage\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 881, "\"", 897, 1);
#nullable restore
#line 29 "C:\Users\Tabriz\Desktop\FierolloManyToMany\FiorelloBack\FiorelloBack\Views\Flower\Details.cshtml"
WriteAttributeValue("", 887, img.Image, 887, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", "\r\n                                 alt=\"", 898, "\"", 938, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </div>\r\n");
#nullable restore
#line 32 "C:\Users\Tabriz\Desktop\FierolloManyToMany\FiorelloBack\FiorelloBack\Views\Flower\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n                </div>\r\n\r\n                <div class=\"bigImage\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1101, "\"", 1166, 1);
#nullable restore
#line 41 "C:\Users\Tabriz\Desktop\FierolloManyToMany\FiorelloBack\FiorelloBack\Views\Flower\Details.cshtml"
WriteAttributeValue("", 1107, Model.FlowerImages.FirstOrDefault(i=>i.IsMain==true).Image, 1107, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", "\r\n                             alt=\"", 1167, "\"", 1203, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n\r\n            </div>\r\n            <div class=\"infos col-lg-6 col-md-12 col-12\">\r\n                <div class=\"info\">\r\n                    <div class=\"title\">\r\n                        <h1>");
#nullable restore
#line 49 "C:\Users\Tabriz\Desktop\FierolloManyToMany\FiorelloBack\FiorelloBack\Views\Flower\Details.cshtml"
                       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    </div>\r\n                    <div class=\"price\">\r\n");
#nullable restore
#line 52 "C:\Users\Tabriz\Desktop\FierolloManyToMany\FiorelloBack\FiorelloBack\Views\Flower\Details.cshtml"
                         if (Model.CampaignId == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>");
#nullable restore
#line 54 "C:\Users\Tabriz\Desktop\FierolloManyToMany\FiorelloBack\FiorelloBack\Views\Flower\Details.cshtml"
                          Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 55 "C:\Users\Tabriz\Desktop\FierolloManyToMany\FiorelloBack\FiorelloBack\Views\Flower\Details.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>$");
#nullable restore
#line 58 "C:\Users\Tabriz\Desktop\FierolloManyToMany\FiorelloBack\FiorelloBack\Views\Flower\Details.cshtml"
                            Write(Model.Price*(100-Model.Campaign.Dicount)/100);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 59 "C:\Users\Tabriz\Desktop\FierolloManyToMany\FiorelloBack\FiorelloBack\Views\Flower\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div class=\"desc\">\r\n                        <p>\r\n                            ");
#nullable restore
#line 63 "C:\Users\Tabriz\Desktop\FierolloManyToMany\FiorelloBack\FiorelloBack\Views\Flower\Details.cshtml"
                       Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </p>
                    </div>
                    <div class=""button"">
                        <input type=""text"" placeholder=""Quantity"">
                        <div class=""counter"">
                            <i class=""fas fa-chevron-left minus""></i><span class=""counting"">0</span><i class=""fas fa-chevron-right plus""></i>
                        </div>
                        <button type=""button"">ADD TO CART <span></span></button>
                    </div>
                    <div class=""details"">
                        <span>SKU: <a");
            BeginWriteAttribute("href", " href=\"", 2557, "\"", 2564, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 74 "C:\Users\Tabriz\Desktop\FierolloManyToMany\FiorelloBack\FiorelloBack\Views\Flower\Details.cshtml"
                                         Write(Model.SKUCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></span>\r\n                        <span>Categories: <a");
            BeginWriteAttribute("href", " href=\"", 2637, "\"", 2644, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 76 "C:\Users\Tabriz\Desktop\FierolloManyToMany\FiorelloBack\FiorelloBack\Views\Flower\Details.cshtml"
                              foreach (var fCategory in Model.FlowerCategories)
                             {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                 <span>");
#nullable restore
#line 78 "C:\Users\Tabriz\Desktop\FierolloManyToMany\FiorelloBack\FiorelloBack\Views\Flower\Details.cshtml"
                                  Write(fCategory.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 79 "C:\Users\Tabriz\Desktop\FierolloManyToMany\FiorelloBack\FiorelloBack\Views\Flower\Details.cshtml"
                             }

#line default
#line hidden
#nullable disable
            WriteLiteral("                             </a></span>\r\n                        <span>Tags: <a");
            BeginWriteAttribute("href", " href=\"", 2945, "\"", 2952, 0);
            EndWriteAttribute();
            WriteLiteral(@"> Lilies, Orchids</a></span>
                    </div>
                </div>

            </div>
        </div>
    </div>
</section>

<section id=""tabs"">
    <div class=""container"">


        <div class=""row titles"">
            <div data-id=""powerofflower"" class=""col-lg-2 col-md-2 col-5 title"">
                <button style=""border-top: none !important;"" type=""button""><span>DESCRIPTION</span></button>
            </div>
            <div data-id=""additional"" class=""col-lg-3 col-md-3 col-8 title"">
                <button style=""border-top: none !important;border-left: none !important;border-right: none !important;"" type=""button""><span>ADDITIONAL INFORMATION</span></button>
            </div>
            <div data-id=""reviews"" class=""col-lg-2 col-md-4 col-5 title"">
                <button style=""border-top: none !important;"" type=""button""><span>REVIEWS (2)</span></button>
            </div>
        </div>


        <div class=""row paragraphs"">
            <div class=""col-lg-12 powe");
            WriteLiteral(@"rofflower"">
                <div class=""title"">
                    <h1>The power of flowers</h1>
                </div>
                <div class=""desc"">
                    <p>
                        Aliquam lorem ante, dapibus in, viverra quis, feugiat a, tellus. Phasellus viverra nulla
                        ut metus varius laoreet. Quisque rutrum. Aenean imperdiet. Etiam ultricies nisi vel
                        augue. Curabitur ullamcorper ultricies nisi. Nam eget dui. Etiam rhoncus. Maecenas
                        tempus, tellus eget condimentum rhoncus, sem quam semper libero, sit amet adipiscing sem
                        neque sed ipsum. Nam quam nunc, blandit vel, luctus pulvinar, hendrerit id, lorem.
                        Maecenas nec odio et ante
                    </p>
                </div>
            </div>
            <div class=""col-lg-12 additional"">
                <span style=""font-weight: bolder;"">Weight:</span><span style=""margin-left: 10px;"">1kg</span><br>
  ");
            WriteLiteral(@"              <span style=""font-weight: bolder;"">Dimensions:</span><span style=""margin-left: 10px;"">
                    30 x 30 x
                    50 cm
                </span>
            </div>
            <div class=""col-lg-12 reviews"">
                <div class=""title"">
                    <h3>Reviews</h3>
                </div>
                <div class=""review"">
                    <div class=""image"">
                        <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/user-img-1-100x100.png""");
            BeginWriteAttribute("alt", "\r\n                             alt=\"", 5550, "\"", 5586, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""info"">
                        <span>JOSHUA GARCIA</span> <span> 27.04.2018</span>
                        <p>
                            Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget
                            dolor. Aenean massa. Cum sociis Theme natoque penatibus et magnis dis parturient
                            montes, nascetur ridiculus mus.
                        </p>
                    </div>

                </div>
                <div class=""review"">
                    <div class=""image"">
                        <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/user-img-2-100x100.png""");
            BeginWriteAttribute("alt", "\r\n                             alt=\"", 6333, "\"", 6369, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""info"">
                        <span>JOAN STANLEY </span><span>27.04.2018</span>
                        <p>
                            Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget
                            dolor. Aenean massa. Cum sociis Theme natoque penatibus et magnis dis parturient
                            montes, nascetur ridiculus mus.
                        </p>
                    </div>

                </div>

                <div class=""forum"">
                    <div class=""title"">
                        <h2>Add a review</h2>
                    </div>
                    <div class=""warning"">
                        <span>
                            Your email address will not be published. Required fields are marked *

                        </span>
                    </div>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffc572f66173f23504468e3b9605686fc392d4fe16906", async() => {
                WriteLiteral("\r\n                        <label for=\"yourreiew\"><span>Your review *</span></label><br>\r\n                        <input style=\"height: 200px;\" type=\"text\" name=\"yourreiew\" required");
                BeginWriteAttribute("id", " id=\"", 7537, "\"", 7542, 0);
                EndWriteAttribute();
                WriteLiteral("><br>\r\n                        <label for=\"name\"><span>Name *</span></label><br>\r\n                        <input style=\"height: 60px;\" type=\"text\" name=\"name\" required");
                BeginWriteAttribute("id", " id=\"", 7710, "\"", 7715, 0);
                EndWriteAttribute();
                WriteLiteral("><br>\r\n                        <label for=\"name\"><span>Email *</span></label><br>\r\n                        <input style=\"height: 60px;\" type=\"email\" name=\"mail\" required");
                BeginWriteAttribute("id", " id=\"", 7885, "\"", 7890, 0);
                EndWriteAttribute();
                WriteLiteral("><br>\r\n                        <input type=\"checkbox\"");
                BeginWriteAttribute("name", " name=\"", 7944, "\"", 7951, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""checkbox""><br>
                        <span>
                            Save my name, email, and website in this browser for the next time I
                            comment.
                        </span><br>
                        <button type=""button""><span>SUBMIT</span></button>
                    ");
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
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</section>\r\n\r\n<section id=\"products\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n\r\n            ");
#nullable restore
#line 200 "C:\Users\Tabriz\Desktop\FierolloManyToMany\FiorelloBack\FiorelloBack\Views\Flower\Details.cshtml"
       Write(await Html.PartialAsync("_FLowerPartialView",related));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n</section>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(" \r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffc572f66173f23504468e3b9605686fc392d4fe20593", async() => {
                    WriteLiteral("\r\n    ");
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
                WriteLiteral("\r\n                \r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Flower> Html { get; private set; }
    }
}
#pragma warning restore 1591
