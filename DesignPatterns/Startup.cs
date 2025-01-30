using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DesignPatterns.Infraestructure.DependencyInjection;
using DesignPatterns.Strategies; // Agregando el namespace correcto
using DesignPatterns.Interfaces;
using DesignPatterns.Factories;

namespace DesignPatterns
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            var dependencyInjection = new ServicesConfiguration();
            services.AddControllersWithViews();
            dependencyInjection.ConfigureServices(services);

            // Registrar estrategias en el contenedor de dependencias
            services.AddScoped<IEngineStrategy, StandardEngineStrategy>();
            services.AddScoped<IFuelStrategy>(provider => new StandardFuelStrategy(10)); // Pasando un límite de combustible
            services.AddScoped<CarFactoryProvider>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
