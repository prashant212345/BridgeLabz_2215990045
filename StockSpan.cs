using System;
using System.Collections.Generic;

class StockSpan
{
    // Function to calculate stock span
    public static int[] CalculateStockSpan(int[] prices)
    {
        int n = prices.Length;
        int[] span = new int[n];
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            // Pop elements that have a smaller or equal price
            while (stack.Count > 0 && prices[stack.Peek()] <= prices[i])
            {
                stack.Pop();
            }

            // If stack is empty, all previous prices are smaller
            span[i] = (stack.Count == 0) ? (i + 1) : (i - stack.Peek());

            // Push the current index onto the stack
            stack.Push(i);
        }

        return span;
    }

    // Function to take user input and print stock span
    public static void Main()
    {
        Console.WriteLine("Enter stock prices (comma-separated): ");
        string input = Console.ReadLine();
        string[] tokens = input.Split(',');

        List<int> prices = new List<int>();
        foreach (var token in tokens)
        {
            if (int.TryParse(token.Trim(), out int price))
            {
                prices.Add(price);
            }
            else
            {
                Console.WriteLine($"Invalid input ignored: {token}");
            }
        }

        if (prices.Count == 0)
        {
            Console.WriteLine("No valid stock prices entered.");
            return;
        }

        int[] stockPrices = prices.ToArray();
        int[] spans = CalculateStockSpan(stockPrices);

        Console.WriteLine("\nStock Prices: " + string.Join(" ", stockPrices));
        Console.WriteLine("Stock Span  : " + string.Join(" ", spans));
    }
}
