using System;

class BonusCalculator
{
    static void Main()
    {
        // Prompt the user to enter salary and years of service
        Console.Write("Enter the employee's salary: ");
        
        // Read the user input for salary and parse it to a double
        if (double.TryParse(Console.ReadLine(), out double salary))
        {
            Console.Write("Enter the employee's years of service: ");
            
            // Read the user input for years of service and parse it to an integer
            if (int.TryParse(Console.ReadLine(), out int yearsOfService))
            {
                // Check if the years of service is more than 5 years
                if (yearsOfService > 5)
                {
                    // Calculate the bonus (5% of the salary)
                    double bonus = salary * 0.05;
                    Console.WriteLine("The bonus amount is: " + bonus);
                }
                else
                {
                    Console.WriteLine("The employee is not eligible for a bonus.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for years of service. Please enter a valid number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input for salary. Please enter a valid number.");
        }
    }
}
