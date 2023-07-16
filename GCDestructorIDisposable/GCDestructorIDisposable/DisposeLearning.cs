using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Resources;
using System.Runtime.Remoting.Lifetime;
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

            // We cannot call destructor explicitly which will release unmanaged resource, for the we will need Dispose Method().

            // To release the resource, it is recommended to implement a Dispose method of the IDisposable interface that
            //      performs the necessary clean-up for the object.

            // So, basically, we need our class to inherit from the IDisposable interface and provide the implementation for
            //      the Dispose methods

            // There are a couple of resources which GC is not able to release as it doesn't have information that,
            //      how to claim memory from those resources like File handlers, window handlers, network sockets,
            //      database connections etc.

            #region Example Filestream Displose/Close Method

            // For example, if we open a file in our program and not closed it after processing than that file will
            //      not be available for other operation or it is being used by other application than they can not
            //      open or modify that file.

            // For this purpose FileStream class provides Dispose method.
            // We must call this method after file processing finished.
            // Otherwise it will through exception Access Denied or file is being used by other program.

            // FileStream Dispose() method iternally calls Close() method.

            // But for some classes both methods behave slightly different.

            // For example Connection class. If Close method is called than it will disconnect with database
            //      and release all resources being used by the connection object and Open method will reconnect
            //      it again with database without reinitializing the connection object.
            //
            // HoweverDispose method completely release the connection object and cannot be reopen
            //      just calling Open method.
            // We will have re-initialize the Connection object.

            #endregion 

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
