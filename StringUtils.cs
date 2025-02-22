using System;
using NUnit.Framework;

public class StringUtils
{
    public string Reverse(string str)
    {
        char[] arr = str.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }

    public bool IsPalindrome(string str)
    {
        return str.Equals(Reverse(str), StringComparison.OrdinalIgnoreCase);
    }

    public string ToUpperCase(string str) { return str.ToUpper(); }
}

[TestFixture]
public class StringUtilsTests
{
    private StringUtils _utils;

    [SetUp]
    public void Setup() { _utils = new StringUtils(); }

    [Test]
    public void Test_Reverse() { Assert.AreEqual("cba", _utils.Reverse("abc")); }

    [Test]
    public void Test_IsPalindrome() { Assert.IsTrue(_utils.IsPalindrome("madam")); }

    [Test]
    public void Test_ToUpperCase() { Assert.AreEqual("HELLO", _utils.ToUpperCase("hello")); }
}
