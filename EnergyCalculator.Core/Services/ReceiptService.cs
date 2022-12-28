using EnergyCalculator.Core.Contracts;
using EnergyCalculator.Core.Models.Ingredient;
using EnergyCalculator.Core.Models.Product;
using EnergyCalculator.Core.Models.Receipt;
using EnergyCalculator.Infrastructure.Data.Common;
using EnergyCalculator.Infrastructure.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EnergyCalculator.Core.Services
{
    public class ReceiptService : IReceiptService
    {
        private readonly IRepository repo;

        public ReceiptService(IRepository repo)
        {
            this.repo = repo;
        }

        public async Task<int> Add(ReceiptViewModel model)
        {

            var receipt = new Receipt()
            {
                Name = model.Name.ToLower(),
                TotalCalories = 0,
                UserId = model.UserId,
              
                  };

            await repo.AddAsync(receipt);
            await repo.SaveChangesAsync();

            return receipt.Id;
        } 

        public async Task<IEnumerable<AllReceiptViewModel>> All()
        {
            var receipts = await repo.AllReadonly<Receipt>()
                .Select(i => new EnergyCalculator.Core.Models.Receipt.AllReceiptViewModel()
                {
                    Id = i.Id,
                    Name = i.Name,
                    TotalQuantity =i.TotalCalories
                })
                .ToListAsync();

            return receipts;
        }

        public async Task<bool> Exists(string name)
        {
            var res = await repo.AllReadonly<Receipt>()
                 .Where(u=>u.Name==name.ToLower()).ToListAsync();

            if (res.Count!=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<Receipt> GetReceiptById(int id)
        {
           return  await repo.AllReadonly<Receipt>()
                 .Where(u=>u.Id==id).FirstAsync();
        }

        public async Task<IEnumerable<AllReceiptViewModel>> MyReceipts(string userId)
        {
             return  await repo.AllReadonly<Receipt>()
                .Where(u=>u.UserId==userId)
              .Select(i => new AllReceiptViewModel()
              {
                  Id = i.Id,
                  Name=i.Name,
                  TotalQuantity = i.TotalCalories
              })
              .ToListAsync();
        }
    }
}
