using System;

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string Category { get; set; }

    public Product(int id, string name, string category)
    {
        ProductId = id;
        ProductName = name;
        Category = category;
    }

    public override string ToString()
    {
        return $"ID: {ProductId}, Name: {ProductName}, Category: {Category}";
    }
}

class Program
{
    // Linear Search by product name
    static Product? LinearSearch(Product[] products, string name)
    {
        foreach (var product in products)
        {
            if (product.ProductName.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                return product;
            }
        }
        return null;
    }

    // Binary Search by product ID (array must be sorted)
    static Product? BinarySearch(Product[] products, int id)
    {
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
            new Product(103, "Phone", "Electronics"),
            new Product(101, "Shoes", "Fashion"),
            new Product(102, "Laptop", "Electronics"),
            new Product(104, "Book", "Stationery")
        };

        // Sort by ProductId for Binary Search
        Array.Sort(products, (a, b) => a.ProductId.CompareTo(b.ProductId));

        Console.WriteLine("Linear Search for 'Laptop':");
        var result1 = LinearSearch(products, "Laptop");
        Console.WriteLine(result1 != null ? $"Found: {result1}" : "Not found");

        Console.WriteLine("\nBinary Search for ID 104:");
        var result2 = BinarySearch(products, 104);
        Console.WriteLine(result2 != null ? $"Found: {result2}" : "Not found");
    }
}
