using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NUGET.BOBERTO.PACKAGE.Services.HealhCheck;
using System;

namespace NUGET.BOBERTO.PACKAGE
{
    public static class ServiceInjection
    {
        public static void AddConfigurations(IServiceCollection services, string baseDirectory)
        {
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            var config = new ConfigurationBuilder()
             .SetBasePath(baseDirectory)
             .AddJsonFile($"appsettings.json", optional: true, reloadOnChange: true)
             .AddJsonFile($"appsettings.{environment}.json", optional: true, reloadOnChange: true)
             .Build();
            services.AddSingleton(config);
        }
        public static void AddHealthCheck(IServiceCollection services)
        {
            services.AddSingleton<IHealthCheck, HealthCheck>();
        }
    }
}