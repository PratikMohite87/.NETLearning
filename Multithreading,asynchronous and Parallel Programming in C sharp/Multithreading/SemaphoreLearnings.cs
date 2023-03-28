using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    internal class SemaphoreLearnings
    {
        /*
         * The Semaphore is used to limit the no. of threads that can have access to shared resource concurrently.
         * In other words, we can say that semaphore allows 1 or more threads to enter into critical section 
         *      and execute the task concurrently with thread safety.
         */

        static Semaphore sema = new Semaphore(2, 2); // it means that 2 threads can work concurrently on shared resource.

        static void Main10(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                new Thread(Write).Start();
            }
        }

        static void Write()
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "Write Thread Waiting");

            sema.WaitOne();

            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "Write Thread Working");
            Thread.Sleep(5000);

            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "Write Thread Completed");

            sema.Release();
        }
    }
}
