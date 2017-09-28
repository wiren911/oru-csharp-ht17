using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

[TestClass]
public class RelationalOperatorTests
{
    [TestMethod]
    public void relational()
    {
        Assert.IsTrue(1 == 1);
        Assert.IsFalse(1 != 1);
        Assert.IsTrue(2 > 1);
        Assert.IsTrue(1 < 2);
        Assert.IsTrue(1 <= 1);
        Assert.IsTrue(1 >= 1);
    }

    [TestMethod]
    public void logical()
    {
        Assert.IsTrue(true && true);
        Assert.IsTrue(false || true);

        int i = 0;
        Assert.IsTrue(true & i++ == 0);
        Assert.AreEqual(1, i);

        Assert.IsTrue(false | true);
    }
}