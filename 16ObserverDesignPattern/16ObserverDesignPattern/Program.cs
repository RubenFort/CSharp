using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16ObserverDesignPattern
{
    interface IMarket
    {
        void Update(Product product);
    }

    abstract class Product
    {
        private double price;
        List<IMarket> markets = new List<IMarket>();

        public Product(double _price)
        {
            price = _price;
        }

        //Añadir observadores a la lista
        public  void Attach(IMarket market)
        {
            markets.Add(market);
        }

        //Eliminar observadores a la lista
        public void Deattach(IMarket market)
        {
            markets.Remove(market);
        }

        public void Notify()
        {
            foreach (IMarket market in markets)
            {
                market.Update(this);
            }
            Console.WriteLine("");
        }

        public double pricePerPound
        {
            get { return price; }
            set
            {
                if (price != value)
                    price = value;
                Notify();
            }
        }
    }

    class Chocolate : Product
    {
        public Chocolate(double price) : base(price) { }
    }

    class Market : IMarket
    {
        private string name;
        private double price;
        public Market(string _name, double _price)
        {
            name = _name;
            price = _price;
        }

        public void Update(Product product)
        {
            Console.WriteLine("Notify: In " + name + " the price of " + product.GetType().Name +
                " was changed with " + product.pricePerPound);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Chocolate chocolate = new Chocolate(2);
            chocolate.Attach(new Market("Market1", 1));
            chocolate.Attach(new Market("Market2", 2));
            chocolate.Attach(new Market("Market3", 3));
            chocolate.Attach(new Market("Market4", 4));
            chocolate.pricePerPound = 5;
            chocolate.pricePerPound = 6;
            chocolate.pricePerPound = 7;
            chocolate.pricePerPound = 8;
            Console.ReadKey();
        }
    }
}
