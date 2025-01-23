using System;

class Rocket_Launch
{
    static void Main()
    {
        // Input: Prompt the user to enter a countdown number
        Console.Write("Enter the countdown start value: ");
        
        // Read the input and parse it into an integer
        if (int.TryParse(Console.ReadLine(), out int counter))
        {
            // Check if the input is a valid positive number
            if (counter > 0)
            {
                // Countdown using a for loop
                for (int i = counter; i >= 1; i--)
                {
                    Console.WriteLine(i); // Print the current countdown value
                }

                Console.WriteLine("Liftoff!"); // After countdown completes
            }
            else
            {
                Console.WriteLine("Please enter a positive number for the countdown.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}
