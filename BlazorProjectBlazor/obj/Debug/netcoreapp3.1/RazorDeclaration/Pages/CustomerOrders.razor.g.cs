#pragma checksum "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\CustomerOrders.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c41e1937c838c0534bacd3954a2587713b23f6a"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorProjectBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\_Imports.razor"
using BlazorProjectBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\_Imports.razor"
using BlazorProjectBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\_Imports.razor"
using Northwİnd.Blazor.Utilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\_Imports.razor"
using BlazorProjectBlazor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\_Imports.razor"
using BlazorProjectBlazor.Services.Abstract;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\CustomerOrders.razor"
using Northwİnd.Blazor.Services.Abstract;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\CustomerOrders.razor"
using Northwİnd.Blazor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\CustomerOrders.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/customerorders")]
    public partial class CustomerOrders : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\CustomerOrders.razor"
      
    List<OrdersByUserIdResultDto> ordersByUserIdResultDtos;

    protected override async Task OnInitializedAsync()
    {
        var userId = await sessionStorage.GetItemAsync<long>("loginUserId");
        ordersByUserIdResultDtos = await OrderService.GetOrdersByUserId(userId);
    }
    private void NavigateToCustomerOrder(int orderId)
    {
        NavigationManager.NavigateTo("/CustomerOrder/" + orderId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOrderService OrderService { get; set; }
    }
}
#pragma warning restore 1591
