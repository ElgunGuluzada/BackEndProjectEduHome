#pragma checksum "C:\Users\elgun\Desktop\EduHomeBackEndProject\EduHomeBackEndProject\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c9959065a8cd49b0a1fcbbaf404b554b632f338"
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
#line 1 "C:\Users\elgun\Desktop\EduHomeBackEndProject\EduHomeBackEndProject\Views\_ViewImports.cshtml"
using EduHomeBackEndProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\elgun\Desktop\EduHomeBackEndProject\EduHomeBackEndProject\Views\_ViewImports.cshtml"
using EduHomeBackEndProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c9959065a8cd49b0a1fcbbaf404b554b632f338", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e25cf6f4b6a2ef388f7eb5d46b724744aed25531", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/icon/section.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("section-title"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("testimonial"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\elgun\Desktop\EduHomeBackEndProject\EduHomeBackEndProject\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Background Area Start -->\r\n<section id=\"slider-container\" class=\"slider-area\">\r\n    <div class=\"slider-owl owl-theme owl-carousel\">\r\n");
#nullable restore
#line 10 "C:\Users\elgun\Desktop\EduHomeBackEndProject\EduHomeBackEndProject\Views\Home\Index.cshtml"
         foreach (var slider in Model.Sliders)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!-- Start Slingle Slide -->\r\n            <div class=\"single-slide item\"");
            BeginWriteAttribute("style", " style=\"", 359, "\"", 414, 4);
            WriteAttributeValue("", 367, "background-image:", 367, 17, true);
            WriteAttributeValue(" ", 384, "url(img/slider/", 385, 16, true);
#nullable restore
#line 13 "C:\Users\elgun\Desktop\EduHomeBackEndProject\EduHomeBackEndProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 400, slider.Image, 400, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 413, ")", 413, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                <!-- Start Slider Content -->
                <div class=""slider-content-area"">
                    <div class=""container"">
                        <div class=""row"">
                            <div class=""col-md-7 col-md-offset-left-5"">
                                <div class=""slide-content-wrapper"">
                                    <div class=""slide-content"">
                                        ");
#nullable restore
#line 21 "C:\Users\elgun\Desktop\EduHomeBackEndProject\EduHomeBackEndProject\Views\Home\Index.cshtml"
                                   Write(Html.Raw(slider.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        <p>");
#nullable restore
#line 22 "C:\Users\elgun\Desktop\EduHomeBackEndProject\EduHomeBackEndProject\Views\Home\Index.cshtml"
                                      Write(slider.Discription);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                        <a class=""default-btn"" href=""about.html"">Learn more</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- Start Slider Content -->
            </div>
            <!-- End Slingle Slide -->
");
#nullable restore
#line 33 "C:\Users\elgun\Desktop\EduHomeBackEndProject\EduHomeBackEndProject\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


    </div>
</section>
<!-- Background Area End -->
<!-- Notice Start -->
<section class=""notice-area pt-150 pb-150"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 col-sm-6 col-xs-12"">
                <div class=""notice-left"">
");
#nullable restore
#line 46 "C:\Users\elgun\Desktop\EduHomeBackEndProject\EduHomeBackEndProject\Views\Home\Index.cshtml"
                     foreach (var item in Model.NoticeBoardLefts)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h3>");
#nullable restore
#line 48 "C:\Users\elgun\Desktop\EduHomeBackEndProject\EduHomeBackEndProject\Views\Home\Index.cshtml"
                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 49 "C:\Users\elgun\Desktop\EduHomeBackEndProject\EduHomeBackEndProject\Views\Home\Index.cshtml"
                        if (count == 3)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"single-notice-left pb-75\">\r\n                                <h4>");
#nullable restore
#line 52 "C:\Users\elgun\Desktop\EduHomeBackEndProject\EduHomeBackEndProject\Views\Home\Index.cshtml"
                               Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <p>");
#nullable restore
#line 53 "C:\Users\elgun\Desktop\EduHomeBackEndProject\EduHomeBackEndProject\Views\Home\Index.cshtml"
                              Write(item.Discription);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                            </div>\r\n");
#nullable restore
#line 55 "C:\Users\elgun\Desktop\EduHomeBackEndProject\EduHomeBackEndProject\Views\Home\Index.cshtml"
                        }
                        else if (count == 6 || count == 9)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"single-notice-left pb-70\">\r\n                                <h4>");
#nullable restore
#line 59 "C:\Users\elgun\Desktop\EduHomeBackEndProject\EduHomeBackEndProject\Views\Home\Index.cshtml"
                               Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <p>");
#nullable restore
#line 60 "C:\Users\elgun\Desktop\EduHomeBackEndProject\EduHomeBackEndProject\Views\Home\Index.cshtml"
                              Write(item.Discription);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                            </div>\r\n");
