using System;

class ReplaceStr
{
    public static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();
        Console.Write("Enter the word to replace: ");
        string oldWord = Console.ReadLine();
        Console.Write("Enter the new word: ");
        string newWord = Console.ReadLine();

        string result = "";
        string[] words = sentence.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i] == oldWord)
            {
                result += newWord;
            }
            else
            {
                result += words[i];
            }

            if (i < words.Length - 1)
            {
                result += " ";
            }
        }

        Console.WriteLine(string.Format("Modified Sentence: {0}", result));
    }
}

