using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace DotnetCoreDdnsDnspod
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            using (var host = Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddLogging();
                    services.AddTransient<IGetIP, GetIPImplement>();
                    services.AddHostedService<UpdateDDNSService>();
                    
                })
                .ConfigureAppConfiguration((hostContext, config) =>
                {
                    config.AddJsonFile("UserData.json", optional: true);
                })
                .Build())
            {
                await host.StartAsync();
                await host.WaitForShutdownAsync();
            }
        }

    }
}
