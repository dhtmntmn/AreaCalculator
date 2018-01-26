namespace AreaCalculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Triangle : Figure
    {
        private double aSide;
        private double bSide;
        private double cSide;

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

        public double CSide
        {
            get
            {
                return this.cSide;
            }
            set
            {
                if (value > 0)
                {
                    this.cSide = value;
                }
                else
                {
                    throw new ArgumentException("Wrong side value. Must be greater than zero");
                }
            }
        }

        private bool IsTriangle(double a, double b, double c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentException("Triangle with indicated sides can not exists");
            }

            return true;
        }

        protected Triangle() { }

        public Triangle(double a, double b, double c)
        {
            if (IsTriangle(a, b, c))
            {
                this.ASide = a;
                this.BSide = b;
                this.CSide = c;
            }
        }

        public double Perimeter()
        {
            return this.aSide + this.bSide + this.cSide;
        }


        public override double GetArea()
        {
            double p = Perimeter() / 2;

            return Math.Sqrt(p * (p - this.aSide) * (p - this.bSide) * (p - this.cSide));
        }
    }
}
