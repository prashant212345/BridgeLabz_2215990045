using System;

class MeanHeight{
    static void Main(){
        // Declare a double array to store the heights of 11 players
        double[] heights = new double[11];
        
        // Declare a variable to store the sum of all heights, initialized to 0
        double sum = 0.0;

        // Get the heights of the players from the user
        Console.WriteLine("Enter the heights of the 11 players:");

        // Use a loop to input the heights
        for (int i = 0; i < 11; i++)
        {
            Console.Write("Enter height for player "+(i + 1)+": ");
            heights[i] = double.Parse(Console.ReadLine()); // Read and store the height in the array
        }

        // Calculate the sum of all heights
        for (int i = 0; i < 11; i++)
        {
            sum += heights[i]; // Add each height to the sum
        }

        // Calculate the mean height
        double meanHeight = sum / 11;

        // Display the mean height of the football team
        Console.WriteLine("\nThe mean height of the football team is: "+(meanHeight)+" meters.");
    }
}
