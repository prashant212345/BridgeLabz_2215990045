using System;

class AbundanNum
{
    static void Main()
    {
        // Input an integer number
        Console.WriteLine("Enter an integer:");
        int number = Convert.ToInt32(Console.ReadLine());

        // Initialize sum of divisors
        int sum = 0;

        // Loop to find all divisors and calculate their sum
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0) // Check if 'i' is a divisor of 'number'
            {
                sum += i; // Add divisor to sum
            }
        }

        // Check if the number is an Abundant Number
        if (sum > number)
        {
            Console.WriteLine(number + " is an Abundant Number.");
        }
        else
        {
            Console.WriteLine(number + " is not an Abundant Number.");
        }
    }
}
