using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.F2
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class ArithmeticTests
    {
        [TestMethod]
        public void addition()
        {
            var added = 1 + 2;
            Assert.AreEqual(3, added);

            var subtracted = 1 - 2;
            Assert.AreEqual(-1, subtracted);

            var multiplied = 1 * 2;
            Assert.AreEqual(2, multiplied);

            var divided = 10 / 2;
            Assert.AreEqual(5, divided);

            var modulus = 3 / 2;
            Assert.AreEqual(1, modulus);
        }

        [TestMethod]
        public void modifying_operators()
        {
            var value = 0;
            value++;
            Assert.AreEqual(1, value);

            value--;
            Assert.AreEqual(0, value);
        }


        [TestMethod]
        public void assignment_operators()
        {
            var value = 1;
            value += 10; 
            Assert.AreEqual(11, value);

            value -= 1;
            Assert.AreEqual(10, value);

            value *= 2;
            Assert.AreEqual(20, value);

            value /= 4;
            Assert.AreEqual(5, value);

            value %= 3;
            Assert.AreEqual(2, value);
        }

        [TestMethod]
        public void operator_precedence()
        {
            var result = 1 + 2 - 3 * 4 / 6;
            // 1 + 2 - ( (3 * 4) / 6 )
            // 1 + 2 - (12 / 6)
            // 1 + 2 - 2
            // 1
            
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void maths()
        {
            var first3DigitsOfPi = Math.Round(Math.PI, 2);
            Assert.AreEqual(3.14d, first3DigitsOfPi);

            var powerOf3 = Math.Pow(10, 3);
            Assert.AreEqual(1000, powerOf3);

            var squareRootOf4 = Math.Sqrt(4);
            Assert.AreEqual(2, squareRootOf4);

            var minValue = Math.Min(2, 1);
            Assert.AreEqual(1, minValue);

            var maxValue = Math.Max(2, 1);
            Assert.AreEqual(2, maxValue);

        }
    }

}
