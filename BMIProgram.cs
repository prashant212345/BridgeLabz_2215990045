using System;

class BMIProgram
{
    static void Main()
    {
        Console.Write("Enter your weight in kg: ");
        double weight;
        if (!double.TryParse(Console.ReadLine(), out weight) || weight <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive number for weight.");
            return;
        }

        Console.Write("Enter your height in cm: ");
        double heightCm;
        if (!double.TryParse(Console.ReadLine(), out heightCm) || heightCm <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive number for height.");
            return;
        }

        // Convert height from cm to meters
        double heightMeters = heightCm / 100;

        // Calculate BMI
        double bmi = weight / (heightMeters * heightMeters);

        // Determine weight status
        string status;
        if (bmi <= 18.4)
        {
            status = "Underweight";
        }
        else if (bmi >= 18.5 && bmi <= 24.9)
        {
            status = "Normal";
        }
        else if (bmi >= 25.0 && bmi <= 39.9)
        {
            status = "Overweight";
        }
        else
        {
            status = "Obese";
        }

        // Display the results
        Console.WriteLine("Your BMI is: " + bmi);
        Console.WriteLine("Weight status: " + status);
    }
}
