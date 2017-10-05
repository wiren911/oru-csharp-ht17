using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

[TestClass]
public class DictionaryTest
{
    [TestMethod]
    public void dictionary()
    {
        var days = new Dictionary<string, DateTime>();
        
        days["Imorgon"] = DateTime.Today.AddDays(1);
        days.Add("Igår", DateTime.Today.AddDays(-1));
        days.Add("Idag", DateTime.Today);        
    }
}