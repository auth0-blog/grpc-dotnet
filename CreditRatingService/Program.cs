using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;

namespace CreditRatingService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        
        // Comment the following method if you are running on MacOS
       public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        // Uncomment the following method if you are running on MacOS
        // public static IHostBuilder CreateHostBuilder(string[] args) =>
        //     Host.CreateDefaultBuilder(args)
        //         .ConfigureWebHostDefaults(webBuilder =>
        //         {
        //             webBuilder.ConfigureKestrel(options =>
        //             {
        //                 // Setup a HTTP/2 endpoint without TLS.
        //                 options.ListenLocalhost(5000, o => o.Protocols = 
        //                     HttpProtocols.Http2);
        //             });
        //             webBuilder.UseStartup<Startup>();
        //         });
    }
}
