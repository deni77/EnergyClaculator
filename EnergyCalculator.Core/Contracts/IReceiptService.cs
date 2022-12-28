using EnergyCalculator.Core.Models.Product;
using EnergyCalculator.Core.Models.Receipt;
using EnergyCalculator.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyCalculator.Core.Contracts
{
    public interface IReceiptService
    {
          Task<IEnumerable<AllReceiptViewModel>> All();

         Task<int> Add(ReceiptViewModel model);
        Task<bool> Exists(string name);

        Task<Receipt> GetReceiptById(int id);
    }
}
