using System;

public class FriendsComparison
{
    // Method to find the youngest friend
    public static string FindYoungest(string[] names, int[] ages)
    {
        int minAge = ages[0];
        int youngestIndex = 0;

        for (int i = 1; i < ages.Length; i++)
        {
            if (ages[i] < minAge)
            {
                minAge = ages[i];
                youngestIndex = i;
            }
        }

        return names[youngestIndex];
    }

    // Method to find the tallest friend
    public static string FindTallest(string[] names, double[] heights)
    {
        double maxHeight = heights[0];
        int tallestIndex = 0;

        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] > maxHeight)
            {
                maxHeight = heights[i];
                tallestIndex = i;
            }
        }

        return names[tallestIndex];
    }
}

class Program
{
    static void Main()
    {
        // Friend names
        string[] friends = { "Amar", "Akbar", "Anthony" };

        // Arrays to store ages and heights
        int[] ages = new int[3];
        double[] heights = new double[3];

        // Taking user input for ages and heights
        for (int i = 0; i < friends.Length; i++)
        {
            Console.Write($"Enter the age of {friends[i]}: ");
            ages[i] = int.Parse(Console.ReadLine());

            Console.Write($"Enter the height (in cm) of {friends[i]}: ");
            heights[i] = double.Parse(Console.ReadLine());
        }

        // Find the youngest and tallest
        string youngest = FriendsComparison.FindYoungest(friends, ages);
        string tallest = FriendsComparison.FindTallest(friends, heights);

        // Display the results
        Console.WriteLine($"\nThe youngest friend is: {youngest}");
        Console.WriteLine($"The tallest friend is: {tallest}");
    }
}
