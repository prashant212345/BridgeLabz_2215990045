using System;

class Product
{
    // Static variable for discount (shared by all products)
    private static double Discount = 10;

    // Readonly variable for ProductID (cannot be changed after assignment)
    public readonly int ProductId;
    public string ProductName;
    public double Price;
    public int Quantity;

    // Constructor using 'this' keyword
    public Product(int productid, string productName, double price, int quantity){
        this.ProductId = productid;
        this.ProductName = productName;
        this.Price = price;
        this.Quantity = quantity;
    }

    // Static method to update discount
    public static void UpdateDiscount(double newDiscount){
        Discount = newDiscount;
        Console.WriteLine("Updated Discount: " + Discount + "%");
    }

    // Method to display product details using 'is' operator
    public void ProductDetails(){
        if (this is Product){
            Console.WriteLine("Id of the Product: " + ProductId);
            Console.WriteLine("Name of the Product: " + ProductName);
            Console.WriteLine("Price of the Product: " + Price);
            Console.WriteLine("Quantity of the Product: " + Quantity);
            Console.WriteLine("Discount Applied: " + Discount + "%");
            Console.WriteLine();
        }
    }

    static void Main(){
        // Creating product objects
        Product pd1 = new Product(101, "Biscuit", 20, 1);
        Product pd2 = new Product(102, "Namkeen", 50, 2);

        // Display product details
        pd1.ProductDetails();
        pd2.ProductDetails();

        // Update discount and show again
        Product.UpdateDiscount(15);
        
        // Display product details after discount update
        pd1.ProductDetails();
        pd2.ProductDetails();
    }
}
