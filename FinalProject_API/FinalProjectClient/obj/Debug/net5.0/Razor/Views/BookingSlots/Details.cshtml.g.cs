#pragma checksum "C:\Users\Phong\Desktop\COMP306\Week 10\FinalProject\FinalProjectClient\Views\BookingSlots\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "749486dc166febdc1f374ec1adf99d48060b7eab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BookingSlots_Details), @"mvc.1.0.view", @"/Views/BookingSlots/Details.cshtml")]
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
#line 1 "C:\Users\Phong\Desktop\COMP306\Week 10\FinalProject\FinalProjectClient\Views\_ViewImports.cshtml"
using FinalProjectClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Phong\Desktop\COMP306\Week 10\FinalProject\FinalProjectClient\Views\_ViewImports.cshtml"
using FinalProjectClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"749486dc166febdc1f374ec1adf99d48060b7eab", @"/Views/BookingSlots/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9347879a72d1916cc611caaf4ed400a86c9f6c2", @"/Views/_ViewImports.cshtml")]
    public class Views_BookingSlots_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FinalProjectLibrary.Models.BookingSlot>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Phong\Desktop\COMP306\Week 10\FinalProject\FinalProjectClient\Views\BookingSlots\Details.cshtml"
  
    ViewData["Title"] = "Booking Slot Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Booking Slot Details</h2>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 13 "C:\Users\Phong\Desktop\COMP306\Week 10\FinalProject\FinalProjectClient\Views\BookingSlots\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BookingSlotId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 16 "C:\Users\Phong\Desktop\COMP306\Week 10\FinalProject\FinalProjectClient\Views\BookingSlots\Details.cshtml"
       Write(Html.DisplayFor(model => model.BookingSlotId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 19 "C:\Users\Phong\Desktop\COMP306\Week 10\FinalProject\FinalProjectClient\Views\BookingSlots\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SlotTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 22 "C:\Users\Phong\Desktop\COMP306\Week 10\FinalProject\FinalProjectClient\Views\BookingSlots\Details.cshtml"
       Write(Html.DisplayFor(model => model.SlotTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 25 "C:\Users\Phong\Desktop\COMP306\Week 10\FinalProject\FinalProjectClient\Views\BookingSlots\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Restaurant.RestaurantName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 28 "C:\Users\Phong\Desktop\COMP306\Week 10\FinalProject\FinalProjectClient\Views\BookingSlots\Details.cshtml"
       Write(Html.DisplayFor(model => model.Restaurant.RestaurantName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 32 "C:\Users\Phong\Desktop\COMP306\Week 10\FinalProject\FinalProjectClient\Views\BookingSlots\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Bookings));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dt>
        <dd>
            <table class=""table"">
                <thead>
                    <tr>
                        <th>
                            Booking Id
                        </th>
                        <th>
                            Number of Seats
                        </th>
                        <th>
                            Booked By
                        </th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 51 "C:\Users\Phong\Desktop\COMP306\Week 10\FinalProject\FinalProjectClient\Views\BookingSlots\Details.cshtml"
                     foreach (var item in Model.Bookings)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 55 "C:\Users\Phong\Desktop\COMP306\Week 10\FinalProject\FinalProjectClient\Views\BookingSlots\Details.cshtml"
                           Write(Html.DisplayFor(modelItem => item.BookingId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 58 "C:\Users\Phong\Desktop\COMP306\Week 10\FinalProject\FinalProjectClient\Views\BookingSlots\Details.cshtml"
                           Write(Html.DisplayFor(modelItem => item.NumberOfSeats));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 61 "C:\Users\Phong\Desktop\COMP306\Week 10\FinalProject\FinalProjectClient\Views\BookingSlots\Details.cshtml"
                           Write(Html.DisplayFor(modelItem => item.User.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 64 "C:\Users\Phong\Desktop\COMP306\Week 10\FinalProject\FinalProjectClient\Views\BookingSlots\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "749486dc166febdc1f374ec1adf99d48060b7eab8661", async() => {
                WriteLiteral("Back to Booking Slots List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FinalProjectLibrary.Models.BookingSlot> Html { get; private set; }
    }
}
#pragma warning restore 1591
