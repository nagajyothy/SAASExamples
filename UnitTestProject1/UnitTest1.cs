using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SAASExamples.Controllers;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            HomeController obj = new HomeController();
             int res =  obj.GetPercentage(600,1200);
            Assert.AreEqual(res, 50);

        }
    }
}
