namespace Figure
{
    public interface IFigure
    {
        /// <summary>
        /// Calculation the areas for currnet figure
        /// </summary>
        /// <param name="parts"></param>
        /// <returns></returns>
        double Area(params double[] parts);

        /// <summary>
        /// Calculation the areas for any figures
        /// </summary>
        /// <param name="parts"></param>
        /// <returns></returns>
        // double AreaForUnknown(params double[] parts);
    }
}
