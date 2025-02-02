using System;

// HotelBooking class
public class HotelBooking
{
    // Attributes of the HotelBooking class
    public string guestName;
    public string roomType;
    public int nights;

    // Default constructor (initializes attributes with default values)
    public HotelBooking()
    {
        guestName = "Unknown Guest";
        roomType = "Standard Room";
        nights = 1;
    }

    // Parameterized constructor (initializes attributes with user-provided values)
    public HotelBooking(string name, string room, int nightsStayed)
    {
        guestName = name;
        roomType = room;
        nights = nightsStayed;
    }

    // Copy constructor (copies another booking's attributes)
    public HotelBooking(HotelBooking anotherBooking)
    {
        guestName = anotherBooking.guestName;
        roomType = anotherBooking.roomType;
        nights = anotherBooking.nights;
        Console.WriteLine("Copy Constructor: Cloned booking for guest: " + guestName + ", Room: " + roomType + ", Nights: " + nights);
    }

    // Method to display booking details
    public void DisplayBookingDetails()
    {
        Console.WriteLine("Guest Name: " + guestName);
        Console.WriteLine("Room Type: " + roomType);
        Console.WriteLine("Nights Stayed: " + nights);
    }
}

class Program
{
    static void Main()
    {
        // Creating a HotelBooking object using the default constructor
        HotelBooking booking1 = new HotelBooking();
        Console.WriteLine("Booking 1 (Using Default Constructor):");
        booking1.DisplayBookingDetails();

        Console.WriteLine();

        // Creating a HotelBooking object using the parameterized constructor
        HotelBooking booking2 = new HotelBooking("Alice", "Deluxe Suite", 5);
        Console.WriteLine("Booking 2 (Using Parameterized Constructor):");
        booking2.DisplayBookingDetails();

        Console.WriteLine();

        // Creating a HotelBooking object using the copy constructor (cloning booking2)
        HotelBooking booking3 = new HotelBooking(booking2);
        Console.WriteLine("Booking 3 (Cloned from Booking 2):");
        booking3.DisplayBookingDetails();
    }
}
