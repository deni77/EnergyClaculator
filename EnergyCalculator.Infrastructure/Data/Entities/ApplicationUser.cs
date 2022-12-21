using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyCalculator.Infrastructure.Data.Entities
{
    public class ApplicationUser : IdentityUser
    {
       public bool IsActive { get; set; } = true;
    }
}
