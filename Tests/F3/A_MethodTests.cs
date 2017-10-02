using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

[TestClass]
public class MethodTests
{
    private int MethodWithReturn()
    {
        return 0;
    }
    private void MethodWithoutReturn()
    {

    }
    private int MethodWithArguments(int a, int b)
    {
        return a + b;
    }
    private bool OneLinerSyntaxMethod(bool value) => !value;
    
    [TestMethod]
    public void calling_method()
    {
        var sum = MethodWithArguments(1, 2);
        Assert.AreEqual(3, sum);

        sum = this.MethodWithArguments(1, 2);
        Assert.AreEqual(3, sum);
    }
    private static string StaticMethod(string value)
    {
        return value.ToUpper();
    }

    [TestMethod]
    public void calling_static()
    {
        StaticMethod("hej");
        //this.StaticMethod("hej"); // Error, this är instancen av en klass. Static ligger på "typen".
        MethodTests.StaticMethod("hello");
    }

    private string MethodWithParams(params string[] values)
    {
        return string.Join(" ", values);
    }

    [TestMethod]
    public void Params()
    {
        var joinedValue = MethodWithParams("hello", "world", "!");

        Assert.AreEqual("hello world !", joinedValue);
    }

    [TestMethod]
    public void anonymous_method()
    {
        var modified = false;
        Action doSomething = () =>
        {
            modified = true;
        };

        doSomething();

        Assert.AreEqual(true, modified);
    }

    private void setIntToZeroWithoutRef(int value) => value = 0;
    private void setIntToZeroWithRef(ref int value) => value = 0;

    [TestMethod]
    public void Ref()
    {
        var value = 10;
        setIntToZeroWithoutRef(value);
        Assert.AreEqual(10, value);

        setIntToZeroWithRef(ref value);
        Assert.AreEqual(0, value);
    }

    private void setIntToZeroWithOut(out int value) => value = 0;

    [TestMethod]
    public void Out()
    {
        int value;
        setIntToZeroWithOut(out value);
        Assert.AreEqual(0, value);
                
        setIntToZeroWithOut(out var value2);
        Assert.AreEqual(0, value2);
    }
}
