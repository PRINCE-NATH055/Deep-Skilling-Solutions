using System;

namespace RetailInventory.Labs
{
    public static class Lab1_OrmIntro
    {
        public static void Run()
        {
            Console.WriteLine("Lab 1 - ORM Introduction");
            Console.WriteLine("What is ORM?");
            Console.WriteLine("ORM (Object-Relational Mapping) maps C# classes to database tables.");
            Console.WriteLine("Benefits: Productivity, maintainability, abstraction from SQL.");

            Console.WriteLine("\nEF Core vs EF Framework:");
            Console.WriteLine("EF Core: Cross-platform, lightweight, supports async, LINQ.");
            Console.WriteLine("EF Framework (EF6): Windows-only, mature but less flexible.");

            Console.WriteLine("\nEF Core 8.0 Features:");
            Console.WriteLine("- JSON column mapping");
            Console.WriteLine("- Compiled models for performance");
            Console.WriteLine("- Interceptors and better bulk operations");
        }
    }
}
