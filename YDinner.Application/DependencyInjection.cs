using Microsoft.Extensions.DependencyInjection;
using YDinner.Application.Services.Authentication;

namespace YDinner.Application;
public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        return services;
    }
}
