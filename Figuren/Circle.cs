using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuren2B
{
    internal class Circle : Figure
    {
        // Attribuut
        private int diameter;

        // Constructor
        public Circle(int diameter, string color) : base(color)
        {
            this.diameter = diameter;
        }

        // Methode
        public string Draw()
        {
            return "De klas is Cirkel, de diameter is " + this.diameter + ", en de kleur is " + this.GetColor();
        }
    }
}


