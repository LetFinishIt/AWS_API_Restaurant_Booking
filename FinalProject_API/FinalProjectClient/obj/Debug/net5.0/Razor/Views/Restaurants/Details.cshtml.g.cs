#pragma checksum "C:\Users\Phong\Desktop\COMP306\Week 10\FinalProject\FinalProjectClient\Views\Restaurants\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd8f54dccb570f1f02f1ca08ef0a0ba405ab32d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurants_Details), @"mvc.1.0.view", @"/Views/Restaurants/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd8f54dccb570f1f02f1ca08ef0a0ba405ab32d8", @"/Views/Restaurants/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9347879a72d1916cc611caaf4ed400a86c9f6c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Restaurants_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FinalProjectLibrary.Models.Restaurant>
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
#line 3 "C:\Users\Phong\Desktop\COMP306\Week 10\FinalProject\FinalProjectClient\Views\Restaurants\Details.cshtml"
  
    ViewData["Title"] = "Restaurant Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Restaurant Details</h2>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 13 "C:\Users\Phong\Desktop\COMP306\Week 10\FinalProject\FinalProjectClient\Views\Restaurants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RestaurantId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 16 "C:\Users\Phong\Desktop\COMP306\Week 10\FinalProject\FinalProjectClient\Views\Restaurants\Details.cshtml"
       Write(Html.DisplayFor(model => model.RestaurantId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 19 "C:\Users\Phong\Desktop\COMP306\Week 10\FinalProject\FinalProjectClient\Views\Restaurants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RestaurantName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 22 "C:\Users\Phong\Desktop\COMP306\Week 10\FinalProject\FinalProjectClient\Views\Restaurants\Details.cshtml"
       Write(Html.DisplayFor(model => model.RestaurantName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 25 "C:\Users\Phong\Desktop\COMP306\Week 10\FinalProject\FinalProjectClient\Views\Restaurants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RestaurantAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 28 "C:\Users\Phong\Desktop\COMP306\Week 10\FinalProject\FinalProjectClient\Views\Restaurants\Details.cshtml"
       Write(Html.DisplayFor(model => model.RestaurantAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 31 "C:\Users\Phong\Desktop\COMP306\Week 10\FinalProject\FinalProjectClient\Views\Restaurants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RestaurantCity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 34 "C:\Users\Phong\Desktop\COMP306\Week 10\FinalProject\FinalProjectClient\Views\Restaurants\Details.cshtml"
       Write(Html.DisplayFor(model => model.RestaurantCity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 37 "C:\Users\Phong\Desktop\COMP306\Week 10\FinalProject\FinalProjectClient\Views\Restaurants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CuisineType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 40 "C:\Users\Phong\Desktop\COMP306\Week 10\FinalProject\FinalProjectClient\Views\Restaurants\Details.cshtml"
       Write(Html.DisplayFor(model => model.CuisineType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Owner User Email\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 46 "C:\Users\Phong\Desktop\COMP306\Week 10\FinalProject\FinalProjectClient\Views\Restaurants\Details.cshtml"
       Write(Html.DisplayFor(model => model.OwnerUser.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 50 "C:\Users\Phong\Desktop\COMP306\Week 10\FinalProject\FinalProjectClient\Views\Restaurants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BookingSlots));

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
                            Booking Slot Id
                        </th>
                        <th>
                            Slot Time
                        </th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 66 "C:\Users\Phong\Desktop\COMP306\Week 10\FinalProject\FinalProjectClient\Views\Restaurants\Details.cshtml"
                     foreach (var item in Model.BookingSlots)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 70 "C:\Users\Phong\Desktop\COMP306\Week 10\FinalProject\FinalProjectClient\Views\Restaurants\Details.cshtml"
                           Write(Html.DisplayFor(modelItem => item.BookingSlotId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 73 "C:\Users\Phong\Desktop\COMP306\Week 10\FinalProject\FinalProjectClient\Views\Restaurants\Details.cshtml"
                           Write(Html.DisplayFor(modelItem => item.SlotTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 76 "C:\Users\Phong\Desktop\COMP306\Week 10\FinalProject\FinalProjectClient\Views\Restaurants\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd8f54dccb570f1f02f1ca08ef0a0ba405ab32d89835", async() => {
                WriteLiteral("Back to Restaurants List");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FinalProjectLibrary.Models.Restaurant> Html { get; private set; }
    }
}
#pragma warning restore 1591
