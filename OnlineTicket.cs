using System;

class TicketNode
{
    public int TicketID;
    public string CustomerName;
    public string MovieName;
    public int SeatNumber;
    public DateTime BookingTime;
    public TicketNode Next;

    public TicketNode(int ticketID, string customerName, string movieName, int seatNumber)
    {
        TicketID = ticketID;
        CustomerName = customerName;
        MovieName = movieName;
        SeatNumber = seatNumber;
        BookingTime = DateTime.Now; // Stores current time as booking time
        Next = null;
    }
}

class TicketReservationSystem
{
    private TicketNode last = null;
    private int count = 0;

    // Add a new ticket reservation at the end of the circular list
    public void AddTicket(int ticketID, string customerName, string movieName, int seatNumber)
    {
        TicketNode newNode = new TicketNode(ticketID, customerName, movieName, seatNumber);

        if (last == null)
        {
            last = newNode;
            last.Next = last; // Circular reference
        }
        else
        {
            newNode.Next = last.Next;
            last.Next = newNode;
            last = newNode;
        }
        count++;
        Console.WriteLine($"Ticket booked successfully for {customerName}.");
    }

    // Remove a ticket by Ticket ID
    public void RemoveTicket(int ticketID)
    {
        if (last == null)
        {
            Console.WriteLine("No tickets available.");
            return;
        }

        TicketNode current = last.Next, prev = last;

        do
        {
            if (current.TicketID == ticketID)
            {
                if (current == last.Next && current == last) // Only one node in the list
                {
                    last = null;
                }
                else if (current == last.Next) // Removing first node
                {
                    last.Next = current.Next;
                }
                else if (current == last) // Removing last node
                {
                    prev.Next = current.Next;
                    last = prev;
                }
                else // Removing intermediate node
                {
                    prev.Next = current.Next;
                }

                count--;
                Console.WriteLine($"Ticket ID {ticketID} has been removed.");
                return;
            }
            prev = current;
            current = current.Next;
        } while (current != last.Next);

        Console.WriteLine("Ticket ID not found.");
    }

    // Display all booked tickets
    public void DisplayTickets()
    {
        if (last == null)
        {
            Console.WriteLine("No tickets booked.");
            return;
        }

        TicketNode temp = last.Next;
        Console.WriteLine("\nBooked Tickets:");
        do
        {
            Console.WriteLine($"Ticket ID: {temp.TicketID}, Customer: {temp.CustomerName}, Movie: {temp.MovieName}, Seat: {temp.SeatNumber}, Time: {temp.BookingTime}");
            temp = temp.Next;
        } while (temp != last.Next);
    }

    // Search for a ticket by Customer Name or Movie Name
    public void SearchTicket(string searchKey)
    {
        if (last == null)
        {
            Console.WriteLine("No tickets booked.");
            return;
        }

        TicketNode temp = last.Next;
        bool found = false;
        Console.WriteLine($"\nSearch Results for '{searchKey}':");

        do
        {
            if (temp.CustomerName.Equals(searchKey, StringComparison.OrdinalIgnoreCase) ||
                temp.MovieName.Equals(searchKey, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Ticket ID: {temp.TicketID}, Customer: {temp.CustomerName}, Movie: {temp.MovieName}, Seat: {temp.SeatNumber}, Time: {temp.BookingTime}");
                found = true;
            }
            temp = temp.Next;
        } while (temp != last.Next);

        if (!found)
            Console.WriteLine("No matching tickets found.");
    }

    // Calculate the total number of booked tickets
    public void CountTickets()
    {
        Console.WriteLine($"Total Booked Tickets: {count}");
    }
}

class OnlineTicket
{
    static void Main()
    {
        TicketReservationSystem system = new TicketReservationSystem();

        while (true)
        {
            Console.WriteLine("\nOnline Ticket Reservation System:");
            Console.WriteLine("1. Book Ticket");
            Console.WriteLine("2. Cancel Ticket");
            Console.WriteLine("3. View All Tickets");
            Console.WriteLine("4. Search Ticket");
            Console.WriteLine("5. Count Tickets");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Ticket ID: ");
                    int ticketID = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Customer Name: ");
                    string customerName = Console.ReadLine();
                    Console.Write("Enter Movie Name: ");
                    string movieName = Console.ReadLine();
                    Console.Write("Enter Seat Number: ");
                    int seatNumber = Convert.ToInt32(Console.ReadLine());
                    system.AddTicket(ticketID, customerName, movieName, seatNumber);
                    break;

                case 2:
                    Console.Write("Enter Ticket ID to cancel: ");
                    int removeID = Convert.ToInt32(Console.ReadLine());
                    system.RemoveTicket(removeID);
                    break;

                case 3:
                    system.DisplayTickets();
                    break;

                case 4:
                    Console.Write("Enter Customer Name or Movie Name: ");
                    string searchKey = Console.ReadLine();
                    system.SearchTicket(searchKey);
                    break;

                case 5:
                    system.CountTickets();
                    break;

                case 6:
                    return;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}
