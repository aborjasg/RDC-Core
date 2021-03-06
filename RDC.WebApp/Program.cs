using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RDC.WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                 .ConfigureLogging((hostingContext, logBuilder) =>
                 {
                     logBuilder.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
                     logBuilder.AddConsole();
                     logBuilder.AddDebug();
                 })                
                .ConfigureWebHostDefaults(webBuilder =>
                {   
                    webBuilder.UseStartup<Startup>();
                })
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    config
                    .SetBasePath(hostingContext.HostingEnvironment.ContentRootPath)
                    .AddJsonFile(Path.Combine("APIGateway", "OcelotConfiguration.json"), optional: false, reloadOnChange: true);
                });
    }
}
