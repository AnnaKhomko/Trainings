using System;
using Xunit;
using Calculator;

namespace XunitTestsForCalculator
{
  
    public class UnitTest1
    {
        [Fact]
        public void TestMethod1()
        {
            Calculation calc = new Calculation();
            double a = 2.0;
            double b = 3.0;
            Assert.Same(-1.0, calc.Subtract(a, b));
        }

    }
}

