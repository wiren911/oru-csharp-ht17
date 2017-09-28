using Microsoft.VisualStudio.TestTools.UnitTesting;
[Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
public class ConditionalStatementsTests
{
    [TestMethod]
    public void if_statement()
    {
        if (1 == 2)
        {
            // Nope.
        }
        else if (1 == 1)
        {
            // YES
        }
        else
        {
            // Nope.
        }
    }

    [TestMethod]
    public void switch_statements()
    {
        var name = "johan";
        var hit = 0;

        switch (name)
        {
            case "pelle":
                hit--;
                break;
            case "johan": // Utan break, går vidare neråt.
            case "max":
                hit++;
                break;
            default: // Om ingen blir "träffad"
                hit--;
                break;
        }

        Assert.AreEqual(1, hit);
    }
}