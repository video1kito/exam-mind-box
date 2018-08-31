using System;
using Figure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FigureUnitTests
{
    [TestClass]
    public class CircleFigureTest
    {
        [TestMethod]
        public void CircleAreaTest()
        {
            Circle circle = new Circle();
            double radius = 10;
            double result = circle.Area(radius);
            Assert.AreEqual(result, 100 * Math.PI);
        }

        [TestMethod]
        public void InvalidParametersCircleAreaTest()
        {
            Circle circle = new Circle();
            double radius = -10;
            double result = circle.Area(radius);
            Assert.AreEqual(result, 0);  // 0 instead Assert.Fail();
        }
    }
}
