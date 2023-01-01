using System.ComponentModel.DataAnnotations;

namespace EnergyCalculator.Infrastructure.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; } = null!;

        [Required]
        public double CaloriesPer100grams { get; set; }

        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

    }
}
