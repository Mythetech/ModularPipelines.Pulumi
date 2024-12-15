using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using ModularPipelines.Context;
using ModularPipelines.Engine;

namespace ModularPipelines.Pulumi.Extensions;

[ExcludeFromCodeCoverage]
public static class PulumiExtensions
{
#pragma warning disable CA2255
    [ModuleInitializer]
#pragma warning restore CA2255
    public static void RegisterPulumiContext()
    {
        ModularPipelinesContextRegistry.RegisterContext(collection => RegisterPulumiContext(collection));
    }

    public static IServiceCollection RegisterPulumiContext(this IServiceCollection services)
    {
        services.TryAddScoped<IPulumi, Pulumi>();

        return services;
    }

    public static IPulumi Pulumi(this IPipelineHookContext context) => context.ServiceProvider.GetRequiredService<IPulumi>();
}