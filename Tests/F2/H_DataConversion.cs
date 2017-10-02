using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

[TestClass]
public class DataConversionTests
{
    [TestMethod]
    public void tostring()
    {
        var date = new DateTime(2000, 01, 01);
        var formatedDate = date.ToString("yyyy-MM-dd");
        Assert.AreEqual("2000-01-01", formatedDate);
        
        Assert.AreEqual("15,99 kr", 15.99m.ToString("C"));
        Assert.AreEqual("100,00 %", 1.ToString("P"));
        Assert.AreEqual("1 000 000", 1000000.ToString("n0"));
    }

    [TestMethod]
    public void parse()
    {
        var intAsString = "0";
        var intAsInt = int.Parse(intAsString);
        Assert.AreEqual(0, intAsInt);

        var success = DateTime.TryParse(intAsString, out var result);
        Assert.AreEqual(false, success);
        Assert.AreEqual(DateTime.MinValue, result);
    }

    [TestMethod]
    public void convert()
    {
        var intAsString = "0";
        var intAsInt = Convert.ToInt32(intAsString);
        Assert.AreEqual(0, intAsInt);
    }
}