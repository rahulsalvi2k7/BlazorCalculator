#pragma checksum "D:\Study\git\rahulsalvi2k7\BlazorCalculator\BlazorCalculator\BlazorCalculator.Server\Components\Button0.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "511ebac677ba2baa24a0fced2c16886251a660f9"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCalculator.Server.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Study\git\rahulsalvi2k7\BlazorCalculator\BlazorCalculator\BlazorCalculator.Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Study\git\rahulsalvi2k7\BlazorCalculator\BlazorCalculator\BlazorCalculator.Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Study\git\rahulsalvi2k7\BlazorCalculator\BlazorCalculator\BlazorCalculator.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Study\git\rahulsalvi2k7\BlazorCalculator\BlazorCalculator\BlazorCalculator.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Study\git\rahulsalvi2k7\BlazorCalculator\BlazorCalculator\BlazorCalculator.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Study\git\rahulsalvi2k7\BlazorCalculator\BlazorCalculator\BlazorCalculator.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Study\git\rahulsalvi2k7\BlazorCalculator\BlazorCalculator\BlazorCalculator.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Study\git\rahulsalvi2k7\BlazorCalculator\BlazorCalculator\BlazorCalculator.Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Study\git\rahulsalvi2k7\BlazorCalculator\BlazorCalculator\BlazorCalculator.Server\_Imports.razor"
using BlazorCalculator.Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Study\git\rahulsalvi2k7\BlazorCalculator\BlazorCalculator\BlazorCalculator.Server\_Imports.razor"
using BlazorCalculator.Server.Shared;

#line default
#line hidden
#nullable disable
    public partial class Button0 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "btn btn-default btn-block  btn-number");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 1 "D:\Study\git\rahulsalvi2k7\BlazorCalculator\BlazorCalculator\BlazorCalculator.Server\Components\Button0.razor"
                                                             clickZero

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(3, "0");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "D:\Study\git\rahulsalvi2k7\BlazorCalculator\BlazorCalculator\BlazorCalculator.Server\Components\Button0.razor"
       
    private async Task clickZero(EventArgs e)
    {
        var i = e;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
