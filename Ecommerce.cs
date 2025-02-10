using System;
using System.Collections.Generic;

// Abstract class Product
abstract class Product
{
    private int productId;
    private string name;
    private double price;

    public int ProductId
    {
        get { return productId; }
        set { productId = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    public Product(int productId, string name, double price)
    {
        this.productId = productId;
        this.name = name;
        this.price = price;
    }

    public abstract double CalculateDiscount();

    public void DisplayProductDetails()
    {
        Console.WriteLine("Product ID: " + productId);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Price: " + price);
    }
}

// Interface ITaxable
interface ITaxable
{
    double CalculateTax();
    string GetTaxDetails();
}

// Electronics class implementing ITaxable
class Electronics : Product, ITaxable
{
    private double discountRate;
    private double taxRate;

    public Electronics(int productId, string name, double price, double discountRate, double taxRate)
        : base(productId, name, price)
    {
        this.discountRate = discountRate;
        this.taxRate = taxRate;
    }

    public override double CalculateDiscount()
    {
        return Price * discountRate / 100;
    }

    public double CalculateTax()
    {
        return Price * taxRate / 100;
    }

    public string GetTaxDetails()
    {
        return "Tax Rate: " + taxRate + "%";
    }
}

// Clothing class implementing ITaxable
class Clothing : Product, ITaxable
{
    private double discountRate;
    private double taxRate;

    public Clothing(int productId, string name, double price, double discountRate, double taxRate)
        : base(productId, name, price)
    {
        this.discountRate = discountRate;
        this.taxRate = taxRate;
    }

    public override double CalculateDiscount()
    {
        return Price * discountRate / 100;
    }

    public double CalculateTax()
    {
        return Price * taxRate / 100;
    }

    public string GetTaxDetails()
    {
        return "Tax Rate: " + taxRate + "%";
    }
}

// Groceries class (No tax applicable)
class Groceries : Product
{
    private double discountRate;

    public Groceries(int productId, string name, double price, double discountRate)
        : base(productId, name, price)
    {
        this.discountRate = discountRate;
    }

    public override double CalculateDiscount()
    {
        return Price * discountRate / 100;
    }
}

// Main Program
class Ecommerce
{
    static void CalculateFinalPrice(List<Product> products)
    {
        foreach (Product product in products)
        {
            product.DisplayProductDetails();
            double discount = product.CalculateDiscount();
            double tax = 0;

            ITaxable taxableProduct = product as ITaxable;
            if (taxableProduct != null)
            {
                tax = taxableProduct.CalculateTax();
                Console.WriteLine(taxableProduct.GetTaxDetails());
            }

            double finalPrice = product.Price + tax - discount;
            Console.WriteLine("Discount: " + discount);
            Console.WriteLine("Final Price: " + finalPrice);
            Console.WriteLine("-------------------------");
        }
    }

    static void Main()
    {
        List<Product> products = new List<Product>();

        products.Add(new Electronics(101, "Laptop", 50000, 10, 18));
        products.Add(new Clothing(102, "T-Shirt", 1000, 5, 12));
        products.Add(new Groceries(103, "Rice", 500, 2));

        CalculateFinalPrice(products);
    }
}
