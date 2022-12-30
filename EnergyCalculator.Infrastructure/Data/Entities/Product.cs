using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyCalculator.Infrastructure.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
         [StringLength(30)]
        public string Name { get; set; }= null!;

         [Required]
           public double CaloriesPer100grams { get; set; }

        public List<Ingredient> Ingredients  { get; set; } = new List<Ingredient>();

    }
}
