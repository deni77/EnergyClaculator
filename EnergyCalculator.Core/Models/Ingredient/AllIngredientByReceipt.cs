using EnergyCalculator.Core.Models.Receipt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyCalculator.Core.Models.Ingredient
{
    public class AllIngredientByReceipt : AllIngredientViewModel
    {
        public string ReceiptName { get; set; } = null!;

        public string TotalCaloriesForReceipt { get; set; }= null!;

        public IEnumerable<AllIngredientViewModel> Ingredients { get; set; }
                          = new List<AllIngredientViewModel>();
    }
}
