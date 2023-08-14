#pragma checksum "D:\MyProjects\VisualStudio Projects\WebApplication2\WebApplication2\Shared\VIdeoBtn.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4e3720136a470aa99aee1b04d6e0704be4c08c4"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication2.Shared
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
    public partial class VIdeoBtn : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "video-btn");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "D:\MyProjects\VisualStudio Projects\WebApplication2\WebApplication2\Shared\VIdeoBtn.razor"
                                 OnVideoClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "b-fbyu1frnye");
            __builder.OpenElement(4, "img");
            __builder.AddAttribute(5, "class", "video-thumbnail");
            __builder.AddAttribute(6, "src", "https://img.youtube.com/vi/" + (
#nullable restore
#line 6 "D:\MyProjects\VisualStudio Projects\WebApplication2\WebApplication2\Shared\VIdeoBtn.razor"
                                                                  VideoId

#line default
#line hidden
#nullable disable
            ) + "/sddefault.jpg");
            __builder.AddAttribute(7, "b-fbyu1frnye");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.AddMarkupContent(9, @"<div class=""video-des"" b-fbyu1frnye><div class=""avatar-container"" b-fbyu1frnye><img class=""channel-avatar"" src=""https://yt3.ggpht.com/5nry4-Zkk5cDoFd7tbd-n4ivth0ridfZAhYTAzLrOpsNx7Yn-Ai61NidnS1-sAqdlZKTvVvs8Rw=s68-c-k-c0x00ffffff-no-rj"" b-fbyu1frnye></div>
        <div class=""text-des"" b-fbyu1frnye><span class=""video-title"" b-fbyu1frnye>This is a video</span>
            <span class=""video-channel"" b-fbyu1frnye>Channel name</span></div></div>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "D:\MyProjects\VisualStudio Projects\WebApplication2\WebApplication2\Shared\VIdeoBtn.razor"
       
    [Parameter]
    public string VideoId { get; set; }

    private void OnVideoClick()
    {
        Console.Write(VideoId);
        localStorage.SetAsync("vidId", VideoId);
        navManager.NavigateTo($"videowatcher");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedLocalStorage localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
    }
}
#pragma warning restore 1591