using System;

class BMIProgra
{
    static void Main()
    {
        // Step 1: Input the number of persons
        Console.Write("Enter the number of persons: ");
        int number = int.Parse(Console.ReadLine());

        // Multi-dimensional array to store height, weight, and BMI
        double[,] personData = new double[number, 3];
        // Array to store weight status
        string[] weightStatus = new string[number];

        // Step 2: Input height and weight for each person
        for (int i = 0; i < number; i++)
        {
            // Input height with validation
            Console.Write("Enter height (in meters) for person " + (i + 1) + ": ");
            double height = double.Parse(Console.ReadLine());
            while (height <= 0)
            {
                Console.Write("Height must be positive. Please re-enter: ");
                height = double.Parse(Console.ReadLine());
            }
            personData[i, 0] = height;

            // Input weight with validation
            Console.Write("Enter weight (in kg) for person " + (i + 1) + ": ");
            double weight = double.Parse(Console.ReadLine());
            while (weight <= 0)
            {
                Console.Write("Weight must be positive. Please re-enter: ");
                weight = double.Parse(Console.ReadLine());
            }
            personData[i, 1] = weight;

            // Step 3: Calculate BMI
            double bmi = weight / (height * height);
            personData[i, 2] = bmi;

            // Determine weight status
            if (bmi <= 18.4)
                weightStatus[i] = "Underweight";
            else if (bmi >= 18.5 && bmi <= 24.9)
                weightStatus[i] = "Normal";
            else if (bmi >= 25.0 && bmi <= 39.9)
                weightStatus[i] = "Overweight";
            else
                weightStatus[i] = "Obese";
        }

        // Step 4: Display results
        Console.WriteLine("\nHeight\tWeight\tBMI\t\tStatus");
        Console.WriteLine("-----------------------------------------");
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine(personData[i, 0] + "\t" + personData[i, 1] + "\t" + personData[i, 2] + "\t" + weightStatus[i]);
        }
    }
}
