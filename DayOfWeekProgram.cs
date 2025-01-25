using System;

class DayOfWeekProgram
{
    static void Main(string[] args)
    {
        // Ensure the program receives exactly 3 arguments (month, day, year)
        if (args.Length != 3)
        {
            Console.WriteLine("Usage: DayOfWeek <month> <day> <year>");
            return;
        }

        // Parse input arguments
        int m = Convert.ToInt32(args[0]); // Month
        int d = Convert.ToInt32(args[1]); // Day
        int y = Convert.ToInt32(args[2]); // Year

        // Apply the formulas to calculate the day of the week
        int y0 = y - (14 - m) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = m + 12 * ((14 - m) / 12) - 2;
        int d0 = (d + x + (31 * m0) / 12) % 7;

        // Print the day of the week (0 = Sunday, 1 = Monday, ..., 6 = Saturday)
        Console.WriteLine("Day of the week: " + d0);
    }
}
