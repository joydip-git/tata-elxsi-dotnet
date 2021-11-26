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
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.AspNetCore.Cors.Infrastructure;

namespace HRMSApp.ServiceLayer
{
    public class Startup
    {
        IConfiguration configuration;
        //public Startup()
        //{

        //}

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        //public IConfiguration Configuration => this.configuration;
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddControllers();
            var conStr = this.configuration.GetConnectionString("applicationDbConstr");
            Console.WriteLine(conStr);
            services.AddDbContext<ApplicationDbContext>((options) =>
            {
                options.UseSqlServer(conStr);
            }, ServiceLifetime.Singleton);
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

            app.UseCors(builder =>
            {
                builder.AllowAnyOrigin();
                builder.AllowAnyMethod();
                builder.AllowAnyHeader();
            });
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
