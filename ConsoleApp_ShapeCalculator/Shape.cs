using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ShapeCalculator
{
    public abstract class Shape
    {
        // Méthode abstraite : doit être implémentée par les classes dérivées.
        public abstract double GetArea();

        // Méthode concrète : commune à toutes les formes.
        public void DisplayArea()
        {
            Console.WriteLine($"The area of the shape is {GetArea()}");
        }
    }
}
