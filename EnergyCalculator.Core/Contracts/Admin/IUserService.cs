using EnergyCalculator.Infrastructure.Data.Entities;

namespace EnergyCalculator.Core.Contracts.Admin
{
    public interface IUserService
    {
        Task AddToRoleUser(ApplicationUser user);
    }
}
