using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnergyCalculator.Infrastructure.Data.Entities
{
    public class Ingredient
    {
        public int Id { get; set; }

        [Required]
        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; init; } = null!;

        [Required]
        public int ReceiptId { get; set; }

        [ForeignKey(nameof(ReceiptId))]
        public Receipt Receipt { get; init; } = null!;

        public string UserId { get; set; } = null!;

        [Required]
        public double QuantityForIngredient { get; set; }

        [Required]
        public double TotalCalories { get; set; }
    }
}
