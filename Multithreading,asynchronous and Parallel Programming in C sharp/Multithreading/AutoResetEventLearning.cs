using System;
using System.Threading;

namespace SemaphoreDemo
{
    class Program
    {
        // AutoResetEvent is used to send signals between two threads.

        // AutoResetEvent(bool initialState): It initializes a new instance of the AutoResetEvent class with
        //              a Boolean value indicating whether to set the initial state to signaled.
        //              Here, if the parameter initialState is true then it set the initial state to signaled;
        //              false to set the initial state to non-signaled.

        // The AutoResetEvent in C# maintains a boolean variable in memory.
        // If the boolean variable is false then it blocks the thread and if the boolean variable is true
        //      it unblocks the thread. So, when we create an instance of AutoResetEvent class,
        //      we need to pass the default value of the boolean value to the constructor of AutoResetEvent class.

        static AutoResetEvent autoResetEvent = new AutoResetEvent(false);

        static void Main8(string[] args)
        {
            Thread newThread = new Thread(SomeMethod)
            {
                Name = "NewThread"
            };
            newThread.Start(); //It will invoke the SomeMethod in a different thread

            //To See how the SomeMethod goes in halt mode
            //Once we enter any key it will call set method and the SomeMethod will Resume its work
            Console.ReadLine();

            //It will send a signal to other threads to resume their work
            autoResetEvent.Set();
        }

        static void SomeMethod()
        {
            Console.WriteLine("Starting........");
            //Put the current thread into waiting state until it receives the signal
            autoResetEvent.WaitOne(); //It will make the thread in halt mode

            Console.WriteLine("Finishing........");
            Console.ReadLine(); //To see the output in the console
        }
    }
}

/*
 * At this point, the main thread is called the New Thread and the new thread executes the first statement 
 * i.e. printing the first message on the console and then invoking the WaitOne method. 
 * Once it invokes the WaitOne method the new thread goes into the sleep state. 
 * Next, when we press the enter key, then the main method invokes the Set method which will send a signal 
 *      to other threads to resume their work. 
 * At this point, SomeMethod will resume its work and continue and you will see the Finishing message 
 *      on the console window as shown below.
 */

/*
 * Note: There is no guarantee that every call to the Set method will release a thread. 
 *       If two calls are too close together, so that the second call occurs before a thread has been released,
 *           only one thread is released. It’s as if the second call did not happen. 
 *       Also, if Set is called when there are no threads waiting and the AutoResetEvent is already signaled, 
 *           the call has no effect.
 */

/*
 * In AutoResetEvent, for every WaitOne method, there should be a Set method. 
 * That means if we are using the WaitOne method 2 times, then we should use the Set method 2 times. 
 * If we use the Set method 1 time, then the 2nd WaitOne method will be hung in the waiting state and 
 *  will not be released.
 */

/*
 * One Set method in ManualResetEvent can release all the WaitOne methods.
 */