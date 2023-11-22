using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
           
            shapes.Add(new Shape()
            {
                X= 1,
                Y= 2,   
                Height= 3,
                Width= 4,   
            });

            shapes.Add(new Rectangle()
            {
                X= 1,
                Y= 2,
                Width= 3,
                Height= 4,
            });
            shapes.Add(new Triangle() { 
                X = 1,
                Y = 2,
                Height = 3,
                Width= 4,
            });
            shapes.Add(new Circle() 
            {
                X = 1,
                Y = 2, 
                Height = 3, 
                Width = 4 });

            for (int i = 0; i < shapes.Count; i++)
            {
                shapes[i].Draw();
            }
            Console.ReadKey();  
            
        }
    }
}
