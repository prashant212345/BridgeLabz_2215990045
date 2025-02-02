using System;

// CarRental class
public class CarRental
{
    // Attributes of the CarRental class
    public string customerName;
    public string carModel;
    public int rentalDays;
    public decimal dailyRate;

    // Default constructor (initializes default rental details)
    public CarRental()
    {
        customerName = "Unknown";
        carModel = "Standard Model";
        rentalDays = 1;
        dailyRate = 50.00m;  // Default daily rental rate
    }

    // Parameterized constructor (initializes rental details with user-provided values)
    public CarRental(string name, string model, int days, decimal rate)
    {
        customerName = name;
        carModel = model;
        rentalDays = days;
        dailyRate = rate;
    }

    // Method to calculate the total rental cost
    public decimal CalculateTotalCost()
    {
        return rentalDays * dailyRate;
    }

    // Method to display rental details
    public void DisplayRentalDetails()
    {
        Console.WriteLine($"Customer Name: {customerName}");
        Console.WriteLine($"Car Model: {carModel}");
        Console.WriteLine($"Rental Days: {rentalDays}");
        Console.WriteLine($"Daily Rate: {dailyRate:C}");
        Console.WriteLine($"Total Rental Cost: {CalculateTotalCost():C}");
    }
}

class Program
{
    static void Main()
    {
        // Creating a CarRental object using the default constructor
        CarRental rental1 = new CarRental();
        Console.WriteLine("Rental 1 (Using Default Constructor):");
        rental1.DisplayRentalDetails();

        Console.WriteLine();

        // Creating a CarRental object using the parameterized constructor
        CarRental rental2 = new CarRental("John Doe", "Toyota Corolla", 7, 65.00m);
        Console.WriteLine("Rental 2 (Using Parameterized Constructor):");
        rental2.DisplayRentalDetails();
    }
}
