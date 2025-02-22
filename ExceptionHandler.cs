using System;
using NUnit.Framework;

public class ExceptionHandler
{
    public int Divide(int a, int b)
    {
        if (b == 0) throw new ArithmeticException("Cannot divide by zero");
        return a / b;
    }
}

[TestFixture]
public class ExceptionHandlerTests
{
    private ExceptionHandler _handler;

    [SetUp]
    public void Setup() { _handler = new ExceptionHandler(); }

    [Test]
    public void Test_DivideByZero()
    {
        Assert.Throws<ArithmeticException>(() => _handler.Divide(10, 0));
    }
}
