using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

[TestClass]
public class StringTests
{
    [TestMethod]
    public void declare_and_join()
    {
        var hello = "Hello";
        var helloWorld = hello + " world";
        Assert.AreEqual("Hello world", helloWorld);

        helloWorld += 11;
        Assert.AreEqual("Hello world11", helloWorld);

    }

    [TestMethod]
    public void magic_escape_chars()
    {
        var pathWithVerbatim = @"c:\hej
";
        /* 
        \\ => \
        \n => newline
        \r => return
        \t => tab
        \" => "
      
        */
        var pathWithEscapeChars = "c:\\hej\r\n";

        Assert.AreEqual(pathWithVerbatim, pathWithEscapeChars);
    }

    [TestMethod]
    public void string_interpolation()
    {
        var result = $"År: {DateTime.Now.Year}, Månad: {DateTime.Now.Month}";

        Assert.AreEqual("År: 2017, Månad: 10", result);
    }

    // LIVE-Time
}