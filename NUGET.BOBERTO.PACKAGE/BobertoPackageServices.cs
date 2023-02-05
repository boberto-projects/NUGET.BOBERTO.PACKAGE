using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NUGET.BOBERTO.PACKAGE.Services.BobertoHealthCheck;
using System;
namespace NUGET.BOBERTO.PACKAGE
{
    public static class BobertoPackageServices
    {
        public static void AddConfigurations(this IServiceCollection services, string baseDirectory)
        {
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            var config = new ConfigurationBuilder()
             .SetBasePath(baseDirectory)
             .AddJsonFile($"appsettings.json", optional: true, reloadOnChange: true)
             .AddJsonFile($"appsettings.{environment}.json", optional: true, reloadOnChange: true)
             .Build();
            services.AddSingleton(config);
        }
        public static void AddHealthCheck(this IServiceCollection services)
        {
            services.AddSingleton<IBobertoHealthCheck, BobertoHealthCheck>();
        }
        public static void AddHealthCheck(this IServiceCollection services, string assemblyName)
        {
            var bobertoHealthCheck = new BobertoHealthCheck(assemblyName);
            services.AddSingleton<IBobertoHealthCheck>(bobertoHealthCheck);
        }
    }
}