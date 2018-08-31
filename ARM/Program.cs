using System;
using Figure;

namespace ARM
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = 10.3;

            Circle circle = new Circle();
            double circleArea = circle.Area(radius);

            double a = 3;
            double b = 5;
            double c = 4;

            Triangle triangle = new Triangle();
            double triangleArea = triangle.Area(a, b, c);

            Figure.Figure anyFigure = new Figure.Figure();

            anyFigure.AreaForUnknown(radius);
            anyFigure.AreaForUnknown(a, b, c);

            Console.ReadKey();
        }
    }
}
