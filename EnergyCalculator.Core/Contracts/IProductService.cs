using EnergyCalculator.Core.Models.Ingredient;
using EnergyCalculator.Core.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyCalculator.Core.Contracts
{
    public interface IProductService
    {
         Task<IEnumerable<AllProductViewModel>> All();
    }
}
