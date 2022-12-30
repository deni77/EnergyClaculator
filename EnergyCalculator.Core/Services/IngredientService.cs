using EnergyCalculator.Core.Contracts;
using EnergyCalculator.Core.Models.Ingredient;
using EnergyCalculator.Core.Models.Product;
using EnergyCalculator.Core.Models.Receipt;
using EnergyCalculator.Infrastructure.Data.Common;
using EnergyCalculator.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EnergyCalculator.Core.Services
{
    public class IngredientService : IIngredientService
    {
        private readonly IRepository repo;

        private readonly IReceiptService receiptService;

        public IngredientService(IRepository repo, IReceiptService receiptService)
        {
            this.repo = repo;
            this.receiptService = receiptService;
        }

        public async Task<int> Add(IngredientViewModel model)
        {
            var ingredient = new Ingredient()
            {
                ProductId = model.ProductId,
                ReceiptId = model.ReceiptId,
                QuantityForIngredient = model.QuantityForIngredient,
                TotalCalories = model.TotalCalories,
                UserId = model.UserId
            };


            await repo.AddAsync(ingredient);
            await repo.SaveChangesAsync();

            Receipt receipt = await receiptService.GetReceiptById(model.ReceiptId);
            receipt.TotalCalories += ingredient.TotalCalories;

            repo.Update(receipt);

            await repo.SaveChangesAsync();

            return ingredient.Id;
        }

        public async Task<IEnumerable<AllIngredientViewModel>> All()
        {
            var ingredients = await repo.AllReadonly<Ingredient>()
                .Select(i => new AllIngredientViewModel()
                {
                    Id = i.Id,
                    Product = i.Product.Name,
                    Receipt = i.Receipt.Name,
                    QuantityForIngredient = i.QuantityForIngredient,
                    TotalQuantity = i.TotalCalories
                    // UserId=
                })
                .ToListAsync();

            return ingredients;
        }

        public async Task<IEnumerable<IngredientProductModel>> AllProducts()
        {
            var result = new List<IngredientProductModel>();

            result.Add(new IngredientProductModel() {  Id=0, Name=""});

            var list= await repo.AllReadonly<Product>()
               .OrderBy(c => c.Name)
               .Select(c => new IngredientProductModel()
               {
                   Id = c.Id,
                   Name = c.Name
               })
               .ToListAsync();

            result.AddRange(list);

            return result;
        }

        public async Task<IEnumerable<IngredientReceiptModel>> AllReceipts()
        {
            return await repo.AllReadonly<Receipt>()
                .OrderBy(c => c.Name)
                .Select(c => new IngredientReceiptModel()
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToListAsync();
        }

        public async Task<double> CalculateTotalCaloriesByProduct(double productId, double totalForIngredient)
        {
            var product = await repo.AllReadonly<Product>()
                .FirstOrDefaultAsync(c => c.Id == productId);

            return product.CaloriesPer100grams * totalForIngredient / 100;
        }

        public async Task<bool> ExistsIngredient(int productId, int receiptId)
        {
            var res = await repo.AllReadonly<Ingredient>()
                 .Where(u => u.ProductId == productId && u.ReceiptId == receiptId).ToListAsync();

            if (res.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<IEnumerable<AllIngredientViewModel>> MyIngredients(string userId)
        {
            return  await repo.AllReadonly<Ingredient>()
                .Where(u=>u.UserId==userId)
              .Select(i => new AllIngredientViewModel()
              {
                  Id = i.Id,
                  Product = i.Product.Name,
                  Receipt = i.Receipt.Name,
                  QuantityForIngredient = i.QuantityForIngredient,
                  TotalQuantity = i.TotalCalories
              })
              .ToListAsync();
        }
    }
}
