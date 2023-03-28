using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCDestructorIDisposable
{
    internal class DisposeLearning
    {
        static void Main(string[] args)
        {
            // If our application is using an expensive external resource, then it is recommended to provide an explicit
            //      way to release the resources before the garbage collector frees the object.

            // To release the resource, it is recommended to implement a Dispose method of the IDisposable interface that
            //      performs the necessary clean-up for the object.

            // So, basically, we need our class to inherit from the IDisposable interface and provide the implementation for
            //      the Dispose methods

            DisposeDemo resource = null;

            try
            {
                resource = new DisposeDemo();
                Console.WriteLine("Using Resources");
            }
            finally
            {
                if (resource != null)
                {
                    Console.WriteLine("Calling Dispose Method to Destroy Resources");
                    resource.Dispose();
                }
            }

            //Trying to Call the Dispose Method again
            Console.WriteLine();
            Console.WriteLine("Trying to Call the Dispose Method Again To Destroy Resources");
            resource.Dispose();
            Console.ReadKey();
        }
    }
}
