using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    internal class ProtectingConcurrentAccess
    {
        /*
            We can protect shared resoure from concurrent access in multithreading using bellow methods:
                Interlocked.Increment()
                Lock method.
                Monitor method.

            Above methods are locking mechanism to protect shared resource from multiple thread accessing at same time.
         */

        public static int sum = 0;  // Will act as shared resource.

        public static object _lock = new object();

        static void Main5(string[] args)
        {
            Console.WriteLine("Main method execution starts here");

            //Thread thread = new(Increment);
            //Thread thread2 = new(Increment);
            //Thread thread3 = new(Increment);

            //Thread thread = new(IncrementProtectedWithInterlockedIncrement);
            //Thread thread2 = new(IncrementProtectedWithInterlockedIncrement);
            //Thread thread3 = new(IncrementProtectedWithInterlockedIncrement);

            //Thread thread = new(IncrementProtectedWithLock);
            //Thread thread2 = new(IncrementProtectedWithLock);
            //Thread thread3 = new(IncrementProtectedWithLock);

            Thread thread = new(IncrementProtectedWithMonitor);
            Thread thread2 = new(IncrementProtectedWithMonitor);
            Thread thread3 = new(IncrementProtectedWithMonitor);

            thread.Start();
            thread2.Start();
            thread3.Start();

            thread.Join();
            thread2.Join();
            thread3.Join();

            Console.WriteLine(sum);

            Console.WriteLine("Main method execution ends here");
        }

        public static void Increment()
        {
            for(int i = 0; i < 50000; i++)
            {
                // Here multiple threads will be able to operate on sum at time, so final value of sum will not be correct.
                sum++;
            }
        }

        public static void IncrementProtectedWithInterlockedIncrement()
        {
            for (int i = 0; i < 50000; i++)
            {
                // Here this method locks & increaments sum value, when it is doing this no other thread is allowed to access sum.
                Interlocked.Increment(ref sum);
            }
        }

        //Note: In this scenarion performance wise Interlocked.Increment(ref sum); is faster than lock

        public static void IncrementProtectedWithLock()
        {
            for (int i = 0; i < 50000; i++)
            {
                // This lock method will allow only one thread to access code at time, after execution comleted will allow next waiting thread.
                // The lock statement acquires the mutual-exclusion lock for a given object,
                //      executes a statement block, and then releases the lock.
                // While a lock is held, the thread that holds the lock can again acquire and release the lock.
                // Any other thread is blocked from acquiring the lock and waits until the lock is released.
                // The lock statement ensures that a single thread has exclusive access to that object.
                lock (_lock)
                {
                    sum++;
                }
            }
        }

        public static void IncrementProtectedWithMonitor()
        {
            for (int i = 0; i < 50000; i++)
            {
                /*
                   Anything netwin Enter and Exit can by accessed by one thread at time, after execution is completed next thread can access it.
                */
                Monitor.Enter(_lock);
                try
                {
                    sum++;
                }
                finally
                {
                    Monitor.Exit(_lock);
                }
            }
        }

        /*
         * Lock v/s Monitor: lock is the shortcut for Monitor.Enter with try and finally.
         *                   So, the lock provides basic functionality to acquire an exclusive lock on a synchronized object.
         *                   But, if you want more control to implement advanced multithreeading solutions using TryEnter(), Wait(), Pulse(), PulseAll() methods, then Monitor class is option.
         *                  
         */
    }
}
