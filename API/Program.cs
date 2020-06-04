using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace API {
    public class Program {
        public static void Main(string[] args) {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                //.UseKestrel(serverOptions => {
                //    // Set properties and call methods on options
                //    serverOptions.Limits.MaxConcurrentConnections = 100;
                //    serverOptions.Limits.MaxConcurrentUpgradedConnections = 100;
                //    serverOptions.Limits.MaxRequestBodySize = 10 * 1024;
                //    serverOptions.Limits.MinRequestBodyDataRate =
                //        new MinDataRate(bytesPerSecond: 100,
                //            gracePeriod: TimeSpan.FromSeconds(10));
                //    serverOptions.Limits.MinResponseDataRate =
                //        new MinDataRate(bytesPerSecond: 100,
                //            gracePeriod: TimeSpan.FromSeconds(10));
                //    serverOptions.Listen(IPAddress.Loopback, 5000);
                //    serverOptions.Listen(IPAddress.Loopback, 5001,
                //        listenOptions => {
                //            listenOptions.UseHttps("testCert.pfx",
                //                "testPassword");
                //        });
                //    serverOptions.Limits.KeepAliveTimeout =
                //        TimeSpan.FromMinutes(2);
                //    serverOptions.Limits.RequestHeadersTimeout =
                //        TimeSpan.FromMinutes(1);
                //})
                .ConfigureWebHostDefaults(webBuilder => {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
