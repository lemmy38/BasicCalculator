using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitCalculatorTest
{
    [TestClass]
    public class BasicCalculator
    {
        [TestMethod]
        public void Test_AddMethod_ReturnCorrectResult()
        {
            // Arrange
            BasicCalculator basicCalculator = new BasicCalculator();

            // Act
            int result = basicCalculator.Add(3, 4);

            // Assert
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void Test_SubtractMethodReturnCorrectResult()
        {
            // Arrange
            BasicCalculator basicCalculator = new BasicCalculator();

            // Act
            int result = basicCalculator.Subtract(10, 5);

            // Assert
            Assert.AreEqual(5, result);
        }



        [TestMethod]
        public void Test_MultiplyMethod_ReturnCorrectResult()
        {
            // Arrange
            BasicCalculator basicCalculator = new BasicCalculator();

            // Act
            int result = basicCalculator.Multiply(3, 4);

            // Assert
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_DivideByZero()
        {
            // Arrange
            BasicCalculator basicCalculator = new BasicCalculator();

            // Act
            int result = basicCalculator.Divide(10, 0);

            // Assert (Exception is expected)


        }



    }
}