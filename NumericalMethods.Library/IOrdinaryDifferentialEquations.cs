using System;

namespace NumericalMethods.Library
{
    public interface IOrdinaryDifferentialEquations
    {
        double[] ExecuteEulerMethod(
            Func<double, double, double> function,
            double t0,
            double y0,
            int iterations,
            double tEnd
            );

        double[] ExecuteRungeKuttaMethod(
            Func<double, double, double> function,
            double t0,
            double y0,
            int iterations,
            double tEnd
            );
    }
}
