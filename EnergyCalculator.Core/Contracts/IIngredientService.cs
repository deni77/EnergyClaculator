using EnergyCalculator.Core.Models.Ingredient;
using EnergyCalculator.Core.Models.Product;
using EnergyCalculator.Core.Models.Receipt;
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

        Task<IEnumerable<IngredientProductModel>> AllProducts();

        Task<IEnumerable<IngredientReceiptModel>> AllReceipts();

        Task<int> Add(IngredientViewModel model);

        Task<bool> ExistsIngredient(int productId, int receiptId);

        Task<IEnumerable<AllIngredientViewModel>> MyIngredients(string userId);
        Task<double> CalculateTotalCaloriesByProduct(double productId, double totalForIngredient);

       Task<AllIngredientByReceipt> SearchIngredientByReceipt(int receiptId);
    }
}
