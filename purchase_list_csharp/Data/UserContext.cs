using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using purchase_list_bg.Models;

namespace purchase_list_bg.Data
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options) 
        {
        }

        public DbSet<User> Users { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("user");
        }

        public User AuthenticateUser(string login, string password)
        {
            return this.Users.FirstOrDefault(u => u.Login == login && u.Password == password);
        }
    }
}