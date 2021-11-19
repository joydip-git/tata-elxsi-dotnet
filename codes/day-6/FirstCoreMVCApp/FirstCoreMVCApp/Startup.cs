using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Routing;

namespace FirstCoreMVCApp
{
    public class Startup
    {
        // This method gets called by the runtime (when hostBuilder.Build() method is called). Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //when  webHost.Run(); method is called
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();


            //Action<IEndpointRouteBuilder> routeBuilder = (IEndpointRouteBuilder builder) =>
            //{
            //    builder.MapControllerRoute("Default", "{controller}/{action}/{data1}/{data2}", new { controller = "Home", action = "Index", data1 = "", data2="" });
            //};

            Action<IEndpointRouteBuilder> routeBuilder = (IEndpointRouteBuilder builder) =>
            {
                builder.MapControllerRoute("Default", "{controller}/{action}/{id}/{name}/{price}", new { controller = "Home", action = "Index", id = "", name = "", price = "" });
            };

            //"{controller}/{action}/{id?}"
            //Action<IEndpointRouteBuilder> routeBuilder = (builder) => builder.MapDefaultControllerRoute();
            app.UseEndpoints(routeBuilder);
        }
    }
}
