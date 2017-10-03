using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class DeclareAndInitializeTests
    {
        [TestMethod]
        public void declare_and_initialize_with_two_statements()
        {
            int daysInWeek;
            daysInWeek = 7;
        }

        [TestMethod]
        public void declare_and_initialize_with_one_statement()
        {
            int daysInWeek = 7;
        }

        [TestMethod]
        public void declare_and_initialize_with_var()
        {
            var daysInWeek = 7;
        }

        [TestMethod]
        public void declare_constant()
        {
            const int daysInWeek = 7;
        }

        [TestMethod]
        public void declare_types()
        {
            string hello = "Hello World";
            float pi = 3.141592f;
            double moreExactPi = 3.141592653589d;
            decimal superExactPi = 3.14159265358979323846264338m;
            bool isItFriday = false;
        }
    }
}
