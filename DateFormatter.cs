using System;
using NUnit.Framework;

public class DateFormatter
{
    public string FormatDate(string inputDate)
    {
        if (DateTime.TryParse(inputDate, out DateTime date))
        {
            return date.ToString("dd-MM-yyyy");
        }
        throw new FormatException("Invalid date format");
    }
}

[TestFixture]
public class DateFormatterTests
{
    private DateFormatter _formatter;

    [SetUp]
    public void Setup() { _formatter = new DateFormatter(); }

    [Test]
    public void Test_ValidDate()
    {
        Assert.AreEqual("25-12-2022", _formatter.FormatDate("2022-12-25"));
    }

    [Test]
    public void Test_InvalidDate()
    {
        Assert.Throws<FormatException>(() => _formatter.FormatDate("Invalid-Date"));
    }
}
