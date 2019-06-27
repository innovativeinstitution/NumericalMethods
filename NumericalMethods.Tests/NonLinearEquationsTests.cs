using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumericalMethods.Library;

namespace NumericalMethods.Tests
{
    [TestClass]
    public class NonLinearEquationsTests
    {
        private NonLinearEquations library;

        [TestInitialize]
        public void TestInitialize()
        {
            library = new NonLinearEquations();
        }

        [TestMethod]
        public void Test_BisectionMethod()
        {
            Func<double, double> f = x => Math.Pow(x, 2) - 4;
            var root = library.ExecuteBisectionMethod(f, 0.75, 4.55, 1e-8);

            double? expected = 2;

            Assert.IsNotNull(root);
            Assert.IsTrue(expected - root <= 1e-8);
        }

        [TestMethod]
        public void Test_RegulaFalsiMethod()
        {
            Func<double, double> f = x => Math.Pow(x, 2) - 4;
            var root = library.ExecuteRegulaFalsiMethod(f, 0.75, 4.55, 1e-8);

            double? expected = 2;

            Assert.IsNotNull(root);
            Assert.IsTrue(expected - root <= 1e-8);
        }

        [TestMethod]
        public void Test_SecantMethod()
        {
            Func<double, double> f = x => Math.Pow(x, 2) - 4;
            var root = library.ExecuteSecantMethod(f, 0.75, 4.55, 1e-8, 20);

            double? expected = 2;

            Assert.IsNotNull(root);
            Assert.IsTrue(expected - root <= 1e-8);
        }

        [TestMethod]
        public void Test_NewtonRaphsonMethod()
        {
            Func<double, double> f = x => Math.Pow(x, 2) - 4;
            Func<double, double> g = x => 2 * x;
            var root = library.ExecuteNewtonRaphsonMethod(f, g, 0.75, 1e-8, 20);

            double? expected = 2;

            Assert.IsNotNull(root);
            Assert.IsTrue(expected - root <= 1e-8);
        }
    }
}