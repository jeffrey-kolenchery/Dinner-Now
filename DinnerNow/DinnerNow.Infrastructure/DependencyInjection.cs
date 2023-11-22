using DinnerNow.Application.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace DinnerNow.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        return services;
    }
}