using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Square : Shape
    {
        private double side;

        public Square(double side)
        {
            this.side = side;
        }
        public override double CalculateArea()
        {
            return Math.Pow(side, 2);
        }
    }
}
