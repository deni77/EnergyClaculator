﻿using EnergyCalculator.Infrastructure.Data.Configuration;
using EnergyCalculator.Infrastructure.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EnergyCalculator.Infrastructure
{
     public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string> //, 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserConfiguration());

            base.OnModelCreating(builder);

            CreateRoles(builder);
        }

        private static void CreateRoles(ModelBuilder builder)
        {
            //create roles
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "2c5e174e-3b0e-446f-86af-483d56fd7210", Name = "Admin", NormalizedName = "ADMIN" });
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "2787b74e-3c0v-466f-m8af-654d56fd9010", Name = "User", NormalizedName = "User" });
           
            //Seeding the relation between our user and role to AspNetUserRoles table
            //admin - rolq admin
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                    UserId = "87612856-d498-4529-b453-bgrfd8395082"
                }
            );

            //user - rolq user
            builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = "2787b74e-3c0v-466f-m8af-654d56fd9010", 
                UserId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e"
            }
        );
        }
    }
}
