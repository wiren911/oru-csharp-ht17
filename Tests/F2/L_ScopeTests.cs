using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class ScopeTests
{
    private bool _canAccessClassScope = true;

    [TestMethod]
    public void access()
    {
        Assert.AreEqual(true, _canAccessClassScope);

        var canAccessMethodScope = true;
        Assert.AreEqual(true, canAccessMethodScope);

        if (true)
        {
            var canAccessIfScope = false;
        }
        //Assert.AreEqual(true, canAccessIfScope); // Error

        for (int i = 0; i < 1; i++)
        {
            var canAccessLoopScope = false;
        }
        //Assert.AreEqual(true, canAccessLoopScope); // Error

        {
            var canAccessBlockScope = false;
        }
        //Assert.AreEqual(true, canAccessBlockScope); // Error
    }
}