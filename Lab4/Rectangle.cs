using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Rectangle: Shape
    {
        public override void Draw()
        {
            Console.WriteLine($"Draw rectangle {X}, {Y}, {Width}, {Height}.");
        }
    }
}
