using System;
using System.Linq;

namespace Figure
{
    public class Triangle : Figure, IFigure
    {
        public double Area(params double[] parts)
        {
            Func<double> calc = () =>
            {
                parts = parts.OrderByDescending(x => x).ToArray();

                double perimeter = (parts[0] + parts[1] + parts[2]);
                for (int i = 0; i < 3; i++)
                {
                    if (perimeter <= 2 * parts[i])
                    {
                        string message = string.Format("The part {0} should be less the sum other parts", parts[i]);
                        throw new Exception(message);
                    }
                }

                double hypotenuseSquare = Math.Pow(parts[1], 2) + Math.Pow(parts[2], 2);
                if (hypotenuseSquare == Math.Pow(parts[0], 2))
                {
                    Console.WriteLine("Current triangle is rectangular");
                }

                double semiperimeter = perimeter / 2;
                return Math.Sqrt(semiperimeter * (semiperimeter - parts[0]) * (semiperimeter - parts[1]) * (semiperimeter - parts[2]));
            };

            return GetArea(calc, 3, parts);
        }
    }
}

