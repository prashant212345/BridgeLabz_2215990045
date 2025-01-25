using System;

class FizzBuzzNum
{
    static void Main()
    {
        // Take user input for the number
        Console.Write("Enter a positive number: ");
        int number = int.Parse(Console.ReadLine());

        // Check if the number is positive
        if (number <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }

        // Create a string array to store the results
        string[] results = new string[number + 1]; // Array size is number + 1 to include the number itself

        // Loop through the numbers from 0 to the entered number
        for (int i = 0; i <= number; i++)
        {
            // Check the conditions for Fizz, Buzz, and FizzBuzz
            if (i % 3 == 0 && i % 5 == 0)
            {
                results[i] = "FizzBuzz";
            }
            else if (i % 3 == 0)
            {
                results[i] = "Fizz";
            }
            else if (i % 5 == 0)
            {
                results[i] = "Buzz";
            }
            else
            {
                results[i] = i.ToString(); // Save the number as string if it's not divisible by 3 or 5
            }
        }

        // Display the results in the specified format
        for (int i = 0; i <= number; i++)
        {
            Console.WriteLine("Position "+(i)+" = "+(results[i])+"");
        }
    }
}
