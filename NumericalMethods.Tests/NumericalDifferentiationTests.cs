using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumericalMethods.Library;

namespace NumericalMethods.Tests
{
    [TestClass]
    public class NumericalDifferentiationTests
    {
        private NumericalDifferentiation library;

        [TestInitialize]
        public void TestInitialize()
        {
            library = new NumericalDifferentiation();
        }

        [TestMethod]
        public void Test_BackwardDifferenceMethod()
        {
            Func<double, double> f = x => Math.Pow(x, 2);
            var derivative = library.ExecuteBackwardDifference(f, 2.0, 0.001);

            double? expected = 4.0;

            Assert.IsNotNull(derivative);
            Assert.IsTrue(Math.Abs(expected.Value - derivative.Value) < 0.001);
        }

        [TestMethod]
        public void Test_ForwardDifferenceMethod()
        {
            Func<double, double> f = x => Math.Pow(x, 2);
            var derivative = library.ExecuteForwardDifference(f, 2.0, 0.001);

            double? expected = 4.0;

            Assert.IsNotNull(derivative);
            Assert.IsTrue(Math.Abs(expected.Value - derivative.Value) < 0.001);
        }

        [TestMethod]
        public void Test_CentralDifferenceMethod()
        {
            Func<double, double> f = x => Math.Pow(x, 2);
            var derivative = library.ExecuteCentralDifference(f, 2.0, 0.001);

            double? expected = 4.0;

            Assert.IsNotNull(derivative);
            Assert.IsTrue(Math.Abs(expected.Value - derivative.Value) < 0.001);
        }
    }
}