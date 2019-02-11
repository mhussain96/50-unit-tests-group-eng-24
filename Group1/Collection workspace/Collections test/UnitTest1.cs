using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Collection_workspace;
using System.Collections.Generic;

namespace Collections_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DictionaryTest1()
        {
            //Arrange
            var dict1 = new CollectionsTesting();
            var expected = new Dictionary<string, string>();
            var expectedCount = 5;

            //Act
            var actual = dict1.DictionaryTest1();
            var actualCount = actual.Count;

            //Assert
            Assert.AreEqual(expectedCount, actualCount);
            Assert.IsInstanceOfType(actual, expected.GetType());

        }
    }
}
