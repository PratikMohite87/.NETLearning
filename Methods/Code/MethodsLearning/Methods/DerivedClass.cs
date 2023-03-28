using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class DerivedClass : BaseClass
    {
        public DerivedClass()
        {
            //Console.WriteLine("Derived Class Constructor");
        }

        public DerivedClass(int a)
        {
            //Console.WriteLine("Derived Class parametereized Constructor");
        }

        public override void Show()
        {
            Console.WriteLine("Derived class method");
        }
    }
}
