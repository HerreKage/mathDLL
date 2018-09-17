using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewMyMathDll;

namespace MyMathyDLLTest
{
    [TestClass]
    public class MathTest
    {

        Mathy m = new Mathy();

        [TestMethod]
        public void AddTest()
        {
            
            Assert.IsTrue(m.Add(2,3).Equals(5));

        }

        [TestMethod]
        public void AddTestNegativeNumbers()
        {
            
            Assert.AreEqual(m.Add(-3,-4),-7);

        }




    }
}
