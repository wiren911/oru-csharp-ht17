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

    [TestMethod, ExpectedException(typeof(Exception))]
    public void catch_exception()
    {
        var value = "";
        var divideBy = 0;
        try
        {
            value += "before ";
            var result = 1 / divideBy;
            value += "after ";
        }
        catch (DivideByZeroException e)
        {
            // AHA! "Förväntat" fel
            throw new Exception("Du kan inte dela med noll!");
        }
        catch (Exception e)
        {
            value += "catch ";
            throw new NotImplementedException("Something is rotten...");
        }
        finally
        {
            value += "finally ";
        }

        Assert.AreEqual("before catch finally ", value);
    }

    [TestMethod]
    public void no_exception()
    {
        var value = "";
        var divideBy = 1;
        try
        {
            value += "before ";
            var result = 1 / divideBy;
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

        Assert.AreEqual("before after finally ", value);
    }
}