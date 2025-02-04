using System;

class Vehicle
{
    // Static variable shared among all vehicles
    public static double RegistrationFee = 5000;

    // Readonly variable for unique registration number
    public readonly string RegistrationNumber;
    public string OwnerName;
    public string VehicleType;

    // Constructor using 'this' keyword
    public Vehicle(string registrationNumber, string ownerName, string vehicleType)
    {
        this.RegistrationNumber = registrationNumber;
        this.OwnerName = ownerName;
        this.VehicleType = vehicleType;
    }

    // Static method to update registration fee
    public static void UpdateRegistrationFee(double newFee)
    {
        RegistrationFee = newFee;
        Console.WriteLine("Updated Registration Fee: " + RegistrationFee);
    }

    // Method to display vehicle details using 'is' operator
    public void DisplayVehicleDetails()
    {
        if (this is Vehicle)
        {
            Console.WriteLine("Registration Number: " + RegistrationNumber);
            Console.WriteLine("Owner Name: " + OwnerName);
            Console.WriteLine("Vehicle Type: " + VehicleType);
            Console.WriteLine("Registration Fee: " + RegistrationFee);
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        // Creating vehicle objects
        Vehicle vehicle1 = new Vehicle("UP32AB1234", "Rajesh Kumar", "Car");
        Vehicle vehicle2 = new Vehicle("DL8CAP5678", "Anita Sharma", "Bike");

        // Display vehicle details
        vehicle1.DisplayVehicleDetails();
        vehicle2.DisplayVehicleDetails();

        // Update registration fee and show updated details
        Vehicle.UpdateRegistrationFee(6000);

        // Display details again after updating registration fee
        vehicle1.DisplayVehicleDetails();
        vehicle2.DisplayVehicleDetails();
    }
}
