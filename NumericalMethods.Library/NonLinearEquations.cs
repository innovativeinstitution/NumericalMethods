using System;

namespace NumericalMethods.Library
{
    public class NonLinearEquations : INonLinearEquations
    {
        public double? ExecuteBisectionMethod(
            Func<double, double> function,
            double lower,
            double upper,
            double error)
        {
            var f = function;
            var x0 = lower;
            var x1 = upper;
            var err = error;

            var Converged = false;
            double x2;

            do
            {
                x2 = (x0 + x1) / 2;

                if (f(x0) * f(x2) < 0)
                    x1 = x2;
                else
                    x0 = x2;

                Converged = Math.Abs(f(x2)) <= err;
            } while (!Converged);

            if (Converged)
                return x2;
            return null;
        }

        public double? ExecuteRegulaFalsiMethod(
            Func<double, double> function,
            double lower,
            double upper,
            double error)
        {
            var f = function;
            var x0 = lower;
            var x1 = upper;
            var err = error;

            var Converged = false;
            double x2;

            do
            {
                x2 = x0 - (x0 - x1) * f(x0) / (f(x0) - f(x1));

                if (f(x0) * f(x2) < 0)
                    x1 = x2;
                else
                    x0 = x2;

                Converged = Math.Abs(f(x2)) <= err;
            } while (!Converged);

            if (Converged)
                return x2;
            return null;
        }

        public double? ExecuteSecantMethod(
            Func<double, double> function,
            double lower,
            double upper,
            double error,
            int iterations)
        {
            var f = function;
            var x0 = lower;
            var x1 = upper;
            var err = error;
            var N = iterations;

            var Converged = false;
            var i = 1;
            double x2 = 0;

            do
            {
                if (f(x0) == f(x1)) return null;

                x2 = x1 - (x1 - x0) * f(x1) / (f(x1) - f(x0));
                x0 = x1;
                x1 = x2;

                i++;

                if (i > N) return null;

                Converged = Math.Abs(f(x2)) <= err;
            } while (!Converged);

            if (Converged)
                return x2;
            return null;
        }

        public double? ExecuteNewtonRaphsonMethod(
            Func<double, double> function,
            Func<double, double> derivative,
            double initialGuess,
            double error,
            int iterations)
        {
            var f = function;
            var g = derivative;

            var x0 = initialGuess;
            var err = error;
            var N = iterations;

            var Converged = false;
            var i = 1;
            double x1 = 0;

            do
            {
                if (g(x0) == 0) return null;

                x1 = x0 - f(x0) / g(x0);
                x0 = x1;

                i++;

                if (i > N) return null;

                Converged = Math.Abs(f(x1)) <= err;
            } while (!Converged);

            if (Converged)
                return x1;
            return null;
        }
    }
}