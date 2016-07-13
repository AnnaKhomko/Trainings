using System;
using Xunit;
using Calculator;
using System.Threading;

namespace XunitTestsForCalculator
{

   
    public class XUnitTest 
    {
        
        [Fact(Skip = "Ignore test")]
        public void TestIgnore()
        {
            // somethith that we don't want to do
        }

        //[Fact]//(Timeout = 1)]
        //public void TimeoutFailTest()
        //{
        //    int flag = 1000;
        //    while (flag != 1000000000)
        //        flag += 5;

        //}

        [Fact]
        public void TestAddition()
        {
            Calculation calc = new Calculation();
            double a = 2.0;
            double b = 3.0;
            Assert.Equal(5.0, calc.Add(a, b));
        }

        [Fact]
        public void TestSubstraction()
        {
            Calculation calc = new Calculation();
            double a = 2.0;
            double b = 3.0;
            Assert.Equal(-1.0, calc.Subtract(a, b));
        }

        [Fact]
        public void TestMultiplication()
        {
            Calculation calc = new Calculation();
            double a = 2.0;
            double b = 3.0;
            Assert.Equal(6.0, calc.Multiplicate(a, b));
        }

        //[Fact]
        //[TestCase(6.0, 3.0)]
        //[TestCase(3.0, 6.0)]
        //[TestCase(0, 6.0)]
        //[TestCase(3.6, 2.4)]
        //public void TestDivision(double a, double b)
        //{
        //    Calculation calc = new Calculation();
        //    Assert.True((a / b) == calc.Divide(a, b));
        //}

        [Fact]
        public void TestDivisionByZero()
        {
            Calculation calc = new Calculation();
            double a = 2.0;
            double b = 0;

            Assert.Throws<DivideByZeroException>(() => calc.Divide(a, b));

        }
    }
}

