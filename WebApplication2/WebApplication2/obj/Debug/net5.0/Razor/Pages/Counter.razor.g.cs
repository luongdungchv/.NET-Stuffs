#pragma checksum "D:\MyProjects\VisualStudio Projects\WebApplication2\WebApplication2\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bbef1239aa3aab83679cd88b3737b34d5172537"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "D:\MyProjects\VisualStudio Projects\WebApplication2\WebApplication2\Pages\Counter.razor"
                  loginInfo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 5 "D:\MyProjects\VisualStudio Projects\WebApplication2\WebApplication2\Pages\Counter.razor"
                                            HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(8);
                __builder2.AddAttribute(9, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "D:\MyProjects\VisualStudio Projects\WebApplication2\WebApplication2\Pages\Counter.razor"
                             loginInfo.Username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => loginInfo.Username = __value, loginInfo.Username))));
                __builder2.AddAttribute(11, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => loginInfo.Username));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n    ");
                __Blazor.WebApplication2.Pages.Counter.TypeInference.CreateValidationMessage_0(__builder2, 13, 14, 
#nullable restore
#line 9 "D:\MyProjects\VisualStudio Projects\WebApplication2\WebApplication2\Pages\Counter.razor"
                            () => loginInfo.Username

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(15, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "D:\MyProjects\VisualStudio Projects\WebApplication2\WebApplication2\Pages\Counter.razor"
                             loginInfo.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => loginInfo.Password = __value, loginInfo.Password))));
                __builder2.AddAttribute(19, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => loginInfo.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n    ");
                __Blazor.WebApplication2.Pages.Counter.TypeInference.CreateValidationMessage_1(__builder2, 21, 22, 
#nullable restore
#line 11 "D:\MyProjects\VisualStudio Projects\WebApplication2\WebApplication2\Pages\Counter.razor"
                            () => loginInfo.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(23, "\r\n    ");
                __builder2.AddMarkupContent(24, "<button type=\"submit\">Submit</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(25, "\r\n\r\n");
            __builder.OpenElement(26, "p");
            __builder.AddContent(27, 
#nullable restore
#line 15 "D:\MyProjects\VisualStudio Projects\WebApplication2\WebApplication2\Pages\Counter.razor"
    result

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "D:\MyProjects\VisualStudio Projects\WebApplication2\WebApplication2\Pages\Counter.razor"
       
    private LoginInfo loginInfo = new();
    private string result;
    private void HandleValidSubmit()
    {
        Console.Write("valid");
        var request = WebRequest.Create("https://localhost:1234/test/post") as HttpWebRequest;
        request.Method = "POST";
        request.ContentType = "application/json";
        using (var writer = new StreamWriter(request.GetRequestStream()))
        {
            var json = JsonConvert.SerializeObject(loginInfo);
            writer.Write(json);
        }
        var response = request.GetResponse() as HttpWebResponse;
        using (var reader = new StreamReader(response.GetResponseStream()))
        {
            result = reader.ReadToEnd();
            if (result == "failed") return;
            var resData = JsonConvert.DeserializeObject<UserAuth>(result);
            localStorage.SetAsync("uid", resData.uid);
            localStorage.SetAsync("token", resData.token);
            navManager.NavigateTo("test");
            Console.Write(result);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedLocalStorage localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
    }
}
namespace __Blazor.WebApplication2.Pages.Counter
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591