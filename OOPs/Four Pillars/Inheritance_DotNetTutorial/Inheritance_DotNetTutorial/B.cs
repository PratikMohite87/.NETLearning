using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_DotNetTutorial
{
    internal class B : A
    {
        public string publicFieldofB;

        public B()
        {
            publicFieldofB = string.Empty;

            Console.WriteLine("Parameterless Constructor of A");
        }

        public void publicMethodofB()
        {
            Console.WriteLine("Method 3");
        }
    }
}
