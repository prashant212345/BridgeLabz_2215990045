using System;

class RandomVal
{
    // Method to generate an array of 4-digit random numbers
    public int[] Generate4DigitRandomArray(int size)
    {
        Random random = new Random();
        int[] randomNumbers = new int[size];
        
        for (int i = 0; i < size; i++)
        {
            // Generate a 4-digit random number (between 1000 and 9999)
            randomNumbers[i] = random.Next(1000, 10000);
        }

        return randomNumbers;
    }

    // Method to find average, min, and max values of an array
    public double[] FindAverageMinMax(int[] numbers)
    {
        double sum = 0;
        int min = numbers[0];
        int max = numbers[0];

        // Loop through the array to calculate sum, min, and max
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
            min = Math.Min(min, numbers[i]);
            max = Math.Max(max, numbers[i]);
        }

        // Calculate average
        double average = sum / numbers.Length;

        // Return average, min, and max values as an array
        return new double[] { average, min, max };
    }

    static void Main()
    {
        Program program = new Program();
        
        // Generate 5 random 4-digit numbers
        int[] randomNumbers = program.Generate4DigitRandomArray(5);
        
        // Display the random numbers
        Console.WriteLine("Generated 4-digit random numbers:");
        foreach (int num in randomNumbers)
        {
            Console.WriteLine(num);
        }

        // Find the average, min, and max values
        double[] results = program.FindAverageMinMax(randomNumbers);

        // Display the results
        Console.WriteLine($"\nAverage: {results[0]:0.00}");
        Console.WriteLine($"Minimum: {results[1]}");
        Console.WriteLine($"Maximum: {results[2]}");
    }
}
