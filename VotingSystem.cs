using System;
using System.Collections.Generic;
using System.Linq;

class VotingSystem
{
    static Dictionary<string, int> voteCount = new Dictionary<string, int>(); // Stores votes
    static SortedDictionary<string, int> sortedResults = new SortedDictionary<string, int>(); // Stores results sorted by candidate names
    static LinkedList<string> voteOrder = new LinkedList<string>(); // Maintains the order of votes

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nVoting System");
            Console.WriteLine("1. Cast Vote");
            Console.WriteLine("2. Display Vote Count");
            Console.WriteLine("3. Display Sorted Results");
            Console.WriteLine("4. Display Vote Order");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.Write("Invalid input! Please enter a number: ");
            }

            switch (choice)
            {
                case 1:
                    CastVote();
                    break;
                case 2:
                    DisplayVoteCount();
                    break;
                case 3:
                    DisplaySortedResults();
                    break;
                case 4:
                    DisplayVoteOrder();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice! Try again.");
                    break;
            }
        }
    }

    static void CastVote()
    {
        Console.Write("Enter Candidate Name: ");
        string candidate = Console.ReadLine().Trim();

        if (string.IsNullOrEmpty(candidate))
        {
            Console.WriteLine("Candidate name cannot be empty!");
            return;
        }

        // Update Dictionary
        if (voteCount.ContainsKey(candidate))
        {
            voteCount[candidate]++;
        }
        else
        {
            voteCount[candidate] = 1;
        }

        // Update LinkedList (vote order)
        voteOrder.AddLast(candidate);

        Console.WriteLine($"Vote cast successfully for {candidate}.");
    }

    static void DisplayVoteCount()
    {
        Console.WriteLine("\nCurrent Vote Count:");
        foreach (var candidate in voteCount)
        {
            Console.WriteLine($"{candidate.Key}: {candidate.Value} votes");
        }
    }

    static void DisplaySortedResults()
    {
        Console.WriteLine("\nSorted Voting Results:");

        // Copy data to SortedDictionary
        sortedResults = new SortedDictionary<string, int>(voteCount);

        foreach (var candidate in sortedResults)
        {
            Console.WriteLine($"{candidate.Key}: {candidate.Value} votes");
        }
    }

    static void DisplayVoteOrder()
    {
        Console.WriteLine("\nVote Order:");
        foreach (var vote in voteOrder)
        {
            Console.Write($"{vote} → ");
        }
        Console.WriteLine("END");
    }
}
