using System;

namespace NumericalMethods.Library
{
    public interface INumericalIntegration
    {
        double? ExecuteTrapezoidalMethod(
            Func<double, double> function,
            double lower,
            double upper,
            int intervals
        );

        double? ExecuteSimpsons13Method(
            Func<double, double> function,
            double lower,
            double upper,
            int intervals
        );

        double? ExecuteSimpsons38Method(
            Func<double, double> function,
            double lower,
            double upper,
            int intervals
        );
    }
}