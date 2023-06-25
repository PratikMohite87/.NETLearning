using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    internal class ManualResetEventLearning
    {
        static ManualResetEvent _mre = new ManualResetEvent(false);

        static void Main7(string[] args)
        {
            Thread t1 = new(Write);

            t1.Start();

            for(int i = 0; i < 5; i++)
            {
                new Thread(Read).Start();
            }

        }

        public static void Write()
        {
            Console.WriteLine("Write Thread working..");

            _mre.Reset(); // it sets _mre signalling state to false, means code marked with WaitOne() need to wait that thread cannot proceed with execution.

            Thread.Sleep(5000);
            Console.WriteLine("Write Thread completed..");

            // It sets _mre signalling state to true means it is signal to thread halted by WaitOne() to proceed with execution.
            // i.e. Allow one or more waiting threads to proceed i.e revokes all the WaitOne() methods and
            // this is the main difference between AutoResetEvent and ManualResetEvent.
            _mre.Set();     
        }

        public static void Read()
        {
            Console.WriteLine("Read Thread wait..");

            // Block the current thread until WaitHandler receives a signal.
            // Basically here it checks state of _mre if False it halts execution else proceeds.
            _mre.WaitOne(); 

            Console.WriteLine("Read Thread completed..");
        }
    }

    internal class ManualResetEventLearning2
    {
        static ManualResetEvent manualResetEvent = new ManualResetEvent(false);

        static void Main71(string[] args)
        {
            Task task = Task.Factory.StartNew(() =>
            {
                GetDataFromServer(1);
            });

            Task.Factory.StartNew(() =>
            {
                GetDataFromServer(2);
            });


            //Send first signal to get first set of data from server 1 and server 2
            manualResetEvent.Set();
            manualResetEvent.Reset();

            Thread.Sleep(TimeSpan.FromSeconds(2));
            //Send second signal to get second set of data from server 1 and server 2
            manualResetEvent.Set();

            Console.ReadLine();

            /* Result
                * I get first data from server1
                * I get first data from server2
                * I get second data from server1
                * I get second data from server2
                * All the data collected from server2
                * All the data collected from server1
                */
        }

        static void GetDataFromServer(int serverNumber)
        {
            //Calling any webservice to get data
            Console.WriteLine("I get first data from server" + serverNumber);
            manualResetEvent.WaitOne();

            Thread.Sleep(TimeSpan.FromSeconds(2));
            Console.WriteLine("I get second data from server" + serverNumber);
            manualResetEvent.WaitOne();
            Console.WriteLine("All the data collected from server" + serverNumber);
        }
    }
}
