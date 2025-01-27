using System;

class ChocolateDivider
{
    static void Main()
    {
        // Taking user input for the number of chocolates and children
        Console.Write("Enter the total number of chocolates: ");
        int numberOfChocolates = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of children: ");
        int numberOfChildren = Convert.ToInt32(Console.ReadLine());

        if (numberOfChildren == 0)
        {
            Console.WriteLine("The number of children cannot be zero.");
        }
        else
        {
            // Finding the chocolates each child gets and the remainder
            int[] result = FindRemainderAndQuotient(numberOfChocolates, numberOfChildren);

            // Displaying the results
            Console.WriteLine("Each child will get: " + result[1] + " chocolates.");
            Console.WriteLine("Remaining chocolates: " + result[0]);
        }
    }

    // Method to calculate the quotient (chocolates per child) and remainder (leftover chocolates)
    public static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        int remainder = number % divisor;
        int quotient = number / divisor;
        return new int[] { remainder, quotient };
    }
}
