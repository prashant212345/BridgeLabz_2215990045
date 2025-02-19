using System;
using System.Collections.Generic;

class BankingSystem
{
    static Dictionary<int, double> accountBalances = new Dictionary<int, double>(); // Stores account balances
    static SortedDictionary<double, List<int>> sortedBalances = new SortedDictionary<double, List<int>>(); // Sorts accounts by balance
    static Queue<Tuple<int, double>> withdrawalQueue = new Queue<Tuple<int, double>>(); // Withdrawal requests

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nBanking System");
            Console.WriteLine("1. Add Account");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Process Withdrawals");
            Console.WriteLine("5. Display Accounts Sorted by Balance");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.Write("Invalid input! Please enter a number: ");
            }

            switch (choice)
            {
                case 1:
                    AddAccount();
                    break;
                case 2:
                    DepositMoney();
                    break;
                case 3:
                    RequestWithdrawal();
                    break;
                case 4:
                    ProcessWithdrawals();
                    break;
                case 5:
                    DisplaySortedAccounts();
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid choice! Try again.");
                    break;
            }
        }
    }

    static void AddAccount()
    {
        Console.Write("Enter Account Number: ");
        int accountNumber;
        while (!int.TryParse(Console.ReadLine(), out accountNumber) || accountBalances.ContainsKey(accountNumber))
        {
            Console.Write("Invalid or existing account! Enter a unique account number: ");
        }

        Console.Write("Enter Initial Balance: ");
        double balance;
        while (!double.TryParse(Console.ReadLine(), out balance) || balance < 0)
        {
            Console.Write("Invalid amount! Enter a non-negative balance: ");
        }

        // Store in Dictionary
        accountBalances[accountNumber] = balance;

        // Store in SortedDictionary
        if (!sortedBalances.ContainsKey(balance))
        {
            sortedBalances[balance] = new List<int>();
        }
        sortedBalances[balance].Add(accountNumber);

        Console.WriteLine($"Account {accountNumber} created with balance ${balance}");
    }

    static void DepositMoney()
    {
        Console.Write("Enter Account Number: ");
        int accountNumber;
        while (!int.TryParse(Console.ReadLine(), out accountNumber) || !accountBalances.ContainsKey(accountNumber))
        {
            Console.Write("Account not found! Enter a valid account number: ");
        }

        Console.Write("Enter Deposit Amount: ");
        double amount;
        while (!double.TryParse(Console.ReadLine(), out amount) || amount <= 0)
        {
            Console.Write("Invalid amount! Enter a positive value: ");
        }

        double oldBalance = accountBalances[accountNumber];
        double newBalance = oldBalance + amount;
        accountBalances[accountNumber] = newBalance;

        // Update SortedDictionary
        sortedBalances[oldBalance].Remove(accountNumber);
        if (sortedBalances[oldBalance].Count == 0) sortedBalances.Remove(oldBalance);

        if (!sortedBalances.ContainsKey(newBalance))
        {
            sortedBalances[newBalance] = new List<int>();
        }
        sortedBalances[newBalance].Add(accountNumber);

        Console.WriteLine($"Deposited ${amount} into account {accountNumber}. New Balance: ${newBalance}");
    }

    static void RequestWithdrawal()
    {
        Console.Write("Enter Account Number: ");
        int accountNumber;
        while (!int.TryParse(Console.ReadLine(), out accountNumber) || !accountBalances.ContainsKey(accountNumber))
        {
            Console.Write("Account not found! Enter a valid account number: ");
        }

        Console.Write("Enter Withdrawal Amount: ");
        double amount;
        while (!double.TryParse(Console.ReadLine(), out amount) || amount <= 0)
        {
            Console.Write("Invalid amount! Enter a positive value: ");
        }

        withdrawalQueue.Enqueue(new Tuple<int, double>(accountNumber, amount));
        Console.WriteLine($"Withdrawal request for ${amount} from account {accountNumber} added to queue.");
    }

    static void ProcessWithdrawals()
    {
        if (withdrawalQueue.Count == 0)
        {
            Console.WriteLine("No pending withdrawal requests.");
            return;
        }

        Console.WriteLine("\nProcessing Withdrawals...");
        while (withdrawalQueue.Count > 0)
        {
            var request = withdrawalQueue.Dequeue();
            int accountNumber = request.Item1;
            double amount = request.Item2;

            if (!accountBalances.ContainsKey(accountNumber))
            {
                Console.WriteLine($"Account {accountNumber} does not exist. Skipping...");
                continue;
            }

            if (accountBalances[accountNumber] < amount)
            {
                Console.WriteLine($"Insufficient balance in account {accountNumber}. Skipping...");
                continue;
            }

            double oldBalance = accountBalances[accountNumber];
            double newBalance = oldBalance - amount;
            accountBalances[accountNumber] = newBalance;

            // Update SortedDictionary
            sortedBalances[oldBalance].Remove(accountNumber);
            if (sortedBalances[oldBalance].Count == 0) sortedBalances.Remove(oldBalance);

            if (!sortedBalances.ContainsKey(newBalance))
            {
                sortedBalances[newBalance] = new List<int>();
            }
            sortedBalances[newBalance].Add(accountNumber);

            Console.WriteLine($"Withdrew ${amount} from account {accountNumber}. New Balance: ${newBalance}");
        }
    }

    static void DisplaySortedAccounts()
    {
        Console.WriteLine("\nAccounts Sorted by Balance:");
        foreach (var balanceGroup in sortedBalances)
        {
            foreach (var account in balanceGroup.Value)
            {
                Console.WriteLine($"Account {account}: ${balanceGroup.Key}");
            }
        }
    }
}
