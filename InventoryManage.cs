using System;

class ItemNode
{
    public int ItemID;
    public string ItemName;
    public int Quantity;
    public double Price;
    public ItemNode Next;

    public ItemNode(int itemID, string itemName, int quantity, double price)
    {
        ItemID = itemID;
        ItemName = itemName;
        Quantity = quantity;
        Price = price;
        Next = null;
    }
}

class Inventory
{
    private ItemNode head = null;

    // Add item at the beginning
    public void AddAtBeginning(int itemID, string itemName, int quantity, double price)
    {
        ItemNode newItem = new ItemNode(itemID, itemName, quantity, price);
        newItem.Next = head;
        head = newItem;
        Console.WriteLine("Item added at the beginning.");
    }

    // Add item at the end
    public void AddAtEnd(int itemID, string itemName, int quantity, double price)
    {
        ItemNode newItem = new ItemNode(itemID, itemName, quantity, price);
        if (head == null)
        {
            head = newItem;
        }
        else
        {
            ItemNode temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newItem;
        }
        Console.WriteLine("Item added at the end.");
    }

    // Remove item by Item ID
    public void RemoveItem(int itemID)
    {
        if (head == null)
        {
            Console.WriteLine("No items in inventory.");
            return;
        }

        if (head.ItemID == itemID)
        {
            head = head.Next;
            Console.WriteLine("Item removed successfully.");
            return;
        }

        ItemNode temp = head, prev = null;
        while (temp != null && temp.ItemID != itemID)
        {
            prev = temp;
            temp = temp.Next;
        }

        if (temp == null)
        {
            Console.WriteLine("Item not found.");
            return;
        }

        prev.Next = temp.Next;
        Console.WriteLine("Item removed successfully.");
    }

    // Update quantity by Item ID
    public void UpdateQuantity(int itemID, int newQuantity)
    {
        ItemNode temp = head;
        while (temp != null)
        {
            if (temp.ItemID == itemID)
            {
                temp.Quantity = newQuantity;
                Console.WriteLine("Item quantity updated successfully.");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Item not found.");
    }

    // Search for item by Item ID
    public void SearchByID(int itemID)
    {
        ItemNode temp = head;
        while (temp != null)
        {
            if (temp.ItemID == itemID)
            {
                Console.WriteLine($"Item Found: ID={temp.ItemID}, Name={temp.ItemName}, Quantity={temp.Quantity}, Price={temp.Price}");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Item not found.");
    }

    // Calculate total inventory value
    public void CalculateTotalValue()
    {
        double totalValue = 0;
        ItemNode temp = head;
        while (temp != null)
        {
            totalValue += temp.Quantity * temp.Price;
            temp = temp.Next;
        }
        Console.WriteLine($"Total Inventory Value: ₹{totalValue}");
    }

    // Display inventory items
    public void DisplayInventory()
    {
        if (head == null)
        {
            Console.WriteLine("Inventory is empty.");
            return;
        }

        Console.WriteLine("\nInventory List:");
        ItemNode temp = head;
        while (temp != null)
        {
            Console.WriteLine($"ID: {temp.ItemID}, Name: {temp.ItemName}, Quantity: {temp.Quantity}, Price: ₹{temp.Price}");
            temp = temp.Next;
        }
    }
}

class InventoryManage
{
    static void Main()
    {
        Inventory inventory = new Inventory();

        while (true)
        {
            Console.WriteLine("\nInventory Management System");
            Console.WriteLine("1. Add Item at Beginning");
            Console.WriteLine("2. Add Item at End");
            Console.WriteLine("3. Remove Item by ID");
            Console.WriteLine("4. Update Quantity by ID");
            Console.WriteLine("5. Search Item by ID");
            Console.WriteLine("6. Display Inventory");
            Console.WriteLine("7. Calculate Total Inventory Value");
            Console.WriteLine("8. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Item ID: ");
                    int itemID1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Item Name: ");
                    string itemName1 = Console.ReadLine();
                    Console.Write("Enter Quantity: ");
                    int quantity1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Price: ");
                    double price1 = Convert.ToDouble(Console.ReadLine());

                    inventory.AddAtBeginning(itemID1, itemName1, quantity1, price1);
                    break;

                case 2:
                    Console.Write("Enter Item ID: ");
                    int itemID2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Item Name: ");
                    string itemName2 = Console.ReadLine();
                    Console.Write("Enter Quantity: ");
                    int quantity2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Price: ");
                    double price2 = Convert.ToDouble(Console.ReadLine());

                    inventory.AddAtEnd(itemID2, itemName2, quantity2, price2);
                    break;

                case 3:
                    Console.Write("Enter Item ID to remove: ");
                    int removeID = Convert.ToInt32(Console.ReadLine());
                    inventory.RemoveItem(removeID);
                    break;

                case 4:
                    Console.Write("Enter Item ID to update quantity: ");
                    int updateID = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter New Quantity: ");
                    int newQuantity = Convert.ToInt32(Console.ReadLine());
                    inventory.UpdateQuantity(updateID, newQuantity);
                    break;

                case 5:
                    Console.Write("Enter Item ID to search: ");
                    int searchID = Convert.ToInt32(Console.ReadLine());
                    inventory.SearchByID(searchID);
                    break;

                case 6:
                    inventory.DisplayInventory();
                    break;

                case 7:
                    inventory.CalculateTotalValue();
                    break;

                case 8:
                    return;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}
