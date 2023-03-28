using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class StaticConstClass
    {
        static StaticConstClass()
        {
            Console.WriteLine("Static Const Invoked");
        }

        public StaticConstClass()
        {
            Console.WriteLine("Default Constructor invoked");
        }

        public StaticConstClass(int i)
        {
            Console.WriteLine("Parameterized Constructor invoked");
        }
    }
}
