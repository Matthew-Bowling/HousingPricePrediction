#pragma checksum "C:\Users\mbowling\Matthew Bowling Personal Dev\HousingPricePrediction\HousingPricePrediction\HousingPricePrediction\Views\HousingInformation\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5d6ebc5cf8a517062c77645f90d65697bc2fcf0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HousingInformation_Index), @"mvc.1.0.view", @"/Views/HousingInformation/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5d6ebc5cf8a517062c77645f90d65697bc2fcf0", @"/Views/HousingInformation/Index.cshtml")]
    public class Views_HousingInformation_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HousingPricePrediction.Models.HousingDataModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mbowling\Matthew Bowling Personal Dev\HousingPricePrediction\HousingPricePrediction\HousingPricePrediction\Views\HousingInformation\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Housing Price Prediction</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\mbowling\Matthew Bowling Personal Dev\HousingPricePrediction\HousingPricePrediction\HousingPricePrediction\Views\HousingInformation\Index.cshtml"
 using (Html.BeginForm("MakePrediction", "HousingInformation", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <p>Overall Quality</p>\r\n        ");
#nullable restore
#line 12 "C:\Users\mbowling\Matthew Bowling Personal Dev\HousingPricePrediction\HousingPricePrediction\HousingPricePrediction\Views\HousingInformation\Index.cshtml"
   Write(Html.TextBoxFor(model => model.OverallQuality));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 13 "C:\Users\mbowling\Matthew Bowling Personal Dev\HousingPricePrediction\HousingPricePrediction\HousingPricePrediction\Views\HousingInformation\Index.cshtml"
   Write(Html.ValidationMessageFor(model => model.OverallQuality));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        <p>Ground Living Area</p>\r\n        ");
#nullable restore
#line 17 "C:\Users\mbowling\Matthew Bowling Personal Dev\HousingPricePrediction\HousingPricePrediction\HousingPricePrediction\Views\HousingInformation\Index.cshtml"
   Write(Html.TextBoxFor(model => model.GroundLivingArea));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        <p>Number of Cars the Garage Fits</p>\r\n        ");
#nullable restore
#line 21 "C:\Users\mbowling\Matthew Bowling Personal Dev\HousingPricePrediction\HousingPricePrediction\HousingPricePrediction\Views\HousingInformation\Index.cshtml"
   Write(Html.TextBoxFor(model => model.GarageCars));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        <p>Garage Area Size</p>\r\n        ");
#nullable restore
#line 25 "C:\Users\mbowling\Matthew Bowling Personal Dev\HousingPricePrediction\HousingPricePrediction\HousingPricePrediction\Views\HousingInformation\Index.cshtml"
   Write(Html.TextBoxFor(model => model.GarageArea));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        <p>Total Basement SquareFootage</p>\r\n        ");
#nullable restore
#line 29 "C:\Users\mbowling\Matthew Bowling Personal Dev\HousingPricePrediction\HousingPricePrediction\HousingPricePrediction\Views\HousingInformation\Index.cshtml"
   Write(Html.TextBoxFor(model => model.TotalBasementSquareFoot));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        <p>First Floor SquareFootage</p>\r\n        ");
#nullable restore
#line 33 "C:\Users\mbowling\Matthew Bowling Personal Dev\HousingPricePrediction\HousingPricePrediction\HousingPricePrediction\Views\HousingInformation\Index.cshtml"
   Write(Html.TextBoxFor(model => model.FirstFloorSquareFoot));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        <p>Number of FullBaths</p>\r\n        ");
#nullable restore
#line 37 "C:\Users\mbowling\Matthew Bowling Personal Dev\HousingPricePrediction\HousingPricePrediction\HousingPricePrediction\Views\HousingInformation\Index.cshtml"
   Write(Html.TextBoxFor(model => model.FullBath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        <p>Total Rooms Above Ground</p>\r\n        ");
#nullable restore
#line 41 "C:\Users\mbowling\Matthew Bowling Personal Dev\HousingPricePrediction\HousingPricePrediction\HousingPricePrediction\Views\HousingInformation\Index.cshtml"
   Write(Html.TextBoxFor(model => model.TotalRoomsAboveGround));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        <p>Year Built</p>\r\n        ");
#nullable restore
#line 45 "C:\Users\mbowling\Matthew Bowling Personal Dev\HousingPricePrediction\HousingPricePrediction\HousingPricePrediction\Views\HousingInformation\Index.cshtml"
   Write(Html.TextBoxFor(model => model.YearBuilt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <button type=\"submit\">Make Sale Price Prediction</button>\r\n");
#nullable restore
#line 49 "C:\Users\mbowling\Matthew Bowling Personal Dev\HousingPricePrediction\HousingPricePrediction\HousingPricePrediction\Views\HousingInformation\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HousingPricePrediction.Models.HousingDataModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
