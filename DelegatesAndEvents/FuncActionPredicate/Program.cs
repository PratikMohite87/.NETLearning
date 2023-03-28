using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncActionPredicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Func : 
            //      Its pred-defined generic-delegate.
            //      Can have 0-16 parameters and 1 return type.

            Func<int, int, int> func = (int a, int b) => a + b;
            Func<int, int, int> func2 = FuncMethod;

            Console.WriteLine(func2(2,3)+" "+func(4,5));


            // Action :
            //      Its pred-defined generic-delegate.
            //      Same as Func but it should be void allways No r.t

            Action<int, int> action = ActionMethod;
            action(2,3);


            // Predicate :
            //      Its pred-defined generic-delegate.
            //      Only one parameter allowed and default return type is boolean.

            Predicate<int> predicate = PredicateMethod;
            Console.WriteLine(predicate(2));
        }

        public static int FuncMethod(int a, int b)
        {
            return a + b;
        }

        public static void ActionMethod(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static bool PredicateMethod(int a)
        {
            return a > 0;
        }
    }
}
