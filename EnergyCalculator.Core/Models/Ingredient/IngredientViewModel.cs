using EnergyCalculator.Core.Models.Product;
using EnergyCalculator.Core.Models.Receipt;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EnergyCalculator.Core.Models.Ingredient
{
    public class IngredientViewModel
    {
        [Display(Name = "Choose a receipt ")]
        public int ReceiptId { get; init; }

        [Display(Name = "Choose a product ")]
        public int ProductId { get; init; }

        [Required]
         [Display(Name = "Quantity in GRAMMES For the Ingredient ")]
          [Range(100, 10000, ErrorMessage = "The field must be greater than 100 !")]
       
        public int QuantityForIngredient { get; set; }


        public int TotalCalories { get; set; } = 0;

        public string UserId { get; set; }

        public IEnumerable<IngredientProductModel> Products { get; set; }
                           = new List<IngredientProductModel>();

        public IEnumerable<IngredientReceiptModel> Receipts { get; set; }
                           = new List<IngredientReceiptModel>();
    }
}
