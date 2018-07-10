using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using dotnetapi.Models;
// using dotnetapi.Controllers;

namespace dotnetapi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.Add(new ServiceDescriptor(typeof(TestDBContext), new TestDBContext(Configuration.GetConnectionString("DefaultConnection"))));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc( routes =>{
                routes.MapRoute(
                    name:"api-retrieve",
                    template:"api/{model}",
                    defaults: new {controller="Api",action="Retrieve",page=1},
                    constraints:new {httpMethod =   new HttpMethodRouteConstraint(new string[] { "GET" })}
                );
                routes.MapRoute(
                    name: "api-retrieve-id",
                    template: "api/{model}/{id}",
                    defaults: new { controller = "Api", action = "RetrieveById" },
                    constraints: new { httpMethod = new HttpMethodRouteConstraint(new string[] { "GET" }) }
                );
                routes.MapRoute(
                    name:"api-add", 
                    template:"api/{model}",
                    defaults: new { controller = "Api", action = "Add"},
                    constraints:new { httpMethod = new HttpMethodRouteConstraint(new string[] { "POST" }) }
                );
                routes.MapRoute(
                    name:"api-update", 
                    template:"api/{model}/{id}",
                    defaults: new { controller = "Api", action = "Update" },
                    constraints:new { httpMethod = new HttpMethodRouteConstraint(new string[] { "PUT" }) }
                );
                routes.MapRoute(
                    name:"api-delete", 
                    template:"api/{model}/{id}",
                    defaults: new { controller = "Api", action = "Delete"},
                    constraints:new { httpMethod = new HttpMethodRouteConstraint(new string[] { "DELETE" }) }
                );
            });
        }
    }
}
