using System;

class Product
{
    public int ProductId;
    public string ProductName;
    public string Category;

    public Product(int id, string name, string category)
    {
        ProductId = id;
        ProductName = name;
        Category = category;
    }
}

class ECommercePlatform
{
    static Product LinearSearchByName(Product[] products, string name)
    {
        foreach (var product in products)
        {
            if (product.ProductName.Equals(name, StringComparison.OrdinalIgnoreCase))
                return product;
        }
        return null;
    }

    static Product BinarySearchById(Product[] products, int id)
    {
        Array.Sort(products, (a, b) => a.ProductId.CompareTo(b.ProductId));
        int left = 0, right = products.Length - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (products[mid].ProductId == id)
                return products[mid];
            else if (products[mid].ProductId < id)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return null;
    }

    static void Main()
    {
        Product[] products = {
            new Product(103, "Laptop", "Electronics"),
            new Product(101, "Mouse", "Electronics"),
            new Product(104, "Shoes", "Footwear"),
            new Product(102, "Keyboard", "Electronics"),
            new Product(105, "T-shirt", "Clothing")
        };

        var result1 = LinearSearchByName(products, "Keyboard");
        Console.WriteLine(result1 != null ? $"Using Linear Search: {result1.ProductName}" : "Not found");

        var result2 = BinarySearchById(products, 104);
        Console.WriteLine(result2 != null ? $"Using Binary Search: {result2.ProductName}" : "Not found");
    }
}
