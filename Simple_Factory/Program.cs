using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
          Animal animal=  Factory.createAnimal("1");
            animal.Bark();
            Console.ReadKey();
        }
    }
    public static class Factory
    {
     public static Animal createAnimal(string type)
        {
            Animal obj;
            switch (type)
            {
                case "1":
                    obj= new Cat();
                    break;
                case "2":
                    obj= new Dog();
                    break;
                default:
                    obj= null;
                    break;
            }
            return obj;

        }
    }

    public abstract class Animal
    {
        public virtual void Bark()
        {
           
        }
    }

    public class Cat : Animal
    {
        public override void Bark()
        {
            Console.WriteLine("喵喵~~~");
        }
    }
    public class Dog : Animal
    {
        public override void Bark()
        {
            Console.WriteLine("旺旺~~~~");
        }
    }

}
