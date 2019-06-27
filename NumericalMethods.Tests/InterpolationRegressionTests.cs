using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumericalMethods.Library;

namespace NumericalMethods.Tests
{
    [TestClass]
    public class InterpolationRegressionTests
    {
        private InterpolationRegression library;

        [TestInitialize]
        public void TestInitialize()
        {
            library = new InterpolationRegression();
        }

        [TestMethod]
        public void Test_LinearInterpolationMethod()
        {
            var result = library.ExecuteLinearInterpolation(1, 2, 3, 4, 2.5);

            double? expected = 3.5;

            Assert.IsNotNull(result);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test_LinearRegressionMethod()
        {
            double[] x = {1, 2, 3, 4, 5};
            double[] y = {12, 22, 32, 42, 52};

            var expected = new double[2] {2, 10}; //y = 2 + 10x

            var result = library.ExecuteLinearRegression(x, y);

            for (var i = 0; i < expected.Length; i++) Assert.AreEqual(expected[i], result[i]);
        }

        [TestMethod]
        public void Test_PowerRegressionMethod()
        {
            double[] x = {1, 2, 3, 4, 5};
            double[] y = {1, 4, 9, 16, 25};

            var expected = new double[2] {1, 2}; //y = 1x^2

            var result = library.ExecutePowerRegression(x, y);

            for (var i = 0; i < expected.Length; i++) Assert.AreEqual(expected[i], result[i]);
        }
    }
}