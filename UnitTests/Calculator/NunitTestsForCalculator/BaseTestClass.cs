using System;
using System.Diagnostics;
using NUnit;
using NUnit.Framework;
using Calculator;


namespace NunitTestsForCalculator
{
    [TestFixture]
    public class BaseTestClass
    {
        public Calculation calc;
       // public static TestContext context; 

        [TestFixtureSetUp]
        public static void ClassInit()
        {
            
            Trace.WriteLine("ClassInit" );
        }

        [TestFixtureTearDown] 
         static public void ClassCleanup()
         {
            Trace.WriteLine("ClassCleanup"); 
         } 
         [SetUp]
         public void Init()
         {
            calc = new Calculation();
            Console.WriteLine("Test starts: " + TestContext.CurrentContext.Test.Name);
        } 
         [TearDown] 
         public void Cleanup()
         { 
             Trace.WriteLine("TestMethodleanup"); 
         } 
    }
}
