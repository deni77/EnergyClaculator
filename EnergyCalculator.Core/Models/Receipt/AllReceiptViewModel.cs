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
        public int Id { get; init; }

           public string Name { get; set; } = null!;
       public int TotalQuantity { get; set; }

    }
}
