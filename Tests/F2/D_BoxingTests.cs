using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.F2
{
    /// <summary>
    /// Kostsamt, försök att undvika :)
    /// </summary>
    [TestClass]
    public class BoxingTests
    {
        [TestMethod]
        public void box()
        {
            int aValueVariable = 1;
            object aBoxedReferenceObject = aValueVariable;
            
            Assert.AreEqual(1, aBoxedReferenceObject);
        }
        
        [TestMethod]
        public void unbox()
        {
            object aReferenceObject = 1;
            
            //int anotherValue = aReferenceObject; // Error: implicit konvertering
            int anotherValue = (int)aReferenceObject;

            Assert.AreEqual(1, anotherValue);
        }
    }
}
