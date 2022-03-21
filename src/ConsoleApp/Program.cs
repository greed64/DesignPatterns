using ConsoleApp.Config;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            await CreateHostBuilder(args).Build().RunAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
           Host.CreateDefaultBuilder(args)
           .ConfigureAppConfiguration((context, config) =>
           {
               config.AddCommandLine(args);
           })
           .ConfigureServices(services =>
           {
               services
               .AddHostedService<Startup>()
               .AddConsoleAppIoC();
           });

    }
}
