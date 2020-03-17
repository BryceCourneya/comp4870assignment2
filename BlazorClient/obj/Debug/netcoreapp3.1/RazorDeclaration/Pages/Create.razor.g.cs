#pragma checksum "C:\Users\Bryce\source\repos\Assignment2\BlazorClient\Pages\Create.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee951e7e6e5718e20da8b44db0adb349b6a1deb4"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorClient.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Bryce\source\repos\Assignment2\BlazorClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bryce\source\repos\Assignment2\BlazorClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bryce\source\repos\Assignment2\BlazorClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Bryce\source\repos\Assignment2\BlazorClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Bryce\source\repos\Assignment2\BlazorClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Bryce\source\repos\Assignment2\BlazorClient\_Imports.razor"
using BlazorClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Bryce\source\repos\Assignment2\BlazorClient\_Imports.razor"
using BlazorClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Bryce\source\repos\Assignment2\BlazorClient\_Imports.razor"
using SpeakerAPI;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/create")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\Bryce\source\repos\Assignment2\BlazorClient\Pages\Create.razor"
       
    string baseUrl = "https://localhost:44377/";

    private Speaker speaker = new Speaker();

    private async void HandleAdd()
    {
        string endpoint = $"{baseUrl}api/speakers";

        speaker.SpeakerId = Guid.NewGuid().ToString();

        await httpClient.SendJsonAsync(HttpMethod.Post, endpoint, speaker);

        navigationManager.NavigateTo($"/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
#pragma warning restore 1591
