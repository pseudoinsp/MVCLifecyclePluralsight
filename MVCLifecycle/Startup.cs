using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MVCLifecycle.Middleware;

namespace MVCLifecycle
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //app.Use(async (ctx, next) =>
            //{
            //    if(ctx.Request.Path.Value.Contains("home"))
            //    {
            //        await ctx.Response.WriteAsync("Response generated from Use");
            //    }
            //    else
            //    {
            //        Debug.WriteLine("=== Before Run===");
            //        await next();
            //        Debug.WriteLine("=== After Run===");
            //    }
            //});

            app.UseMiddleware<LoggingMiddleware>();

            //app.Run(async ctx =>
            //{
            //    Debug.WriteLine("=== During Run");
            //    await ctx.Response.WriteAsync("The response from Run.");
            //});

            // static files like .css, .js, images, ...
            // does not trigger MVC! -> faster
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
            
        }
    }
}
