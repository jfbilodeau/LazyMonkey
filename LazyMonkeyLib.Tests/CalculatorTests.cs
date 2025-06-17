using Microsoft.VisualStudio.TestTools.UnitTesting;
using LazyMonkeyLib;
using System;

namespace LazyMonkeyLib.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_ReturnsCorrectSum()
        {
            var calc = new Calculator();
            var result = calc.Add(2, 3);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Subtract_ReturnsCorrectDifference()
        {
            var calc = new Calculator();
            var result = calc.Subtract(5, 2);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Multiply_ReturnsCorrectProduct()
        {
            var calc = new Calculator();
            var result = calc.Multiply(4, 3);
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void Divide_ReturnsCorrectQuotient()
        {
            var calc = new Calculator();
            var result = calc.Divide(10, 2);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_ByZero_ThrowsException()
        {
            var calc = new Calculator();
            calc.Divide(10, 0);
        }
    }
}
