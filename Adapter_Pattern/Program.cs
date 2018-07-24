using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Adapter adapter = new Adapter(new Adaptee());
            adapter.request();
        }
    }

    public interface Target
    {
         void request();
    }

    public class Adaptee
    {
        public void specialRequest()
        {
            Console.WriteLine("特殊调用");
        }

    }
    public class Adapter : Target
    {
        public Adaptee adaptee;
        public Adapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }

        public void request()
        {
            this.adaptee.specialRequest();
        }

    }

}
