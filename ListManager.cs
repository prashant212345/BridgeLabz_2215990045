using System;
using System.Collections.Generic;
using NUnit.Framework;

public class ListManager
{
    public void AddElement(List<int> list, int element) { list.Add(element); }
    public void RemoveElement(List<int> list, int element) { list.Remove(element); }
    public int GetSize(List<int> list) { return list.Count; }
}

[TestFixture]
public class ListManagerTests
{
    private ListManager _manager;
    private List<int> _list;

    [SetUp]
    public void Setup()
    {
        _manager = new ListManager();
        _list = new List<int>();
    }

    [Test]
    public void Test_AddElement()
    {
        _manager.AddElement(_list, 5);
        Assert.Contains(5, _list);
    }

    [Test]
    public void Test_RemoveElement()
    {
        _manager.AddElement(_list, 10);
        _manager.RemoveElement(_list, 10);
        Assert.IsFalse(_list.Contains(10));
    }

    [Test]
    public void Test_GetSize()
    {
        _manager.AddElement(_list, 7);
        Assert.AreEqual(1, _manager.GetSize(_list));
    }
}
