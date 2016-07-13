using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace MSTestsForCalculator
{
    [TestClass]
    public class MSTests : BaseTestClass
    {
        [TestMethod]
        [Description("test for addition")]
        [Owner("Hanna Khomka")]
        [TestCategory("Smoke")]
        [Timeout(1000)]
        [Ignore]
        public void TestIgnore()
        {
            // somethith that we don't want to do
        }

        [TestMethod]
        [Description("test for addition")]
        [Owner("Hanna Khomka")]
        [TestCategory("Smoke")]
        [Timeout(1)]
        public void TimeoutFailTest()
        {
            double i = 0;
            i++;
        }

        [TestMethod]
        [Description("test for addition")]
        [Owner("Hanna Khomka")]
        [TestCategory("Smoke")]
        [Timeout(1000)]
        public void TestAddition()
        {
            double a = 2.0;
            double b = 3.0;
            Assert.AreEqual(5.0, calc.Add(a, b));
        }

        [TestMethod]
        [Description("test for substraction")]
        [Owner("Hanna Khomka")]
        [TestCategory("Daily")]
        [Timeout(1000)]
        public void TestSubstraction()
        {
            double a = 2.0;
            double b = 3.0;
            Assert.AreEqual(-1.0, calc.Subtract(a, b));
        }

        [TestMethod]
        [Description(" test for multiplication")]
        [Owner("Hanna Khomka")]
        [TestCategory("Daily")]
        [Timeout(1000)]
        public void TestMultiplication()
        {
            double a = 2.0;
            double b = 3.0;
            Assert.AreEqual(6.0, calc.Multiplicate(a, b));
        }

        [TestMethod]
        [Description(" test for division by zero")]
        [Owner("Hanna Khomka")]
        [TestCategory("Daily")]
        [Timeout(1000)]
        public void TestDivision()
        {
            double a = 6.0;
            double b = 3.0;
            Assert.AreEqual(2.0, calc.Divide(a, b));
        }

        [TestMethod]
        [Description(" test for division by zero")]
        [Owner("Hanna Khomka")]
        [TestCategory("Daily")]
        [Timeout(1000)]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivisionByZero()
        {
            double a = 2.0;
            double b = 0;
            calc.Divide(a, b);
        }
    }
}
