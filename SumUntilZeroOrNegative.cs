using System;

class SumUntilZeroOrNegative
{
    static void Main()
    {
        // Initialize total to store the sum
        double total = 0.0;
        double number;

        // Infinite while loop
        while (true)
        {
            // Prompt the user for a number
            Console.Write("Enter a number (0 or a negative number to stop): ");
            
            // Read and parse the input to a double
            if (double.TryParse(Console.ReadLine(), out number))
            {
                // If the number is 0 or negative, break the loop
                if (number <= 0)
                {
                    break;
                }

                // Add the number to total if it's positive
                total += number;
            }
            else
            {
                // If the input is invalid, prompt the user again
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        // Output the total sum
        Console.WriteLine("The total sum is: " + total);
    }
}
