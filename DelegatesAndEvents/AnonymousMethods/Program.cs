using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethods
{
    public delegate void MyDelegate(string value);

    internal class Program
    {
        static void Main(string[] args)
        {
            // Anonymous Method :
            //      It is useful when the user wants to create an inline method and also wants to pass parameter in the anonymous method like other methods.
            //      An Anonymous method is defined using the "delegate" keyword and the user can assign this method to a variable of the delegate type.

            string surname = "Mohite";

            MyDelegate myDelegate = delegate (string value)     // anonymous method.
            {
                Console.WriteLine(value+" "+surname);           // Can access ouside variables.
            };

            myDelegate("Pratik");

            // --------------------------------------------------------------------------------------

            // Passing anonymous method as a paramter to another method.
            AnotherMethod(delegate (string value)
            {
                Console.WriteLine(value);
            }, "Mohite");
        }

        public static void AnotherMethod(MyDelegate myDelegate, string surname)
        {
            myDelegate(surname);
        }
    }
}
