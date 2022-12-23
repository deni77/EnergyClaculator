using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyCalculator.Core.Models.Product
{
    public class AllProductViewModel:ProductViewModel
    {
        public int Id { get; init; }
        }
}
