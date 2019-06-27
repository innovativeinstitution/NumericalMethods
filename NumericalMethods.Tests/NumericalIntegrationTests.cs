using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumericalMethods.Library;

namespace NumericalMethods.Tests
{
    [TestClass]
    public class NumericalIntegrationTests
    {
        private NumericalIntegration library;

        [TestInitialize]
        public void TestInitialize()
        {
            library = new NumericalIntegration();
        }

        [TestMethod]
        public void Test_TrapezoidalMethod()
        {
            Func<double, double> f = x => Math.Pow(x, 2); //integral x^3 / 3, limits 0, 2
            var integral = library.ExecuteTrapezoidalMethod(f, 0, 2, 1000);

            double? expected = 8.0 / 3.0;

            Assert.IsNotNull(integral);
            Assert.IsTrue(Math.Abs(expected.Value - integral.Value) <= 1e-1);
        }

        [TestMethod]
        public void Test_Simpsons13Method()
        {
            Func<double, double> f = x => Math.Pow(x, 2); //integral x^3 / 3, limits 0, 2
            var integral = library.ExecuteSimpsons13Method(f, 0, 2, 1200);

            double? expected = 8.0 / 3.0;

            Assert.IsNotNull(integral);
            Assert.IsTrue(Math.Abs(expected.Value - integral.Value) <= 1e-1);
        }

        [TestMethod]
        public void Test_Simpsons38Method()
        {
            Func<double, double> f = x => Math.Pow(x, 2); //integral x^3 / 3, limits 0, 2
            var integral = library.ExecuteSimpsons38Method(f, 0, 2, 1200);

            double? expected = 8.0 / 3.0;

            Assert.IsNotNull(integral);
            Assert.IsTrue(Math.Abs(expected.Value - integral.Value) <= 1e-1);
        }
    }
}