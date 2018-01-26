namespace AreaCalculatorTests
{
    using System;
    using AreaCalculator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void GetTriangleArea_aSide3_bSIde5_cSide7_return15()
        {
            double aSide = 3;
            double bSide = 5;
            double cSide = 7;
            double expected = GetExpectedValue(aSide, bSide, cSide);

            Triangle tr = new Triangle(3, 5, 7);
            double actual = tr.GetArea();

            Assert.AreEqual(expected, actual, 0.001);

        }

        private double GetExpectedValue(double aSide, double bSide, double cSide)
        {
            double perimeter = aSide + bSide + cSide;
            double p = perimeter / 2;
            double expected = Math.Sqrt(p * (p - aSide) * (p - bSide) * (p - cSide));
            return expected;
        }
    }
}
