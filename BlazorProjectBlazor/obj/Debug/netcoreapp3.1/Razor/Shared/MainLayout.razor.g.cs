#pragma checksum "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff71c00a19f026fab7e1d9b86a10a00fd7c01574"
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
#line 11 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\_Imports.razor"
using Northwİnd.Blazor.Models;

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
#line 2 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Shared\MainLayout.razor"
using Northwİnd.Blazor.Services;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "header");
            __builder.AddAttribute(1, "class", "header mb-5");
            __builder.AddMarkupContent(2, "\r\n    \r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "id", "top");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "container");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.AddMarkupContent(12, "<div class=\"col-lg-6 offer mb-3 mb-lg-0\"><a href=\"#\" class=\"btn btn-success btn-sm\">Offer of the day</a><a href=\"#\" class=\"ml-1\">Get flat 35% off on orders over $50!</a></div>\r\n                ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "col-lg-6 text-center text-lg-right");
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "ul");
            __builder.AddAttribute(17, "class", "menu list-inline mb-0");
            __builder.AddMarkupContent(18, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(19);
            __builder.AddAttribute(20, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(21, "\r\n                                ");
                __builder2.OpenElement(22, "h3");
                __builder2.AddAttribute(23, "style", "color:white;");
                __builder2.AddContent(24, 
#nullable restore
#line 24 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Shared\MainLayout.razor"
                                                          context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n                                ");
                __builder2.OpenElement(26, "li");
                __builder2.AddAttribute(27, "class", "list-inline-item");
                __builder2.AddMarkupContent(28, "\r\n                                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(29);
                __builder2.AddAttribute(30, "href", "");
                __builder2.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Shared\MainLayout.razor"
                                                               Logout

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(33, "Logout");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n                            ");
            }
            ));
            __builder.AddAttribute(36, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(37, "\r\n                                ");
                __builder2.AddMarkupContent(38, "<li class=\"list-inline-item\">\r\n                                    <a href=\"#\" data-toggle=\"modal\" data-target=\"#login-modal\">Login</a>\r\n                                </li>\r\n                                ");
                __builder2.OpenElement(39, "li");
                __builder2.AddAttribute(40, "class", "list-inline-item");
                __builder2.AddMarkupContent(41, "\r\n                                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(42);
                __builder2.AddAttribute(43, "href", "register");
                __builder2.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(45, "Register");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n                                ");
                __builder2.OpenElement(48, "li");
                __builder2.AddAttribute(49, "class", "list-inline-item");
                __builder2.AddMarkupContent(50, "\r\n                                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(51);
                __builder2.AddAttribute(52, "href", "contact");
                __builder2.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(54, "Contact");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(55, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n                            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(57, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n    ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "id", "login-modal");
            __builder.AddAttribute(65, "tabindex", "-1");
            __builder.AddAttribute(66, "role", "dialog");
            __builder.AddAttribute(67, "aria-labelledby", "Login");
            __builder.AddAttribute(68, "aria-hidden", "true");
            __builder.AddAttribute(69, "class", "modal fade");
            __builder.AddMarkupContent(70, "\r\n        ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "modal-dialog modal-sm");
            __builder.AddMarkupContent(73, "\r\n            ");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "modal-content");
            __builder.AddMarkupContent(76, "\r\n                ");
            __builder.AddMarkupContent(77, @"<div class=""modal-header"">
                    <h5 class=""modal-title"">Customer login</h5>
                    <button type=""button"" data-dismiss=""modal"" aria-label=""Close"" class=""close""><span aria-hidden=""true"">×</span></button>
                </div>
                ");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "modal-body");
            __builder.AddMarkupContent(80, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(81);
            __builder.AddAttribute(82, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 54 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Shared\MainLayout.razor"
                                     loginModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(83, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 54 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Shared\MainLayout.razor"
                                                                 HandleLogin

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(84, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(85, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(86);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(87, "\r\n                        ");
                __builder2.OpenElement(88, "div");
                __builder2.AddAttribute(89, "class", "form-group");
                __builder2.AddMarkupContent(90, "\r\n                            ");
                __builder2.AddMarkupContent(91, "<label for=\"email\">Email</label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(92);
                __builder2.AddAttribute(93, "id", "loginText");
                __builder2.AddAttribute(94, "Class", "form-control");
                __builder2.AddAttribute(95, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 58 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Shared\MainLayout.razor"
                                                                                         loginModel.UsernameOrEmailAddress

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(96, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => loginModel.UsernameOrEmailAddress = __value, loginModel.UsernameOrEmailAddress))));
                __builder2.AddAttribute(97, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => loginModel.UsernameOrEmailAddress));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(98, "\r\n                            ");
                __Blazor.BlazorProjectBlazor.Shared.MainLayout.TypeInference.CreateValidationMessage_0(__builder2, 99, 100, 
#nullable restore
#line 59 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Shared\MainLayout.razor"
                                                      ()=>loginModel.UsernameOrEmailAddress

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(101, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n                        ");
                __builder2.OpenElement(103, "div");
                __builder2.AddAttribute(104, "class", "form-group");
                __builder2.AddMarkupContent(105, "\r\n                            ");
                __builder2.AddMarkupContent(106, "<label for=\"password\">Password</label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(107);
                __builder2.AddAttribute(108, "id", "passwordText");
                __builder2.AddAttribute(109, "Class", "form-control");
                __builder2.AddAttribute(110, "type", "password");
                __builder2.AddAttribute(111, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 63 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Shared\MainLayout.razor"
                                                                                                            loginModel.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(112, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => loginModel.Password = __value, loginModel.Password))));
                __builder2.AddAttribute(113, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => loginModel.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(114, "\r\n                            ");
                __Blazor.BlazorProjectBlazor.Shared.MainLayout.TypeInference.CreateValidationMessage_1(__builder2, 115, 116, 
#nullable restore
#line 64 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Shared\MainLayout.razor"
                                                      ()=>loginModel.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(117, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(118, "\r\n                        ");
                __builder2.AddMarkupContent(119, "<div class=\"text-center\">\r\n                            <button type=\"submit\" class=\"btn btn-primary\"><i class=\"fa fa-sign-in\"></i> Log in</button>\r\n                        </div>\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(120, "\r\n                    ");
            __builder.AddMarkupContent(121, "<p class=\"text-center text-muted\">Not registered yet?</p>\r\n                    ");
            __builder.AddMarkupContent(122, "<p class=\"text-center text-muted\"><a href=\"/register\"><strong>Register now</strong></a>! It is easy and done in 1 minute and gives you access to special discounts and much more!</p>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n    ");
            __builder.OpenComponent<BlazorProjectBlazor.Shared.NavMenu>(127);
            __builder.CloseComponent();
            __builder.AddMarkupContent(128, "\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n");
            __builder.OpenElement(130, "div");
            __builder.AddAttribute(131, "id", "all");
            __builder.AddMarkupContent(132, "\r\n    ");
            __builder.OpenElement(133, "div");
            __builder.AddAttribute(134, "id", "content");
            __builder.AddMarkupContent(135, "\r\n        ");
            __builder.AddContent(136, 
#nullable restore
#line 81 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(137, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n\r\n\r\n\r\n");
            __builder.AddMarkupContent(140, "<div id=\"footer\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-3 col-md-6\">\r\n                <h4 class=\"mb-3\">Pages</h4>\r\n                <ul class=\"list-unstyled\">\r\n                    <li><a href=\"text.html\">About us</a></li>\r\n                    <li><a href=\"text.html\">Terms and conditions</a></li>\r\n                    <li><a href=\"faq.html\">FAQ</a></li>\r\n                    <li><a href=\"contact.html\">Contact us</a></li>\r\n                </ul>\r\n                <hr>\r\n                <h4 class=\"mb-3\">User section</h4>\r\n                <ul class=\"list-unstyled\">\r\n                    <li><a href=\"#\" data-toggle=\"modal\" data-target=\"#login-modal\">Login</a></li>\r\n                    <li><a href=\"register.html\">Regiter</a></li>\r\n                </ul>\r\n            </div>\r\n            \r\n            <div class=\"col-lg-3 col-md-6\">\r\n                <h4 class=\"mb-3\">Top categories</h4>\r\n                <h5>Men</h5>\r\n                <ul class=\"list-unstyled\">\r\n                    <li><a href=\"category.html\">T-shirts</a></li>\r\n                    <li><a href=\"category.html\">Shirts</a></li>\r\n                    <li><a href=\"category.html\">Accessories</a></li>\r\n                </ul>\r\n                <h5>Ladies</h5>\r\n                <ul class=\"list-unstyled\">\r\n                    <li><a href=\"category.html\">T-shirts</a></li>\r\n                    <li><a href=\"category.html\">Skirts</a></li>\r\n                    <li><a href=\"category.html\">Pants</a></li>\r\n                    <li><a href=\"category.html\">Accessories</a></li>\r\n                </ul>\r\n            </div>\r\n            \r\n            <div class=\"col-lg-3 col-md-6\">\r\n                <h4 class=\"mb-3\">Where to find us</h4>\r\n                <p><strong>Obaju Ltd.</strong><br>13/25 New Avenue<br>New Heaven<br>45Y 73J<br>England<br><strong>Great Britain</strong></p><a href=\"contact.html\">Go to contact page</a>\r\n                <hr class=\"d-block d-md-none\">\r\n            </div>\r\n            \r\n            <div class=\"col-lg-3 col-md-6\">\r\n                <h4 class=\"mb-3\">Get the news</h4>\r\n                <p class=\"text-muted\">Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.</p>\r\n                <form>\r\n                    <div class=\"input-group\">\r\n                        <input type=\"text\" class=\"form-control\"><span class=\"input-group-append\">\r\n                            <button type=\"button\" class=\"btn btn-outline-secondary\">Subscribe!</button>\r\n                        </span>\r\n                    </div>\r\n                    \r\n                </form>\r\n                <hr>\r\n                <h4 class=\"mb-3\">Stay in touch</h4>\r\n                <p class=\"social\"><a href=\"#\" class=\"facebook external\"><i class=\"fa fa-facebook\"></i></a><a href=\"#\" class=\"twitter external\"><i class=\"fa fa-twitter\"></i></a><a href=\"#\" class=\"instagram external\"><i class=\"fa fa-instagram\"></i></a><a href=\"#\" class=\"gplus external\"><i class=\"fa fa-google-plus\"></i></a><a href=\"#\" class=\"email external\"><i class=\"fa fa-envelope\"></i></a></p>\r\n            </div>\r\n            \r\n        </div>\r\n        \r\n    </div>\r\n    \r\n</div>\r\n\r\n\r\n\r\n");
            __builder.AddMarkupContent(141, @"<div id=""copyright"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-6 mb-2 mb-lg-0"">
                <p class=""text-center text-lg-left"">©2019 Your name goes here.</p>
            </div>
            <div class=""col-lg-6"">
                <p class=""text-center text-lg-right"">
                    0
                    Template design by <a href=""https://bootstrapious.com/p/big-bootstrap-tutorial"">Bootstrapious</a>
                    
                </p>
            </div>
        </div>
    </div>
</div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 175 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Shared\MainLayout.razor"
      
    LoginModel loginModel = new LoginModel();
    public string LoginMesssage { get; set; }
    protected async override Task OnInitializedAsync()
    {
        if (HttpClient.DefaultRequestHeaders.Authorization==null&&localStorage.GetItemAsync<string>("token")!=null)
        {
            HttpClient.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", await localStorage.GetItemAsync<string>("token"));
        }
    }
    private async Task HandleLogin()
    {
        await AuthService.Login(loginModel);

    }
    public async Task Logout()
    {
        await AuthService.Logout();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthService AuthService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
namespace __Blazor.BlazorProjectBlazor.Shared.MainLayout
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
