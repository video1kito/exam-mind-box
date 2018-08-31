using Figure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FigureUnitTests
{
    [TestClass]
    public class UnknownFigureTest
    {
        [TestMethod]
        public void UnknownCircleAreaTest()
        {
            Figure.Figure circle = new Figure.Figure();
            double radius = 10;
            double result = circle.AreaForUnknown(radius);
            Assert.AreEqual(result, 100 * Math.PI);
        }

        [TestMethod]
        public void UnknownTriangleAreaTest()
        {
            Figure.Figure triangle = new Figure.Figure();
            double a = 3;
            double b = 5;
            double c = 4;
            double result = triangle.AreaForUnknown(a, b, c);
            Assert.AreEqual(result, 6);  // 0 instead Assert.Fail();
        }
    }
}