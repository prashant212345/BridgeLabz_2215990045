using System;
using System.Collections.Generic;

// Abstract class Vehicle
abstract class Vehicle
{
    private string vehicleNumber;
    private string type;
    private double rentalRate;

    public string VehicleNumber
    {
        get { return vehicleNumber; }
        set { vehicleNumber = value; }
    }

    public string Type
    {
        get { return type; }
        set { type = value; }
    }

    public double RentalRate
    {
        get { return rentalRate; }
        set { rentalRate = value; }
    }

    public Vehicle(string vehicleNumber, string type, double rentalRate)
    {
        this.vehicleNumber = vehicleNumber;
        this.type = type;
        this.rentalRate = rentalRate;
    }

    public abstract double CalculateRentalCost(int days);

    public void DisplayVehicleDetails()
    {
        Console.WriteLine("Vehicle Number: " + vehicleNumber);
        Console.WriteLine("Type: " + type);
        Console.WriteLine("Rental Rate per Day: " + rentalRate);
    }
}

// Interface IInsurable
interface IInsurable
{
    double CalculateInsurance();
    string GetInsuranceDetails();
}

// Car class implementing IInsurable
class Car : Vehicle, IInsurable
{
    private double insuranceRate;
    private string policyNumber;

    public Car(string vehicleNumber, double rentalRate, double insuranceRate, string policyNumber)
        : base(vehicleNumber, "Car", rentalRate)
    {
        this.insuranceRate = insuranceRate;
        this.policyNumber = policyNumber;
    }

    public override double CalculateRentalCost(int days)
    {
        return RentalRate * days;
    }

    public double CalculateInsurance()
    {
        return RentalRate * insuranceRate / 100;
    }

    public string GetInsuranceDetails()
    {
        return "Insurance Policy: Confidential";
    }
}

// Bike class implementing IInsurable
class Bike : Vehicle, IInsurable
{
    private double insuranceRate;
    private string policyNumber;

    public Bike(string vehicleNumber, double rentalRate, double insuranceRate, string policyNumber)
        : base(vehicleNumber, "Bike", rentalRate)
    {
        this.insuranceRate = insuranceRate;
        this.policyNumber = policyNumber;
    }

    public override double CalculateRentalCost(int days)
    {
        return RentalRate * days;
    }

    public double CalculateInsurance()
    {
        return RentalRate * insuranceRate / 100;
    }

    public string GetInsuranceDetails()
    {
        return "Insurance Policy: Confidential";
    }
}

// Truck class implementing IInsurable
class Truck : Vehicle, IInsurable
{
    private double insuranceRate;
    private string policyNumber;

    public Truck(string vehicleNumber, double rentalRate, double insuranceRate, string policyNumber)
        : base(vehicleNumber, "Truck", rentalRate)
    {
        this.insuranceRate = insuranceRate;
        this.policyNumber = policyNumber;
    }

    public override double CalculateRentalCost(int days)
    {
        return RentalRate * days;
    }

    public double CalculateInsurance()
    {
        return RentalRate * insuranceRate / 100;
    }

    public string GetInsuranceDetails()
    {
        return "Insurance Policy: Confidential";
    }
}

// Main Class to Demonstrate Polymorphism
class VehicleProg
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>();

        Car car1 = new Car("CAR123", 1000, 5, "POLICY-CAR-001");
        Bike bike1 = new Bike("BIKE567", 500, 3, "POLICY-BIKE-002");
        Truck truck1 = new Truck("TRUCK890", 2000, 8, "POLICY-TRUCK-003");

        vehicles.Add(car1);
        vehicles.Add(bike1);
        vehicles.Add(truck1);

        foreach (Vehicle vehicle in vehicles)
        {
            vehicle.DisplayVehicleDetails();
            Console.WriteLine("Rental Cost for 5 days: " + vehicle.CalculateRentalCost(5));

            IInsurable insurance = vehicle as IInsurable;
            if (insurance != null)
            {
                Console.WriteLine("Insurance Cost: " + insurance.CalculateInsurance());
                Console.WriteLine(insurance.GetInsuranceDetails());
            }

            Console.WriteLine("-------------------------");
        }
    }
}
