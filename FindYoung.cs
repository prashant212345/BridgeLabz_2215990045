using System;

class FindYoung
{
    static void Main()
    {
        // Declare arrays to store age and height of the 3 friends
        int[] ages = new int[3];
        double[] heights = new double[3];

        // Take user input for the ages and heights of the friends
        Console.WriteLine("Enter the details for the three friends:");

        // Input for ages
        Console.Write("Enter Amar's age: ");
        ages[0] = int.Parse(Console.ReadLine());
        
        Console.Write("Enter Akbar's age: ");
        ages[1] = int.Parse(Console.ReadLine());

        Console.Write("Enter Anthony's age: ");
        ages[2] = int.Parse(Console.ReadLine());

        // Input for heights
        Console.Write("Enter Amar's height (in cm): ");
        heights[0] = double.Parse(Console.ReadLine());

        Console.Write("Enter Akbar's height (in cm): ");
        heights[1] = double.Parse(Console.ReadLine());

        Console.Write("Enter Anthony's height (in cm): ");
        heights[2] = double.Parse(Console.ReadLine());

        // Find the youngest friend (minimum age)
        int youngestIndex = 0;
        for (int i = 1; i < 3; i++)
        {
            if (ages[i] < ages[youngestIndex])
            {
                youngestIndex = i;
            }
        }

        // Find the tallest friend (maximum height)
        int tallestIndex = 0;
        for (int i = 1; i < 3; i++)
        {
            if (heights[i] > heights[tallestIndex])
            {
                tallestIndex = i;
            }
        }

        // Display the youngest and tallest friend
        Console.WriteLine("\nYoungest friend is: "+(GetFriendName(youngestIndex))+" with age "+(ages[youngestIndex])+" years.");
        Console.WriteLine("Tallest friend is: "+(GetFriendName(tallestIndex))+" with height "+(heights[tallestIndex])+" cm.");
    }

    // Helper method to get the friend's name based on the index
    static string GetFriendName(int index)
    {
        switch (index)
        {
            case 0: return "Amar";
            case 1: return "Akbar";
            case 2: return "Anthony";
            default: return "Unknown";
        }
    }
}
