using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class NullableTypeTests
    {
        [TestMethod]
        public void valueTypes_cannot_be_null()
        {
            //bool isItFriday = null; // Error!
            //Assert.AreEqual(null, isItFriday);
        }

        [TestMethod]
        public void nullableValueTypes_can_be_null()
        {
            bool? isItFriday = null;

            Assert.AreEqual(null, isItFriday);
            Assert.AreEqual(false, isItFriday.HasValue);
        }

        [TestMethod, ExpectedException(typeof(InvalidOperationException))]
        public void nullableValueTypes_value_throws_if_null()
        {
            bool? isItFriday = null;

            Assert.AreEqual(null, isItFriday.Value);
        }
    }
}
