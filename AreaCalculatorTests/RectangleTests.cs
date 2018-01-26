namespace AreaCalculatorTests
{
    using System;
    using AreaCalculator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void GetRectangleArea_a3_b7_15returned()
        {
            double a = 3;
            double b = 5;
            double expected = a * b;

            Rectangle rect = new Rectangle(3, 5);
            double actual = rect.GetArea();

            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}
