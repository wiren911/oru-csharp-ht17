using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic; // <-- OBS

[TestClass]
public class CollectionsTest
{
    [TestMethod]
    public void init()
    {
        // Generic: går att specificera n antal GenericArguments (typer) för att 
        // få bättre typsäkerhet
        List<string> declareWithoutInit;
        var declareAndInit = new List<string>();

        var declareAndInitWithValues = new List<string> { "hello", "world" };

        Assert.AreEqual(2, declareAndInitWithValues.Count);
        Assert.AreEqual("hello world", string.Join(" ", declareAndInitWithValues));
    }

    [TestMethod]
    public void add_remove()
    {
        var list = new List<object>();

        list.Add("Hello World");

        var intList = new List<object> { 1, 2, 3 };

        list.AddRange(intList);

        Assert.AreEqual(4, list.Count);

        list.Remove("Hello World");

        Assert.AreEqual(3, list.Count);
    }

    [TestMethod]
    public void iterate()
    {
        var values = new List<int> { 1, 2, 3, 4, 5 };

        var sum = 0;
        foreach (var value in values)
        {
            sum += value;
        }

        Assert.AreEqual(15, sum); 
    }

    [TestMethod]
    public void common_methods_props()
    {
        var list = new List<string> { "hello", "world" };

        Assert.AreEqual("hello", list[0]);

        Assert.AreEqual(true, list.Contains("world"));

        Assert.AreEqual(4, list.Capacity);

        list.Add("oh");
        list.Add("realy");
        list.Add("?");
        Assert.AreEqual(8, list.Capacity);

        list.Clear();
        Assert.AreEqual(0, list.Count);
    }

    [TestMethod]
    public void stack()
    {
        var stack = new Stack<string>();
        stack.Push("ACE");
        stack.Push("KING");
        stack.Push("QUEEN");
        stack.Push("KNIGHT");

        var removedCard = stack.Pop();

        Assert.AreEqual("KNIGHT", removedCard);

        var peekedCard = stack.Peek();

        Assert.AreEqual("QUEEN", peekedCard);
    }

    [TestMethod]
    public void queue()
    {
        var queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        var dequeed = queue.Dequeue();

        Assert.AreEqual(1, dequeed);

        var peeked = queue.Peek();

        Assert.AreEqual(2, peeked);
    }

    [TestMethod]
    public void untyped()
    {
        // Pre .NET Framework 2
        // Osäkert och mycket konvertering mellan datatyper.
        var untypedMadness = new ArrayList();
        untypedMadness.Add("hello");
        untypedMadness.Add(true);
    }
}