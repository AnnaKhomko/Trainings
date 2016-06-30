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
            long.TryParse((ResourceData.first), out a);
            long.TryParse((ResourceData.second), out b);
            Assert.AreEqual((a + b), calc.Add(a, b) );
        }

        [TestMethod]
        public void TestSubtraction()
        {
            Calculation calc = new Calculation();
            long a, b;
            long.TryParse((ResourceData.first), out a);
            long.TryParse((ResourceData.second), out b);
            Assert.AreEqual((a - b), calc.Subtract(a, b));
        }

        [TestMethod]
        public void TestMultiplication()
        {
            Calculation calc = new Calculation();
            long a, b;
            long.TryParse((ResourceData.first), out a);
            long.TryParse((ResourceData.second), out b);
            Assert.AreEqual((a * b), calc.Multiplicate(a, b));
        }

        [TestMethod]
        public void TestDivision()
        {
            Calculation calc = new Calculation();
            long a, b;
            long.TryParse((ResourceData.first), out a);
            long.TryParse((ResourceData.second), out b);
            Assert.AreEqual((a / b), calc.Divide(a, b));
        }
    }
}
