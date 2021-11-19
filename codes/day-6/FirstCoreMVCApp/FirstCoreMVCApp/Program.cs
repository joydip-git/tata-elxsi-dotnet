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
            IHostBuilder builder = Host.CreateDefaultBuilder();
            Action<IWebHostBuilder> action = (IWebHostBuilder builder) => builder.UseStartup<Startup>();
            IHostBuilder hostBuilder = builder.ConfigureWebHostDefaults(action);
            IHost webHost = hostBuilder.Build();
            webHost.Run();
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
