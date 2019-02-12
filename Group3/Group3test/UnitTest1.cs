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

        [TestMethod]
        public void Check_Array_Sum()
        {
            // arrange (setup)
            var arrayInstance = new Group3tests.Class1();
            var expectedOutput = 385;
            // act (run code)
            var actualOutput = arrayInstance.CreateArray(10);

            // assert (see if test pass /fail)
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void StackTest()
        {
            // arrange
            var instance01 = new Group3tests.Class1();
            var expected = 8733475;

            // act
            var actual = instance01.StackTest();

            // assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void QueueTest()
        {
            // arrange
            var instance01 = new Group3tests.Class1();
            var expected = 3025;

            // act
            var actual = instance01.QueueTest();

            // assert
            Assert.AreEqual(expected, actual);

        }
    }
}
