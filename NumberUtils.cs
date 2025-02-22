using NUnit.Framework;

public class NumberUtils
{
    public bool IsEven(int number) { return number % 2 == 0; }
}

[TestFixture]
public class NumberUtilsTests
{
    private NumberUtils _utils;

    [SetUp]
    public void Setup() { _utils = new NumberUtils(); }

    [TestCase(2, ExpectedResult = true)]
    [TestCase(4, ExpectedResult = true)]
    [TestCase(7, ExpectedResult = false)]
    [TestCase(9, ExpectedResult = false)]
    public bool Test_IsEven(int num) { return _utils.IsEven(num); }
}
