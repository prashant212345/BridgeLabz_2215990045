using System;

class DigitFrequency
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        long number = long.Parse(Console.ReadLine());

        // Array to store the frequency of each digit (0-9)
        int[] frequency = new int[10];

        // Convert the number into a string to easily extract each digit
        string numberStr = number.ToString();

        // Loop through each digit in the number
        for (int i = 0; i < numberStr.Length; i++)
        {
            // Get the digit at the current position and convert it to an integer
            int digit = (int)Char.GetNumericValue(numberStr[i]);

            // Increase the frequency of the digit
            frequency[digit]++;
        }

        // Display the frequency of each digit
        Console.WriteLine("\nFrequency of each digit in the number:");
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i] > 0)
            {
                Console.WriteLine("Digit " + i + ": " + frequency[i] + " time(s)");
            }
        }
    }
}
