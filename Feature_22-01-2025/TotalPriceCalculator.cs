using System;

class TotalPriceCalculator{
    // Main method
    static void Main(String[] args){
        // Prompt the user to enter the unit price
        Console.Write("Enter the unit price of the item (INR): ");
        double unitPrice = Convert.ToDouble(Console.ReadLine());

        // Prompt the user to enter the quantity
        Console.Write("Enter the quantity to be bought: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        // Calculate the total price
        double totalPrice = unitPrice * quantity;

        // Display the results
        Console.WriteLine("The total purchase price is INR "+(totalPrice)+" if the quantity "+(quantity)+" and unit price is INR "+(unitPrice));
    }
}
