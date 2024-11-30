using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuren2B
{
    internal class Figure
    {
        // Attribuut
        private string color;

        // Constructor
        public Figure(string kleur)
        {
            Console.WriteLine("\n");
            Console.Write("Dit is de constructor in de BASE klas");
            Console.WriteLine("\n");
            this.color = kleur;
        }

        public string GetColor()
        {
            return this.color;
        }

        public string Draw()
        {
            return "De figuur wordt getekend";
        }
    }
}
