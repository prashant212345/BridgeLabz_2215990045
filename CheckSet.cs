using System;
using System.Collections.Generic;

class CheckSet
{
    static void Main()
    {
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 3, 2, 1 };

        bool areEqual = AreSetsEqual(set1, set2);
        Console.WriteLine(areEqual); // Output: true
    }

    public static bool AreSetsEqual(HashSet<int> set1, HashSet<int> set2)
    {
        // Check if both sets have the same count and contain the same elements
        return set1.SetEquals(set2);
    }
}
