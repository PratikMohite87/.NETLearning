using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    internal class WhatIsSynchronousProgramming
    {
        /*
         * In Synchronous operations tasks are performed one at a time.
         * Only when one optn is completed the following is unblocked.
         * Here we wait for a task to finish to move to the next one.
         * 
         * A Synchronous call waits for the method to complete beforee continouing with program flow.
         * In Synchronous programming flow is one after another.
         * 
         * How bad is it ?
         *      As Synchronous operations are performed one at a time, synchronous method call can create delay in program execution.
         *      So leaves end user with bad user experience & blocked UI whenever user attempts to perform 
         *      some lengthy (time consuming) operations.
         *      
         * Solution : ASYNCHRONOUS PROGRAMMING
         */ 

         /* ASYNCHRONOUS PROGRAMMING :
         * 
         *      We could define asynchronous programming as the way of executing programming code in a thread 
         *      without having to wait for an I/O-bound or CPU-bound task to finish. 
         *      I/O-bound operations could be file-system accesses, HTTP requests, API calls, or database queries. 
         *      And CPU-bound operations would be actions like encrypting data, complex calculations, image or document management.
         * 
         *      One of the ideas of asynchronous programming is to divide our logic into awaitable tasks so that 
         *      we don't block the execution of our application. 
         *      We can call an async method and get a task object that represents it. 
         *      In the meantime, we can do some not related and not dependant work. 
         *      After we execute those operations, we await the async task, which may already be finished or not. 
         *      If the execution is finished, we will get the resulting value from the task and use it in the next dependant operations.
         *      
         *      Some of the benefits we have working with asynchronous tasks are:
                    We keep the UI of our app responsive.
                    We improve the performance of our application.
                    We avoid thread pool starvation.

                Although, there are some drawbacks when working with async programming:
                    Code gets more complex and harder to maintain.
                    There is increased memory allocation, as some objects have to stay alive longer while awaiting other code to be executed.
                    It can get hard to find bugs occurring in asynchronous tasks.
                    When we're writing an asynchronous piece of code, all our application code tends to become asynchronous.
         */
    }
}
