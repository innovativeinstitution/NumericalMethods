using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumericalMethods.Library;

namespace NumericalMethods.Tests
{
    [TestClass]
    public class SystemOfEquationsTests
    {
        private SystemOfEquations library;

        [TestInitialize]
        public void TestInitialize()
        {
            library = new SystemOfEquations();
        }

        [TestMethod]
        public void Test_GuassEliminationMethod()
        {
            var coefficients = new string[2] {"1 2 3", "4 5 6"};
            var result = library.ExecuteGaussianElimination(coefficients);

            var expected = new double[2] {-1, 2};

            for (var i = 0; i < expected.Length; i++) Assert.AreEqual(expected[i], result[i]);
        }
    }
}