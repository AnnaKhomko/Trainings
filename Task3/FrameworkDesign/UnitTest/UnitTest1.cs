using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FrameworkDesign;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckSave()
        {
            PageService ps = new PageService();
            ps.Save();
            
        }
    }
}
