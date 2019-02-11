using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Group3tests;

namespace Group3test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var arrayInstance = new Group3tests.Class1();
            Assert.AreEqual("drow", arrayInstance.Reverse("word"));
            Assert.AreEqual("", arrayInstance.Reverse(""));
            Assert.AreEqual("arsenal", arrayInstance.Reverse("lanesra"));
            Assert.AreEqual("oop", arrayInstance.Reverse("poo"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            var arrayInstance = new Group3tests.Class1();
            Assert.AreEqual(1, arrayInstance.Smallest(new[] { 9, 1, 4, 5, 2, 3, 6, 7, 8 }));
            Assert.AreEqual(8, arrayInstance.Smallest(new[] { 90, 79, 55, 23, 22, 45, 60, 29, 8 }));
        }

        [TestMethod]
        public void TestMethod3()
        {
            var arrayInstance = new Group3tests.Class1();
            Assert.AreEqual(16, arrayInstance.NextSquare(9));
            Assert.AreEqual(36, arrayInstance.NextSquare(25));
        }

        [TestMethod]
        public void TestMethod4()
        {
            var arrayInstance = new Group3tests.Class1();
            Assert.AreEqual(142.32, arrayInstance.GeometricSeries(10, 1.15, 20));
            Assert.AreEqual(1.55, arrayInstance.GeometricSeries(1, 1.01, 45));
        }
    }
}
