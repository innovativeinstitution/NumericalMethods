using System;

namespace NumericalMethods.Library
{
    public class SystemOfEquations : ISystemOfEquations
    {
        public double[] ExecuteGaussianElimination(string[] coefficients)
        {
            var input = coefficients;
            var result = SolveLinearEquations(input);
            return result;
        }

        private double[] SolveLinearEquations(string[] coefficients)
        {
            var rowsMatrix = new double[coefficients.Length][];
            for (var i = 0; i < rowsMatrix.Length; i++)
                rowsMatrix[i] = Array.ConvertAll(coefficients[i].Split(' '), double.Parse);

            return GetReducedForm(rowsMatrix);
        }

        private double[] GetReducedForm(double[][] rowsMatrix)
        {
            var length = rowsMatrix[0].Length;

            for (var i = 0; i < rowsMatrix.Length; i++)
            {
                if (rowsMatrix[i][i] == 0 && !SwapRows(rowsMatrix, i, i)) return null;

                for (var j = i; j < rowsMatrix.Length; j++)
                {
                    var d = new double[length];
                    for (var k = 0; k < length; k++)
                    {
                        d[k] = rowsMatrix[j][k];
                        if (rowsMatrix[j][i] != 0) d[k] = d[k] / rowsMatrix[j][i];
                    }

                    rowsMatrix[j] = d;
                }

                for (var y = i + 1; y < rowsMatrix.Length; y++)
                {
                    var f = new double[length];
                    for (var g = 0; g < length; g++)
                    {
                        f[g] = rowsMatrix[y][g];
                        if (rowsMatrix[y][i] != 0) f[g] = f[g] - rowsMatrix[i][g];
                    }

                    rowsMatrix[y] = f;
                }
            }

            return BackSubstitution(rowsMatrix);
        }

        private bool SwapRows(double[][] rowsMatrix, int row, int column)
        {
            var isRowSwapped = false;
            for (var z = rowsMatrix.Length - 1; z > row; z--)
                if (rowsMatrix[z][row] != 0)
                {
                    var temp = new double[rowsMatrix[0].Length];
                    temp = rowsMatrix[z];
                    rowsMatrix[z] = rowsMatrix[column];
                    rowsMatrix[column] = temp;
                    isRowSwapped = true;
                }

            return isRowSwapped;
        }

        private double[] BackSubstitution(double[][] rowsMatrix)
        {
            double val = 0;
            var length = rowsMatrix[0].Length;
            var result = new double[rowsMatrix.Length];
            for (var i = rowsMatrix.Length - 1; i >= 0; i--)
            {
                val = rowsMatrix[i][length - 1];
                for (var x = length - 2; x > i - 1; x--) val -= rowsMatrix[i][x] * result[x];
                result[i] = val / rowsMatrix[i][i];

                if (!IsValidSolution(result[i])) return null;
            }

            return result;
        }

        private bool IsValidSolution(double result)
        {
            return !(double.IsNaN(result) || double.IsInfinity(result));
        }
    }
}