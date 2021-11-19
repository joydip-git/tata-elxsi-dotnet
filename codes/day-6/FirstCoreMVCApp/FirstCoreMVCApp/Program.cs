using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreMVCApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //HostBuilder
            IHostBuilder builder = Host.CreateDefaultBuilder(); //create a default builder which creates a host
            Action<IWebHostBuilder> action = (IWebHostBuilder builder) => builder.UseStartup<Startup>();
            IHostBuilder hostBuilder = builder.ConfigureWebHostDefaults(action);
            IHost webHost = hostBuilder.Build(); //creates a web host and hosts your asp.net core web application
            webHost.Run(); //the web app actually starts running and starts listenning to the incoming HTTP requests
            //CreateHostBuilder(args).Build().Run();
            
        }

        //public static IHostBuilder CreateHostBuilder(string[] args)
        //{
        //   return Host.CreateDefaultBuilder(args)
        //        .ConfigureWebHostDefaults(webBuilder =>
        //        {
        //            webBuilder.UseStartup<Startup>();
        //        });
        //}
    }
}
