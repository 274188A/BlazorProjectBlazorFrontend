#pragma checksum "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b988c04ee53ab582b350b9d3d4adbb0191a32e9e"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorProjectBlazor.Shared
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
#line 1 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Shared\NavMenu.razor"
using Northwİnd.Blazor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Shared\NavMenu.razor"
using Northwİnd.Blazor.Services.Abstract;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Shared\NavMenu.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar navbar-expand-lg");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(6);
            __builder.AddAttribute(7, "href", "/");
            __builder.AddAttribute(8, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 10 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Shared\NavMenu.razor"
                                 NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "class", "navbar-brand home");
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(11, "<img src=\"img/logo.png\" alt=\"Obaju logo\" class=\"d-none d-md-inline-block\"><img src=\"img/logo-small.png\" alt=\"Obaju logo\" class=\"d-inline-block d-md-none\">");
                __builder2.AddMarkupContent(12, "<span class=\"sr-only\">Obaju - go to homepage</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.AddMarkupContent(14, @"<div class=""navbar-buttons"">
            <button type=""button"" data-toggle=""collapse"" data-target=""#navigation"" class=""btn btn-outline-secondary navbar-toggler""><span class=""sr-only"">Toggle navigation</span><i class=""fa fa-align-justify""></i></button>

            <button type=""button"" data-toggle=""collapse"" data-target=""#search"" class=""btn btn-outline-secondary navbar-toggler""><span class=""sr-only"">Toggle search</span><i class=""fa fa-search""></i></button>
            
            <a href=""basket.html"" class=""btn btn-outline-secondary navbar-toggler""><i class=""fa fa-shopping-cart""></i></a>
        </div>
        ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "id", "navigation");
            __builder.AddAttribute(17, "class", "collapse navbar-collapse");
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "ul");
            __builder.AddAttribute(20, "class", "navbar-nav mr-auto");
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "li");
            __builder.AddAttribute(23, "class", "nav-item");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(24);
            __builder.AddAttribute(25, "class", "nav-link");
            __builder.AddAttribute(26, "href", "/");
            __builder.AddAttribute(27, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 20 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Shared\NavMenu.razor"
                                                                               NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(29, "Home");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
#nullable restore
#line 21 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Shared\NavMenu.razor"
                 if (categoryModels != null)
                {
                    foreach (var category in categoryModels)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "                        ");
            __builder.OpenElement(32, "li");
            __builder.AddAttribute(33, "class", "nav-item");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(34);
            __builder.AddAttribute(35, "class", "nav-link");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Shared\NavMenu.razor"
                                                                                   ()=>NavigateToProducts(category.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(38, 
#nullable restore
#line 25 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Shared\NavMenu.razor"
                                                                                                                          category.Name

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 26 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Shared\NavMenu.razor"
                    }
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, "                ");
            __builder.OpenElement(41, "li");
            __builder.AddAttribute(42, "class", "nav-item");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(43);
            __builder.AddAttribute(44, "class", "nav-link");
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Shared\NavMenu.razor"
                                                                         NavigateToCustomerOrders

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(47, "Hesabım");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n\r\n            ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "navbar-buttons d-flex justify-content-end");
            __builder.AddMarkupContent(52, "\r\n                \r\n                \r\n                <div id=\"search-not-mobile\" class=\"navbar-collapse collapse\"></div>");
            __builder.AddMarkupContent(53, "<a data-toggle=\"collapse\" href=\"#search\" class=\"btn navbar-btn btn-primary d-none d-lg-inline-block\"><span class=\"sr-only\">Toggle search</span><i class=\"fa fa-search\"></i></a>\r\n                ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "id", "basket-overview");
            __builder.AddAttribute(56, "class", "navbar-collapse collapse d-none d-lg-block");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(57);
            __builder.AddAttribute(58, "href", "/basket");
            __builder.AddAttribute(59, "class", "btn btn-primary navbar-btn");
            __builder.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(61, "<i class=\"fa fa-shopping-cart\"></i>");
                __builder2.AddMarkupContent(62, "<span>3 items in cart</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "id", "search");
            __builder.AddAttribute(70, "class", "collapse");
            __builder.AddMarkupContent(71, "\r\n    ");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "container");
            __builder.AddMarkupContent(74, "\r\n        ");
            __builder.OpenElement(75, "form");
            __builder.AddAttribute(76, "role", "search");
            __builder.AddAttribute(77, "class", "ml-auto");
            __builder.AddMarkupContent(78, "\r\n            ");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "input-group");
            __builder.AddMarkupContent(81, "\r\n                ");
            __builder.OpenComponent<MatBlazor.MatAutocompleteList<ProductModel>>(82);
            __builder.AddAttribute(83, "CustomStringSelector", new System.Func<ProductModel, System.String>(
#nullable restore
#line 44 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Shared\NavMenu.razor"
                                                                                  x=>x.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(84, "type", "text");
            __builder.AddAttribute(85, "placeholder", "Search");
            __builder.AddAttribute(86, "class", "form-control");
            __builder.AddAttribute(87, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<ProductModel>>(
#nullable restore
#line 44 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Shared\NavMenu.razor"
                                                                                                                                                            products

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(88, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ProductModel>(
#nullable restore
#line 44 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Shared\NavMenu.razor"
                                                                                                                                                                                    product

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(89, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ProductModel>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ProductModel>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product = __value, product))));
            __builder.AddAttribute(90, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(91, "\r\n                    ");
                __builder2.OpenElement(92, "div");
                __builder2.AddAttribute(93, "style", "display: flex; flex-direction: row; width: 100%;");
                __builder2.AddMarkupContent(94, "\r\n                        ");
                __builder2.OpenElement(95, "div");
                __builder2.AddAttribute(96, "style", "flex: 1;");
                __builder2.AddContent(97, 
#nullable restore
#line 46 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Shared\NavMenu.razor"
                                               product.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "                        \r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(100, "                \r\n\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(101);
            __builder.AddAttribute(102, "class", "btn btn-primary");
            __builder.AddAttribute(103, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Shared\NavMenu.razor"
                                                               NavigateToProductDetail

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(104, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(105, "<i class=\"fa fa-search\"></i>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(106, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Shared\NavMenu.razor"
       
    List<CategoryModel> categoryModels;
    List<ProductModel> products;
    ProductModel product;
    protected override async Task OnInitializedAsync()
    {
        product = null;
        categoryModels = await CategoryService.GetCategories();
        products = await ProductService.GetAll();
    }
    void NavigateToProductDetail()
    {
        if (product!=null)
        {
            var id = product.Id;
            product = null;
            NavigationManager.NavigateTo("/productdetail/" + id);
        }

    }
    void NavigateToProducts(int categoryId)
    {
        NavigationManager.NavigateTo("/products/" + categoryId);
    }
    void NavigateToCustomerOrders()
    {
        NavigationManager.NavigateTo("/customerorders");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICategoryService CategoryService { get; set; }
    }
}
#pragma warning restore 1591