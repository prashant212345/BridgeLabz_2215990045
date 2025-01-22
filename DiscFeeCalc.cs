using System;

class DiscFeeCalc{
    // Main method
    static void Main(String[] args){
        // Prompt the user to enter the fee
        Console.Write("Enter the student fee (in INR): ");
        double fee = Convert.ToDouble(Console.ReadLine());
        // Prompt the user to enter the discount percentage
        Console.Write("Enter the discount percentage: ");
        double discountPercent = Convert.ToDouble(Console.ReadLine());

        // Calculate the discount amount
        double discount = (fee * discountPercent) / 100;
        // Calculate the final discounted fee
        double finalFee = fee - discount;

        // Display the discount amount and final discounted fee
        Console.WriteLine("The discount amount is INR " + discount + " and final discounted fee is INR " + finalFee);
    }
}
