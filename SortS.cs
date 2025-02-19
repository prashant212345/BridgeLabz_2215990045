using System;
using System.Collections.Generic;

class SortS
{
    static void Main()
    {
        HashSet<int> set = new HashSet<int> { 5, 3, 9, 1 };

        List<int> sortedList = ConvertToSortedList(set);

        Console.WriteLine("Sorted List: " + string.Join(", ", sortedList));
    }

    public static List<int> ConvertToSortedList(HashSet<int> set)
    {
        List<int> result = new List<int>(set); // Copy elements from set to list
        result.Sort();
        return result;
    }
}