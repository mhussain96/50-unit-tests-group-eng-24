using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using collections;

namespace collectionTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CollectionTest01()
        {
            //Arrannge
            var expectedOutput = true;

            var instance01 = new Collections_Dict();


            //Actual
            var actual = instance01.Collection_Test_01();

            //Assert
            Assert.AreEqual(actual, expectedOutput);
        }

        [TestMethod]
        public void CollectionTest02()
        {
            //Arrannge
            var expectedOutput02 = 1;

            var instance02 = new Collections_Dict();


            //Actual
            var actual02 = instance02.Collection_Test_02();

            //Assert
            Assert.AreEqual(actual02, expectedOutput02);
        }

        [TestMethod]
        public void CollectionTest03()
        {
            //Arrannge
            var expectedOutput03 = "This is a queue.";

            var instance03 = new Collections_Dict();


            //Actual
            var actual03 = instance03.Collection_Test_03();

            //Assert
            Assert.AreEqual(actual03, expectedOutput03);
        }

        [TestMethod]
        public void CollectionTest04()
        {
            //Arrannge
            var expectedOutput04 = "Item Two";

            var instance04 = new Collections_Dict();


            //Actual
            var actual04 = instance04.Collection_Test_04();

            //Assert
            Assert.AreEqual(actual04, expectedOutput04);
        }
    }
}
