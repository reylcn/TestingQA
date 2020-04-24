using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyTesting;

namespace MyUniteTest
{
    [TestClass]
    public class ClassicProgramsTest
    {
       

        [TestMethod]
        public void TestIsEven()
        {
            // Assable
            ClassicPrograms classicPrograms = new ClassicPrograms();
            bool expectitResulte = true;

            // Act
            bool actualResult = classicPrograms.IsEven(8);

            //Assert
            Assert.AreEqual(expectitResulte, actualResult);
        }

        [TestMethod]
        public void TestIsNotEven()
        {
            // Assable
            ClassicPrograms classicPrograms = new ClassicPrograms();
            bool expectitResulte = false;

            // Act
            bool actualResult = classicPrograms.IsEven(7);

            //Assert
            Assert.AreEqual(expectitResulte, actualResult);
        }

        [TestMethod]
        public void TestIsNotPrime()
        {
            // Assable
            ClassicPrograms classicPrograms = new ClassicPrograms();
            bool expectitResulte = false;

            // Act
            bool actualResult = classicPrograms.IsPrime(-7);

            //Assert
            Assert.AreEqual(expectitResulte, actualResult);
        }
        [TestMethod]
        public void TestIsPrime_Whit0and1()
        {
            // Assable
            ClassicPrograms classicPrograms = new ClassicPrograms();
            bool expectitResulte = true;

            // Act
            bool actualResult = classicPrograms.IsPrime(1);

            //Assert
            Assert.AreEqual(expectitResulte, actualResult);
        }

        [TestMethod]
        public void TestIsPrime_WhitTruePrimeValue()
        {
            // Assable
            ClassicPrograms classicPrograms = new ClassicPrograms();
            bool expectitResulte = true;

            // Act
            bool actualResult = classicPrograms.IsPrime(7);

            //Assert
            Assert.AreEqual(expectitResulte, actualResult);
        }

        [TestMethod]
        public void TestIsPrime_WhitFalsePrimeValue()
        {
            // Assable
            ClassicPrograms classicPrograms = new ClassicPrograms();
            bool expectitResulte = false;

            // Act
            bool actualResult = classicPrograms.IsPrime(12);

            //Assert
            Assert.AreEqual(expectitResulte, actualResult);
        }
    }
}
