using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStoreMVC.Models
{
    public class SportsStoreDb : DbContext
    {
        public SportsStoreDb(DbContextOptions<SportsStoreDb> options) :
            base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }


    }
}
