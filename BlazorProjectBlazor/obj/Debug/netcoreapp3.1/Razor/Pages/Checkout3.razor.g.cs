#pragma checksum "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Pages\Checkout3.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7a09438b03b19580360b772797ba26aec966f35"
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
#line 1 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\_Imports.razor"
using BlazorProjectBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\_Imports.razor"
using BlazorProjectBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\_Imports.razor"
using Northwİnd.Blazor.Utilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\_Imports.razor"
using BlazorProjectBlazor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\_Imports.razor"
using BlazorProjectBlazor.Services.Abstract;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Pages\Checkout3.razor"
using Northwİnd.Blazor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Pages\Checkout3.razor"
using Northwİnd.Blazor.Services.Abstract;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Pages\Checkout3.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/checkout3")]
    public partial class Checkout3 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-lg-12");
            __builder.AddMarkupContent(8, "\n            \n            ");
            __builder.OpenElement(9, "nav");
            __builder.AddAttribute(10, "aria-label", "breadcrumb");
            __builder.AddMarkupContent(11, "\n                ");
            __builder.OpenElement(12, "ol");
            __builder.AddAttribute(13, "class", "breadcrumb");
            __builder.AddMarkupContent(14, "\n                    ");
            __builder.OpenElement(15, "li");
            __builder.AddAttribute(16, "class", "breadcrumb-item");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(17);
            __builder.AddAttribute(18, "href", "/");
            __builder.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(20, "Home");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n                    ");
            __builder.AddMarkupContent(22, "<li aria-current=\"page\" class=\"breadcrumb-item active\">Checkout - Payment method</li>\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n        ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "id", "checkout");
            __builder.AddAttribute(28, "class", "col-lg-9");
            __builder.AddMarkupContent(29, "\n            ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "box");
            __builder.AddMarkupContent(32, "\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(33);
            __builder.AddAttribute(34, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 21 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Pages\Checkout3.razor"
                                 orderModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 21 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Pages\Checkout3.razor"
                                                            SetPayment

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(37, "\n                    ");
                __builder2.AddMarkupContent(38, "<h1>Checkout - Payment method</h1>\n                    ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "nav flex-column flex-sm-row nav-pills");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(41);
                __builder2.AddAttribute(42, "href", "checkout");
                __builder2.AddAttribute(43, "class", "nav-link flex-sm-fill text-sm-center");
                __builder2.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(45, " ");
                    __builder3.AddMarkupContent(46, "<i class=\"fa fa-map-marker\">                  </i>Address");
                }
                ));
                __builder2.CloseComponent();
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(47);
                __builder2.AddAttribute(48, "href", "checkout2");
                __builder2.AddAttribute(49, "class", "nav-link flex-sm-fill text-sm-center");
                __builder2.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(51, " ");
                    __builder3.AddMarkupContent(52, "<i class=\"fa fa-truck\">                       </i>Delivery Method");
                }
                ));
                __builder2.CloseComponent();
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(53);
                __builder2.AddAttribute(54, "href", "checkout3");
                __builder2.AddAttribute(55, "class", "nav-link flex-sm-fill text-sm-center active");
                __builder2.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(57, " ");
                    __builder3.AddMarkupContent(58, "<i class=\"fa fa-money\">                      </i>Payment Method");
                }
                ));
                __builder2.CloseComponent();
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(59);
                __builder2.AddAttribute(60, "href", "#");
                __builder2.AddAttribute(61, "class", "nav-link flex-sm-fill text-sm-center disabled");
                __builder2.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(63, " ");
                    __builder3.AddMarkupContent(64, "<i class=\"fa fa-eye\">                     </i>Order Review");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\n                    ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "content py-3");
                __builder2.AddMarkupContent(68, "\n                        ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "row");
                __builder2.AddMarkupContent(71, "\n");
#nullable restore
#line 26 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Pages\Checkout3.razor"
                             if (Payments != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Pages\Checkout3.razor"
                                 foreach (var item in Payments)
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(72, "                                    ");
                __builder2.OpenElement(73, "div");
                __builder2.AddAttribute(74, "class", "col-md-6");
                __builder2.AddMarkupContent(75, "\n                                        ");
                __builder2.OpenElement(76, "div");
                __builder2.AddAttribute(77, "class", "box payment-method");
                __builder2.AddMarkupContent(78, "\n                                            ");
                __builder2.OpenElement(79, "h4");
                __builder2.AddContent(80, 
#nullable restore
#line 32 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Pages\Checkout3.razor"
                                                 item.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\n                                            ");
                __builder2.AddMarkupContent(82, "<p>We like it all.</p>\n                                            ");
                __builder2.OpenElement(83, "div");
                __builder2.AddAttribute(84, "class", "box-footer text-center");
                __builder2.AddMarkupContent(85, "\n                                                ");
                __builder2.OpenElement(86, "input");
                __builder2.AddAttribute(87, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Pages\Checkout3.razor"
                                                                   ()=>SetPaymentId(item.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(88, "type", "radio");
                __builder2.AddAttribute(89, "name", "payment");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\n                                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\n                                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\n");
#nullable restore
#line 39 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Pages\Checkout3.razor"

                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Pages\Checkout3.razor"
                                 
                            }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(94, "\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\n                        \n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\n                    \n                    ");
                __builder2.OpenElement(97, "div");
                __builder2.AddAttribute(98, "class", "box-footer d-flex justify-content-between");
                __builder2.AddMarkupContent(99, "\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(100);
                __builder2.AddAttribute(101, "href", "checkout2");
                __builder2.AddAttribute(102, "class", "btn btn-outline-secondary");
                __builder2.AddAttribute(103, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(104, "<i class=\"fa fa-chevron-left\"></i>Back to Shipping Method");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(105, "\n                        ");
                __builder2.AddMarkupContent(106, "<button type=\"submit\" class=\"btn btn-primary\">Continue to Order Review<i class=\"fa fa-chevron-right\"></i></button>\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(107, "\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(108, "\n                \n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\n        \n        ");
            __builder.OpenElement(111, "div");
            __builder.AddAttribute(112, "class", "col-lg-3");
            __builder.AddMarkupContent(113, "\n            ");
            __builder.OpenElement(114, "div");
            __builder.AddAttribute(115, "id", "order-summary");
            __builder.AddAttribute(116, "class", "card");
            __builder.AddMarkupContent(117, "\n                ");
            __builder.AddMarkupContent(118, "<div class=\"card-header\">\n                    <h3 class=\"mt-4 mb-4\">Order summary</h3>\n                </div>\n                ");
            __builder.OpenElement(119, "div");
            __builder.AddAttribute(120, "class", "card-body");
            __builder.AddMarkupContent(121, "\n                    ");
            __builder.AddMarkupContent(122, "<p class=\"text-muted\">Shipping and additional costs are calculated based on the values you have entered.</p>\n                    ");
            __builder.OpenElement(123, "div");
            __builder.AddAttribute(124, "class", "table-responsive");
            __builder.AddMarkupContent(125, "\n                        ");
            __builder.OpenElement(126, "table");
            __builder.AddAttribute(127, "class", "table");
            __builder.AddMarkupContent(128, "\n                            ");
            __builder.OpenElement(129, "tbody");
            __builder.AddMarkupContent(130, "\n                                ");
            __builder.OpenElement(131, "tr");
            __builder.AddMarkupContent(132, "\n                                    ");
            __builder.AddMarkupContent(133, "<td>Order subtotal</td>\n                                    ");
            __builder.OpenElement(134, "th");
            __builder.AddContent(135, "$");
            __builder.AddContent(136, 
#nullable restore
#line 68 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Pages\Checkout3.razor"
                                          SubTotal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\n                                ");
            __builder.AddMarkupContent(139, "<tr>\n                                    <td>Shipping and handling</td>\n                                    <th>$10.00</th>\n                                </tr>\n\n                                ");
            __builder.OpenElement(140, "tr");
            __builder.AddAttribute(141, "class", "total");
            __builder.AddMarkupContent(142, "\n                                    ");
            __builder.AddMarkupContent(143, "<td>Total</td>\n                                    ");
            __builder.OpenElement(144, "th");
            __builder.AddContent(145, "$");
            __builder.AddContent(146, 
#nullable restore
#line 77 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Pages\Checkout3.razor"
                                          Total

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(147, "\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(149, "\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "\n        \n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(155, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 88 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Pages\Checkout3.razor"
       
    List<Payment> Payments = new List<Payment>();
    OrderModel orderModel = new OrderModel();
    public decimal SubTotal { get; set; }
    public decimal Total { get; set; }
    public int PaymentId { get; set; }
    protected override async Task OnInitializedAsync()
    {
        var result = await sessionStorage.GetItemAsync<OrderModel>("order");
        if (result != null)
        {
            orderModel = result;
        }
        SubTotal = await sessionStorage.GetItemAsync<decimal>("subtotal");
        orderModel = await sessionStorage.GetItemAsync<OrderModel>("order");
        Payments = await PaymentService.GetPayments();
        Total = SubTotal + 10;
    }
    void SetPaymentId(int paymentId)
    {
        PaymentId = paymentId;
        Console.WriteLine(PaymentId);
    }
    async Task SetPayment()
    {
        orderModel.PaymentId = PaymentId;
        await sessionStorage.SetItemAsync("order", orderModel);
        NavigationManager.NavigateTo("/checkout4");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPaymentService PaymentService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591
