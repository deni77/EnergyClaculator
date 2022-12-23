using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyCalculator.Infrastructure.Data.Entities
{
    public class Receipt
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; } = null!;

        [Precision(18,3)]
        public decimal TotalQuantity { get; set; }

         public string UserId { get; set; }= null!;

        public List<Ingredient> Ingredients  { get; set; } = new List<Ingredient>();
    }
}
