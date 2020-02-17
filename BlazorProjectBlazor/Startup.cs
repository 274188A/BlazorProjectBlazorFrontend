using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Northw›nd.Blazor.Services;
using Northw›nd.Blazor.Services.Concrete;
using Northw›nd.Blazor.Services.Abstract;
using Microsoft.AspNetCore.Components.Authorization;
using Northw›nd.Blazor.Models;
using Blazored.SessionStorage;
using Blazored.LocalStorage;
using BlazorProjectBlazor.Services.Abstract;
using BlazorProjectBlazor.Services.Concrete;

namespace BlazorProjectBlazor
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
            
            services.AddBlazoredSessionStorage();
            services.AddBlazoredLocalStorage();
            
            services.AddHttpClient<IAuthService, AuthService>();            
            services.AddHttpClient<ICategoryService, CategoryService>();
            services.AddHttpClient<IProductService, ProductService>();
            services.AddHttpClient<ICountryService, CountryService>();
            services.AddHttpClient<ICargoService, CargoService>();
            services.AddHttpClient<IPaymentService, PaymentService>();
            services.AddHttpClient<IUserService, UserService>();
            services.AddHttpClient<IOrderService, OrderService>();
            services.AddHttpClient<IColourService, ColourService>();                       
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();           
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
