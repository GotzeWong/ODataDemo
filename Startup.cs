using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using ODataDemo.Data;

namespace ODataDemo
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

            services.AddControllersWithViews().AddNewtonsoftJson();

            services.AddOData();

            services.AddDbContext<XxxDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("XxxDbContext")));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}
            //else
            //{
                //app.UseExceptionHandler("/Home/Error");

                app.UseExceptionHandler(errorApp =>
                {
                    errorApp.Run(ODataExceptionHandler.HandleException());
                });

                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            //}
            app.UseHttpsRedirection();


            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "odata/{controller=Home}/{action=Index}/{id?}");
                endpoints.EnableDependencyInjection();
                endpoints.Select().Expand().Filter().OrderBy().Count().MaxTop(10);

            });


        }
    }

    public class ODataExceptionHandler
    {
        public static RequestDelegate HandleException()
        {
            return async context =>
            {
                await Handle(context);
            };
        }

        public static Task Handle(HttpContext context)
        {
            return Task.Run(new Action(() =>
            {
                context.Response.ContentType = "application/problem+json";
                var exceptionHandlerPathFeature = context.Features.Get<IExceptionHandlerPathFeature>();
                var content = JsonConvert.SerializeObject(exceptionHandlerPathFeature);
                byte[] byteArray = Encoding.ASCII.GetBytes(content);
                context.Response.Body.Write(byteArray);
            }));
        }
    }
}
