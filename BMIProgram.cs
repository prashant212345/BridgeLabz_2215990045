using System;

class BMIProgram
{
    static void Main()
    {
        // Step 1: Input the number of persons
        Console.Write("Enter the number of persons: ");
        int n = int.Parse(Console.ReadLine());

        // Arrays to store height, weight, BMI, and status
        double[] heights = new double[n];
        double[] weights = new double[n];
        double[] bmis = new double[n];
        string[] statuses = new string[n];

        // Step 2: Input height and weight for each person
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter height (in meters) for person " + (i + 1) + ": ");
            heights[i] = double.Parse(Console.ReadLine());

            Console.Write("Enter weight (in kg) for person " + (i + 1) + ": ");
            weights[i] = double.Parse(Console.ReadLine());
        }

        // Step 3: Calculate BMI and determine status
        for (int i = 0; i < n; i++)
        {
            bmis[i] = weights[i] / (heights[i] * heights[i]);

            if (bmis[i] <= 18.4)
                statuses[i] = "Underweight";
            else if (bmis[i] >= 18.5 && bmis[i] <= 24.9)
                statuses[i] = "Normal";
            else if (bmis[i] >= 25.0 && bmis[i] <= 39.9)
                statuses[i] = "Overweight";
            else
                statuses[i] = "Obese";
        }

        // Step 4: Display the results
        Console.WriteLine("\nHeight\tWeight\tBMI\t\tStatus");
        Console.WriteLine("-----------------------------------------");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(heights[i] + "\t" + weights[i] + "\t" + bmis[i] + "\t" + statuses[i]);
        }
    }
}
