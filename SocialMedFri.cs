using System;
using System.Collections.Generic;

class UserNode
{
    public int UserID;
    public string Name;
    public int Age;
    public List<int> FriendIDs; // Stores Friend IDs
    public UserNode Next;

    public UserNode(int userID, string name, int age)
    {
        UserID = userID;
        Name = name;
        Age = age;
        FriendIDs = new List<int>();
        Next = null;
    }
}

class SocialMedia
{
    private UserNode head = null;

    // Add a new user to the social media system
    public void AddUser(int userID, string name, int age)
    {
        UserNode newUser = new UserNode(userID, name, age);
        if (head == null)
        {
            head = newUser;
        }
        else
        {
            UserNode temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newUser;
        }
        Console.WriteLine($"User {name} added successfully.");
    }

    // Find user by ID
    private UserNode FindUser(int userID)
    {
        UserNode temp = head;
        while (temp != null)
        {
            if (temp.UserID == userID)
                return temp;
            temp = temp.Next;
        }
        return null;
    }

    // Add friend connection between two users
    public void AddFriend(int userID1, int userID2)
    {
        UserNode user1 = FindUser(userID1);
        UserNode user2 = FindUser(userID2);

        if (user1 == null || user2 == null)
        {
            Console.WriteLine("One or both users not found.");
            return;
        }

        if (!user1.FriendIDs.Contains(userID2))
            user1.FriendIDs.Add(userID2);

        if (!user2.FriendIDs.Contains(userID1))
            user2.FriendIDs.Add(userID1);

        Console.WriteLine($"Friend connection added between {user1.Name} and {user2.Name}.");
    }

    // Remove friend connection
    public void RemoveFriend(int userID1, int userID2)
    {
        UserNode user1 = FindUser(userID1);
        UserNode user2 = FindUser(userID2);

        if (user1 == null || user2 == null)
        {
            Console.WriteLine("One or both users not found.");
            return;
        }

        if (user1.FriendIDs.Contains(userID2))
            user1.FriendIDs.Remove(userID2);

        if (user2.FriendIDs.Contains(userID1))
            user2.FriendIDs.Remove(userID1);

        Console.WriteLine($"Friend connection removed between {user1.Name} and {user2.Name}.");
    }

    // Find mutual friends between two users
    public void FindMutualFriends(int userID1, int userID2)
    {
        UserNode user1 = FindUser(userID1);
        UserNode user2 = FindUser(userID2);

        if (user1 == null || user2 == null)
        {
            Console.WriteLine("One or both users not found.");
            return;
        }

        List<int> mutualFriends = new List<int>();

        foreach (int id in user1.FriendIDs)
        {
            if (user2.FriendIDs.Contains(id))
            {
                mutualFriends.Add(id);
            }
        }

        Console.WriteLine($"Mutual friends between {user1.Name} and {user2.Name}:");
        if (mutualFriends.Count == 0)
        {
            Console.WriteLine("No mutual friends.");
        }
        else
        {
            foreach (int id in mutualFriends)
            {
                UserNode friend = FindUser(id);
                if (friend != null)
                    Console.WriteLine($"{friend.Name} (User ID: {friend.UserID})");
            }
        }
    }

    // Display all friends of a user
    public void DisplayFriends(int userID)
    {
        UserNode user = FindUser(userID);
        if (user == null)
        {
            Console.WriteLine("User not found.");
            return;
        }

        Console.WriteLine($"Friends of {user.Name}:");
        if (user.FriendIDs.Count == 0)
        {
            Console.WriteLine("No friends added.");
        }
        else
        {
            foreach (int id in user.FriendIDs)
            {
                UserNode friend = FindUser(id);
                if (friend != null)
                    Console.WriteLine($"{friend.Name} (User ID: {friend.UserID})");
            }
        }
    }

    // Search for a user by Name or User ID
    public void SearchUser(string nameOrID)
    {
        UserNode temp = head;
        while (temp != null)
        {
            if (temp.Name.Equals(nameOrID, StringComparison.OrdinalIgnoreCase) || temp.UserID.ToString() == nameOrID)
            {
                Console.WriteLine($"User Found: {temp.Name} (ID: {temp.UserID}), Age: {temp.Age}");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("User not found.");
    }

    // Count the number of friends of a user
    public void CountFriends(int userID)
    {
        UserNode user = FindUser(userID);
        if (user == null)
        {
            Console.WriteLine("User not found.");
            return;
        }
        Console.WriteLine($"{user.Name} has {user.FriendIDs.Count} friend(s).");
    }
}

class SocialMedFri
{
    static void Main()
    {
        SocialMedia socialMedia = new SocialMedia();

        while (true)
        {
            Console.WriteLine("\nSocial Media Friend Connection System:");
            Console.WriteLine("1. Add User");
            Console.WriteLine("2. Add Friend");
            Console.WriteLine("3. Remove Friend");
            Console.WriteLine("4. Find Mutual Friends");
            Console.WriteLine("5. Display Friends");
            Console.WriteLine("6. Search User");
            Console.WriteLine("7. Count Friends");
            Console.WriteLine("8. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter User ID: ");
                    int userID = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Age: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    socialMedia.AddUser(userID, name, age);
                    break;

                case 2:
                    Console.Write("Enter User ID 1: ");
                    int userID1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter User ID 2: ");
                    int userID2 = Convert.ToInt32(Console.ReadLine());
                    socialMedia.AddFriend(userID1, userID2);
                    break;

                case 3:
                    Console.Write("Enter User ID 1: ");
                    int user1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter User ID 2: ");
                    int user2 = Convert.ToInt32(Console.ReadLine());
                    socialMedia.RemoveFriend(user1, user2);
                    break;

                case 4:
                    Console.Write("Enter User ID 1: ");
                    int mutualID1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter User ID 2: ");
                    int mutualID2 = Convert.ToInt32(Console.ReadLine());
                    socialMedia.FindMutualFriends(mutualID1, mutualID2);
                    break;

                case 5:
                    Console.Write("Enter User ID: ");
                    int displayID = Convert.ToInt32(Console.ReadLine());
                    socialMedia.DisplayFriends(displayID);
                    break;

                case 6:
                    Console.Write("Enter User Name or ID: ");
                    string searchInput = Console.ReadLine();
                    socialMedia.SearchUser(searchInput);
                    break;

                case 7:
                    Console.Write("Enter User ID: ");
                    int countID = Convert.ToInt32(Console.ReadLine());
                    socialMedia.CountFriends(countID);
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
