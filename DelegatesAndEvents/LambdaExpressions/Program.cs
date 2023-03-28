using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    public delegate int MyDelegate(int a,int b);
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDelegate lambdaeXP = (int a, int b) =>            // lambda expression.
            {
                Console.WriteLine(a + b);
                return 2;
            };

            lambdaeXP(1,2);

            // inline lamda expression

            MyDelegate myDelegate = (int a, int b) => a + b;
            Console.WriteLine(myDelegate(1,22));
        }
    }
}
