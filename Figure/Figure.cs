using System;
using System.Linq;

namespace Figure
{
    public class Figure
    {
        protected double GetArea(Func<double> actionHandler, int partsCount, double[] parts)
        {
            try
            {
                if (parts != null && parts.Count() == partsCount && parts.All(p => p > 0))
                {
                    double area = actionHandler();
                    Console.WriteLine(area);
                    return area;
                }
                else
                {
                    // LogWarning();
                }

            }
            catch (Exception e)
            {
                // LogException();
                // Maybe throw exception
                Console.WriteLine(e);
            }

            return 0;
        }

        public double AreaForUnknown(params double[] parts)
        {
            IFigure figure = null;
            if (parts != null)
            {
                switch (parts.Count())
                {
                    case 1:
                        figure = new Circle();
                        break;
                    case 3:
                        figure = new Triangle();
                        break;
                    default: break;
                }
                return figure.Area(parts);
            }

            return 0;
        }
    }
}
