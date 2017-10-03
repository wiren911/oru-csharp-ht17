using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

[TestClass]
public class ExceptionTests
{
    [TestMethod, ExpectedException(typeof(Exception))]
    public void throw_exception()
    {
        throw new Exception("Woops.");
    }

    [TestMethod, ExpectedException(typeof(NotImplementedException))]
    public void catch_exception()
    {
        var value = "";
        try
        {
            value += "before ";
            throw_exception();
            value += "after ";
        }
        catch (Exception e)
        {
            value += "catch ";

            Assert.AreEqual("Woops.", e.Message);
            throw new NotImplementedException("Something is rotten...");
        }
        finally
        {
            value += "finally ";
        }

        Assert.AreEqual("before after catch finally ", value);
    }
}