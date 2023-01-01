using System.ComponentModel.DataAnnotations;

namespace EnergyCalculator.Core.Models.Receipt
{
    public class ReceiptViewModel
    {
        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Name must be at least 3 characters !")]
       
        public string Name { get; set; } = null!;  

         public string UserId { get; set; }= null!;
      }
}
