using System;

class UniversityFee{
    // Main method
    static void Main(String[] args){
        // initialize the fee
        int fee = 125000;

        // initialize the discount percentage
        int discountPercent = 10;

        // Calculate the discount amount
        double discount = (fee * discountPercent) / 100.0;

        // Calculate the final discounted fee
        double finalFee = fee - discount;

        // Display the discount amount and final discounted fee
        Console.WriteLine("The discount amount is INR " + discount + " and final discounted fee is INR " + finalFee);
    }
}
