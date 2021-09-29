#pragma checksum "D:\Tech\openautomobile\OASDWebApp\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcdf2a9876b9da5bddb582963faa27cca349937d"
// <auto-generated/>
#pragma warning disable 1591
namespace OASDWebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Tech\openautomobile\OASDWebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Tech\openautomobile\OASDWebApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Tech\openautomobile\OASDWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Tech\openautomobile\OASDWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Tech\openautomobile\OASDWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Tech\openautomobile\OASDWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Tech\openautomobile\OASDWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Tech\openautomobile\OASDWebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Tech\openautomobile\OASDWebApp\_Imports.razor"
using OASDWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Tech\openautomobile\OASDWebApp\_Imports.razor"
using OASDWebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Tech\openautomobile\OASDWebApp\_Imports.razor"
using OASDWebApp.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Open-source Automobile System Design</h1>\r\n<br>\r\n<br>\r\n");
            __builder.AddMarkupContent(1, "<h5>The Approach:</h5>\r\n<br>\r\n<br>\r\n");
            __builder.AddMarkupContent(2, @"<ol><li>
        The user input parameters are processed to generate the suggestions.
    </li>
    <li>
        The selected options in the suggestions are re-processed for detailed specifications.
    </li>
    <li>
        These detailed specifications can be helpful in validating for prototyping.
    </li></ol>
<br>
<br>
");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "class", "btn btn-primary");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "D:\Tech\openautomobile\OASDWebApp\Pages\Index.razor"
                                          DesignVehicle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(6, "Design my vehicle");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n<br>\r\n<br>\r\n");
            __builder.AddMarkupContent(8, "<h5>Sponsor us at <a href=\"https://github.com/sponsors/valstekt\">Valstekt - Github</a></h5>");
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "D:\Tech\openautomobile\OASDWebApp\Pages\Index.razor"
 
    private void DesignVehicle()
    {
        Nav.NavigateTo("/inputs");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Nav { get; set; }
    }
}
#pragma warning restore 1591
