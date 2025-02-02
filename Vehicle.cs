using System;

class Vehicle
{
    // Instance Variables (Specific to each vehicle)
    private string ownerName;
    private string vehicleType;

    // Class Variable (Shared among all vehicles)
    private static double registrationFee = 10000;

    // Constructor to initialize a vehicle
    public Vehicle(string ownerName, string vehicleType)
    {
        this.ownerName = ownerName;
        this.vehicleType = vehicleType;
    }

    // Instance Method: Display vehicle details
    public void DisplayVehicleDetails()
    {
        Console.WriteLine("Owner Name : " + ownerName);
        Console.WriteLine("Vehicle Type : " + vehicleType);
        Console.WriteLine("Registration Fee : ₹" + registrationFee);
        Console.WriteLine();
    }

    // Class Method: Update registration fee (affects all vehicles)
    public static void UpdateRegistrationFee(double newRegistrationFee)
    {
        registrationFee = newRegistrationFee;
        Console.WriteLine("Registration Fee Updated to : ₹" + registrationFee);
    }

    // Main Method
    static void Main()
    {
        // Creating Vehicle Objects
        Vehicle vehicle1 = new Vehicle("Aarjoo", "Bike");
        Vehicle vehicle2 = new Vehicle("Prash", "Car");

        // Display details before updating registration fee
        Console.WriteLine("Before Updating Registration Fees:");
        vehicle1.DisplayVehicleDetails();
        vehicle2.DisplayVehicleDetails();

        // Update Registration Fee
        Vehicle.UpdateRegistrationFee(15000);

        Console.WriteLine("\nAfter Updating Registration Fees:");

        // Display vehicle details after update
        vehicle1.DisplayVehicleDetails();
        vehicle2.DisplayVehicleDetails();
    }
}
