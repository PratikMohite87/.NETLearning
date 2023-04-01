using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace PartialClassAndMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Partial class : class that splits into multiple files, each file is treated as part of class.
            //                 This allows multiple developer to work on same class differently.
            //                 We will see different classes but it will be one class.

            // we have created partial class class1 in 3 different files class1 class2 class3 in classlibrary1.
            // At compilation time all partial classes are combined as single class.
            // namespaces of all partial classes must be same otherwise they will be treated as different class.
            // duplicate members are not allowed in partial classes becoz both will be part of same class.

            Class1 class1 = new Class1();
            class1.ProductId = 1;
            class1.Cost = 2334.3;
            Console.WriteLine(class1.GetTax());


            // Partial methods are declared in one partial class (just like abstract method ) & implemented in another partial class
            // that have same name.
            // Partial methods are private by default, so it needs to be called from another public method.
            // Can have only void return type.

            class1.CallPartialMethod();

            Console.ReadKey();

        }
    }
}
