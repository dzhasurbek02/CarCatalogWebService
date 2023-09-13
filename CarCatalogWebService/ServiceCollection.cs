using System.Reflection;
using CarCatalogWebService.Context;
using CarCatalogWebService.Interfaces;
using CarCatalogWebService.Services.Cars;
using CarCatalogWebService.Services.Users;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace CarCatalogWebService;

public static class ServiceCollection
{
    public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
    {
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddScoped<IApplicationDbContext, ApplicationDbContext>();
        services.AddScoped<ICarService, CarService>();
        services.AddScoped<IUserService, UserService>();
        
        return services;
    }
}