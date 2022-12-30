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

        public async Task<int> Add(ProductViewModel model)
        {
             var product = new Product()
            {
                  Name=model.Name.ToLower(),
                   CaloriesPer100grams=model.CaloriesPer100grams
             };

            await repo.AddAsync(product);
            await repo.SaveChangesAsync();

            return product.Id;
        }

        public async Task<IEnumerable<AllProductViewModel>> All()
        {
            var products = await repo.AllReadonly<Product>()
                .OrderBy(i=>i.Name)
                .Select(i => new AllProductViewModel()
                {
                     Id = i.Id,
                    CaloriesPer100grams = i.CaloriesPer100grams,
                    Name = i.Name
                })
                .ToListAsync();

            return products;
        }
        public async Task<bool> Exists(string name)
        {
            var res = await repo.AllReadonly<Product>()
                 .Where(u=>u.Name==name.ToLower()).ToListAsync();

            if (res.Count!=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
