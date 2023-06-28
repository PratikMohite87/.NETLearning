using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    internal class MutexLearning
    {
        /*
         * Mutex is synchronization primitive that grants exclusive access to the shared resource to only one thread.
         * If a thread acquires a Mutex, the 2nd thread that wants to acquire that Mutx is suspended until first thread releases the Mutex.
         */

        static Mutex mutex = new Mutex();

        static void Main20(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                new Thread(Write).Start();
            }
        }

        static void Write()
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "Write Thread Waiting");

            mutex.WaitOne();

            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "Write Thread Working");
            Thread.Sleep(5000);

            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "Write Thread Completed");

            mutex.ReleaseMutex();
        }
    }
}

/*
 * 6Write Thread Waiting
4Write Thread Waiting
5Write Thread Waiting
7Write Thread Waiting
8Write Thread Waiting
4Write Thread Working
4Write Thread Completed
6Write Thread Working
6Write Thread Completed
5Write Thread Working
5Write Thread Completed
7Write Thread Working
7Write Thread Completed
8Write Thread Working
8Write Thread Completed
 */
