using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class VehicleSystem
    {
        public static void Main()
        {
            Vehicle[] vehicles = new Vehicle[]
            {
            new Car(200, "Petrol", 5),
            new Truck(120, "Diesel", 10000),
            new MotorCycle(180, "Petrol", true)
            };

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.DisplayInfo();
            }
        }
    }
    public class Vehicle
    {
        public int MaxSpeed { get; set; }
        public string FuelType { get; set; }
        public Vehicle(int maxSpeed, string fuelType) {
            MaxSpeed = maxSpeed;
            FuelType = fuelType;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine("Max Speed: {0} km/h, Fuel Type: {1}", MaxSpeed, FuelType);
        }

    }
    public class Car : Vehicle
    {
        public int SeatCapacity {  get; set; }
        public Car(int maxSpeed, string fuelType, int seatCapacity) : base(maxSpeed, fuelType) { 
            SeatCapacity = seatCapacity;
        }
        public override void DisplayInfo() {
            Console.WriteLine("Max Speed: {0} km/h, Fuel Type: {1}, Seat Capacity: {2}", MaxSpeed, FuelType, SeatCapacity);
        }
    }

    public class Truck : Vehicle
    {
        public int PayloadCapacity { get; set; }
        public Truck(int maxSpeed, string fuelType, int payloadCapacity) : base(maxSpeed, fuelType) { 
            PayloadCapacity = payloadCapacity;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("Max Speed: {0} km/h, Fuel Type: {1}, Payload Capacity: {2} kg", MaxSpeed, FuelType, PayloadCapacity);
        }
    }
    public class MotorCycle : Vehicle
    {
        public bool HasSidecar { get; set; }
        public MotorCycle(int maxSpeed, string fuelType, bool hasSidecar) : base(maxSpeed, fuelType) { 
            HasSidecar = hasSidecar;
        }
        public override void DisplayInfo() {
            Console.WriteLine("Max Speed: {0} km/h, Fuel Type: {1}, Has Sidecar: {2}", MaxSpeed, FuelType, HasSidecar);
        }
    }
}