#nullable restore
#line 62 "C:\Users\elgun\Desktop\EduHomeBackEndProject\EduHomeBackEndProject\Views\Home\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"single-notice-left mb-25 pb-25\">\r\n                                <h4>");
#nullable restore
#line 66 "C:\Users\elgun\Desktop\EduHomeBackEndProject\EduHomeBackEndProject\Views\Home\Index.cshtml"
                               Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <p>");
#nullable restore
#line 67 "C:\Users\elgun\Desktop\EduHomeBackEndProject\EduHomeBackEndProject\Views\Home\Index.cshtml"
                              Write(item.Discription);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                            </div>\r\n");
#nullable restore
#line 69 "C:\Users\elgun\Desktop\EduHomeBackEndProject\EduHomeBackEndProject\Views\Home\Index.cshtml"
                        }
                        count++;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n            <div class=\"col-md-6 col-sm-6 col-xs-12\">\r\n                <div class=\"notice-right\">\r\n");
#nullable restore
#line 76 "C:\Users\elgun\Desktop\EduHomeBackEndProject\EduHomeBackEndProject\Views\Home\Index.cshtml"
                     foreach (var item in Model.NoticeBoardRights)
                    {

                        if (count == 3)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"single-notice-right\">\r\n                                <h3>");
#nullable restore
#line 82 "C:\Users\elgun\Desktop\EduHomeBackEndProject\EduHomeBackEndProject\Views\Home\Index.cshtml"
                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                <p>");
#nullable restore
#line 83 "C:\Users\elgun\Desktop\EduHomeBackEndProject\EduHomeBackEndProject\Views\Home\Index.cshtml"
                              Write(item.Discription);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                            </div>\r\n");
#nullable restore
#line 85 "C:\Users\elgun\Desktop\EduHomeBackEndProject\EduHomeBackEndProject\Views\Home\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"single-notice-right \" style=\"margin-bottom: 17px; padding-bottom: 17px\">\r\n                                <h3>");
#nullable restore
#line 89 "C:\Users\elgun\Desktop\EduHomeBackEndProject\EduHomeBackEndProject\Views\Home\Index.cshtml"
                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                <p>");
#nullable restore
#line 90 "C:\Users\elgun\Desktop\EduHomeBackEndProject\EduHomeBackEndProject\Views\Home\Index.cshtml"
                              Write(item.Discription);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                            </div>\r\n");
#nullable restore
#line 92 "C:\Users\elgun\Desktop\EduHomeBackEndProject\EduHomeBackEndProject\Views\Home\Index.cshtml"
                        }
                        count++;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- Notice End -->\r\n<!-- Choose Start -->\r\n<section class=\"choose-area pb-85 pt-77\"");
            BeginWriteAttribute("style", " style=\"", 3900, "\"", 4112, 14);
            WriteAttributeValue(" ", 3908, "background:", 3909, 12, true);
            WriteAttributeValue(" ", 3920, "url(~/../img/choose/", 3921, 21, true);
#nullable restore
#line 102 "C:\Users\elgun\Desktop\EduHomeBackEndProject\EduHomeBackEndProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 3941, Model.WhyYouChooseUss.Image, 3941, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3969, ");", 3969, 2, true);
            WriteAttributeValue(" ", 3971, "background-repeat:", 3972, 19, true);
            WriteAttributeValue(" ", 3990, "no-repeat;", 3991, 11, true);
            WriteAttributeValue("\r\n ", 4001, "background-size:", 4004, 19, true);
            WriteAttributeValue(" ", 4020, "cover;background-attachment:", 4021, 29, true);
            WriteAttributeValue(" ", 4049, "fixed;", 4050, 7, true);
            WriteAttributeValue(" ", 4056, "background-position:", 4057, 21, true);
            WriteAttributeValue(" ", 4077, "center", 4078, 7, true);
            WriteAttributeValue(" ", 4084, "center;", 4085, 8, true);
            WriteAttributeValue(" ", 4092, "position:", 4093, 10, true);
            WriteAttributeValue(" ", 4102, "relative;", 4103, 10, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-8 col-md-offset-left-4 col-sm-8 col-md-offset-left-4\">\r\n                <div class=\"choose-content text-left\">\r\n                    <h2>");
