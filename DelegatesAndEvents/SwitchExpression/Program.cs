using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int operation = 1;
            string result;

            result = operation switch
            {
                1 => "Customer",
                2 => "Supplier",
                _ => "No case available",       // _ stands for default.
            };

            Console.WriteLine(result);
        }
    }
}
