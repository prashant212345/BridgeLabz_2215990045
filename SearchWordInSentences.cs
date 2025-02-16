using System;

public class SearchWordInSentences
{
    static void Main()
    {
        Console.Write("Enter the number of sentences: ");
        int n = int.Parse(Console.ReadLine());

        string[] sentences = new string[n];

        Console.WriteLine("Enter the sentences:");
        for (int i = 0; i < n; i++)
        {
            sentences[i] = Console.ReadLine();
        }

        Console.Write("Enter the word to search for: ");
        string searchWord = Console.ReadLine();

        string result = FindSentenceContainingWord(sentences, searchWord);

        if (result != null)
            Console.WriteLine($"First sentence containing '{searchWord}': {result}");
        else
            Console.WriteLine($"No sentence contains the word '{searchWord}'.");
    }

    public static string FindSentenceContainingWord(string[] sentences, string word)
    {
        foreach (string sentence in sentences)
        {
            if (sentence.Contains(word, StringComparison.OrdinalIgnoreCase)) // Case-insensitive search
            {
                return sentence; // Return first matching sentence
            }
        }
        return null; // If no sentence contains the word
    }
}
