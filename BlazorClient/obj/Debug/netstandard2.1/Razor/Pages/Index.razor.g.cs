#pragma checksum "C:\Users\Bryce\source\repos\Assignment2\BlazorClient\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c83d62e6461f1bfbbdecec65b58f5bfbaaea5508"
// <auto-generated/>
#pragma warning disable 1591
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
using SpeakerClass;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Speakers</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>Created by Bryce Courneya and Perry Li</p>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Bryce\source\repos\Assignment2\BlazorClient\Pages\Index.razor"
 if (speakers == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 12 "C:\Users\Bryce\source\repos\Assignment2\BlazorClient\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\Bryce\source\repos\Assignment2\BlazorClient\Pages\Index.razor"
                       Add

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "class", "btn btn-success");
            __builder.AddContent(8, "Add");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    <br>\r\n");
            __builder.AddContent(10, "    ");
            __builder.OpenElement(11, "table");
            __builder.AddAttribute(12, "class", "table table-hover");
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.AddMarkupContent(14, "<thead>\r\n            <tr>\r\n                <th>Name</th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(15, "tbody");
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 26 "C:\Users\Bryce\source\repos\Assignment2\BlazorClient\Pages\Index.razor"
             foreach (var item in speakers)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "                ");
            __builder.OpenElement(18, "tr");
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 29 "C:\Users\Bryce\source\repos\Assignment2\BlazorClient\Pages\Index.razor"
                         item.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(22, " ");
            __builder.AddContent(23, 
#nullable restore
#line 29 "C:\Users\Bryce\source\repos\Assignment2\BlazorClient\Pages\Index.razor"
                                         item.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "td");
            __builder.OpenElement(26, "a");
            __builder.AddAttribute(27, "class", "btn btn-success btn-sm");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\Bryce\source\repos\Assignment2\BlazorClient\Pages\Index.razor"
                                                                      () => Edit(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(29, "Edit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.OpenElement(31, "td");
            __builder.OpenElement(32, "a");
            __builder.AddAttribute(33, "class", "btn btn-danger btn-sm");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\Bryce\source\repos\Assignment2\BlazorClient\Pages\Index.razor"
                                                                     () => Delete(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(35, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 33 "C:\Users\Bryce\source\repos\Assignment2\BlazorClient\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 36 "C:\Users\Bryce\source\repos\Assignment2\BlazorClient\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\Bryce\source\repos\Assignment2\BlazorClient\Pages\Index.razor"
       
    Speaker[] speakers;
    string baseUrl = "https://localhost:44377/";

    protected override async Task OnInitializedAsync()
    {
        await load();
    }

    protected async Task load()
    {
        speakers = await httpClient.GetJsonAsync<Speaker[]>($"{baseUrl}api/speakers");
    }

    protected void Edit(Speaker speaker)
    {
        navigationManager.NavigateTo($"/edit/{speaker.SpeakerId}");
    }

    protected void Delete(Speaker speaker)
    {
        navigationManager.NavigateTo($"/delete/{speaker.SpeakerId}");
    }
    protected void Add()
    {
        navigationManager.NavigateTo($"/create");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
#pragma warning restore 1591
