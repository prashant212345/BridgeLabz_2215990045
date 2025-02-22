using System;
using System.Threading;
using NUnit.Framework;

public class PerformanceChecker
{
    public void LongRunningTask() { Thread.Sleep(3000); }
}

[TestFixture]
public class PerformanceCheckerTests
{
    private PerformanceChecker _checker;

    [SetUp]
    public void Setup() { _checker = new PerformanceChecker(); }

    [Test, Timeout(2000)]
    public void Test_LongRunningTask()
    {
        _checker.LongRunningTask();
    }
}
