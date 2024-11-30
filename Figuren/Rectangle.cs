using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Figuren2B
{
    internal class Rectangle : Figure
    {
        private int height;
        private int width;

        public Rectangle(int height, int width, string color) : base(color)
        {
            this.height = height;
            this.width = width;
        }


        public string Draw()
        {
            return "Dit is een object , de hoogte is " + this.height + ", de breedte is " + this.width + ", en de kleur is " + this.GetColor();
        }
    }
}

