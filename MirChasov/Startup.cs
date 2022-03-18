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
            
            var dbConfigSection = Configuration.GetSection("DBConfig");
            var dbConfig = new DBConf(dbConfigSection);
            var mongoClient = new MongoClient(dbConfig.ConnectionString);
            Program.DB = mongoClient.GetDatabase(dbConfig.DBName);

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

                endpoints.MapControllerRoute("route1",
                   "{controller}/{action}",
                   new { controller = "Home", action = "Index" });

                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
