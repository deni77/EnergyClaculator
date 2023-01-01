using EnergyCalculator.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyCalculator.Infrastructure.Data.Configuration
{
    public class ReceiptConfiguration : IEntityTypeConfiguration<Receipt>
    {
        public void Configure(EntityTypeBuilder<Receipt> builder)
        {
            builder.HasData(CreateReceipts());
        }

        private List<Receipt> CreateReceipts()
        {
            var receipts = new List<Receipt>();

            var rec = new Receipt()
            {
                Id = 1,
                Name = "Swinsko sy zele",
                UserId = "87612856 - d498 - 4529 - b453 - bgrfd8395082"
            };

            var receipUser = new Receipt()
            {
                Id = 2,
                UserId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                Name = "Brocoli sys smetana",
            };

            receipts.Add(rec);
            receipts.Add(receipUser);

            return receipts;
        }
    }

}
