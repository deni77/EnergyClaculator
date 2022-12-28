using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyCalculator.Core.Models.Receipt
{   
    public class ReceiptViewModel
    {
        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Name must be at least 3 characters")]
       
        public string Name { get; set; } = null!;  

         public string UserId { get; set; }= null!;
      //  public List<EnergyCalculator.Infrastructure.Data.Entities.Ingredient> Ingredients  { get; set; }
       //     = new List<EnergyCalculator.Infrastructure.Data.Entities.Ingredient>();
    }
}
