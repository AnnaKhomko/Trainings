using System;
using NUnit;
using NUnit.Framework;
using ParserForInt;

namespace UnitTestForParser
{
   

   

    [TestFixture]
    public class UnitTests 
    {
        public Logic logic;


        [SetUp]
        public void Init()
        {
            logic = new Logic();
        }

        [Test]
        [TestCase("12")]
        [TestCase("-12")]
        [TestCase("145")]
        [TestCase("+145")]
        [TestCase("0")]
        public void TestDivision(string str)
        {
            Assert.AreEqual(int.Parse(str), logic.DetermeType(str));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void TestDivisionByZero(string str)
        {

            Assert.Throws<ArgumentException>(() => logic.DetermeType(str));

        }

        [Test]
        [TestCase("dgdghgh")]
        [TestCase("-2//b")]
        public void Test1(string str)
        {

            Assert.Throws<TypeIsStringException>(() => logic.DetermeType(str));

        }

        [Test]
        [TestCase("3.5")]
        [TestCase("-3.5")]
        public void Test2(string str)
        {

            Assert.Throws<TypeIsFloatException>(() => logic.DetermeType(str));

        }

        [Test]
        [TestCase("21474836476")]
        [TestCase("-21474836488")]
        public void Test3(string str)
        {

            Assert.Throws<OverflowException>(() => logic.DetermeType(str));

        }
    }
   
}
