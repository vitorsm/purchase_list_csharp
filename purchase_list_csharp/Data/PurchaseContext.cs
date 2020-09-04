using System;
using Microsoft.EntityFrameworkCore;
using purchase_list_bg.Models;

namespace purchase_list_bg.Data
{
    public class PurchaseContext : DbContext
    {
        public PurchaseContext(DbContextOptions<PurchaseContext> options) : base(options)
        {
        }

        public DbSet<Purchase> Purchases { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Purchase>().ToTable("purchase");
        }
    }
}