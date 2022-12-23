using EnergyCalculator.Core.Contracts;
using EnergyCalculator.Core.Models.Product;
using EnergyCalculator.Core.Models.Receipt;
using EnergyCalculator.Infrastructure.Data.Common;
using EnergyCalculator.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyCalculator.Core.Services
{
    public class ReceiptService : IReceiptService
    {
        private readonly IRepository repo;

        public ReceiptService(IRepository repo)
        {
            this.repo = repo;
        }

        public async Task<IEnumerable<AllReceiptViewModel>> All()
        {
            var receipts = await repo.AllReadonly<Receipt>()
                .Select(i => new EnergyCalculator.Core.Models.Receipt.AllReceiptViewModel()
                {
                    Name = i.Name,
                    TotalQuantity=i.TotalQuantity
                })
                .ToListAsync();

            return receipts;
        }
    }
}
