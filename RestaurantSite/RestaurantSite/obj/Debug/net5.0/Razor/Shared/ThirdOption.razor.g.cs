#pragma checksum "D:\MyProjects\VisualStudio Projects\RestaurantSite\RestaurantSite\Shared\ThirdOption.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23c725404531fe324328af2f8178a78a1ae4348b"
// <auto-generated/>
#pragma warning disable 1591
namespace RestaurantSite.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\MyProjects\VisualStudio Projects\RestaurantSite\RestaurantSite\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MyProjects\VisualStudio Projects\RestaurantSite\RestaurantSite\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\MyProjects\VisualStudio Projects\RestaurantSite\RestaurantSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\MyProjects\VisualStudio Projects\RestaurantSite\RestaurantSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\MyProjects\VisualStudio Projects\RestaurantSite\RestaurantSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\MyProjects\VisualStudio Projects\RestaurantSite\RestaurantSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\MyProjects\VisualStudio Projects\RestaurantSite\RestaurantSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\MyProjects\VisualStudio Projects\RestaurantSite\RestaurantSite\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\MyProjects\VisualStudio Projects\RestaurantSite\RestaurantSite\_Imports.razor"
using RestaurantSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\MyProjects\VisualStudio Projects\RestaurantSite\RestaurantSite\_Imports.razor"
using RestaurantSite.Shared;

#line default
#line hidden
#nullable disable
    public partial class ThirdOption : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "third-option");
            __builder.AddAttribute(2, "b-vp0bgovq2h");
            __builder.OpenElement(3, "p");
            __builder.AddAttribute(4, "id", "one");
            __builder.AddAttribute(5, "b-vp0bgovq2h");
            __builder.AddContent(6, 
#nullable restore
#line 2 "D:\MyProjects\VisualStudio Projects\RestaurantSite\RestaurantSite\Shared\ThirdOption.razor"
                 IconString

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "p");
            __builder.AddAttribute(9, "id", "two");
            __builder.AddAttribute(10, "b-vp0bgovq2h");
            __builder.AddContent(11, 
#nullable restore
#line 3 "D:\MyProjects\VisualStudio Projects\RestaurantSite\RestaurantSite\Shared\ThirdOption.razor"
                 Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "p");
            __builder.AddAttribute(14, "id", "three");
            __builder.AddAttribute(15, "b-vp0bgovq2h");
            __builder.AddContent(16, 
#nullable restore
#line 4 "D:\MyProjects\VisualStudio Projects\RestaurantSite\RestaurantSite\Shared\ThirdOption.razor"
                   Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "D:\MyProjects\VisualStudio Projects\RestaurantSite\RestaurantSite\Shared\ThirdOption.razor"
       
    [Parameter]
    public string IconString { get; set; }
    [Parameter]
    public string Name { get; set; }
    [Parameter]
    public string Description { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
