using System.Reflection;
using CarCatalogWebService.Context;
using CarCatalogWebService.Interfaces;
using CarCatalogWebService.Services.CarModels;
using CarCatalogWebService.Services.Cars;
using CarCatalogWebService.Services.Features;
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
        services.AddScoped<ICarModelService, CarModelService>();
        services.AddScoped<IFeatureService, FeatureService>();
        
        return services;
    }
}