using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_DotNetTutorial
{
    internal class A
    {
        public string publicFieldofA;
        private string privateFieldofA;

        public A()
        {
            publicFieldofA = string.Empty;
            privateFieldofA = string.Empty;

            Console.WriteLine("Parameterless Constructor of A");
        }

        public void publicMethodofA()
        {
            Console.WriteLine("Method 1");
        }
        private void privateMethodofA()
        {
            Console.WriteLine("Method 2");
        }
    }
}
