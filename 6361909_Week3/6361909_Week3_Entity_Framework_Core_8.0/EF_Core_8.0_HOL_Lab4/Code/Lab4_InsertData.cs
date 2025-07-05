using System;
using System.Linq;
using RetailInventory.Labs;

namespace RetailInventory.Labs
{
    public class Lab4_InsertData
    {
        public static void Run()
        {
            using (var context = new AppDbContext())
            {
                // Check if specific sample products already exist
                bool alreadyInserted = context.Products.Any(p => p.Name == "Smartphone" || p.Name == "Laptop" || p.Name == "Jeans");

                if (alreadyInserted)
                {
                    Console.WriteLine("Data already exists. Not inserting again.");
                    return;
                }

                
                var electronics = new Category { Name = "Electronics" };
                var clothing = new Category { Name = "Clothing" };

                context.Categories.AddRange(electronics, clothing);
                context.SaveChanges(); // Generate IDs

                
                var product1 = new Product { Name = "Smartphone", Price = 299.99M, CategoryId = electronics.Id };
                var product2 = new Product { Name = "Laptop", Price = 999.99M, CategoryId = electronics.Id };
                var product3 = new Product { Name = "Jeans", Price = 49.99M, CategoryId = clothing.Id };

                context.Products.AddRange(product1, product2, product3);
                context.SaveChanges();

                Console.WriteLine("Sample data inserted successfully.");
            }
        }
    }
}
