﻿using System;
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
        }
    
  
        public void List1_Test()
        {
            //Arrange
            var instance01 = new Collection_workspace.myList1();
            int expectedValue = 44;
            //Act
            var actual = instance01.IntegerList(10);
            //Assert
            Assert.AreEqual(expectedValue, actual);
        }
        [TestMethod]
        public void List2_Test()
        {
            //Arrange
            var instance02 = new Collection_workspace.myList2();
            var expected = new List<string>();
            var expectedCount = 12;

            //Act
            var actual = instance02.ClassList();

            var actualCount = actual.Count;

            //Assert
            Assert.AreEqual(expectedCount, actualCount);
            Assert.IsInstanceOfType(actual, expected.GetType());


        }
        [TestMethod]
        public void List3_Test()
        {
            //Arrange
            var instance03 = new Collection_workspace.myList3();
            var expected = new List<myList3.Book>();
            var expectedCount = 4;
            //Act
            var actual = instance03.Library();
            var actualCount = actual.Count;
            //Assert
            Assert.AreEqual(expectedCount, actualCount);
            Assert.IsInstanceOfType(actual, expected.GetType());

        }
    }
}
