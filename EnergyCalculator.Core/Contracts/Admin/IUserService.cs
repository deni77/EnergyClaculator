using EnergyCalculator.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyCalculator.Core.Contracts.Admin
{
    public interface IUserService
    {
        Task AddToRoleUser(ApplicationUser user);
    }
}
