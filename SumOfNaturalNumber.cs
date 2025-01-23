using System;

class SumOfNaturalNumber
{
    static void Main()
    {
        // Input: Prompt the user to enter a natural number
        Console.Write("Enter a natural number: ");
        
        // Read the user input and parse it to an integer
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            // Check if the number is a valid natural number (positive integer)
            if (n > 0)
            {
                // Compute the sum using the for loop
                int sumUsingFor = 0;
                for (int i = 1; i <= n; i++)
                {
                    sumUsingFor += i;
                }

                // Compute the sum using the formula n*(n+1)/2
                int sumUsingFormula = n * (n + 1) / 2;

                // Compare both results
                Console.WriteLine("Sum using for loop: " + sumUsingFor);
                Console.WriteLine("Sum using formula: " + sumUsingFormula);

                // Check if the results are correct
                if (sumUsingFor == sumUsingFormula)
                {
                    Console.WriteLine("Both computations are correct.");
                }
                else
                {
                    Console.WriteLine("There is an error in the computations.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a positive natural number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
