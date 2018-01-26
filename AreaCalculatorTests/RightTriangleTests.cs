namespace AreaCalculatorTests
{
    using System;
    using AreaCalculator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class RightTriangleTests
    {
        [TestMethod]
        public void GetRightTriangleArea_aSide3_bSide4()
        {
            //arrange
            RightTriangle rt = new RightTriangle(3, 4 ,5);
            double aSide = 3;
            double bSide = 4;
            double expected = (aSide * bSide) / 2;

            //act
            double area = rt.GetArea();

            //assert
            Assert.AreEqual(expected, area, 0.001);
        }
    }
}
