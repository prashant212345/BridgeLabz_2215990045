using System;
using NUnit.Framework;

public class Calculator
{
    public int Add(int a, int b) { return a + b; }
    public int Subtract(int a, int b) { return a - b; }
    public int Multiply(int a, int b) { return a * b; }
    public int Divide(int a, int b)
    {
        if (b == 0) throw new DivideByZeroException();
        return a / b;
    }
}

[TestFixture]
public class CalculatorTests
{
    private Calculator _calc;

    [SetUp]
    public void Setup() { _calc = new Calculator(); }

    [Test]
    public void Test_Add() { Assert.AreEqual(5, _calc.Add(2, 3)); }

    [Test]
    public void Test_Subtract() { Assert.AreEqual(1, _calc.Subtract(4, 3)); }

    [Test]
    public void Test_Multiply() { Assert.AreEqual(12, _calc.Multiply(4, 3)); }

    [Test]
    public void Test_Divide() { Assert.AreEqual(2, _calc.Divide(6, 3)); }

    [Test]
    public void Test_DivideByZero()
    {
        Assert.Throws<DivideByZeroException>(() => _calc.Divide(4, 0));
    }
}
