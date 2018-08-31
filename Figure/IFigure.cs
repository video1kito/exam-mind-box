namespace Figure
{
    public interface IFigure
    {
        /// <summary>
        /// Calculation the area for figure
        /// </summary>
        /// <param name="parts"></param>
        /// <returns></returns>
        double Area(params double[] parts);
    }
}
