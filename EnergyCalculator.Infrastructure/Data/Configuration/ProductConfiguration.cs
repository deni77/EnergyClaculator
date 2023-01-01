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
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(CreateProducts());

        }

        private List<Product> CreateProducts()
        {
            var products = new List<Product>();

            var product = new Product()
            {
                Id = 1,
                Name = "Swinsko ",
                CaloriesPer100grams = 200
            };

            products.Add(product);

            return products;
        }
    }

}
