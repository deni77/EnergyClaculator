using System.ComponentModel.DataAnnotations;

namespace EnergyCalculator.Core.Models.Product
{
    public class ProductViewModel
    {
        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Name must be at least 3 characters !")]
        public string Name { get; set; } = null!;

        [Range(1, 10000, ErrorMessage = "The Calories must be greater than 0 !")]
        [Display(Name = "Calories Per 100grammes")]
       
         public double CaloriesPer100grams { get; set; }
    }
}
