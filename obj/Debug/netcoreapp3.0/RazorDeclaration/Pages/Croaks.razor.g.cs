#pragma checksum "c:\Users\User\Documents\Developer\edu-croaker\Pages\Croaks.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa7169b02d0febeec247dad69d7c94e0f704e448"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace edu_croaker.Pages
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\User\Documents\Developer\edu-croaker\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\User\Documents\Developer\edu-croaker\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\User\Documents\Developer\edu-croaker\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\User\Documents\Developer\edu-croaker\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\User\Documents\Developer\edu-croaker\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\User\Documents\Developer\edu-croaker\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\User\Documents\Developer\edu-croaker\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\User\Documents\Developer\edu-croaker\_Imports.razor"
using edu_croaker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\User\Documents\Developer\edu-croaker\_Imports.razor"
using edu_croaker.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\User\Documents\Developer\edu-croaker\Pages\Croaks.razor"
using edu_croaker.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\User\Documents\Developer\edu-croaker\Pages\Croaks.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\User\Documents\Developer\edu-croaker\Pages\Croaks.razor"
using Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/croaks")]
    public class Croaks : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "c:\Users\User\Documents\Developer\edu-croaker\Pages\Croaks.razor"
       
    private IEnumerable<edu_croaker.Data.Croak> croaks = new List<edu_croaker.Data.Croak>();

    protected override async Task OnInitializedAsync()
    {
        CroakSrv.NotifyOnChange += OnNotifyChange;
        await FetchCroaks();
    }

    public async Task OnNotifyChange()
    {
        await FetchCroaks();
    }

    protected async Task FetchCroaks()
    {
        croaks = await CroakSrv.GetCroaksAsync();
        StateHasChanged();
    }

    public void Dispose()
    {
        CroakSrv.NotifyOnChange -= OnNotifyChange;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CroakService CroakSrv { get; set; }
    }
}
#pragma warning restore 1591
