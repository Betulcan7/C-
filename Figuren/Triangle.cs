using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuren2B
{
    internal class Triangle : Figure
    {
        private int height;
        private int width;

        public Triangle(int height, int width, string color) : base(color)
        {
            this.height = height;
            this.width = width;
        }

        public string Draw()
        {
            return "De klas is Driehoek, de hoogte is " + this.height + ", de breedte is " + this.width + ", en de kleur is " + this.GetColor();
        }
    }
}
