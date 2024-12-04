using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ShapeCalculator
{
    public abstract class Shape
    {
        public abstract double GetArea();

        public void DisplayArea()
        {
            Console.WriteLine($"The area of the shape is {GetArea()}");
        }
    }
}
