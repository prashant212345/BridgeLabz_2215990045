using System;

class Program
{
    static void Main()
    {
        // Declare an array to store up to 10 double values
        double[] numbers = new double[10];
        
        // Declare a variable to store the sum, initialized to 0.0
        double total = 0.0;

        // Declare an index variable to keep track of the current position in the array
        int index = 0;

        // Start an infinite while loop
        while (true)
        {
            // Prompt the user to enter a number
            Console.Write("Enter a number (enter 0 or a negative number to stop): ");
            double input = double.Parse(Console.ReadLine());

            // Check if the user entered 0 or a negative number, or if the array is full
            if (input <= 0 || index == 10)
            {
                break; // Exit the loop if condition is met
            }

            // Store the valid input in the array
            numbers[index] = input;

            // Increment the index
            index++;
        }

        // Calculate the total sum of the array elements
        for (int i = 0; i < index; i++)
        {
            total += numbers[i]; // Add each number to the total
        }

        // Display all the entered numbers
        Console.WriteLine("\nEntered numbers:");
        for (int i = 0; i < index; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        // Display the total sum of the numbers
        Console.WriteLine("\nTotal sum: " + total);
    }
}
