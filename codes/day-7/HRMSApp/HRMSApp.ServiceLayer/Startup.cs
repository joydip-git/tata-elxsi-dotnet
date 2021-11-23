using HRMSApp.ServiceLayer.BusinessLayer.Contracts;
using HRMSApp.ServiceLayer.BusinessLayer.Implementations;
using HRMSApp.ServiceLayer.DataAccessLayer.Contracts;
using HRMSApp.ServiceLayer.DataAccessLayer.Implementations;
using HRMSApp.ServiceLayer.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRMSApp.ServiceLayer
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        public IConfiguration Configuration { get; set; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<ApplicationDbContext>(ServiceLifetime.Singleton);
            services.AddSingleton<IApplicationDao<Employee>, EmployeeDao>();
            services.AddSingleton<IApplicationBO<Employee>, EmployeeBO>();            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
