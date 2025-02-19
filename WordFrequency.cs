using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class WordFrequency
{
    static void Main()
    {
        string filePath = "sample.txt"; // Change to your file path
        Dictionary<string, int> wordFrequency = CountWordFrequency(filePath);

        // Print result
        foreach (var pair in wordFrequency)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }

    public static Dictionary<string, int> CountWordFrequency(string filePath)
    {
        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        // Read file content
        string text = File.ReadAllText(filePath);

        // Normalize case & split words using regex (ignoring punctuation)
        string[] words = Regex.Split(text.ToLower(), @"\W+");

        foreach (string word in words)
        {
            if (!string.IsNullOrEmpty(word)) // Ignore empty words
            {
                if (wordCount.ContainsKey(word))
                    wordCount[word]++;
                else
                    wordCount[word] = 1;
            }
        }

        return wordCount;
    }
}
