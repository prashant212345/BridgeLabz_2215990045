using System;
using System.Collections.Generic;

class CustomHashMap<K, V>
{
    private const int SIZE = 10; // Default size of hash table
    private LinkedList<KeyValuePair<K, V>>[] table;

    public CustomHashMap()
    {
        table = new LinkedList<KeyValuePair<K, V>>[SIZE];
        for (int i = 0; i < SIZE; i++)
        {
            table[i] = new LinkedList<KeyValuePair<K, V>>();
        }
    }

    private int GetIndex(K key)
    {
        return Math.Abs(key.GetHashCode()) % SIZE;
    }

    public void Put(K key, V value)
    {
        int index = GetIndex(key);
        var list = table[index];

        foreach (var pair in list)
        {
            if (pair.Key.Equals(key))
            {
                list.Remove(pair);
                break;
            }
        }

        list.AddLast(new KeyValuePair<K, V>(key, value));
    }

    public V Get(K key)
    {
        int index = GetIndex(key);
        var list = table[index];

        foreach (var pair in list)
        {
            if (pair.Key.Equals(key))
            {
                return pair.Value;
            }
        }

        throw new KeyNotFoundException("Key not found.");
    }

    public bool Remove(K key)
    {
        int index = GetIndex(key);
        var list = table[index];

        foreach (var pair in list)
        {
            if (pair.Key.Equals(key))
            {
                list.Remove(pair);
                return true;
            }
        }
        return false;
    }

    public void Display()
    {
        Console.WriteLine("\nHashMap Contents:");
        for (int i = 0; i < SIZE; i++)
        {
            if (table[i].Count > 0)
            {
                Console.Write($"Bucket {i}: ");
                foreach (var pair in table[i])
                {
                    Console.Write($"[{pair.Key} -> {pair.Value}] ");
                }
                Console.WriteLine();
            }
        }
    }
}

class HashMapProg
{
    public static void Main()
    {
        CustomHashMap<string, int> hashMap = new CustomHashMap<string, int>();

        while (true)
        {
            Console.WriteLine("\nChoose an operation:");
            Console.WriteLine("1: Insert (Put)");
            Console.WriteLine("2: Retrieve (Get)");
            Console.WriteLine("3: Delete (Remove)");
            Console.WriteLine("4: Display");
            Console.WriteLine("5: Exit");
            Console.Write("Enter choice: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Write("Enter key (string): ");
                    string key = Console.ReadLine();
                    Console.Write("Enter value (integer): ");
                    if (int.TryParse(Console.ReadLine(), out int value))
                    {
                        hashMap.Put(key, value);
                        Console.WriteLine($"Inserted [{key} -> {value}].");
                    }
                    else
                    {
                        Console.WriteLine("Invalid value.");
                    }
                    break;

                case "2":
                    Console.Write("Enter key to retrieve: ");
                    string getKey = Console.ReadLine();
                    try
                    {
                        int retrievedValue = hashMap.Get(getKey);
                        Console.WriteLine($"Value for '{getKey}': {retrievedValue}");
                    }
                    catch (KeyNotFoundException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;

                case "3":
                    Console.Write("Enter key to delete: ");
                    string delKey = Console.ReadLine();
                    if (hashMap.Remove(delKey))
                    {
                        Console.WriteLine($"Deleted key '{delKey}'.");
                    }
                    else
                    {
                        Console.WriteLine("Key not found.");
                    }
                    break;

                case "4":
                    hashMap.Display();
                    break;

                case "5":
                    Console.WriteLine("Exiting...");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}
