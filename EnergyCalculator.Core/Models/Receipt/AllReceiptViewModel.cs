using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyCalculator.Core.Models.Receipt
{
    public class AllReceiptViewModel
    {
        public string Name { get; set; } = null!;

         public decimal TotalQuantity { get; set; }
    }
}
