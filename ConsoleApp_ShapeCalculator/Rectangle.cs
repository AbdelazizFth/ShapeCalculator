using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ShapeCalculator
{
    class Rectangle : Shape
    {
        private double _width;
        private double _height;

        // Constructeur pour initialiser la largeur et la hauteur.
        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }

        // Implémentation de la méthode abstraite pour un rectangle.
        public override double GetArea()
        {
            return _height * _width;
        }
    }
}
