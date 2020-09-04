using System;
using Microsoft.EntityFrameworkCore;
using purchase_list_bg.Models;


namespace purchase_list_bg.Data
{
    public class PurchaseListContext : DbContext
    {
        public PurchaseListContext(DbContextOptions<PurchaseListContext> options) : base(options)
        {
        }

        public DbSet<PurchaseList> PurchaseLists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PurchaseList>().ToTable("purchase_list");
        }
    }
}