using System;
using System.Collections.Generic;

// Abstract class BankAccount
abstract class BankAccount
{
    private string accountNumber;
    private string holderName;
    private double balance;

    public string AccountNumber
    {
        get { return accountNumber; }
        set { accountNumber = value; }
    }

    public string HolderName
    {
        get { return holderName; }
        set { holderName = value; }
    }

    public double Balance
    {
        get { return balance; }
        protected set { balance = value; } // Restrict direct modification
    }

    public BankAccount(string accountNumber, string holderName, double initialBalance)
    {
        this.accountNumber = accountNumber;
        this.holderName = holderName;
        this.balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine("Deposited: " + amount);
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    public virtual void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Withdrawn: " + amount);
        }
        else
        {
            Console.WriteLine("Insufficient balance or invalid amount.");
        }
    }

    public abstract double CalculateInterest();

    public void DisplayAccountDetails()
    {
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Holder Name: " + holderName);
        Console.WriteLine("Balance: " + balance);
    }
}

// Interface ILoanable
interface ILoanable
{
    bool ApplyForLoan(double amount);
    double CalculateLoanEligibility();
}

// SavingsAccount class implementing ILoanable
class SavingsAccount : BankAccount, ILoanable
{
    private double interestRate;

    public SavingsAccount(string accountNumber, string holderName, double initialBalance, double interestRate)
        : base(accountNumber, holderName, initialBalance)
    {
        this.interestRate = interestRate;
    }

    public override double CalculateInterest()
    {
        return Balance * interestRate / 100;
    }

    public bool ApplyForLoan(double amount)
    {
        return Balance > 5000 && amount <= Balance * 2; // Simple condition for loan eligibility
    }

    public double CalculateLoanEligibility()
    {
        return Balance * 2;
    }
}

// CurrentAccount class implementing ILoanable
class CurrentAccount : BankAccount, ILoanable
{
    private double interestRate;
    private double overdraftLimit;

    public CurrentAccount(string accountNumber, string holderName, double initialBalance, double interestRate, double overdraftLimit)
        : base(accountNumber, holderName, initialBalance)
    {
        this.interestRate = interestRate;
        this.overdraftLimit = overdraftLimit;
    }

    public override double CalculateInterest()
    {
        return Balance * interestRate / 100;
    }

    public override void Withdraw(double amount)
    {
        if (amount > 0 && amount <= (Balance + overdraftLimit))
        {
            Balance -= amount;
            Console.WriteLine("Withdrawn: " + amount);
        }
        else
        {
            Console.WriteLine("Withdrawal exceeds limit.");
        }
    }

    public bool ApplyForLoan(double amount)
    {
        return Balance > 10000 && amount <= Balance * 3;
    }

    public double CalculateLoanEligibility()
    {
        return Balance * 3;
    }
}

// Main Class to Demonstrate Polymorphism
class Bank
{
    static void Main()
    {
        List<BankAccount> accounts = new List<BankAccount>();

        SavingsAccount sa1 = new SavingsAccount("SA1001", "Alice", 8000, 4);
        CurrentAccount ca1 = new CurrentAccount("CA2001", "Bob", 15000, 3, 5000);

        accounts.Add(sa1);
        accounts.Add(ca1);

        foreach (BankAccount account in accounts)
        {
            account.DisplayAccountDetails();
            Console.WriteLine("Interest Earned: " + account.CalculateInterest());

            ILoanable loan = account as ILoanable;
            if (loan != null)
            {
                Console.WriteLine("Loan Eligibility: " + loan.CalculateLoanEligibility());
                Console.WriteLine("Loan Approval (10,000): " + (loan.ApplyForLoan(10000) ? "Approved" : "Denied"));
            }

            Console.WriteLine("-------------------------");
        }
    }
}
