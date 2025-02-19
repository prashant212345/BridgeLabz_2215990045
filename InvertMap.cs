using System;
using System.Collections.Generic;

class InvertMap
{
    static void Main()
    {
        Dictionary<string, int> originalMap = new Dictionary<string, int>
        {
            { "A", 1 },
            { "B", 2 },
            { "C", 1 }
        };

        Dictionary<int, List<string>> invertedMap = InvertDictionary(originalMap);

        // Print the inverted map
        foreach (var pair in invertedMap)
        {
            Console.WriteLine($"{pair.Key}: [{string.Join(", ", pair.Value)}]");
        }
    }

    public static Dictionary<V, List<K>> InvertDictionary<K, V>(Dictionary<K, V> original)
    {
        Dictionary<V, List<K>> inverted = new Dictionary<V, List<K>>();

        foreach (var pair in original)
        {
            if (!inverted.ContainsKey(pair.Value))
                inverted[pair.Value] = new List<K>();

            inverted[pair.Value].Add(pair.Key);
        }

        return inverted;
    }
}
