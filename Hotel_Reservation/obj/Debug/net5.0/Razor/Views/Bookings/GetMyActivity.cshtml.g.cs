#pragma checksum "C:\Users\FreeComp\Desktop\New folder\Hotel Booking Task\Hotel_Reservation\Hotel_Reservation\Views\Bookings\GetMyActivity.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "734fcd1b6ff57daa86f8ec602a894863c9f5a249"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bookings_GetMyActivity), @"mvc.1.0.view", @"/Views/Bookings/GetMyActivity.cshtml")]
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
#line 1 "C:\Users\FreeComp\Desktop\New folder\Hotel Booking Task\Hotel_Reservation\Hotel_Reservation\Views\_ViewImports.cshtml"
using Hotel_Reservation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FreeComp\Desktop\New folder\Hotel Booking Task\Hotel_Reservation\Hotel_Reservation\Views\_ViewImports.cshtml"
using Hotel_Reservation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"734fcd1b6ff57daa86f8ec602a894863c9f5a249", @"/Views/Bookings/GetMyActivity.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"993f5814db3ac14ae0ea0e6f0d31251fd979cbdb", @"/Views/_ViewImports.cshtml")]
    public class Views_Bookings_GetMyActivity : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Booking>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Rooms", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("small text-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\FreeComp\Desktop\New folder\Hotel Booking Task\Hotel_Reservation\Hotel_Reservation\Views\Bookings\GetMyActivity.cshtml"
  
    ViewData["Title"] = "Reservation";
    Layout = "_MyLayout";
    var x = 0;
    var y = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
  <div class=""contact main-font-family text-center"">
            <div class=""container"">
                <br />
                <br />
                <br />
                <div class=""row"">
                    <div class=""col-6"">
                        <div class=""contact-form"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "734fcd1b6ff57daa86f8ec602a894863c9f5a2495774", async() => {
                WriteLiteral("\r\n                                <div class=\"container\">\r\n");
#nullable restore
#line 20 "C:\Users\FreeComp\Desktop\New folder\Hotel Booking Task\Hotel_Reservation\Hotel_Reservation\Views\Bookings\GetMyActivity.cshtml"
 foreach(var item in Model){

#line default
#line hidden
#nullable disable
                WriteLiteral("<div class=\"card\" style=\"width: 18rem;\">\r\n  <div class=\"card-body\">\r\n");
                WriteLiteral("    <h6 class=\"card-subtitle mb-2 text-muted\">");
#nullable restore
#line 24 "C:\Users\FreeComp\Desktop\New folder\Hotel Booking Task\Hotel_Reservation\Hotel_Reservation\Views\Bookings\GetMyActivity.cshtml"
                                           Write(item.RoomType.Type);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n");
#nullable restore
#line 25 "C:\Users\FreeComp\Desktop\New folder\Hotel Booking Task\Hotel_Reservation\Hotel_Reservation\Views\Bookings\GetMyActivity.cshtml"
     if(item.Status==null) {

#line default
#line hidden
#nullable disable
                WriteLiteral("<p style=\"color:yellow\">Status:\r\n    \r\n        <span>Wait</span>\r\n    \r\n    </p>\r\n");
#nullable restore
#line 31 "C:\Users\FreeComp\Desktop\New folder\Hotel Booking Task\Hotel_Reservation\Hotel_Reservation\Views\Bookings\GetMyActivity.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 31 "C:\Users\FreeComp\Desktop\New folder\Hotel Booking Task\Hotel_Reservation\Hotel_Reservation\Views\Bookings\GetMyActivity.cshtml"
       if(item.Status==1) {

#line default
#line hidden
#nullable disable
                WriteLiteral("<p style=\"color:green\">Status:\r\n    \r\n        <span style=\"color:green\">accept</span>\r\n        <h6 style=\"color:green\">Room Number : ");
#nullable restore
#line 35 "C:\Users\FreeComp\Desktop\New folder\Hotel Booking Task\Hotel_Reservation\Hotel_Reservation\Views\Bookings\GetMyActivity.cshtml"
                                         Write(item.RoomId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n    \r\n");
#nullable restore
#line 37 "C:\Users\FreeComp\Desktop\New folder\Hotel Booking Task\Hotel_Reservation\Hotel_Reservation\Views\Bookings\GetMyActivity.cshtml"
          double l=  ( @item.To -@item.From).TotalDays;
          double p=  @item.RoomType.price;
             double total=l*p;

#line default
#line hidden
#nullable disable
                WriteLiteral("               <h6 style=\"color:green\">Cost : ");
#nullable restore
#line 40 "C:\Users\FreeComp\Desktop\New folder\Hotel Booking Task\Hotel_Reservation\Hotel_Reservation\Views\Bookings\GetMyActivity.cshtml"
                                         Write(total);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </h6>\r\n\r\n\r\n    \r\n    </p>\r\n");
#nullable restore
#line 45 "C:\Users\FreeComp\Desktop\New folder\Hotel Booking Task\Hotel_Reservation\Hotel_Reservation\Views\Bookings\GetMyActivity.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 45 "C:\Users\FreeComp\Desktop\New folder\Hotel Booking Task\Hotel_Reservation\Hotel_Reservation\Views\Bookings\GetMyActivity.cshtml"
       if(item.Status==0) {

#line default
#line hidden
#nullable disable
                WriteLiteral("<p style=\"color:red\">Status:\r\n    \r\n        <span>Refuse</span>\r\n    \r\n    </p>\r\n");
#nullable restore
#line 51 "C:\Users\FreeComp\Desktop\New folder\Hotel Booking Task\Hotel_Reservation\Hotel_Reservation\Views\Bookings\GetMyActivity.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("  </div>\r\n</div>\r\n");
#nullable restore
#line 54 "C:\Users\FreeComp\Desktop\New folder\Hotel Booking Task\Hotel_Reservation\Hotel_Reservation\Views\Bookings\GetMyActivity.cshtml"
}

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                            <div >\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "734fcd1b6ff57daa86f8ec602a894863c9f5a24911604", async() => {
                WriteLiteral("Back to Home Page");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            
                            

                        </div>
                    </div>
                 
                    <div class=""col-6"">
                        <h2 class=""text-right"">Reservations</h2>
                        <img src=""/imgs/shape.png"">
                        
                    </div>
                </div>
            </div>
            <div></div>
        </div>
      
        
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 79 "C:\Users\FreeComp\Desktop\New folder\Hotel Booking Task\Hotel_Reservation\Hotel_Reservation\Views\Bookings\GetMyActivity.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n   ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Booking>> Html { get; private set; }
    }
}
#pragma warning restore 1591
