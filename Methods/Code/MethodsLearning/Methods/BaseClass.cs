using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class BaseClass
    {
        public BaseClass()
        {
            //Console.WriteLine("Base class constructor");
        }

        public BaseClass(int a)
        {
            //Console.WriteLine("Base class parameterized constructor");
        }

        public virtual void Show()
        {
            Console.WriteLine("Base class method");
        }
    }
}
