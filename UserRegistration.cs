using System;
using System.Text.RegularExpressions;
using NUnit.Framework;

public class UserRegistration
{
    public void RegisterUser(string username, string email, string password)
    {
        if (string.IsNullOrEmpty(username) || username.Length < 3)
            throw new ArgumentException("Invalid username");

        if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            throw new ArgumentException("Invalid email");

        if (password.Length < 8 || !Regex.IsMatch(password, @"[A-Z]") || !Regex.IsMatch(password, @"\d"))
            throw new ArgumentException("Invalid password");
    }
}

[TestFixture]
public class UserRegistrationTests
{
    private UserRegistration _registration;

    [SetUp]
    public void Setup() { _registration = new UserRegistration(); }

    [Test]
    public void Test_ValidRegistration()
    {
        Assert.DoesNotThrow(() => _registration.RegisterUser("JohnDoe", "john@example.com", "Password1"));
    }

    [Test]
    public void Test_InvalidUsername()
    {
        Assert.Throws<ArgumentException>(() => _registration.RegisterUser("JD", "john@example.com", "Password1"));
    }

    [Test]
    public void Test_InvalidEmail()
    {
        Assert.Throws<ArgumentException>(() => _registration.RegisterUser("JohnDoe", "invalid-email", "Password1"));
    }

    [Test]
    public void Test_InvalidPassword()
    {
        Assert.Throws<ArgumentException>(() => _registration.RegisterUser("JohnDoe", "john@example.com", "weakpass"));
    }
}
