using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MongoDB.Driver;

namespace MirChasov
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
            services.AddControllersWithViews();

            Data.InitData(Configuration);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseEndpoints(endpoints => {

                //endpoints.MapControllerRoute("route1",
                //   "blog/{action}",
                //   new { controller = "Blog", action = "Index" });

                //endpoints.MapControllerRoute("catpage",
                //    "{category}/Page{productPage:int}",
                //    new { Controller = "Home", action = "Index" });
                //endpoints.MapControllerRoute("page", "Page{productPage:int}",
                //    new { Controller = "Home", action = "Index", productPage = 1 });
                //endpoints.MapControllerRoute("category", "{category}",
                //    new { Controller = "Home", action = "Index", productPage = 1 });
                //endpoints.MapControllerRoute("pagination",
                //    "Products/Page{productPage}",
                //    new { Controller = "Home", action = "Index", productPage = 1 });



                endpoints.MapControllerRoute("route1",
                   "Product/{id?}",
                   new { controller = "Product", action = "Product" });

                endpoints.MapControllerRoute("route2",
                   "{controller}/{action}/{id?}",
                   new { controller = "Home", action = "Index" });

                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
