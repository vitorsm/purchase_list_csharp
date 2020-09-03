using System;
using Microsoft.EntityFrameworkCore;
using purchase_list_bg.Models;

namespace purchase_list_bg.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<UserContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("product");
        }
    }
}