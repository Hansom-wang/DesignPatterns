using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
public  abstract class DrawShape
    {
        protected Color color;


        public  DrawShape(Color color)
        {
            this.color = color;
        }

        public abstract void draw();

    }

    public interface Color
    {
         void draw();
    }

    public class Circle : DrawShape

    {
        public Circle(Color color):base(color)
        {
           
        }

       
        public override void draw()
        {
            Console.WriteLine("Circle Color is:");
            color.draw();
        }
    }

    public class Rectangle : DrawShape
    {
        public Rectangle(Color color) : base(color) {
           
        }
        public override void draw()
        {
            Console.WriteLine("Rectangle Color is:");
            color.draw();
        }
    }

    public class Pink : Color
    {
        public void draw()
        {
            Console.WriteLine("Pink");
        }
    }

    public class Black : Color
    {
        public void draw()
        {
            Console.WriteLine("Black");
        }
    }

}
