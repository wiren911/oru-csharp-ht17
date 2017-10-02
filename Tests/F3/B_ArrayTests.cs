using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

[TestClass]
public class MyTestClass
{
    [TestMethod]
    public void declare_initialize()
    {
        string[] helloWorld = new[] { "hello", "world" };
        var multiDimension = new[,] {
            { "h", "e", "l", "l", "o" },
            { "w", "o", "r", "l", "d" }
        };

        string[] helloInTwoStatements = new string[2];
        helloInTwoStatements[0] = "hello";
        helloInTwoStatements[1] = "world";
    }

    [TestMethod]
    public void access()
    {
        var helloWorld = new[] { "hello", "World" };
        var hello = helloWorld[0];

        Assert.AreEqual("hello", hello);
    }

    [TestMethod, ExpectedException(typeof(IndexOutOfRangeException))]
    public void add()
    {
        var helloWorld = new[] { "hello" };
        //helloWorld.Add("world"); // Error. Längd definieras vid instancieringen
        helloWorld[1] = "world"; // Error. Längden är 1, går inte att lägga till ytterligare plats
    }

    [TestMethod]
    public void remove()
    {
        var helloWorld = new[] { "hello", "world" };
        //helloWorld.Remove("world"); // Error. 
        helloWorld[1] = string.Empty;
        Assert.AreEqual(2, helloWorld.Length);
    }

    [TestMethod]
    public void jagged_array()
    {
        var jaggedArray = new int[2][];
        jaggedArray[0] = new[] { 1 };
        jaggedArray[1] = new[] { 1, 2, 3 };

        Assert.AreEqual(3, jaggedArray[1][2]);
    }

    [TestMethod]
    public void iterate_fibonacci()
    {
        var numbers = new long[20];

        for (int i = 0; i < numbers.Length; i++)
        {
            if (i <= 1)
                numbers[i] = i;
            else
                numbers[i] = numbers[i - 1] + numbers[i - 2];
        }

        Assert.AreEqual(4181, numbers[19]);
    }

    [TestMethod]
    public void join_arrays()
    {
        var hello = new[] { "h", "e", "l", "l", "o" };
        var world = new[] { "w", "o", "r", "l", "d" };

        var helloWorld = new string[hello.Length + world.Length];

        hello.CopyTo(helloWorld, 0);
        world.CopyTo(helloWorld, hello.Length);

        var helloWorldString = string.Join("", helloWorld);

        Assert.AreEqual("helloworld", helloWorldString);
    }
}