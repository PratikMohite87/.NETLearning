using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            Console.WriteLine(c[1]);

            c[2] = "Nissan";
            Console.WriteLine(c[2]);

            Console.WriteLine(c["first"] + " " + c["third"]);
        }
    }

    public class Car
    {
        private string[] _brands = new string[] { "BMW", "Skoda", "Honda" };

        // Indexer : always created with this keyword.
        //           used to access group of elements
        //           Parameterized properties are called indexer.
        //           Cannot be static.
        //           Cannot have ref or out parameter
        public string this[int index]
        {
            set { _brands[index] = value; }
            get { return _brands[index]; }
        }

        private string[] _names = new string[] { "first", "second", "third" };

        // Indexer overloading
        public string this[string name]
        {
            set { this._brands[Array.IndexOf(_names, name)] = value; }
            get { return _brands[Array.IndexOf(_names, name)]; }
        }

    }
}
