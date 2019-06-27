using System;

namespace NumericalMethods.Library
{
    public class NumericalDifferentiation : INumericalDifferentiation
    {
        public double? ExecuteForwardDifference(
            Func<double, double> function,
            double xValue,
            double stepSize)
        {
            var f = function;
            var x = xValue;
            var dx = stepSize;
            double? fp = (-f(x + 2 * dx) + 4 * f(x + dx) - 3 * f(x)) / (2 * dx);
            return fp;
        }

        public double? ExecuteBackwardDifference(
            Func<double, double> function,
            double xValue,
            double stepSize)
        {
            var f = function;
            var x = xValue;
            var dx = stepSize;
            double? fp = (3 * f(x) - 4 * f(x - dx) + f(x - 2 * dx)) / (2 * dx);
            return fp;
        }

        public double? ExecuteCentralDifference(
            Func<double, double> function,
            double xValue,
            double stepSize)
        {
            var f = function;
            var x = xValue;
            var dx = stepSize;
            double? fp = (-f(x + 2 * dx) + 8 * f(x + dx) - 8 * f(x - dx) + f(x - 2 * dx)) / (12 * dx);
            return fp;
        }
    }
}