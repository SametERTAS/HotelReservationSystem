#pragma checksum "C:\Users\samet\source\repos\HotelReservation\HotelService.WebUI\Views\Reservation\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb635a8b09b4912e72b1cf8be9547b0d9b0f4f76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservation_Index), @"mvc.1.0.view", @"/Views/Reservation/Index.cshtml")]
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
#line 1 "C:\Users\samet\source\repos\HotelReservation\HotelService.WebUI\Views\_ViewImports.cshtml"
using HotelService.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\samet\source\repos\HotelReservation\HotelService.WebUI\Views\_ViewImports.cshtml"
using HotelService.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\samet\source\repos\HotelReservation\HotelService.WebUI\Views\_ViewImports.cshtml"
using HotelService.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\samet\source\repos\HotelReservation\HotelService.WebUI\Views\_ViewImports.cshtml"
using HotelService.WebUI.ViewModels.City;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\samet\source\repos\HotelReservation\HotelService.WebUI\Views\_ViewImports.cshtml"
using HotelService.WebUI.ViewModels.Country;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\samet\source\repos\HotelReservation\HotelService.WebUI\Views\_ViewImports.cshtml"
using HotelService.WebUI.ViewModels.District;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\samet\source\repos\HotelReservation\HotelService.WebUI\Views\_ViewImports.cshtml"
using HotelService.WebUI.ViewModels.Hotel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\samet\source\repos\HotelReservation\HotelService.WebUI\Views\_ViewImports.cshtml"
using HotelService.WebUI.ViewModels.RoomType;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\samet\source\repos\HotelReservation\HotelService.WebUI\Views\_ViewImports.cshtml"
using HotelService.WebUI.ViewModels.Room;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\samet\source\repos\HotelReservation\HotelService.WebUI\Views\_ViewImports.cshtml"
using HotelService.WebUI.ViewModels.Document;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\samet\source\repos\HotelReservation\HotelService.WebUI\Views\_ViewImports.cshtml"
using HotelService.WebUI.ViewModels.Customer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\samet\source\repos\HotelReservation\HotelService.WebUI\Views\_ViewImports.cshtml"
using HotelService.WebUI.ViewModels.Reservation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\samet\source\repos\HotelReservation\HotelService.WebUI\Views\_ViewImports.cshtml"
using HotelService.WebUI.ViewModels.CustomerReservation;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb635a8b09b4912e72b1cf8be9547b0d9b0f4f76", @"/Views/Reservation/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f63c9ff3ba1fc104f8ec311bccbcb07bb819698b", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservation_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ReservationIndexVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb635a8b09b4912e72b1cf8be9547b0d9b0f4f767469", async() => {
                WriteLiteral("Create New Reservation");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>");
#nullable restore
#line 6 "C:\Users\samet\source\repos\HotelReservation\HotelService.WebUI\Views\Reservation\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RoomInfo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <th>");
#nullable restore
#line 7 "C:\Users\samet\source\repos\HotelReservation\HotelService.WebUI\Views\Reservation\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PersonCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <th>");
#nullable restore
#line 8 "C:\Users\samet\source\repos\HotelReservation\HotelService.WebUI\Views\Reservation\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CheckInDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <th>");
#nullable restore
#line 9 "C:\Users\samet\source\repos\HotelReservation\HotelService.WebUI\Views\Reservation\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CheckOutDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <th>");
#nullable restore
#line 10 "C:\Users\samet\source\repos\HotelReservation\HotelService.WebUI\Views\Reservation\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <th></th>\n\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 16 "C:\Users\samet\source\repos\HotelReservation\HotelService.WebUI\Views\Reservation\Index.cshtml"
         foreach (var reservation in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"gradeX\">\n                <td>");
#nullable restore
#line 19 "C:\Users\samet\source\repos\HotelReservation\HotelService.WebUI\Views\Reservation\Index.cshtml"
               Write(Html.DisplayFor(modelItem => reservation.RoomInfo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 20 "C:\Users\samet\source\repos\HotelReservation\HotelService.WebUI\Views\Reservation\Index.cshtml"
               Write(Html.DisplayFor(modelItem => reservation.PersonCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 21 "C:\Users\samet\source\repos\HotelReservation\HotelService.WebUI\Views\Reservation\Index.cshtml"
               Write(Html.DisplayFor(modelItem => reservation.CheckInDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 22 "C:\Users\samet\source\repos\HotelReservation\HotelService.WebUI\Views\Reservation\Index.cshtml"
               Write(Html.DisplayFor(modelItem => reservation.CheckOutDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 23 "C:\Users\samet\source\repos\HotelReservation\HotelService.WebUI\Views\Reservation\Index.cshtml"
               Write(Html.DisplayFor(modelItem => reservation.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb635a8b09b4912e72b1cf8be9547b0d9b0f4f7612208", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "C:\Users\samet\source\repos\HotelReservation\HotelService.WebUI\Views\Reservation\Index.cshtml"
                                                                    WriteLiteral(reservation.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb635a8b09b4912e72b1cf8be9547b0d9b0f4f7614510", async() => {
                WriteLiteral("Update");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "C:\Users\samet\source\repos\HotelReservation\HotelService.WebUI\Views\Reservation\Index.cshtml"
                                                                  WriteLiteral(reservation.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </td>\n            </tr>\n");
#nullable restore
#line 29 "C:\Users\samet\source\repos\HotelReservation\HotelService.WebUI\Views\Reservation\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n</table>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ReservationIndexVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
