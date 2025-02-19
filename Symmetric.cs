using System;
using System.Collections.Generic;

class Symmetric
{
    static void Main()
    {
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

        HashSet<int> symmetricDiff = GetSymmetricDifference(set1, set2);

        Console.WriteLine("Symmetric Difference: " + string.Join(", ", symmetricDiff));
    }

    public static HashSet<int> GetSymmetricDifference(HashSet<int> set1, HashSet<int> set2)
    {
        HashSet<int> result = new HashSet<int>();
        foreach (int num in set1)
        {
            if (!set2.Contains(num))
            {
                result.Add(num);
            }
        }
        foreach (int num in set2)
        {
            if (!set1.Contains(num))
            {
                result.Add(num);
            }
        }
        return result;
    }
}

