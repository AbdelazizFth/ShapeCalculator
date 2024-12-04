using System;

namespace ConsoleApp_ShapeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(5);
            circle.DisplayArea();

            Shape rectangle = new Rectangle(3, 7);
            rectangle.DisplayArea();
        }
    }
}
