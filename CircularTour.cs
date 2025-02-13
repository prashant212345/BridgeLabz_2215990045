using System;
using System.Collections.Generic;

class CircularTour
{
    // Function to find the starting petrol pump index
    public static int FindStartingPoint(int[] petrol, int[] distance)
    {
        int n = petrol.Length;
        int totalSurplus = 0;
        int currentSurplus = 0;
        int startIndex = 0;

        for (int i = 0; i < n; i++)
        {
            totalSurplus += petrol[i] - distance[i];
            currentSurplus += petrol[i] - distance[i];

            // If balance is negative, reset start index and surplus
            if (currentSurplus < 0)
            {
                startIndex = i + 1;
                currentSurplus = 0;
            }
        }

        return (totalSurplus >= 0) ? startIndex : -1;
    }

    // Function to take user input and find the circular tour start
    public static void Main()
    {
        Console.WriteLine("Enter petrol at each pump (comma-separated): ");
        string petrolInput = Console.ReadLine();
        Console.WriteLine("Enter distance to next pump (comma-separated): ");
        string distanceInput = Console.ReadLine();

        string[] petrolTokens = petrolInput.Split(',');
        string[] distanceTokens = distanceInput.Split(',');

        if (petrolTokens.Length != distanceTokens.Length)
        {
            Console.WriteLine("Invalid input: Number of petrol pumps and distances must be equal.");
            return;
        }

        List<int> petrolList = new List<int>();
        List<int> distanceList = new List<int>();

        for (int i = 0; i < petrolTokens.Length; i++)
        {
            if (int.TryParse(petrolTokens[i].Trim(), out int petrolVal) &&
                int.TryParse(distanceTokens[i].Trim(), out int distanceVal))
            {
                petrolList.Add(petrolVal);
                distanceList.Add(distanceVal);
            }
            else
            {
                Console.WriteLine($"Invalid input ignored at index {i}: {petrolTokens[i]}, {distanceTokens[i]}");
            }
        }

        if (petrolList.Count == 0)
        {
            Console.WriteLine("No valid petrol pumps entered.");
            return;
        }

        int[] petrolArray = petrolList.ToArray();
        int[] distanceArray = distanceList.ToArray();

        int startPump = FindStartingPoint(petrolArray, distanceArray);

        if (startPump != -1)
            Console.WriteLine($"\nStart the tour from petrol pump index: {startPump}");
        else
            Console.WriteLine("\nNo possible circular tour exists.");
    }
}
