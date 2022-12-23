using EnergyCalculator.Core.Contracts;
using EnergyCalculator.Core.Models.Ingredient;
using EnergyCalculator.Core.Models.Product;
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
    public class ProductService : IProductService
    {
        private readonly IRepository repo;

        public ProductService(IRepository repo)
        {
            this.repo = repo;
        }

        public async Task<IEnumerable<AllProductViewModel>> All()
        {
            var products = await repo.AllReadonly<Product>()
                .Select(i => new AllProductViewModel()
                {
                    CaloriesPer100grams = i.CaloriesPer100grams,
                    Name = i.Name
                })
                .ToListAsync();

            return products;
        }
    }
}
