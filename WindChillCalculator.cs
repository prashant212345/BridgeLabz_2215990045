using System;

class WindChillCalculator
{
    static void Main()
    {
        // Taking user input for temperature and wind speed
        Console.Write("Enter the temperature in Fahrenheit: ");
        double temperature = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the wind speed in miles per hour: ");
        double windSpeed = Convert.ToDouble(Console.ReadLine());

        if (windSpeed <= 0)
        {
            Console.WriteLine("Wind speed must be greater than 0.");
        }
        else
        {
            // Calculating the wind chill
            double windChill = CalculateWindChill(temperature, windSpeed);

            // Displaying the result
            Console.WriteLine("The wind chill temperature is: "+(windChill)+" °F");
        }
    }

    // Method to calculate the wind chill temperature
    public static double CalculateWindChill(double temperature, double windSpeed)
    {
        return 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);
    }
}
