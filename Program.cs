using System;

class Program
{
    static void Main()
    {
        // Input an integer number
        Console.WriteLine("Enter an integer:");
        int number = Convert.ToInt32(Console.ReadLine());

        // Initialize count variable
        int count = 0;

        // If the number is 0, it has exactly 1 digit
        if (number == 0)
        {
            count = 1;
        }
        else
        {
            // Use a loop to count digits
            while (number != 0)
            {
                number = number / 10; // Remove the last digit
                count++; // Increment the count
            }
        }

        // Output the count
        Console.WriteLine("The number of digits is: " + count);
    }
}
