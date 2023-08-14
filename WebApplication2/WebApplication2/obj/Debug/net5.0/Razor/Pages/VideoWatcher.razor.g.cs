#pragma checksum "D:\MyProjects\VisualStudio Projects\WebApplication2\WebApplication2\Pages\VideoWatcher.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a14d36cfdcded59e2a7952172aa5a70e1451df5"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\MyProjects\VisualStudio Projects\WebApplication2\WebApplication2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MyProjects\VisualStudio Projects\WebApplication2\WebApplication2\_Imports.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\MyProjects\VisualStudio Projects\WebApplication2\WebApplication2\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\MyProjects\VisualStudio Projects\WebApplication2\WebApplication2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\MyProjects\VisualStudio Projects\WebApplication2\WebApplication2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\MyProjects\VisualStudio Projects\WebApplication2\WebApplication2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\MyProjects\VisualStudio Projects\WebApplication2\WebApplication2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\MyProjects\VisualStudio Projects\WebApplication2\WebApplication2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\MyProjects\VisualStudio Projects\WebApplication2\WebApplication2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\MyProjects\VisualStudio Projects\WebApplication2\WebApplication2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\MyProjects\VisualStudio Projects\WebApplication2\WebApplication2\_Imports.razor"
using WebApplication2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\MyProjects\VisualStudio Projects\WebApplication2\WebApplication2\_Imports.razor"
using WebApplication2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\MyProjects\VisualStudio Projects\WebApplication2\WebApplication2\_Imports.razor"
using WebApplication2.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\MyProjects\VisualStudio Projects\WebApplication2\WebApplication2\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\MyProjects\VisualStudio Projects\WebApplication2\WebApplication2\_Imports.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\MyProjects\VisualStudio Projects\WebApplication2\WebApplication2\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\MyProjects\VisualStudio Projects\WebApplication2\WebApplication2\_Imports.razor"
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/videowatcher")]
    public partial class VideoWatcher : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "D:\MyProjects\VisualStudio Projects\WebApplication2\WebApplication2\Pages\VideoWatcher.razor"
 if (VideoId != "t")
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "iframe");
            __builder.AddAttribute(1, "width", "560");
            __builder.AddAttribute(2, "height", "315");
            __builder.AddAttribute(3, "src", "https://www.youtube.com/embed/" + (
#nullable restore
#line 8 "D:\MyProjects\VisualStudio Projects\WebApplication2\WebApplication2\Pages\VideoWatcher.razor"
                                                VideoId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "title", "YouTube video player");
            __builder.AddAttribute(5, "frameborder", "0");
            __builder.AddAttribute(6, "allow", "accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture");
            __builder.AddAttribute(7, "allowfullscreen");
            __builder.CloseElement();
#nullable restore
#line 14 "D:\MyProjects\VisualStudio Projects\WebApplication2\WebApplication2\Pages\VideoWatcher.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "<video width=\"700\" height=\"500\" controls><source src=\"D:\\MyProjects\\VisualStudio Projects\\WebApplication2\\WebApplication2\\vid.mp4\" , type=\"video/mp4\"></video>");
#nullable restore
#line 20 "D:\MyProjects\VisualStudio Projects\WebApplication2\WebApplication2\Pages\VideoWatcher.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "D:\MyProjects\VisualStudio Projects\WebApplication2\WebApplication2\Pages\VideoWatcher.razor"
       
    public string VideoId { get; set; }


    public string VideoIdMethod()
    {
        var res = localStorage.GetAsync<string>("vidId");
        return res.Result.Value;
    }
    protected override async Task OnInitializedAsync()
    {
        var res = await localStorage.GetAsync<string>("vidId");
        VideoId = res.Value;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedLocalStorage localStorage { get; set; }
    }
}
#pragma warning restore 1591
