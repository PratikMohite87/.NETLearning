using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class AbsChild : AbsParent
    {
        public override void Mul(int x, int y)
        {
            Console.WriteLine($"Multiplication of {x} and {y} is : {x * y}");
        }
        public override void Div(int x, int y)
        {
            Console.WriteLine($"Division of {x} and {y} is : {x / y}");
        }
    }
}
