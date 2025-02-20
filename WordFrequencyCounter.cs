using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class WordFrequencyCounter
{
    static string filePath = "sample.txt";  // Sample text file

    static void Main()
    {
        try
        {
            // Ensure the sample file exists
            CreateSampleFile(filePath);

            // Count words and display the top 5 frequent ones
            CountWordsInFile(filePath);
        }
        catch (IOException ex)
        {
            Console.WriteLine($"File error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
    }

    static void CountWordsInFile(string path)
    {
        Dictionary<string, int> wordCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

        using (StreamReader reader = new StreamReader(path))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                // Extract words using regex (ignores punctuation)
                foreach (string word in Regex.Matches(line.ToLower(), @"\b[a-zA-Z]+\b")
                                             .Cast<Match>()
                                             .Select(m => m.Value))
                {
                    if (wordCount.ContainsKey(word))
                        wordCount[word]++;
                    else
                        wordCount[word] = 1;
                }
            }
        }

        // Sort words by frequency (descending order) and take top 5
        var topWords = wordCount.OrderByDescending(pair => pair.Value).Take(5);

        Console.WriteLine("\nTop 5 Most Frequent Words:");
        foreach (var pair in topWords)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value} times");
        }
    }

    // Creates a sample text file for testing
    static void CreateSampleFile(string path)
    {
        if (!File.Exists(path))
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("This is a sample text file.");
                writer.WriteLine("This file is used for counting word occurrences.");
                writer.WriteLine("Word frequency is calculated based on how often a word appears in this file.");
                writer.WriteLine("This is a simple example of counting words in a file.");
            }
            Console.WriteLine("Sample text file created: 'sample.txt'");
        }
        else
        {
            Console.WriteLine("Sample text file already exists.");
        }
    }
}
