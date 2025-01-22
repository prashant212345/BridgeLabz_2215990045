using System;

class Calc
{
    // Main method
    static void Main(String[] args)
    {
        //initialize the cost price
        int costPrice = 129;

        //initialize the selling price
        int sellPrice = 191;

        // Calculate the profit
        int Profit = sellPrice - costPrice;

        // Calculate the profit percentage
        double profitPercent = ((double)Profit / costPrice) * 100;

        // Display the cost price and selling price
        Console.WriteLine("The Cost Price is INR " + costPrice + " and Selling Price is INR " + sellPrice);

        // Display the profit and profit percentage
        Console.WriteLine("The Profit is INR " + Profit + " and the Profit Percentage is " + profitPercent + "%");
    }
}
