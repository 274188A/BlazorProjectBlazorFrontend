#pragma checksum "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\Checkout4.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0257cf76abb3df2106dedd5f1ac7a4c1a364c02f"
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
#line 2 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\Checkout4.razor"
using Northwİnd.Blazor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\Checkout4.razor"
using Northwİnd.Blazor.Services.Abstract;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\Checkout4.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/checkout4")]
    public partial class Checkout4 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 124 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\Checkout4.razor"
      
    List<BasketModel> basketModels = new List<BasketModel>();
    OrderModel orderModel = new OrderModel();
    public decimal SubTotal { get; set; }
    public decimal Total { get; set; }
    protected override async Task OnInitializedAsync()
    {
        var result = await sessionStorage.GetItemAsync<OrderModel>("order");
        if (result != null)
        {
            orderModel = result;
        }

        basketModels = await sessionStorage.GetItemAsync<List<BasketModel>>("basket");
        SubTotal = await sessionStorage.GetItemAsync<decimal>("subtotal");
        Total = SubTotal + 10;

    }
    async Task ApplyOrder()
    {
        var loginUserId = await sessionStorage.GetItemAsync<long>("loginUserId");
        orderModel.Status = "Order was placed";
        orderModel.UserId = loginUserId;
        orderModel.Total = Total;

        await sessionStorage.SetItemAsync("order", orderModel);
        var orderId = await OrderService.Order();
        NavigationManager.NavigateTo("/customerorder/" + orderId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOrderService OrderService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICountryService CountryService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591
