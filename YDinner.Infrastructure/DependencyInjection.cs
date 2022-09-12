using Microsoft.Extensions.DependencyInjection;
using YDinner.Application.Services.Authentication;

namespace YDinner.Application;
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        return services;
    }
}
