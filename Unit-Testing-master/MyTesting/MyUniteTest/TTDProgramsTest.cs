using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyTesting;
using MyUniteTest;

namespace MyUniteTest
{
    [TestClass]
    public class TTDProgramsTest
    {
        [TestMethod]
        public void TestSmallest()
        {
            // Assable
            TTDPrograms tDDPrograms = new TTDPrograms();
            int[] arr = { 4, 5, 1, 7 };
            int expextedValu = 1;

            // Act
            int actualValue = tDDPrograms.Smallest(arr);

            // Assert
            Assert.AreEqual(expextedValu, actualValue);
        }

        [TestMethod]
        public void TestSmallest_WihiteSizeOne()
        {
            // Assable
            TTDPrograms tDDPrograms = new TTDPrograms();
            int[] arr = {4};
            int expextedValu = 4;

            // Act
            int actualValue = tDDPrograms.Smallest(arr);

            // Assert
            Assert.AreEqual(expextedValu, actualValue);
        }
        [TestMethod]
        public void TestPower()
        {
            // Assable
            TTDPrograms tDDPrograms = new TTDPrograms();
            int baseValue = 2;
            int expValu = 3;
            int expextValue = 8;

            // Act
            int actualValue = tDDPrograms.Power(baseValue,expValu);

            // Assert
            Assert.AreEqual(expextValue, actualValue);
        }
    }
}
