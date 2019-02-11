using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Collections_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // arrange
            var instance1 = new Collection_workspace.Class1();
            var expected = "Hello";
            // act 
            var actual = instance1.StackMethod();
            // assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // arrange
            var instance2 = new Collection_workspace.Class1();
            var expected = 5;
            // act 
            var actual = instance2.AnotherStack();
            // assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            // arrange
            var instance3 = new Collection_workspace.Class1();
            var expected = 40;
            // act 
            var actual = instance3.AnotherStack2();
            // assert 
            Assert.AreEqual(expected, actual);
        }


        //var instance3 = new Collection_workspace.Class1();
        //var expected = instance3.AnotherStack2();
        //var expectedCount = 40;
        //// act 
        //var actual = instance3.TestMethod3();
        //var actualCount = actual.Count;
        //// assert 
        //Assert.AreEqual(expectedCount, actualCount);
        //    Assert.IsInstanceOfType(actual, expected.GetType());
    }
}
