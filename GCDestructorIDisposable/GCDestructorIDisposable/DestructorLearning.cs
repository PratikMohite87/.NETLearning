using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace GCDestructorIDisposable
{
    internal class DestructorLearning
    {
        static void Main1(string[] args)
        {
            // Destructor : Clears unmanaged resources just before deleting object. i.e generally at the end of application execution.
            //              Destructors which are also called Finalizers in C# are used to perform any necessary final clean-up when a class instance is
            //                  being collected by the garbage collector.
            //              Cannot have any parameters as well as cannot be applied with any modifiers.

            // When to use Destructor in C#?
            //      In general, as C#.NET developers, we need not be much more worried about memory management.
            //      This is because the .NET garbage collector implicitly manages the allocation and deallocation of
            //          the memory for our objects.
            //      However, when our application works with unmanaged resources, such as windows, files, and network
            //          connections, we should use a destructor to free the memory for those unmanaged resources.
            //      When the object is eligible for destruction, the garbage collector runs the Finalize method of the object.

            #region WithoutGC.Collect

            //DestructorDemo obj1 = new DestructorDemo();
            //DestructorDemo obj2 = new DestructorDemo();

            //Making obj1 for Garbage Collection
            //obj1 = null;
            //Console.ReadKey();

            // You can see the statements written inside the destructor are not printed in the output.
            // Then you might be thinking that our destructor is not executed even though we made the obj2 value null.
            // This is not right. The point that you need to remember is that the destructor method is implicitly called
            //      by the garbage collector and we cannot predict when it calls the destructor method.

            #endregion

            #region With GC.Collect

            DestructorDemo obj1 = new DestructorDemo();
            DestructorDemo obj2 = new DestructorDemo();

            //Making obj1 and obj2 ready for Garbage Collection
            obj1 = null;
            obj2 = null;

            GC.Collect();

            Console.ReadKey();

            #endregion

        }
    }
}
