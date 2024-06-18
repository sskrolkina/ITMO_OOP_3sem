using Lab5.CoreBusinessRules.Services;
using Lab5.CoreBusinessRules.Services.UseScenarios;
using Lab5.CoreBusinessRules.Services.UseScenarios.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace Lab5.CoreBusinessRules.Extensions;

public static class CoreServicesExtensions
{
    public static IServiceCollection GetCoreServices(this IServiceCollection collection)
    {
        collection.AddScoped<TerminalLogin>();
        collection.AddScoped<IUserUseScenario, UserUseScenario>();
        collection.AddScoped<IAdminUseScenario, AdminUseScenario>();

        return collection;
    }
}