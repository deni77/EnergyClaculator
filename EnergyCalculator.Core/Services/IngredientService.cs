using EnergyCalculator.Core.Contracts;
using EnergyCalculator.Core.Models.Ingredient;
using EnergyCalculator.Infrastructure.Data.Common;
using EnergyCalculator.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyCalculator.Core.Services
{
    public class IngredientService : IIngredientService
    {
        private readonly IRepository repo;

        public IngredientService(IRepository repo)
        {
            this.repo = repo;
        }

        public async Task<IEnumerable<AllIngredientViewModel>> All()
        {
            var ingredients = await repo.AllReadonly<Ingredient>()
                .Select(i=>new AllIngredientViewModel() { 
                 Product=i.Product.Name,
                  Receipt=i.Receipt.Name,
                   QuantityForIngredient=i.QuantityForIngredient ,
                   TotalQuantity=i.TotalQuantity 
                  // UserId=
                })
                .ToListAsync();

            return ingredients;
        }
    }
}
