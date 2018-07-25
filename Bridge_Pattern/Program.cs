using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Color black = new Black();
            DrawShape retangle = new Rectangle(black);
           // retangle.setColor(black);
            retangle.draw();

            Color pink = new Pink();

            DrawShape circle = new Circle(pink);
          //  circle.setColor(pink);
            circle.draw();
        }
    }
}
