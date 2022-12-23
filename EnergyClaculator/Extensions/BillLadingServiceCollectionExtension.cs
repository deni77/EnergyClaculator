using EnergyCalculator.Core.Contracts;
using EnergyCalculator.Core.Contracts.Admin;
using EnergyCalculator.Core.Services;
using EnergyCalculator.Core.Services.Admin;
using EnergyCalculator.Infrastructure.Data.Common;
using NuGet.Protocol.Core.Types;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class BillLadingServiceCollectionExtension
    {

         public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
             services.AddScoped<IUserService, UserService>();

            services.AddScoped<IIngredientService, IngredientService>();

            services.AddScoped<IProductService, ProductService>();

             services.AddScoped<IRepository, EnergyCalculator.Infrastructure.Data.Common.Repository>();

             return services;
        }
    }
}
