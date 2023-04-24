using Devacore.Humaxoo.Application.Common.Interfaces.Authentication;
using Devacore.Humaxoo.Application.Common.Interfaces.Services;
using Devacore.Humaxoo.Application.Common.Persistence;
using Devacore.Humaxoo.Infrastructure.Authentication;
using Devacore.Humaxoo.Infrastructure.Persistence;
using Devacore.Humaxoo.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Devacore.Humaxoo.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        ConfigurationManager configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
        services.AddScoped<IUserRepository, UserRepository>();

        return services;
    }
}