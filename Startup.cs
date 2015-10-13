using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Routing;
using Microsoft.Framework.DependencyInjection;
using Microsoft.Data.Entity;
using Microsoft.AspNet.Cors;
using AspnetBr.Api.Models;
using AspnetBr.Api.Migrations;
using Newtonsoft.Json.Serialization;

namespace AspnetBr.Api
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
        }

        // This method gets called by a runtime.
        // Use this method to add services to the container
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddEntityFramework()
              .AddSqlite()
              .AddDbContext<AspnetBrContext>(opt => opt.UseSqlite($"Data Source=./aspnetbr.db"));

            services.AddMvc()
              .AddJsonOptions(options =>
               {
                   options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
               });

            services.AddCors();
            services.ConfigureCors(o =>
              o.AddPolicy("AllowAll", p => p
                  .AllowAnyOrigin()
                  .AllowAnyMethod()
                  .AllowAnyHeader()
                  .AllowCredentials()
                  .SetPreflightMaxAge(TimeSpan.FromSeconds(2520))));

            services.AddScoped<DataInit>();

            // Uncomment the following line to add Web API services which makes it easier to port Web API 2 controllers.
            // You will also need to add the Microsoft.AspNet.Mvc.WebApiCompatShim package to the 'dependencies' section of project.json.
            // services.AddWebApiConventions();
        }

        // Configure is called after ConfigureServices is called.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            // Configure the HTTP request pipeline.
            app.UseStaticFiles();

            // Add MVC to the request pipeline.
            app.UseCors("AllowAll");
            app.UseMvc();
            // Add the following route for porting Web API 2 controllers.
            // routes.MapWebApiRoute("DefaultApi", "api/{controller}/{id?}");

            var datainit = app.ApplicationServices.GetService<DataInit>();
            datainit.AddEvent();
        }
    }
}
