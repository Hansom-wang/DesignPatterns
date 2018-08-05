using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();

            PrintMsg(beverage);



            Beverage beverage1 = new HouseBlend();
            beverage1 = new Mocha(beverage1);
            beverage1 = new Whip(beverage1);
            beverage1 = new Soy(beverage1);

            PrintMsg(beverage1);
        }

        public static void PrintMsg(Beverage beverage)
        {
            Console.WriteLine(beverage.getDescription() + "$" + beverage.cost());
            Console.ReadKey();
        }

    }
    public abstract class Beverage
    {
    public string description = "Unknown Beverage";

        public virtual string getDescription()
        {
            return description;
        }
        public abstract double cost();

    }


    public abstract class CondimentDecorator : Beverage
    {
       
    }

    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso";
        }

        public override double cost()
        {
            return 1.99;
        }
    }

    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "HouseBlend";
        }

        public override double cost()
        {
            return .89;
        }
    }


    public class Mocha : CondimentDecorator
    {
        Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double cost()
        {
            return beverage.cost() + .20;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ",Mocha";
        }
    }

    public class Soy : CondimentDecorator
    {
        Beverage beverage;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double cost()
        {
            return beverage.cost() + .15;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ",Soy";
        }
    }

    public class Whip : CondimentDecorator
    {
        Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double cost()
        {
            return beverage.cost() + .10;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ",Whip";
        }
    }
}
