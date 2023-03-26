using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;

namespace ClassAndObjects
{
    internal class Program
    {
        // internal : accesible within same assembly i.e Project (default)
                // compiled project is called assembly.
                // In case of console application project it compiles to .exe
                // In case of class library type projects it compiles to .dll
        // public : accesible in same project as well asmother projects.

        static void Main(string[] args)
        {
            Class1 c = new Class1(); // class1 is accesible as it is public in class library project ClassLibrary2.
            //Class2 c2 = new Class2(); // class2 is not accesible as it is internal in class library project ClassLibrary2.

            // objects are stored inside heap.
            // objects only store set of fields in heap it does not store method, but can access it.
            // its reference cariable is stored in stack. it stores address of object.  Default value is NULL.

            // after completeion of execution object in heap gets deleted.

            Console.WriteLine(c.Name+" "+c.Description);
        }
    }
}
