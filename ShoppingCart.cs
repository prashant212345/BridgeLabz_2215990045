using System;
using System.Collections.Generic;
using System.Linq;

class ShoppingCart
{
    static Dictionary<string, double> productPrices = new Dictionary<string, double>(); // Stores product prices
    static LinkedList<KeyValuePair<string, double>> cartOrder = new LinkedList<KeyValuePair<string, double>>(); // Maintains order
    static SortedDictionary<double, List<string>> sortedProducts = new SortedDictionary<double, List<string>>(); // Sorts by price

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nShopping Cart System");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Remove Product");
            Console.WriteLine("3. Display Cart (Order Added)");
            Console.WriteLine("4. Display Cart (Sorted by Price)");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.Write("Invalid input! Please enter a number: ");
            }

            switch (choice)
            {
                case 1:
                    AddProduct();
                    break;
                case 2:
                    RemoveProduct();
                    break;
                case 3:
                    DisplayCartOrder();
                    break;
                case 4:
                    DisplaySortedCart();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice! Try again.");
                    break;
            }
        }
    }

    static void AddProduct()
    {
        Console.Write("Enter Product Name: ");
        string product = Console.ReadLine().Trim();

        if (string.IsNullOrEmpty(product))
        {
            Console.WriteLine("Product name cannot be empty!");
            return;
        }

        Console.Write("Enter Product Price: ");
        double price;
        while (!double.TryParse(Console.ReadLine(), out price) || price <= 0)
        {
            Console.Write("Invalid price! Enter a valid positive price: ");
        }

        // Update Dictionary
        productPrices[product] = price;

        // Update LinkedList (order of insertion)
        cartOrder.AddLast(new KeyValuePair<string, double>(product, price));

        // Update SortedDictionary
        if (!sortedProducts.ContainsKey(price))
        {
            sortedProducts[price] = new List<string>();
        }
        sortedProducts[price].Add(product);

        Console.WriteLine($"{product} added to cart.");
    }

    static void RemoveProduct()
    {
        Console.Write("Enter Product Name to Remove: ");
        string product = Console.ReadLine().Trim();

        if (!productPrices.ContainsKey(product))
        {
            Console.WriteLine("Product not found in cart.");
            return;
        }

        double price = productPrices[product];

        // Remove from Dictionary
        productPrices.Remove(product);

        // Remove from LinkedList (order of insertion)
        var node = cartOrder.First;
        while (node != null)
        {
            if (node.Value.Key == product)
            {
                cartOrder.Remove(node);
                break;
            }
            node = node.Next;
        }

        // Remove from SortedDictionary
        sortedProducts[price].Remove(product);
        if (sortedProducts[price].Count == 0)
        {
            sortedProducts.Remove(price);
        }

        Console.WriteLine($"{product} removed from cart.");
    }

    static void DisplayCartOrder()
    {
        Console.WriteLine("\nShopping Cart (Order Added):");
        foreach (var item in cartOrder)
        {
            Console.WriteLine($"{item.Key}: ${item.Value}");
        }
    }

    static void DisplaySortedCart()
    {
        Console.WriteLine("\nShopping Cart (Sorted by Price):");
        foreach (var priceGroup in sortedProducts)
        {
            foreach (var product in priceGroup.Value)
            {
                Console.WriteLine($"{product}: ${priceGroup.Key}");
            }
        }
    }
}
