using System;

class SumOfNumbers
{
    static void Main()
    {
        // Initialize total to store the sum and input to store the user's input
        double total = 0.0;
        double number;

        // Use a while loop to keep asking for user input until 0 is entered
        do
        {
            // Prompt the user for a number
            Console.Write("Enter a number (0 to stop): ");
            
            // Read and parse the input to a double
            if (double.TryParse(Console.ReadLine(), out number))
            {
                // If the number is not 0, add it to total
                if (number != 0)
                {
                    total += number;
                }
            }
            else
            {
                // If input is invalid, prompt the user again
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

        } while (number != 0); // The loop continues until the user enters 0

        // Output the total sum
        Console.WriteLine("The total sum is: " + total);
    }
}
