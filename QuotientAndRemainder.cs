using System;

class QuotientAndRemainder
{
    static void Main()
    {
        // Taking user input for the number and the divisor
        Console.Write("Enter the number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the divisor: ");
        int divisor = Convert.ToInt32(Console.ReadLine());

        if (divisor == 0)
        {
            Console.WriteLine("Divisor cannot be zero.");
        }
        else
        {
            // Finding the quotient and remainder
            int[] result = FindRemainderAndQuotient(number, divisor);

            // Displaying the results
            Console.WriteLine("The quotient is: " + result[1]);
            Console.WriteLine("The remainder is: " + result[0]);
        }
    }

    // Method to calculate the remainder and quotient
    public static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        int remainder = number % divisor;
        int quotient = number / divisor;
        return new int[] { remainder, quotient };
    }
}
