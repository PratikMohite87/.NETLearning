using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal abstract class AbsParent
    {
        public void Add(int x, int y)
        {
            Console.WriteLine($"Addition of {x} and {y} is : {x + y}");
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine($"Subtraction of {x} and {y} is : {x - y}");
        }
        public abstract void Mul(int x, int y);
        public abstract void Div(int x, int y);
    }
}
