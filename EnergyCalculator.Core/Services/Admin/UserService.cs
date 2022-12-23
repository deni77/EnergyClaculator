using EnergyCalculator.Core.Contracts.Admin;
using EnergyCalculator.Infrastructure.Data.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyCalculator.Core.Services.Admin
{
    public class UserService : IUserService
    {
         private readonly  UserManager<ApplicationUser> userManager;

        public UserService(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }

        public async Task AddToRoleUser(ApplicationUser user)
        {
            await userManager.AddToRoleAsync(user, "User");
        }
    }
}
