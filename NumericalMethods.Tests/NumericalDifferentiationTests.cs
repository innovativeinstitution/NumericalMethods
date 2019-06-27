using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumericalMethods.Library;
using System;

namespace NumericalMethods.Tests
{
    [TestClass]
    public class NumericalDifferentiationTests
    {
        NumericalDifferentiation library;

        [TestInitialize]
        public void TestInitialize()
        {
            library = new NumericalDifferentiation();
        }

        [TestMethod]
        public void Test_BackwardDifferenceMethod()
        {
            Func<double, double> f = x => Math.Pow(x, 2);
            double? derivative = library.ExecuteBackwardDifference(f, 2.0, 0.001);

            double? expected = 4.0;

            Assert.IsNotNull(derivative);
            Assert.IsTrue(Math.Abs(expected.Value - derivative.Value) < 0.001);
        }

        [TestMethod]
        public void Test_ForwardDifferenceMethod()
        {
            Func<double, double> f = x => Math.Pow(x, 2);
            double? derivative = library.ExecuteForwardDifference(f, 2.0, 0.001);

            double? expected = 4.0;

            Assert.IsNotNull(derivative);
            Assert.IsTrue(Math.Abs(expected.Value - derivative.Value) < 0.001);
        }

        [TestMethod]
        public void Test_CentralDifferenceMethod()
        {
            Func<double, double> f = x => Math.Pow(x, 2);
            double? derivative = library.ExecuteCentralDifference(f, 2.0, 0.001);

            double? expected = 4.0;

            Assert.IsNotNull(derivative);
            Assert.IsTrue(Math.Abs(expected.Value - derivative.Value) < 0.001);
        }
    }
}
