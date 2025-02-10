using System;
using System.Collections.Generic;

// Abstract class Vehicle
abstract class Vehicle
{
    private int vehicleId;
    private string driverName;
    private double ratePerKm;

    public int VehicleId
    {
        get { return vehicleId; }
        set { vehicleId = value; }
    }

    public string DriverName
    {
        get { return driverName; }
        set { driverName = value; }
    }

    public double RatePerKm
    {
        get { return ratePerKm; }
        set { ratePerKm = value; }
    }

    public Vehicle(int vehicleId, string driverName, double ratePerKm)
    {
        this.vehicleId = vehicleId;
        this.driverName = driverName;
        this.ratePerKm = ratePerKm;
    }

    public abstract double CalculateFare(double distance); // Abstract method

    public void GetVehicleDetails()
    {
        Console.WriteLine("Vehicle ID: " + vehicleId);
        Console.WriteLine("Driver Name: " + driverName);
        Console.WriteLine("Rate per Km: " + ratePerKm);
    }
}

// Interface IGPS
interface IGPS
{
    string GetCurrentLocation();
    void UpdateLocation(string newLocation);
}

// Car class implementing IGPS
class Car : Vehicle, IGPS
{
    private string currentLocation;

    public Car(int vehicleId, string driverName, double ratePerKm, string initialLocation)
        : base(vehicleId, driverName, ratePerKm)
    {
        this.currentLocation = initialLocation;
    }

    public override double CalculateFare(double distance)
    {
        return RatePerKm * distance;
    }

    public string GetCurrentLocation()
    {
        return currentLocation;
    }

    public void UpdateLocation(string newLocation)
    {
        currentLocation = newLocation;
    }
}

// Bike class implementing IGPS
class Bike : Vehicle, IGPS
{
    private string currentLocation;

    public Bike(int vehicleId, string driverName, double ratePerKm, string initialLocation)
        : base(vehicleId, driverName, ratePerKm)
    {
        this.currentLocation = initialLocation;
    }

    public override double CalculateFare(double distance)
    {
        return RatePerKm * distance;
    }

    public string GetCurrentLocation()
    {
        return currentLocation;
    }

    public void UpdateLocation(string newLocation)
    {
        currentLocation = newLocation;
    }
}

// Auto class implementing IGPS
class Auto : Vehicle, IGPS
{
    private string currentLocation;

    public Auto(int vehicleId, string driverName, double ratePerKm, string initialLocation)
        : base(vehicleId, driverName, ratePerKm)
    {
        this.currentLocation = initialLocation;
    }

    public override double CalculateFare(double distance)
    {
        return RatePerKm * distance;
    }

    public string GetCurrentLocation()
    {
        return currentLocation;
    }

    public void UpdateLocation(string newLocation)
    {
        currentLocation = newLocation;
    }
}

// Main Class to Demonstrate Polymorphism
class VehicleRide
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>();

        Car car1 = new Car(101, "John", 15, "Downtown");
        Bike bike1 = new Bike(201, "Mike", 8, "City Center");
        Auto auto1 = new Auto(301, "Raj", 10, "Main Square");

        vehicles.Add(car1);
        vehicles.Add(bike1);
        vehicles.Add(auto1);

        foreach (Vehicle vehicle in vehicles)
        {
            vehicle.GetVehicleDetails();
            double distance = 10; // Example distance for fare calculation
            Console.WriteLine("Estimated Fare for " + distance + " km: " + vehicle.CalculateFare(distance));

            IGPS gpsVehicle = vehicle as IGPS;
            if (gpsVehicle != null)
            {
                Console.WriteLine("Current Location: " + gpsVehicle.GetCurrentLocation());
                gpsVehicle.UpdateLocation("New Location");
                Console.WriteLine("Updated Location: " + gpsVehicle.GetCurrentLocation());
            }

            Console.WriteLine("-------------------------");
        }
    }
}
