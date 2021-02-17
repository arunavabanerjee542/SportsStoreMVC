using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStoreMVC.Models
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder mb)
        {
            mb.Entity<Product>().HasData(
                new Product
                {
                    ProductID = 1,
                    Name = "Lifejacket",
                    Description = "Protective and fashionable",
                    Category = "Watersports",
                    Price = 48.95m
                },
new Product
{
    ProductID = 2,
    Name = "Soccer Ball",
    Description = "FIFA-approved size and weight",
    Category = "Soccer",
    Price = 19.50m
},
new Product
{
    ProductID = 3,
    Name = "Corner Flags",
    Description = "Give your playing field a professional touch",
    Category = "Soccer",
    Price = 34.95m
},
new Product
{
    ProductID = 4,
    Name = "Stadium",
    Description = "Flat-packed 35,000-seat stadium",
    Category = "Soccer",
    Price = 79500
}) ;


    }
    }

}