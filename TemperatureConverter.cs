using System;
using NUnit.Framework;

public class TemperatureConverter
{
    public double CelsiusToFahrenheit(double celsius) { return (celsius * 9 / 5) + 32; }
    public double FahrenheitToCelsius(double fahrenheit) { return (fahrenheit - 32) * 5 / 9; }
}

[TestFixture]
public class TemperatureConverterTests
{
    private TemperatureConverter _converter;

    [SetUp]
    public void Setup() { _converter = new TemperatureConverter(); }

    [Test]
    public void Test_CelsiusToFahrenheit()
    {
        Assert.AreEqual(32, _converter.CelsiusToFahrenheit(0));
    }

    [Test]
    public void Test_FahrenheitToCelsius()
    {
        Assert.AreEqual(0, _converter.FahrenheitToCelsius(32));
    }
}
