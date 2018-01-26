namespace AreaCalculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Rectangle : Figure
    {
        private double aSide;
        private double bSide;

        public double ASide
        {
            get
            {
                return this.aSide;
            }
            set
            {
                if (value > 0)
                {
                    this.aSide = value;
                }
                else
                {
                    throw new ArgumentException("Wrong side value. Must be greater than zero");
                }
            }
        }

        public double BSide
        {
            get
            {
                return this.bSide;
            }
            set
            {
                if (value > 0)
                {
                    this.bSide = value;
                }
                else
                {
                    throw new ArgumentException("Wrong side value. Must be greater than zero");
                }
            }
        }

        protected Rectangle() { }

        public Rectangle(double a, double b)
        {
            ASide = a;
            BSide = b;
        }

        public override double GetArea()
        {
            return this.aSide * this.bSide;
        }
    }
}