#nullable restore
#line 108 "C:\Users\elgun\Desktop\EduHomeBackEndProject\EduHomeBackEndProject\Views\Home\Index.cshtml"
                   Write(Model.WhyYouChooseUss.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    ");
#nullable restore
#line 109 "C:\Users\elgun\Desktop\EduHomeBackEndProject\EduHomeBackEndProject\Views\Home\Index.cshtml"
               Write(Html.Raw(Model.WhyYouChooseUss.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    <a class=""default-btn"" href=""course-details.html"">view courses</a>
                </div>
            </div>
        </div>
    </div>
</section>

<!-- Courses Area Start -->
<div class=""courses-area pt-150 text-center"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""section-title"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4c9959065a8cd49b0a1fcbbaf404b554b632f33816751", async() => {
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
            WriteLiteral("\r\n                    <h2>COURSES WE OFFER</h2>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row coursecard\">\r\n            ");
#nullable restore
#line 129 "C:\Users\elgun\Desktop\EduHomeBackEndProject\EduHomeBackEndProject\Views\Home\Index.cshtml"
       Write(await Component.InvokeAsync("Course", 3));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>
</div>
<!-- Courses Area End -->
<!-- Event Area Start -->
<div class=""event-area one text-center pt-140 pb-150"" style=""padding-top: 70px !important"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""section-title"">
                    <img src=""img/icon/section.png"" alt=""section-title"">
                    <h2>UPCOMMING EVENTS</h2>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-6 col-sm-12 col-xs-12"">
                ");
#nullable restore
#line 147 "C:\Users\elgun\Desktop\EduHomeBackEndProject\EduHomeBackEndProject\Views\Home\Index.cshtml"
           Write(await Component.InvokeAsync("Event", 4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-6 hidden-sm hidden-xs\">\r\n                ");
#nullable restore
#line 150 "C:\Users\elgun\Desktop\EduHomeBackEndProject\EduHomeBackEndProject\Views\Home\Index.cshtml"
           Write(await Component.InvokeAsync("Event", 4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Event Area End -->\r\n<!-- Testimonial Area Start -->\r\n<div class=\"testimonial-area pt-110 pb-105 text-center\"");
            BeginWriteAttribute("style", " style=\"", 6050, "\"", 6320, 15);
            WriteAttributeValue(" ", 6058, "background:", 6059, 12, true);
            WriteAttributeValue(" ", 6070, "url(~/../img/testimonial/", 6071, 26, true);
#nullable restore
#line 157 "C:\Users\elgun\Desktop\EduHomeBackEndProject\EduHomeBackEndProject\Views\Home\Index.cshtml"
WriteAttributeValue("\r\n", 6096, Model.Testimonials.backGroundImage, 6098, 35, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6133, ");", 6133, 2, true);
            WriteAttributeValue("\r\n        ", 6135, "background-size:", 6145, 26, true);
            WriteAttributeValue(" ", 6161, "cover;", 6162, 7, true);
            WriteAttributeValue("\r\n        ", 6168, "background-repeat:", 6178, 28, true);
            WriteAttributeValue(" ", 6196, "no-repeat;", 6197, 11, true);
            WriteAttributeValue("\r\n        ", 6207, "background-position:", 6217, 30, true);
            WriteAttributeValue(" ", 6237, "center", 6238, 7, true);
            WriteAttributeValue(" ", 6244, "center;", 6245, 8, true);
            WriteAttributeValue("\r\n        ", 6252, "background-attachment:", 6262, 32, true);
            WriteAttributeValue(" ", 6284, "fixed;", 6285, 7, true);
            WriteAttributeValue("\r\n        ", 6291, "position:", 6301, 19, true);
            WriteAttributeValue(" ", 6310, "relative;", 6311, 10, true);
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""container"">
        <div class=""row"">
            <div class=""testimonial-owl owl-theme owl-carousel"">
                <div class=""col-md-8 col-md-offset-2 col-sm-12"">
                    <div class=""single-testimonial"">
                        <div class=""testimonial-info"">
                            <div class=""testimonial-img"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4c9959065a8cd49b0a1fcbbaf404b554b632f33821675", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6723, "~/../img/testimonial/", 6723, 21, true);
#nullable restore
#line 171 "C:\Users\elgun\Desktop\EduHomeBackEndProject\EduHomeBackEndProject\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 6744, Model.Testimonials.Image, 6744, 25, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"testimonial-content\">\r\n                                <p>");
#nullable restore
#line 174 "C:\Users\elgun\Desktop\EduHomeBackEndProject\EduHomeBackEndProject\Views\Home\Index.cshtml"
                              Write(Model.Testimonials.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <h4>");
#nullable restore
#line 175 "C:\Users\elgun\Desktop\EduHomeBackEndProject\EduHomeBackEndProject\Views\Home\Index.cshtml"
                               Write(Model.Testimonials.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <h5>");
#nullable restore
#line 176 "C:\Users\elgun\Desktop\EduHomeBackEndProject\EduHomeBackEndProject\Views\Home\Index.cshtml"
                               Write(Model.Testimonials.Job);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 176 "C:\Users\elgun\Desktop\EduHomeBackEndProject\EduHomeBackEndProject\Views\Home\Index.cshtml"
                                                        Write(Model.Testimonials.nameOfLesson);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Testimonial Area End -->");
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
