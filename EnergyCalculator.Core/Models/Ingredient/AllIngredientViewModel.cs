using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EnergyCalculator.Core.Models.Ingredient
{
    public class AllIngredientViewModel
    {
         public int Id { get; init; }

        public string Receipt { get; init; } = null!;


        public string Product { get; init; } = null!;

        public double QuantityForIngredient { get; set; }

        public double TotalQuantity { get; set; }

    }
}
