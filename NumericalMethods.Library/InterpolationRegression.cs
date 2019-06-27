using System;

namespace NumericalMethods.Library
{
    public class InterpolationRegression : IInterpolationRegression
    {
        public double? ExecuteLinearInterpolation(
            double x0,
            double y0,
            double x1,
            double y1,
            double xp)
        {
            double? yp = null;
            yp = y0 + ((y1 - y0) / (x1 - x0)) * (xp - x0);
            return yp;
        }

        public double[] ExecuteLinearRegression(double[] xValues, double[] yValues)
        {
            double[] x = xValues;
            double[] y = yValues;

            int n = x.Length;

            double sumX = 0;
            double sumX2 = 0;
            double sumY = 0;
            double sumXY = 0;

            for (int i = 0; i < n; i++)
            {
                sumX += x[i];
                sumX2 += Math.Pow(x[i], 2);
                sumY += y[i];
                sumXY += x[i] * y[i];
            }

            //y = a + bx
            double b = (n * sumXY - sumX * sumY) / (n * sumX2 - Math.Pow(sumX, 2));
            double a = (sumY - b * sumX) / n;

            double[] result = new double[2] { a, b };
            return result;
        }

        public double[] ExecutePowerRegression(double[] xValues, double[] yValues)
        {
            double[] x = xValues;
            double[] y = yValues;

            int n = x.Length;

            double sumX = 0;
            double sumX2 = 0;
            double sumY = 0;
            double sumXY = 0;

            for (int i = 0; i < n; i++)
            {
                sumX += Math.Log10(x[i]);
                sumX2 += Math.Pow(Math.Log10(x[i]), 2);
                sumY += Math.Log10(y[i]);
                sumXY += Math.Log10(x[i]) * Math.Log10(y[i]);
            }

            //y = ax^b
            double b = (n * sumXY - sumX * sumY) / (n * sumX2 - Math.Pow(sumX, 2));
            double A = (sumY - b * sumX) / n;

            double a = Math.Exp(A);

            double[] result = new double[2] { a, b };
            return result;
        }
    }
}
