using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RetailInventory.Labs
{
    public class Lab5_RetrievingData
    {
        public static void Run()
        {
            using (var context = new AppDbContext())
            {
                var productsWithCategory = context.Products
                    .Include(p => p.Category)
                    .ToList();

                if (!productsWithCategory.Any())
                {
                    Console.WriteLine("No products found in the database.");
                    return;
                }

                Console.WriteLine("Lab 5 - Retrieving Data from Products Table with Category");
                Console.WriteLine(new string('=', 50));
                Console.WriteLine("Products List:\n");


                foreach (var product in productsWithCategory)
                {
                    Console.WriteLine($"ID: {product.Id}");
                    Console.WriteLine($"Name: {product.Name}");
                    Console.WriteLine($"Price: {product.Price:C}");
                    Console.WriteLine($"Category: {product.Category?.Name ?? "Uncategorized"}");
                    Console.WriteLine(new string('-', 30));
                }
            }
        }
    }
}
