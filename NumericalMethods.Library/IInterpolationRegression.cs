namespace NumericalMethods.Library
{
    public interface IInterpolationRegression
    {
        double? ExecuteLinearInterpolation(
            double x0,
            double y0,
            double x1,
            double y1,
            double xp
            );

        //y = a + bx
        double[] ExecuteLinearRegression(
            double[] xValues,
            double[] yValues
            );

        //y = ax^b
        double[] ExecutePowerRegression(
            double[] xValues,
            double[] yValues
            );
    }
}
