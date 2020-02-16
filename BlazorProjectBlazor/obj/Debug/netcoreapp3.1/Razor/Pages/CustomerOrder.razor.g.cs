#pragma checksum "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\CustomerOrder.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1373edde50ed2df5b38c533e1b6b19405235f8a"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\CustomerOrder.razor"
using Northwİnd.Blazor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\CustomerOrder.razor"
using Northwİnd.Blazor.Services.Abstract;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\CustomerOrder.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/customerorder/{OrderId:int}")]
    public partial class CustomerOrder : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, @"<div class=""col-lg-12"">
            
            <nav aria-label=""breadcrumb"">
                <ol class=""breadcrumb"">
                    <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                    <li aria-current=""page"" class=""breadcrumb-item""><a href=""#"">My orders</a></li>
                    <li aria-current=""page"" class=""breadcrumb-item active"">Order # 1735</li>
                </ol>
            </nav>
        </div>
        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-lg-3");
            __builder.AddMarkupContent(9, "\r\n            \r\n            ");
            __builder.OpenComponent<BlazorProjectBlazor.Shared.CustomerSection>(10);
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n            \r\n            \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "id", "customer-order");
            __builder.AddAttribute(15, "class", "col-lg-9");
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "box");
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 30 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\CustomerOrder.razor"
                 if (GetOrderDetailByIdResultDto != null)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "                    ");
            __builder.OpenElement(21, "h1");
            __builder.AddContent(22, "Order #");
            __builder.AddContent(23, 
#nullable restore
#line 32 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\CustomerOrder.razor"
                                OrderId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "p");
            __builder.AddAttribute(26, "class", "lead");
            __builder.AddContent(27, "Order #");
            __builder.AddContent(28, 
#nullable restore
#line 33 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\CustomerOrder.razor"
                                            OrderId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(29, " was placed on ");
            __builder.OpenElement(30, "strong");
            __builder.AddContent(31, 
#nullable restore
#line 33 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\CustomerOrder.razor"
                                                                           GetOrderDetailByIdResultDto.CreationTime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(32, " and is currently ");
            __builder.OpenElement(33, "strong");
            __builder.AddContent(34, 
#nullable restore
#line 33 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\CustomerOrder.razor"
                                                                                                                                                       GetOrderDetailByIdResultDto.Status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(35, ".");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.OpenElement(37, "p");
            __builder.AddAttribute(38, "class", "text-muted");
            __builder.AddContent(39, "If you have any questions, please feel free to ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(40);
            __builder.AddAttribute(41, "href", "contact");
            __builder.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(43, "contact us");
            }
            ));
            __builder.CloseComponent();
            __builder.AddContent(44, ", our customer service center is working for you 24/7.");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                    <hr>\r\n                    ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "table-responsive mb-4");
            __builder.AddMarkupContent(48, "\r\n                        ");
            __builder.OpenElement(49, "table");
            __builder.AddAttribute(50, "class", "table");
            __builder.AddMarkupContent(51, "\r\n                            ");
            __builder.AddMarkupContent(52, @"<thead>
                                <tr>
                                    <th colspan=""2"">Product</th>
                                    <th>Quantity</th>
                                    <th>Unit price</th>
                                    <th>Discount</th>
                                    <th>Total</th>
                                </tr>
                            </thead>
                            ");
            __builder.OpenElement(53, "tbody");
            __builder.AddMarkupContent(54, "\r\n");
#nullable restore
#line 48 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\CustomerOrder.razor"
                                 foreach (var product in productModels)
                                {
                                    decimal discountPrice = product.UnitPrice - (product.UnitPrice * ((decimal)product.Discount / 100));

#line default
#line hidden
#nullable disable
            __builder.AddContent(55, "                                    ");
            __builder.OpenElement(56, "tr");
            __builder.AddMarkupContent(57, "\r\n                                        ");
            __builder.OpenElement(58, "td");
            __builder.OpenElement(59, "a");
            __builder.AddAttribute(60, "href", "#");
            __builder.OpenElement(61, "img");
            __builder.AddAttribute(62, "src", 
#nullable restore
#line 52 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\CustomerOrder.razor"
                                                                   product.ImgUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(63, "alt", 
#nullable restore
#line 52 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\CustomerOrder.razor"
                                                                                         product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                                        ");
            __builder.OpenElement(65, "td");
            __builder.OpenElement(66, "a");
            __builder.AddAttribute(67, "href", "#");
            __builder.AddContent(68, 
#nullable restore
#line 53 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\CustomerOrder.razor"
                                                         product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                                        ");
            __builder.OpenElement(70, "td");
            __builder.AddContent(71, 
#nullable restore
#line 54 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\CustomerOrder.razor"
                                             GetOrderDetailByIdResultDto.OrderProducts.FirstOrDefault(x => x.ProductId == product.Id).Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                                        ");
            __builder.OpenElement(73, "td");
            __builder.AddContent(74, "$");
            __builder.AddContent(75, 
#nullable restore
#line 55 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\CustomerOrder.razor"
                                              product.UnitPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                                        ");
            __builder.OpenElement(77, "td");
            __builder.AddContent(78, 
#nullable restore
#line 56 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\CustomerOrder.razor"
                                             product.Discount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                                        ");
            __builder.OpenElement(80, "td");
            __builder.AddContent(81, "$");
            __builder.AddContent(82, 
#nullable restore
#line 57 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\CustomerOrder.razor"
                                               discountPrice * (decimal)GetOrderDetailByIdResultDto.OrderProducts.FirstOrDefault(x => x.ProductId == product.Id).Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n");
#nullable restore
#line 59 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\CustomerOrder.razor"

                                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(85, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                            ");
            __builder.OpenElement(87, "tfoot");
            __builder.AddMarkupContent(88, "\r\n                                ");
            __builder.OpenElement(89, "tr");
            __builder.AddMarkupContent(90, "\r\n                                    ");
            __builder.AddMarkupContent(91, "<th colspan=\"5\" class=\"text-right\">Order subtotal</th>\r\n                                    ");
            __builder.OpenElement(92, "th");
            __builder.AddContent(93, "$");
            __builder.AddContent(94, 
#nullable restore
#line 66 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\CustomerOrder.razor"
                                          SubTotal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n                                ");
            __builder.AddMarkupContent(97, "<tr>\r\n                                    <th colspan=\"5\" class=\"text-right\">Shipping and handling</th>\r\n                                    <th>$10.00</th>\r\n                                </tr>\r\n                                ");
            __builder.AddMarkupContent(98, "<tr>\r\n                                    <th colspan=\"5\" class=\"text-right\">Tax</th>\r\n                                    <th>$0.00</th>\r\n                                </tr>\r\n                                ");
            __builder.OpenElement(99, "tr");
            __builder.AddMarkupContent(100, "\r\n                                    ");
            __builder.AddMarkupContent(101, "<th colspan=\"5\" class=\"text-right\">Total</th>\r\n                                    ");
            __builder.OpenElement(102, "th");
            __builder.AddContent(103, "$");
            __builder.AddContent(104, 
#nullable restore
#line 78 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\CustomerOrder.razor"
                                          GetOrderDetailByIdResultDto.Total

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n                    \r\n                    ");
            __builder.OpenElement(110, "div");
            __builder.AddAttribute(111, "class", "row addresses");
            __builder.AddMarkupContent(112, "\r\n                        ");
            __builder.OpenElement(113, "div");
            __builder.AddAttribute(114, "class", "col-lg-6");
            __builder.AddMarkupContent(115, "\r\n                            ");
            __builder.AddMarkupContent(116, "<h2>Invoice address</h2>\r\n                            ");
            __builder.OpenElement(117, "p");
            __builder.AddContent(118, 
#nullable restore
#line 87 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\CustomerOrder.razor"
                                GetOrderDetailByIdResultDto.FullName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(119, "<br>");
            __builder.AddContent(120, 
#nullable restore
#line 87 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\CustomerOrder.razor"
                                                                         GetOrderDetailByIdResultDto.Address

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(121, " <br>");
            __builder.AddContent(122, 
#nullable restore
#line 87 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\CustomerOrder.razor"
                                                                                                                  GetOrderDetailByIdResultDto.CountryName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(123, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n                        ");
            __builder.OpenElement(126, "div");
            __builder.AddAttribute(127, "class", "col-lg-6");
            __builder.AddMarkupContent(128, "\r\n                            ");
            __builder.AddMarkupContent(129, "<h2>Shipping address</h2>\r\n                            ");
            __builder.OpenElement(130, "p");
            __builder.AddContent(131, 
#nullable restore
#line 91 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\CustomerOrder.razor"
                                GetOrderDetailByIdResultDto.FullName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(132, "<br>");
            __builder.AddContent(133, 
#nullable restore
#line 91 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\CustomerOrder.razor"
                                                                         GetOrderDetailByIdResultDto.Address

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(134, " <br>");
            __builder.AddContent(135, 
#nullable restore
#line 91 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\CustomerOrder.razor"
                                                                                                                  GetOrderDetailByIdResultDto.CountryName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n                        ");
            __builder.OpenElement(138, "div");
            __builder.AddAttribute(139, "class", "col-lg-6");
            __builder.AddMarkupContent(140, "\r\n                            ");
            __builder.AddMarkupContent(141, "<h2>Payment Type</h2>\r\n                            ");
            __builder.OpenElement(142, "p");
            __builder.AddContent(143, 
#nullable restore
#line 95 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\CustomerOrder.razor"
                                GetOrderDetailByIdResultDto.PaymentName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(144, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\r\n                        ");
            __builder.OpenElement(146, "div");
            __builder.AddAttribute(147, "class", "col-lg-6");
            __builder.AddMarkupContent(148, "\r\n                            ");
            __builder.AddMarkupContent(149, "<h2>Cargo company</h2>\r\n                            ");
            __builder.OpenElement(150, "p");
            __builder.AddContent(151, 
#nullable restore
#line 99 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\CustomerOrder.razor"
                                GetOrderDetailByIdResultDto.CargoName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "\r\n");
#nullable restore
#line 102 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\CustomerOrder.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(155, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(156, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(157, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(158, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 110 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\CustomerOrder.razor"
       
    [Parameter]
    public int OrderId { get; set; }
    public decimal SubTotal { get; set; }
    GetOrderDetailByIdResultDto GetOrderDetailByIdResultDto = new GetOrderDetailByIdResultDto();
    List<ProductModel> productModels = new List<ProductModel>();
    protected override async Task OnInitializedAsync()
    {
        GetOrderDetailByIdResultDto = await OrderService.GetOrderDetailById(OrderId);
        foreach (var item in GetOrderDetailByIdResultDto.OrderProducts)
        {
            productModels.Add(await ProductService.GetProductById(item.ProductId));
        }
        SubTotal = GetOrderDetailByIdResultDto.Total - 10;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOrderService OrderService { get; set; }
    }
}
#pragma warning restore 1591
