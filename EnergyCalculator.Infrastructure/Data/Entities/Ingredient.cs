using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyCalculator.Infrastructure.Data.Entities
{
    public class Ingredient
    {
        public int Id { get; set; }

        [Required]
         [StringLength(30)]
        public string Name { get; set; }

          [Required]
        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; init; } = null!;

          [Required]
        public int ReceiptId { get; set; }

        [ForeignKey(nameof(ReceiptId))]
        public Receipt Receipt { get; init; } = null!;

        [Required]
        [Precision(18,3)]
        public decimal QuantityForIngredient { get; set; }

         [Required]
        [Precision(18,3)]
        public decimal TotalQuantity { get; set; }
    }
}
