using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RetailInventory.Labs
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public List<Product> Products { get; set; } = new();
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
    }



    public class AppDbContext : DbContext
    {
        
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=BT-22051178\\SQLEXPRESS;Database=RetailStore;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;");
        }


    }

    public static class Lab2_DbContextSetup
    {
        public static void Run()
        {
            using var context = new AppDbContext();
            context.Database.EnsureCreated();
            Console.WriteLine("Lab 2 - DbContext setup complete. Database ensured.");
        }
    }
}
