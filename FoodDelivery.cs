using System;
using System.Collections.Generic;

// Abstract class FoodItem
abstract class FoodItem
{
    private string itemName;
    private double price;
    private int quantity;

    public string ItemName
    {
        get { return itemName; }
        set { itemName = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    public int Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }

    public FoodItem(string itemName, double price, int quantity)
    {
        this.itemName = itemName;
        this.price = price;
        this.quantity = quantity;
    }

    public abstract double CalculateTotalPrice(); // Abstract method to be overridden

    public void GetItemDetails()
    {
        Console.WriteLine("Item Name: " + itemName);
        Console.WriteLine("Price per Unit: " + price);
        Console.WriteLine("Quantity: " + quantity);
    }
}

// Interface IDiscountable
interface IDiscountable
{
    double ApplyDiscount();
    string GetDiscountDetails();
}

// VegItem class implementing IDiscountable
class VegItem : FoodItem, IDiscountable
{
    private double discountRate;

    public VegItem(string itemName, double price, int quantity, double discountRate)
        : base(itemName, price, quantity)
    {
        this.discountRate = discountRate;
    }

    public override double CalculateTotalPrice()
    {
        return Price * Quantity - ApplyDiscount();
    }

    public double ApplyDiscount()
    {
        return (Price * Quantity) * discountRate / 100;
    }

    public string GetDiscountDetails()
    {
        return "Veg Item Discount: " + discountRate + "%";
    }
}

// NonVegItem class implementing IDiscountable
class NonVegItem : FoodItem, IDiscountable
{
    private double serviceCharge;
    private double discountRate;

    public NonVegItem(string itemName, double price, int quantity, double serviceCharge, double discountRate)
        : base(itemName, price, quantity)
    {
        this.serviceCharge = serviceCharge;
        this.discountRate = discountRate;
    }

    public override double CalculateTotalPrice()
    {
        double total = (Price * Quantity) + serviceCharge;
        return total - ApplyDiscount();
    }

    public double ApplyDiscount()
    {
        return ((Price * Quantity) + serviceCharge) * discountRate / 100;
    }

    public string GetDiscountDetails()
    {
        return "Non-Veg Item Discount: " + discountRate + "%";
    }
}

// Main Class to Demonstrate Polymorphism
class FoodDelivery
{
    static void Main()
    {
        List<FoodItem> foodItems = new List<FoodItem>();

        VegItem veg1 = new VegItem("Paneer Tikka", 200, 2, 10);
        NonVegItem nonVeg1 = new NonVegItem("Chicken Biryani", 300, 1, 50, 5);

        foodItems.Add(veg1);
        foodItems.Add(nonVeg1);

        foreach (FoodItem item in foodItems)
        {
            item.GetItemDetails();
            Console.WriteLine("Total Price: " + item.CalculateTotalPrice());

            IDiscountable discountItem = item as IDiscountable;
            if (discountItem != null)
            {
                Console.WriteLine(discountItem.GetDiscountDetails());
                Console.WriteLine("Discount Applied: " + discountItem.ApplyDiscount());
            }

            Console.WriteLine("-------------------------");
        }
    }
}
