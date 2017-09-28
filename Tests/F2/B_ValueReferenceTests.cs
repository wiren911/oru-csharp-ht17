using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class ValueReferenceTests
    {

        [TestMethod]
        public void valueTypes_passes_value()
        {
            bool isItFriday = false;

            bool isItRealyFriday = isItFriday;

            isItFriday = true;

            Assert.AreEqual(false, isItRealyFriday);
        }

        [TestMethod]
        public void referenceTypes_passes_reference()
        {
            bool[] sumArray = new[] { false };

            bool[] secondSumArray = sumArray;

            sumArray[0] = true;

            Assert.AreEqual(true, secondSumArray[0]);
        }


        [TestMethod]
        public void referenceTypes()
        {
            int[] arrayReference;
            object objectReference;
            ReferenceClass classReference;
            IReferenceInterface interfaceReference;
            ReferenceDelegate d = () => { };
        }

        interface IReferenceInterface { }
        class ReferenceClass { }
        delegate void ReferenceDelegate();
    }
}
