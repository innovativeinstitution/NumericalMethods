using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumericalMethods.Library;

namespace NumericalMethods.Tests
{
    [TestClass]
    public class SystemOfEquationsTests
    {
        SystemOfEquations library;

        [TestInitialize]
        public void TestInitialize()
        {
            library = new SystemOfEquations();
        }

        [TestMethod]
        public void Test_GuassEliminationMethod()
        {
            string[] coefficients = new string[2] { "1 2 3", "4 5 6" };
            double[] result = library.ExecuteGaussianElimination(coefficients);

            double[] expected = new double[2] { -1, 2 };

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
    }
}
