using System;

class Factor
{
    static void Main()
    {
        // Declare the integer variable for the user's input number
        int number;

        // Ask the user to input a number
        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        // Initialize maxFactor for the initial size of the factors array
        int maxFactor = 10;
        int[] factors = new int[maxFactor];
        int index = 0;

        // Loop through numbers from 1 to the entered number to find factors
        for (int i = 1; i <= number; i++)
        {
            // If 'i' is a factor of the number, store it in the array
            if (number % i == 0)
            {
                // Check if the array is full, if so, resize it
                if (index == maxFactor)
                {
                    maxFactor *= 2; // Double the size of the array
                    int[] temp = new int[maxFactor]; // Create a temporary array
                    factors.CopyTo(temp, 0); // Copy the old array to the temporary array
                    factors = temp; // Assign the new larger array to factors
                }

                // Store the factor in the array and increment the index
                factors[index] = i;
                index++;
            }
        }

        // Display the factors of the number
        Console.WriteLine("\nFactors of "+(number)+":");
        for (int i = 0; i < index; i++)
        {
            Console.Write(factors[i] + " ");
        }
    }
}
