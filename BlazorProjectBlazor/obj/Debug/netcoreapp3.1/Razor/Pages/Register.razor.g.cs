#pragma checksum "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95d615162a3bda3b60d547def72adf4340143d26"
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
#line 15 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\Register.razor"
using Northwİnd.Blazor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\Register.razor"
using Northwİnd.Blazor.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
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
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-lg-12");
            __builder.AddMarkupContent(8, "\r\n            \r\n            ");
            __builder.OpenElement(9, "nav");
            __builder.AddAttribute(10, "aria-label", "breadcrumb");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "ol");
            __builder.AddAttribute(13, "class", "breadcrumb");
            __builder.AddMarkupContent(14, "\r\n                    ");
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
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.AddMarkupContent(22, "<li aria-current=\"page\" class=\"breadcrumb-item active\">New account / Sign in</li>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.AddMarkupContent(26, "<div class=\"col-lg-6\">\r\n            <div class=\"box\">\r\n                <h1>New account</h1>\r\n                <p class=\"lead\">Not our registered customer yet?</p>\r\n                <p>With registration with us new world of fashion, fantastic discounts and much more opens to you! The whole process will not take you more than a minute!</p>\r\n                <p class=\"text-muted\">If you have any questions, please feel free to <a href=\"contact.html\">contact us</a>, our customer service center is working for you 24/7.</p>\r\n                <hr>\r\n                <form action=\"customer-orders.html\" method=\"post\">\r\n                    <div class=\"form-group\">\r\n                        <label for=\"name\">Name</label>\r\n                        <input id=\"name\" type=\"text\" class=\"form-control\">\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"email\">Email</label>\r\n                        <input id=\"email\" type=\"text\" class=\"form-control\">\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"password\">Password</label>\r\n                        <input id=\"password\" type=\"password\" class=\"form-control\">\r\n                    </div>\r\n                    <div class=\"text-center\">\r\n                        <button type=\"submit\" class=\"btn btn-primary\"><i class=\"fa fa-user-md\"></i> Register</button>\r\n                    </div>\r\n                </form>\r\n            </div>\r\n        </div>\r\n        ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "col-lg-6");
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "box");
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.AddMarkupContent(33, "<h1>Login</h1>\r\n                ");
            __builder.AddMarkupContent(34, "<p class=\"lead\">Already our customer?</p>\r\n                <hr>\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(35);
            __builder.AddAttribute(36, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 51 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\Register.razor"
                                 loginModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 51 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\Register.razor"
                                                             HandleLogin

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(39, "\r\n                    ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-group");
                __builder2.AddMarkupContent(42, "\r\n                        ");
                __builder2.AddMarkupContent(43, "<label for=\"email\">Email</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(44);
                __builder2.AddAttribute(45, "Class", "form-control");
                __builder2.AddAttribute(46, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 54 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\Register.razor"
                                                                      loginModel.UsernameOrEmailAddress

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => loginModel.UsernameOrEmailAddress = __value, loginModel.UsernameOrEmailAddress))));
                __builder2.AddAttribute(48, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => loginModel.UsernameOrEmailAddress));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(49, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n                    ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "form-group");
                __builder2.AddMarkupContent(53, "\r\n                        ");
                __builder2.AddMarkupContent(54, "<label for=\"password\">Password</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(55);
                __builder2.AddAttribute(56, "Class", "form-control");
                __builder2.AddAttribute(57, "type", "password");
                __builder2.AddAttribute(58, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 58 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\Register.razor"
                                                                                      loginModel.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(59, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => loginModel.Password = __value, loginModel.Password))));
                __builder2.AddAttribute(60, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => loginModel.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(61, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n                    ");
                __builder2.AddMarkupContent(63, "<div class=\"text-center\">\r\n                        <button type=\"submit\" class=\"btn btn-primary\"><i class=\"fa fa-sign-in\"></i> Log in</button>\r\n                    </div>\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(64, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "C:\Users\konto\Desktop\Kod Dökümanları\BlazorProject.Blazor\BlazorProjectBlazor\Pages\Register.razor"
       
    LoginModel loginModel = new LoginModel();
    public string LoginMesssage { get; set; }
    private async Task HandleLogin()
    {
        var userModel = await AuthService.Login(loginModel);

        if (userModel.EmailAddress != null)
        {
            await sessionStorage.SetItemAsync("loginUser", userModel);
            await sessionStorage.SetItemAsync("loginUserId", userModel.Id);
            ((CustomAuthenticationStateProvider)AuthenticationStateProvider).MarkUserAsAuthenticated(userModel);
            NavigationManager.NavigateTo("/");
        }
        else
        {
            LoginMesssage = "Invalid username or password";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthService AuthService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591
