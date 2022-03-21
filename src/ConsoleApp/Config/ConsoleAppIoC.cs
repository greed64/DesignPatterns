using DesignPatterns.Builder.Config;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp.Config
{
    public static class ConsoleAppIoC
    {
        public static IServiceCollection AddConsoleAppIoC(this IServiceCollection services, IConfiguration configuration = null)
        {
            services.AddDependenciesRegistration();

            return services;
        }

        private static IServiceCollection AddDependenciesRegistration(this IServiceCollection services)
        {
            services.AddBuilderIoC();

            return services;
        }
    }
}