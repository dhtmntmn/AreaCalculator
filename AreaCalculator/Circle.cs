namespace AreaCalculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Circle : Figure
    {
        private double radius;

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    throw new ArgumentException("Wrong radius value. Must be greater than zero");
                }
            }
        }

        protected Circle() { }

        public Circle(double rad)
        {
            this.Radius = rad;
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
