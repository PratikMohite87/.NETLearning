using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    internal class ThreadPoolExample
    {
        /*
         * When there are multiple requests we handle them with multiple threads.
         * When we create thread, some resources are allocated to that thread object such as memory. 
         * After then the task is executed and once the task is completed then the garbage collector removes that thread object to free up memory allocation.
         * So when there are mulriple requests for each request for creating thread above things will be done.
         * This becomes very time consuming, so here comes "Thread Pool".
         * 
         * The Thread pool in C# is nothing but a collection of threads that can be reused to perform a number of tasks in the background. 
         * Please refer image.
         */

        static void Main13(string[] args)
        {
            

            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(MyMethod));
            }

            Console.WriteLine(ThreadPool.ThreadCount);

            Console.ReadLine();
        }
        public static void MyMethod(object obj)
        {
            Thread thread = Thread.CurrentThread;
            string message = $"Background: {thread.IsBackground}, Thread Pool: {thread.IsThreadPoolThread}, Thread ID: {thread.ManagedThreadId}";
            Console.WriteLine(message);
        }
    }
}

// PERFORMANCE USING Thread Pool V/S Without using Thread Pool.
// Thread Pool is much faster than without using Thread Pool. i.e creating new thread for each request.

namespace Multithreading
{
    class Program
    {
        static void Main14(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                MethodWithThread();
                MethodWithThreadPool();
            }

            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Execution using Thread");
            stopwatch.Start();
            MethodWithThread();
            stopwatch.Stop();
            Console.WriteLine("Time consumed by MethodWithThread is : " +
                                 stopwatch.ElapsedTicks.ToString());

            stopwatch.Reset();

            Console.WriteLine("Execution using Thread Pool");
            stopwatch.Start();
            MethodWithThreadPool();
            stopwatch.Stop();
            Console.WriteLine("Time consumed by MethodWithThreadPool is : " +
                                 stopwatch.ElapsedTicks.ToString());

            Console.Read();
        }

        public static void MethodWithThread()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread thread = new Thread(Test);
                thread.Start();
            }
        }

        public static void MethodWithThreadPool()
        {
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(Test));
            }
        }

        public static void Test(object obj)
        {
        }
    }
}