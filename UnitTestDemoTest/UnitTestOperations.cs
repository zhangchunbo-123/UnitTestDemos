using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestDemoTest
{
    [TestClass]
    public class UnitTestOperations
    {
        //Arrange
        double numberA = 1;
        double numberB = 2;
        [TestMethod]
        public void Test_AddMethod()
        {
            //Act
            var result = UnitTestDemo.UnitTestHelper.Add(numberA, numberB);
            
            //Assert
            Assert.AreEqual(result, 3);
        }
        [TestMethod]
        public void Test_SubstractMethod()
        {
            var result = UnitTestDemo.UnitTestHelper.Substract(numberA, numberB);
            Assert.AreEqual(result, -1);
        }
        [TestMethod]
        public void Test_DivideMethod()
        {
            var result = UnitTestDemo.UnitTestHelper.Divide(numberA, numberB);
            Assert.AreEqual(result, 0.5);
        }
        [TestMethod]
        public void Test_MultiplyMethod()
        {
            var result = UnitTestDemo.UnitTestHelper.Multiply(numberA, numberB);
            Assert.AreEqual(result, 2);
        }
    }
}
