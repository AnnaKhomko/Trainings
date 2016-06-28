using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
namespace CalculationTests
{
    [TestClass]
    public class CalculationTests
    {
        [TestMethod]
        public void TestAddition()
        {
            Calculation calc = new Calculation();
            long a, b;
            long.TryParse((Resource1.FirstNumber), out a);
            long.TryParse((Resource1.FirstNumber), out b);
            Assert.AreEqual((a + b), calc.Addition(a, b) );
        }

        public void TestSubtraction()
        {
            Calculation calc = new Calculation();
            long a, b;
            Assert.AreEqual((a - b), calc.Subtraction(a, b));
        }

        public void TestMultiplication()
        {
            Calculation calc = new Calculation();
            long a, b;
            Assert.AreEqual((a * b), calc.Multiplication(a, b));
        }

        public void TestDivision()
        {
            Calculation calc = new Calculation();
            long a, b;
            Assert.AreEqual((a / b), calc.Division(a, b));
        }
    }
}
