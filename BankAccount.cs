using System;
using NUnit.Framework;

public class BankAccount
{
    private double _balance;

    public void Deposit(double amount)
    {
        if (amount < 0) throw new ArgumentException("Deposit amount cannot be negative");
        _balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount > _balance) throw new InvalidOperationException("Insufficient funds");
        _balance -= amount;
    }

    public double GetBalance() { return _balance; }
}

[TestFixture]
public class BankAccountTests
{
    private BankAccount _account;

    [SetUp]
    public void Setup() { _account = new BankAccount(); }

    [Test]
    public void Test_Deposit()
    {
        _account.Deposit(100);
        Assert.AreEqual(100, _account.GetBalance());
    }

    [Test]
    public void Test_Withdraw()
    {
        _account.Deposit(200);
        _account.Withdraw(100);
        Assert.AreEqual(100, _account.GetBalance());
    }

    [Test]
    public void Test_Withdraw_InsufficientFunds()
    {
        Assert.Throws<InvalidOperationException>(() => _account.Withdraw(50));
    }
}
