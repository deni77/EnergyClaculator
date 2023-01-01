using EnergyCalculator.Core.Models.Receipt;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyCalculator.Core.Models.Ingredient
{
    public class IngredientBySearchViewModel
    {
        [Display(Name = "Choose a receipt ")]
        [Required]
        [Range(1, 1000000, ErrorMessage = "The receipt is required !")]
        public int ReceiptId { get; init; }
        public IEnumerable<IngredientReceiptModel> Receipts { get; set; }
                          = new List<IngredientReceiptModel>();
    }
}
