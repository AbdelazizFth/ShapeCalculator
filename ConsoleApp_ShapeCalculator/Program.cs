using System;

namespace ConsoleApp_ShapeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Création d'une instance de Circle.
            Shape circle = new Circle(5); // Rayon = 5
            circle.DisplayArea(); // Affiche l'aire du cercle.

            // Création d'une instance de Rectangle.
            Shape rectangle = new Rectangle(3, 7); // Largeur = 3, Hauteur = 7
            rectangle.DisplayArea(); // Affiche l'aire du rectangle.
        }
    }
}
