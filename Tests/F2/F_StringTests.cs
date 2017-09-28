using Microsoft.VisualStudio.TestTools.UnitTesting;
[Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
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
}