using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    internal class MonitorClassMethods
    {
        /*
         * Monitor is a locking mechanism that will ensure one thread is executing a piece of code at one time.
         * Monitor is no different from loct but it provides more control over the synchronization of various threads trying to access the same block of code.
         * Monitor locks object. While you can pass a value type to Enter & Exit, it is boxed separately for each cell.
         * Monitor has signaling mechanism, like wait, pulse, pulseall methods
         */

        /*
         * Monitor.Wait(): A thread wait for other threads to notify.
         * Monitor.Pulse(): A thread notify to another thread.
         * Monitor.PulseAll(): A hread notifies all other threads within a process.
         */

        /*
         * Advantage of Synchronization: To avoid deadlock.
         *                               To maintain consistency.
         */

        static object _lock = new object();

        static void Main6(string[] args)
        {
            // 

            Thread t1 = new(Write);
            Thread t2 = new(Read);

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();
        }

        public static void Write()
        {
            Monitor.Enter(_lock);

            for(int i = 0; i < 5; i++)
            {
                Monitor.Pulse(_lock);       // Will notify other thread who is waiting to start execution.

                Console.WriteLine("Write Thread working.." + i);
                Console.WriteLine("Write Thread completed.." + i);

                Monitor.Wait(_lock);        // Will make current thread wait until it gets notified by some other thread.
            }
        }

        public static void Read()
        {
            Monitor.Enter(_lock);

            for (int i = 0; i < 5; i++)
            {
                Monitor.Pulse(_lock);        // Will notify other thread who is waiting to stat execution.

                Console.WriteLine("Read Thread working.." + i);
                Console.WriteLine("Read Thread completed.." + i);

                Monitor.Wait(_lock);         // Will make current thread wait until it gets notified by some other thread.
            }
        }
    }
}
/*
 *  Expected operation is that 1st write should work and then read should work for each loop as bellow:
 
 *  Write Thread working..0
    Write Thread completed..0
    Read Thread working..0
    Read Thread completed..0
    Write Thread working..1
    Write Thread completed..1
    Read Thread working..1
    Read Thread completed..1
    Write Thread working..2
    Write Thread completed..2
    Read Thread working..2
    Read Thread completed..2
    Write Thread working..3
    Write Thread completed..3
    Read Thread working..3
    Read Thread completed..3
    Write Thread working..4
    Write Thread completed..4
    Read Thread working..4
    Read Thread completed..4
 */