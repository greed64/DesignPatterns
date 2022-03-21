using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace DesignPatterns.Builder.Config
{
    public static class BuilderIoC
    {
        public static IServiceCollection AddBuilderIoC(this IServiceCollection services)
        {
            services.AddServicesRegistration();

            services.AddServicesDependencies();

            return services;
        }

        private static IServiceCollection AddServicesRegistration(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();

            services.Scan(s => s.FromAssemblies(assembly)
            .AddClasses(false)
            .AsImplementedInterfaces()
            .WithScopedLifetime());

            return services;
        }

        private static IServiceCollection AddServicesDependencies(this IServiceCollection services)
        {
            //Add if there is a need
            //services.AddConnectorIoC();

            return services;
        }
    }
}