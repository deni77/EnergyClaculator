using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EnergyCalculator.Core.Models.Product
{
    public class ProductViewModel
    {
        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Name must be at least 3 characters")]
         public string Name { get; set; }

        [Range(1, 10000, ErrorMessage = "The field must be greater than 0 !")]
        [Display(Name = "Calories Per 100grammes")]
       
         public double CaloriesPer100grams { get; set; }
    }
}
