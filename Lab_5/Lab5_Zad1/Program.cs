using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Square square = new Square(4);

            Console.WriteLine("Pole koła: " + circle.CalculateArea());
            Console.WriteLine("Pole kwadratu: " + square.CalculateArea());
        }
    }
}
