using Microsoft.VisualStudio.TestTools.UnitTesting;
[Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
public class LoopTests
{
    [TestMethod]
    public void While()
    {
        int i = 0;
        while (i <= 10)
        {
            i++;
        }

        Assert.AreEqual(11, i);
    }

    [TestMethod]
    public void do_while()
    {
        int i = 0;
        do
        {
            i++;
        } while (i <= 10);

        Assert.AreEqual(11, i);
    }

    [TestMethod]
    public void For()
    {
        var sum = 0;
        for (int i = 0; i < 10; i++)
        {
            sum += i;
        }

        Assert.AreEqual(45, sum);
    }

    [TestMethod]
    public void Break()
    {
        var sum = 0;
        for (int i = 0; i < 10; i++)
        {
            if (sum > 20)
            {
                break;
            }

            sum += i;
        }

        Assert.AreEqual(21, sum);
    }


    [TestMethod]
    public void Continue()
    {
        var sum = 0;
        for (int i = 0; i < 10; i++)
        {
            if (i < 9)
            {
                continue;
            }

            sum += i;
        }

        Assert.AreEqual(9, sum);
    }

	// LIVE-Time
}