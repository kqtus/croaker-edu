#pragma checksum "c:\Users\User\Documents\Developer\edu-croaker\Components\WriteCroak.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d3458ace561d32bcb128634b195e9635c4c010c"
// <auto-generated/>
#pragma warning disable 1591
namespace Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
#line 1 "c:\Users\User\Documents\Developer\edu-croaker\Components\WriteCroak.razor"
using edu_croaker.Data;

#line default
#line hidden
#nullable disable
    public class WriteCroak : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "ckass", "input-group mb-3");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "text");
            __builder.AddAttribute(5, "class", "form-control");
            __builder.AddAttribute(6, "placeholder", "Gurgle here...");
            __builder.AddAttribute(7, "aria-describedby", "send-btn");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "c:\Users\User\Documents\Developer\edu-croaker\Components\WriteCroak.razor"
               NewCroakContent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NewCroakContent = __value, NewCroakContent));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "input-group-append");
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "class", "btn btn-outline-secondary");
            __builder.AddAttribute(16, "type", "button");
            __builder.AddAttribute(17, "id", "send-btn");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "c:\Users\User\Documents\Developer\edu-croaker\Components\WriteCroak.razor"
                      AddCroak

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(19, "Send\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "c:\Users\User\Documents\Developer\edu-croaker\Components\WriteCroak.razor"
       
    private string NewCroakContent { get; set; }

    private void AddCroak()
    {
        if (!string.IsNullOrWhiteSpace(NewCroakContent))
        {
            CroakSrv.AddCroakAsync(new edu_croaker.Data.Croak()
            {
                Title = "Another croak",
                Author = "Marek",
                Content = NewCroakContent,
                Shares = 0
            });
            NewCroakContent = string.Empty;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CroakService CroakSrv { get; set; }
    }
}
#pragma warning restore 1591
