
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using Calculator;


namespace MSTestsForCalculator
{
    [TestClass]
    public class BaseTestClass
    {
        public TestContext TestContext { get; set; }
        public Calculation calc; 

        [ClassInitialize]
        public void ClassInit(TestContext testContext)
        {
           Trace.WriteLine("ClassInit" );
            TestContext = testContext;
        }
        [TestInitialize]
        public void Init()
        {
            calc = new Calculation();
            Trace.WriteLine("TestMethodInit" + TestContext.TestName);

        }
        [TestCleanup]
        public void Cleanup()
        {
            Trace.WriteLine("TestMethodleanup");
        }
        [ClassCleanup] 
         public void ClassCleanup()
         { 
             Trace.WriteLine("ClassCleanup"); 
         } 
        
     
    }
}
