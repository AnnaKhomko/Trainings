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
            long.TryParse((Resource1.first), out a);
            long.TryParse((Resource1.second), out b);
            Assert.AreEqual((a + b), calc.Addition(a, b) );
        }

        [TestMethod]
        public void TestSubtraction()
        {
            Calculation calc = new Calculation();
            long a, b;
            long.TryParse((Resource1.first), out a);
            long.TryParse((Resource1.second), out b);
            Assert.AreEqual((a - b), calc.Subtraction(a, b));
        }

        [TestMethod]
        public void TestMultiplication()
        {
            Calculation calc = new Calculation();
            long a, b;
            long.TryParse((Resource1.first), out a);
            long.TryParse((Resource1.second), out b);
            Assert.AreEqual((a * b), calc.Multiplication(a, b));
        }

        [TestMethod]
        public void TestDivision()
        {
            Calculation calc = new Calculation();
            long a, b;
            long.TryParse((Resource1.first), out a);
            long.TryParse((Resource1.second), out b);
            Assert.AreEqual((a / b), calc.Division(a, b));
        }
    }
}
