using System;
using Figure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FigureUnitTests
{
    [TestClass]
    public class TriangleFigureTest
    {
        [TestMethod]
        public void ValidParametersTriangleAreaTest()
        {
            Triangle triangle = new Triangle();
            double a = 2;
            double b = 5;
            double c = 4;
            double result = triangle.Area(a, b, c);
            Assert.AreEqual(result, 3.799671038392666);
        }

        [TestMethod]
        public void RectangularAreaTest()
        {
            Triangle triangle = new Triangle();
            double a = 3;
            double b = 5;
            double c = 4;
            double result = triangle.Area(a, b, c);
            Assert.AreEqual(result, 6);
        }

        [TestMethod]
        public void InvalidParametersWithMinusTriangleAreaTest()
        {
            Triangle triangle = new Triangle();
            double a = 3;
            double b = -5;
            double c = 4;
            double result = triangle.Area(a, b, c);
            Assert.AreEqual(result, 0);  // 0 instead Assert.Fail();
        }

        [TestMethod]
        public void InvalidParametersBigPartTriangleAreaTest()
        {
            Triangle triangle = new Triangle();
            double a = 30;
            double b = 5;
            double c = 4;
            double result = triangle.Area(a, b, c);
            Assert.AreEqual(result, 0);  // 0 instead Assert.Fail();
        }
    }
}
