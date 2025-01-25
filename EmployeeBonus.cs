using System;

class EmployeeBonus
{
    static void Main()
    {
        // Arrays to store salaries, years of service, bonuses, and new salaries
        double[] salaries = new double[10];
        double[] yearsOfService = new double[10];
        double[] bonuses = new double[10];
        double[] newSalaries = new double[10];

        // Variables to calculate total old salary, total bonus, and total new salary
        double totalOldSalary = 0;
        double totalBonus = 0;
        double totalNewSalary = 0;

        Console.WriteLine("Enter the salary and years of service for 10 employees:\n");

        // Input loop
        for (int i = 0; i < 10; i++)
        {
            try
            {
                // Input salary
                Console.Write("Enter salary for employee " + (i + 1) + ": ");
                salaries[i] = Convert.ToDouble(Console.ReadLine());
                if (salaries[i] <= 0) throw new Exception("Invalid salary. Salary must be positive.");

                // Input years of service
                Console.Write("Enter years of service for employee " + (i + 1) + ": ");
                yearsOfService[i] = Convert.ToDouble(Console.ReadLine());
                if (yearsOfService[i] < 0) throw new Exception("Invalid years of service. It must be non-negative.");

                // Accumulate total old salary
                totalOldSalary += salaries[i];
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message + ". Please re-enter details for employee " + (i + 1) + ".\n");
                i--; // Decrement index to retry
            }
        }

        // Calculation loop
        for (int i = 0; i < 10; i++)
        {
            // Calculate bonus based on years of service
            bonuses[i] = yearsOfService[i] > 5 ? salaries[i] * 0.05 : salaries[i] * 0.02;

            // Calculate new salary
            newSalaries[i] = salaries[i] + bonuses[i];

            // Accumulate total bonus and new salary
            totalBonus += bonuses[i];
            totalNewSalary += newSalaries[i];
        }

        // Output results
        Console.WriteLine("\n--- Bonus and Salary Details ---\n");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Employee " + (i + 1) + ": Old Salary = " + salaries[i].ToString("C") + ", Bonus = " + bonuses[i].ToString("C") + ", New Salary = " + newSalaries[i].ToString("C"));
        }

        // Print totals
        Console.WriteLine("\n--- Summary ---");
        Console.WriteLine("Total Old Salary: " + totalOldSalary.ToString("C"));
        Console.WriteLine("Total Bonus Payout: " + totalBonus.ToString("C"));
        Console.WriteLine("Total New Salary: " + totalNewSalary.ToString("C"));
    }
}
