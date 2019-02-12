using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TestingClass;

namespace unit_tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Check_initial_sum()
        {
            var initialInstance = new TestingClass.Class1();

            var expectedOutput = 10;

            var actualOutput = initialInstance.initial_test();

            Assert.AreEqual(expectedOutput, actualOutput);


        }

        [TestMethod]
        public void Check_name_initials()
        {
            var initialInstance = new TestingClass.Class1();

            var expectedOutput = "JS";

            var actualOutput = initialInstance.displayInitials();

            Assert.AreEqual(expectedOutput, actualOutput);


        }

        [TestMethod]
        public void Check_num_times_3()
        {
            var initialInstance = new TestingClass.Class1();

            var expectedOutput = 18;

            var actualOutput = initialInstance.timesBy3(3, 3);

            Assert.AreEqual(expectedOutput, actualOutput);


        }

        [TestMethod]
        public void Double_To_Int_Test()
        {
            double num1 = 5.3432;
            var initialInstance = new TestingClass.Class1();

            var expectedOutput = 5;

            var actualOutput = initialInstance.explicitCasting(num1);

            Assert.AreEqual(expectedOutput, actualOutput);


        }

        [TestMethod]
        public void sum_of_all_to_50_Test()
        {
            
            var initialInstance = new TestingClass.Class1();

            var expectedOutput = 98;

            var actualOutput = initialInstance.sumOfAll();

            Assert.AreEqual(expectedOutput, actualOutput);


        }


    }
}
