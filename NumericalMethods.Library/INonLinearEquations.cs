using System;

namespace NumericalMethods.Library
{
    public interface INonLinearEquations
    {
        double? ExecuteBisectionMethod(
            Func<double, double> function,
            double lower,
            double upper,
            double error
        );

        double? ExecuteRegulaFalsiMethod(
            Func<double, double> function,
            double lower,
            double upper,
            double error
        );

        double? ExecuteSecantMethod(
            Func<double, double> function,
            double lower,
            double upper,
            double error,
            int iterations
        );

        double? ExecuteNewtonRaphsonMethod(
            Func<double, double> function,
            Func<double, double> derivative,
            double initialGuess,
            double error,
            int iterations
        );
    }
}