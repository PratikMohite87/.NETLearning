using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    internal class AsynchronousProgrammingPatterns
    {
        /*
         * Asynchronous Programming Patterns:
         *      Asynchronous Programming Model - (APM) - .NET 1.1
         *      Event-based Asynchronous Pattern - (EAP) - .NET 2.0
         *      Task-based Asynchronous Pattern - (TAP) - .NET 4.5
         */

        /*
         * APM :
         *      An asynchronous operation that uses the IAsyncResult design pattern.        
         *      It is implemented as two methods named "Begin<OperationName>" & "End<OperationName>" that begin & end the asynchronous operation respectively.
         *      E.g. : FileStream class provides "BeginRead" & "EndRead" methods to asynchronously read bytes from a file.
         */

        /*
         * EAP :
         *      It is event-based legacy model for providing asynchronous behaviour.
         *      A class that supports Event-Based Asynchronous Pattern will have 1 or more methods named "MethodNameAsync".
         *      These methods may mirror synchronous versions, which perform the same operation on the current thread.
         *      Class may also have "MethodNameCompleted" event & it may have "MethodNameAsync" method.
         */

        /*
         * TAP : 
         *      Above patterns are outdated, micosoft recommends to use this pattern.
         *      It is based on Task & Task<TResult> types in the System.Threading.Tasks namespace which are used to represent asynchronous operations.
         */
    }
}
