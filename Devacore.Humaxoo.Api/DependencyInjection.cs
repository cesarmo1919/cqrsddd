using Devacore.Humaxoo.Api.Common.Errors;
using Devacore.Humaxoo.Api.Common.Mapping;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Devacore.Humaxoo.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddMappings();

        services.AddControllers();
        services.AddSingleton<ProblemDetailsFactory, HumaxooProblemDetailsFactory>();

        return services;
    }
}