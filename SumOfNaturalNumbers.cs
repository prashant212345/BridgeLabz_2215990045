using System;

class SumOfNaturalNumbers
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
                // Compute the sum using the while loop
                int sumUsingWhile = 0;
                int i = 1;
                while (i <= n)
                {
                    sumUsingWhile += i;
                    i++;
                }

                // Compute the sum using the formula n*(n+1)/2
                int sumUsingFormula = n * (n + 1) / 2;

                // Compare both results
                Console.WriteLine("Sum using while loop: " + sumUsingWhile);
                Console.WriteLine("Sum using formula: " + sumUsingFormula);

                // Check if the results are correct
                if (sumUsingWhile == sumUsingFormula)
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
