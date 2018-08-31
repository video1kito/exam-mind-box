using System;

namespace Figure
{
    public class Circle : Figure, IFigure
    {
        public double Area(params double[] parts)
        {
            Func<double> calc = () =>
            {
                return Math.PI * Math.Pow(parts[0], 2);
            };

            return GetArea(calc, 1, parts);
        }
    }
}
