using System;
using CSnakes.Runtime;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FastANPRDotNet;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddFastAnpr(this IServiceCollection services, IHostEnvironment environment)
    {
        services
            .WithPython()
            .WithHome(environment.ContentRootPath)
            .WithVirtualEnvironment("pythonVirtualEnvironment")
            .WithUvInstaller()
            .FromRedistributable();

        services.AddSingleton<INprDetectionService, NprDetectionService>();

        return services;
    }

}
