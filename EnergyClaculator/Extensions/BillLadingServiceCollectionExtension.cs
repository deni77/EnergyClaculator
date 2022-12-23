using EnergyCalculator.Core.Contracts.Admin;
using EnergyCalculator.Core.Services.Admin;
using NuGet.Protocol.Core.Types;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class BillLadingServiceCollectionExtension
    {

         public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
             services.AddScoped<IUserService, UserService>();

             return services;
        }
    }
}
