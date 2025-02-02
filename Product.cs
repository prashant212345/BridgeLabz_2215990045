using System;

class Product
{
    // Instance Variables (Specific to each product)
    private string productName;
    private double price;

    // Class Variable (Shared among all products)
    private static int totalProducts = 0;

    // Constructor to initialize a product
    public Product(string name, double price)
    {
        this.productName = name;
        this.price = price;
        totalProducts++; // Increment total product count whenever a new product is created
    }

    // Instance Method: Display details of an individual product
    public void DisplayProductDetails()
    {
        Console.WriteLine("Product Name: " + productName);
        Console.WriteLine("Price: $" + price);
    }

    // Class Method: Display total number of products
    public static void DisplayTotalProducts()
    {
        Console.WriteLine("Total Products Created: " + totalProducts);
    }

    // Main Method
    static void Main()
    {
        // Creating Product Objects
        Product product1 = new Product("Laptop", 750.99);
        Product product2 = new Product("Smartphone", 499.50);

        // Display details of each product
        Console.WriteLine("Product 1 Details:");
        product1.DisplayProductDetails();
        Console.WriteLine();

        Console.WriteLine("Product 2 Details:");
        product2.DisplayProductDetails();
        Console.WriteLine();

        // Display total products created
        Product.DisplayTotalProducts();
    }
}
