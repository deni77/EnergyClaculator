using EnergyCalculator.Core.Models.Ingredient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyCalculator.Core.Contracts
{
    public interface IIngredientService
    {
        Task<IEnumerable<AllIngredientViewModel>> All();
    }
}
