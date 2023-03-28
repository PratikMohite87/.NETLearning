using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    internal class Delegates
    {
        static void Main(string[] args)
        {
            // Delegates : (System.Delegate)
            //      It is special object whic stores reference of one or more method.
            //      Its all about access of elements indirectly.
            //      Used in Events. They are building block for creating Event.

            //      It is object that stores reference of specific method of specific class, with compatible parameters and
            //      return type, which is already defined in delegate type.

            Sample sample = new Sample();

            // creating delegate object And assigning method
            MyDelegateTypes myDelegateTypes = new MyDelegateTypes(sample.Add);

            // Invoking method in delegate.
            Console.WriteLine(myDelegateTypes.Invoke(1, 2));


            // MultiCast Delegate : can store reference of multiple methods.
            //      Will invoke method one by one in sequence.
            //      Return value of last executed method will be only accessible.

            myDelegateTypes += new MyDelegateTypes(sample.Subtract);
            myDelegateTypes += new MyDelegateTypes(sample.Multiply);

            Console.WriteLine(myDelegateTypes.Invoke(4, 5));
        }
    }

    public class Sample
    {
        // target method
        public int Add(int a,int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            Console.WriteLine("Subtract method executed");
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            Console.WriteLine("Multiply method executed");
            return a * b;
        }
    }

    // Creating Delegate.
    // Can take the method which have same return type and same parameters(datatype as well as no of parameters)
    public delegate int MyDelegateTypes(int a, int b);
}
