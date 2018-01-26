namespace AreaCalculatorTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using AreaCalculator;

    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void GetCircleArea_rad7_compareDoublesDifference()
        {
            //arrange
            double radValue = 7;
            double expected = Math.PI * radValue * radValue;

            //act
            Circle c = new Circle(7);
            double actual = c.GetArea();

            //assert
            Assert.AreEqual(expected, actual, 0.0001);
        }
    }
}
