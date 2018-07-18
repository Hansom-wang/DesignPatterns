using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            //FactoryA factoryA = new FactoryA();
            //factoryA.CreateFactory().use();


            //FactoryB factoryB = new FactoryB();
            //factoryB.CreateFactory().use();

            FileLogFactory fileLog = new FileLogFactory();
            fileLog.createLog().writeLog();

            DatabaseLogFactory databaseLog = new DatabaseLogFactory();
            databaseLog.createLog().writeLog();

            Console.ReadKey();
        }
    }

    public abstract class Factory
    {
        public abstract Product CreateFactory();
    }

    public abstract class Product
    {
        public abstract void use();
    }


    public class FactoryA : Factory
    {
        public override Product CreateFactory()
        {
            return new ProductA();
        }
    }

    public class ProductA : Product
    {
        public override void use()
        {
            Console.WriteLine("ProductA");
        }
    }
    public class FactoryB : Factory
    {
        public override Product CreateFactory()
        {
            return new ProductB();
        }
    }

    public class ProductB : Product
    {
        public override void use()
        {
            Console.WriteLine("ProductB");
        }
    }



}
