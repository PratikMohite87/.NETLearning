using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GCDestructorIDisposable
{
    internal class GarbageCollectorLearning
    {
        #region What is Garbage Collector ?

        //Garbage Collector in .NET Framework is nothing but a Small Routine or you can say it’s a Background Process Thread 
        //that runs periodically and try to identify what objects are not being used currently by the application and 
        //de-allocates the memory of those objects.

        //Garbage Collector is nothing but, it is a feature provided by CLR which helps us to clean or destroy unused managed objects.

        //Note: The Garbage Collector will destroy only the unused managed objects. It does not clean unmanaged objects.

        #region Managed & Unmanaged Objects

        // Managed Resources : objects that are created by CLR are "Managed resources".
        //                     These object will participate in GC process which is part of .NET framework.
        //                     The codes which run under the complete control of CLR are called Managed Code in .NET Framework.
        //                     These kinds of code (Managed code in C#) are run by a dot net runtime environment.
        //                     If the dot net framework is not installed or if dot net runtime is not available,
        //                     then these kinds of codes are not going to be executed.

        // Unmanaged Resources : objects are not created by CLR & not managed by CLR are called "Unmanaged resources".
        //                       The code (EXE, Web App) which not run under the control of CLR is called unmanaged code in .NET.
        //                       exg : Filestreams, DB connections, Skype, Powerpoint used in application.

        // Now unmanaged resource object are not clear by GC.
        // So for that purpose : Destructor & Dispose method used.

        #endregion

        #endregion

        #region Process of deleting object from memory.

        // When CLR can't find space for storing objects, it performs Garbage Collection.

        // Garbage collection is done by GARBAGE COLLECTOR (GC) component of CLR.

        // GC checks below inf from MSIL COde :
        //      collects referencs of object.
        //      identifies wheteher any object is referenced by static field.

        // If object has at least one living reference variable in any stock or static field are "alive object"; others are "dead"

        // There is NO specific timing for GC to get triggered.

        // GC automatically triggered in following conditions:
        //      When heap is full.
        //      When we call GC.Collect() explicitly.

        #endregion

        #region Generations

        //Heap contains 3 segments called generations :
        //      Generation 2 [long-lived generation] => After long time and after again removing some unused object in Gen 1 remaining objects are moved to Gen 2.
        //      Generation 1 [Survival Generation]  => After execution of some other methods and removal of unused objects, remaining objects are moved to Gen 1.
        //      Generation 0 [Short-lived Generation] => When any new fresh objects are created they are moved to Gen 0 => youngest object

        //CLR uses MARK & Compact Algorithm in order to perform GC.
        //      1st go for Gen 0 then Gen 1 then Gen 2

        #endregion

        #region When will the Object of a Class get Destroyed in C#?

        //At the end of the program execution, each and every object that is associated with the program will be destroyed by the garbage collector.

        //The Implicit calling of the garbage collector occurs sometime in the middle of the program execution provided the
        //memory is full so the garbage collector will identify unused objects of the program and destroys them.

        //The Explicit calling of the garbage collector can also be done in the middle of program execution by the programmer with the help of the
        //“Collect()” statement so that if there are any unused objects associated with the program will be destroyed in the middle of the program
        //execution.

        #endregion
    }
}
