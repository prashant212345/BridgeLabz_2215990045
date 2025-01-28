using System;

class HeightP
{
    // Method to find the sum of all elements in an array
    public int FindSum(int[] heights)
    {
        int sum = 0;
        foreach (int height in heights)
        {
            sum += height;
        }
        return sum;
    }

    // Method to calculate the mean height
    public double FindMeanHeight(int[] heights)
    {
        int sum = FindSum(heights);
        return (double)sum / heights.Length;
    }

    // Method to find the shortest height
    public int FindShortestHeight(int[] heights)
    {
        int shortest = heights[0];
        foreach (int height in heights)
        {
            shortest = Math.Min(shortest, height);
        }
        return shortest;
    }

    // Method to find the tallest height
    public int FindTallestHeight(int[] heights)
    {
        int tallest = heights[0];
        foreach (int height in heights)
        {
            tallest = Math.Max(tallest, height);
        }
        return tallest;
    }

    static void Main()
    {
        Program program = new Program();

        // Create an array to store the heights of 11 players
        int[] heights = new int[11];
        Random random = new Random();

        // Generate random heights between 150 and 250 cm
        for (int i = 0; i < heights.Length; i++)
        {
            heights[i] = random.Next(150, 251);
        }

        // Display the heights of the players
        Console.WriteLine("Heights of the players (in cm):");
        foreach (int height in heights)
        {
            Console.WriteLine(height);
        }

        // Calculate and display the results
        int shortest = program.FindShortestHeight(heights);
        int tallest = program.FindTallestHeight(heights);
        double meanHeight = program.FindMeanHeight(heights);

        Console.WriteLine($"\nShortest Height: {shortest} cm");
        Console.WriteLine($"Tallest Height: {tallest} cm");
        Console.WriteLine($"Mean Height: {meanHeight:0.00} cm");
    }
}
