using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15AbstractFactory
{
    class Program
    {
        abstract class Burger { }

        abstract class Dessert { }

        abstract class RecipeFactory
        {
            public abstract Burger CreateBurger();
            public abstract Dessert CreateDessert();
        }

        class SteakBurguer : Burger { }

        class CleamBurguer : Dessert { }

        class AdultCuisineFactory : RecipeFactory
        {
            public override Burger CreateBurger()
            {
                return new SteakBurguer();
            }

            public override Dessert CreateDessert()
            {
                return new CleamBurguer();
            }
        }

        class KidBurger : Burger { }

        class IceCream : Dessert { }

        class KidCuisineFactory : RecipeFactory
        {
            public override Burger CreateBurger()
            {
                return new KidBurger();
            }

            public override Dessert CreateDessert()
            {
                return new IceCream();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Who are you?");
            Console.WriteLine("A- Adult");
            Console.WriteLine("K- Kid");
            char result = Console.ReadKey().KeyChar;
            RecipeFactory factory = new AdultCuisineFactory();
            switch (result)
            {
                case 'A':
                case 'a':
                    factory = new AdultCuisineFactory();
                    break;
                case 'K':
                case 'k':
                    factory = new KidCuisineFactory();
                    break;
                default:
                    break;
            }
            var burger = factory.CreateBurger();
            var dessert = factory.CreateDessert();

            Console.WriteLine("");

            Console.WriteLine("Burger: " + burger.GetType().Name);
            Console.WriteLine("Dessert: " + dessert.GetType().Name);
        }
    }
}
