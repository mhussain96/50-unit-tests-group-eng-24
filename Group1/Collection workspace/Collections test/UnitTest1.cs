using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Collection_workspace;

namespace Collections_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void List1_Test()
        {
            //Arrange
            var instance01 = new Collection_workspace.myList1();
            int expectedValue = 44;

            //Act
            var actual = instance01.IntegerList();
            //Assert
            Assert.AreEqual(expectedValue, actual);
        }
    }
}
