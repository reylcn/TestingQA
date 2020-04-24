using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyTesting;

namespace MyUniteTest
{
    [TestClass]
    public class BasicOperationsTest
    {
        [TestMethod]
        public void TestAdd()
        {
            // Assemble
            MyTesting.BasicOperations basicOperation = new MyTesting.BasicOperations();
            int expectiedResult = 5;

            //Act
            int actualResult = basicOperation.Add(2, 3);

            // Assert
            Assert.AreEqual(expectiedResult, actualResult);
        }

        [TestMethod]
        public void TestMul()
        {
            // Assemble
            MyTesting.BasicOperations basicOperation = new MyTesting.BasicOperations();
            int expectiedResult = 12;

            //Act
            int actualResult = basicOperation.Mul(2, 6);

            // Assert
            Assert.AreEqual(expectiedResult, actualResult);
        }
        [TestMethod]
        public void TestDiv()
        {
            // Assemble
            MyTesting.BasicOperations basicOperation = new MyTesting.BasicOperations();
            int expectiedResult = 3;

            //Act
            int actualResult = basicOperation.Div(15, 5);

            // Assert
            Assert.AreEqual(expectiedResult, actualResult);
        }
        [TestMethod]
        public void TestSub()
        {
            // Assemble
            MyTesting.BasicOperations basicOperation = new MyTesting.BasicOperations();
            int expectiedResult = 7;

            //Act
            int actualResult = basicOperation.Sub(10, 6);

            // Assert
            Assert.AreNotEqual(expectiedResult, actualResult);
        }
    }
}
