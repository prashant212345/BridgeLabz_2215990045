using System;
using NUnit.Framework;

public class DatabaseConnection
{
    public bool IsConnected { get; private set; }

    public void Connect() { IsConnected = true; }
    public void Disconnect() { IsConnected = false; }
}

[TestFixture]
public class DatabaseConnectionTests
{
    private DatabaseConnection _db;

    [SetUp]
    public void Setup() { _db = new DatabaseConnection(); _db.Connect(); }

    [TearDown]
    public void Teardown() { _db.Disconnect(); }

    [Test]
    public void Test_Connection() { Assert.IsTrue(_db.IsConnected); }
}
