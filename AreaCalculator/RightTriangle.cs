namespace AreaCalculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RightTriangle : Triangle
    {
        protected RightTriangle() { }

        public RightTriangle(double a, double b, double c) : base(a, b, c)
        {
            double[] array = new double[3]{a, b, c};
            Array.Sort(array);

            this.ASide = array[0];
            this.BSide = array[1];
            this.CSide = array[2];

            IsRightTriangle();
        }

        private bool IsRightTriangle()
        {
            if (this.ASide * this.ASide + this.BSide * this.BSide != this.CSide * this.CSide)
            {
                throw new ArgumentException("Triangle is not rectangular");
            }

            return true;
        }

        public override double GetArea()
        {
            return (this.ASide * this.BSide) / 2;
        }
    }
}
