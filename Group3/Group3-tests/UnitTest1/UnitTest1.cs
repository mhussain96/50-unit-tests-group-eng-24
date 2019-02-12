using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab_01;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var arrayInstance = new lab_01.Class1();
            var actual = arrayInstance.summation(8.2);
            var expected = 585.0;
            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var arrayInstance2 = new lab_01.Class1();
            Assert.IsTrue(arrayInstance2.isWithdraw(20));
        }
        [TestMethod]
        public void TestMethod3()
        {
            var arrayInstance3 = new lab_01.Class1();
            Assert.IsTrue(arrayInstance3.isAllowedEntry(15));
        }
        [TestMethod]
        public void TestMethod4()
        {
            var arrayInstance4 = new lab_01.Class1();
            Assert.IsTrue(arrayInstance4.NameReturn('j','e','s','s'));
        }
    }
}
