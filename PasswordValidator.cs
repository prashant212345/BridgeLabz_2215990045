using System;
using System.Text.RegularExpressions;
using NUnit.Framework;

public class PasswordValidator
{
    public bool IsValidPassword(string password)
    {
        if (password.Length < 8) return false;
        if (!Regex.IsMatch(password, @"[A-Z]")) return false;
        if (!Regex.IsMatch(password, @"\d")) return false;
        return true;
    }
}

[TestFixture]
public class PasswordValidatorTests
{
    private PasswordValidator _validator;

    [SetUp]
    public void Setup() { _validator = new PasswordValidator(); }

    [Test]
    public void Test_ValidPassword()
    {
        Assert.IsTrue(_validator.IsValidPassword("Strong1Pass"));
    }

    [Test]
    public void Test_InvalidPassword_Short()
    {
        Assert.IsFalse(_validator.IsValidPassword("Pass1"));
    }
}
