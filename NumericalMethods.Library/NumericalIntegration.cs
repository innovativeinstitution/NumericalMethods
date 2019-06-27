using System;

namespace NumericalMethods.Library
{
    public class NumericalIntegration : INumericalIntegration
    {
        public double? ExecuteTrapezoidalMethod(
            Func<double, double> function,
            double lower,
            double upper,
            int intervals)
        {
            Func<double, double> f = function;
            int n = intervals;
            double stepSize = (upper - lower) / n;
            double? integration = f(lower) + f(upper);

            int i = 1;
            do
            {
                double k = i * stepSize;
                integration += 2 * f(k);
                i++;

            } while (i <= n);

            integration *= stepSize / 2;

            return integration;
        }

        public double? ExecuteSimpsons13Method(
            Func<double, double> function,
            double lower,
            double upper,
            int intervals)
        {
            Func<double, double> f = function;
            int n = intervals;
            double stepSize = (upper - lower) / n;
            double? integration = f(lower) + f(upper);

            int i = 1;
            do
            {
                double k = i * stepSize;

                if (i % 2 == 0)
                {
                    integration += 2 * f(k);
                }
                else
                {
                    integration += 4 * f(k);
                }

                i++;

            } while (i <= n);

            integration *= stepSize / 3;

            return integration;
        }

        public double? ExecuteSimpsons38Method(
            Func<double, double> function,
            double lower,
            double upper,
            int intervals)
        {
            Func<double, double> f = function;
            int n = intervals;
            double stepSize = (upper - lower) / n;
            double? integration = f(lower) + f(upper);

            int i = 1;
            do
            {
                double k = i * stepSize;

                if (i % 3 == 0)
                {
                    integration += 2 * f(k);
                }
                else
                {
                    integration += 3 * f(k);
                }

                i++;

            } while (i <= n);

            integration *= stepSize * 3 / 8;

            return integration;
        }
    }
}
