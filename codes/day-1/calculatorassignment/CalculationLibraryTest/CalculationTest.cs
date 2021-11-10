using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary;

namespace CalculationLibraryTest
{

    [TestClass]
    public class CalculationTest
    {
        [TestMethod]
        public void DivideTest()
        {
            Calculation calculation = new Calculation();
            int actual = calculation.Divide(10, 2);
            int expected = 5;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [ExpectedException(typeof(System.DivideByZeroException))]
        public void DivideExceptionTest()
        {
            Calculation calculation = new Calculation();
            calculation.Divide(10, 0);
            // try
            // {
            //     calculation.Divide(10, 0);
            // }
            // catch (DivideByZeroException ex)
            // {
            //     Assert.Fail(ex.Message, "denominator should not be zero");
            // }
        }
    }
}