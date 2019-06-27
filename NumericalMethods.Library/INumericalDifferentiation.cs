using System;

namespace NumericalMethods.Library
{
    public interface INumericalDifferentiation
    {
        double? ExecuteForwardDifference(
            Func<double, double> function,
            double xValue,
            double stepSize
        );

        double? ExecuteBackwardDifference(
            Func<double, double> function,
            double xValue,
            double stepSize
        );

        double? ExecuteCentralDifference(
            Func<double, double> function,
            double xValue,
            double stepSize
        );
    }
}