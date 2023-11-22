using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Triangle: Shape
    {
        public override void Draw()
        {
            Console.WriteLine($"Draw triangle {X}, {Y}, {Width}, {Height}.");
        }
    }
}
