using System;
using System.Collections.Generic;

class CheckSubSuper
{
    static void Main()
    {
        HashSet<int> subset = new HashSet<int> { 2, 3 };
        HashSet<int> superset = new HashSet<int> { 1, 2, 3, 4 };

        bool isSubset = CheckSubset(subset, superset);

        Console.WriteLine("Is Subset: " + isSubset); // Output: true
    }

    public static bool CheckSubset(HashSet<int> subset, HashSet<int> superset)
    {
        // Iterate through each element in subset and check if it exists in superset
        foreach (int num in subset)
        {
            if (!superset.Contains(num))
            {
                return false; // If any element is missing, return false
            }
        }
        return true; // All elements found, it's a subset
    }
}
