using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ShapeCalculator
{
    class Circle : Shape
    {
        private double _radius;

        // Constructeur pour initialiser le rayon.
        public Circle(int radius) 
        {
            _radius = radius;
        }

        // Implémentation de la méthode abstraite pour un cercle.
        public override double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
