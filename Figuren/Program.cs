using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

using System;

namespace Figuren2B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start programma");

            // Maak een Figuur object
            Figure figuur1 = new Figure("red");
            string kleurFiguur1 = figuur1.GetColor();
            Console.WriteLine("De kleur van figuur1 is " + kleurFiguur1);

            // Maak een Cirkel object
            Circle cirkel1 = new Circle(12, "purple");
            string kleurCirkel1 = cirkel1.GetColor();
            Console.WriteLine("De gegevens van circlel1 zijn " + cirkel1.Draw());

            // Maak een Rechthoek object
            Rectangle rechthoek1 = new Rectangle(5, 8, "blue");
            string kleurRechthoek1 = rechthoek1.GetColor();
            Console.WriteLine("De gegevens van rechthoek1 zijn " + rechthoek1.Draw());

            // Maak een Vierkant object
            Square vierkant1 = new Square(6, "green");
            string kleurVierkant1 = vierkant1.GetColor();
            Console.WriteLine("De gegevens van vierkant1 zijn " + vierkant1.Draw());

            // Maak een Driehoek object
            Triangle driehoek1 = new Triangle(4, 7, "orange");
            string kleurDriehoek1 = driehoek1.GetColor();
            Console.WriteLine("De gegevens van driehoek1 zijn " + driehoek1.Draw());

            Console.ReadKey();
        }
    }
}





