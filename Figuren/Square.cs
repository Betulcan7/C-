using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

using System;

using System;

namespace Figuren2B
{
    internal class Square : Figure
    {
        private int length;

        public Square(int length, string color) : base(color)
        {
            this.length = length;
        }

        public string Draw()
        {
            return "De klas is Vierkant, de zijde lengte is " + this.length + ", en de kleur is " + this.GetColor();
        }
    }
}



