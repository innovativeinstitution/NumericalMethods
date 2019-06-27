namespace NumericalMethods.Library
{
    public interface ISystemOfEquations
    {
        double[] ExecuteGaussianElimination(string[] coefficients);
    }
}