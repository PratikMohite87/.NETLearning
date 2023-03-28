using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallel_Programming
{
    internal class ParallelForLoop
    {
        static void Main1(string[] args)
        {
            int forloop = 0, parallelforloop = 0;

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            Console.WriteLine("C# For Loop");
            for (int i = 1; i <= 100; i++)
            {
                //Console.WriteLine(i);
                forloop++;
            }

            stopwatch.Stop();

            Console.WriteLine(stopwatch.ElapsedTicks);
            Console.ReadKey();

            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();

            Console.WriteLine("C# Parallel For Loop");

            //It will start from 1 until 101
            //Here 1 is the start index which is Inclusive
            //Here 11 us the end index which is Exclusive
            //Here number is similar to i of our standard for loop
            //The value will be store in the variable number

            //public static ParallelLoopResult For(int fromInclusive, int toExclusive, Action<int> body):
            //      This method is used to execute a for loop in which iterations may run in parallel.
            //      Here, the parameter fromInclusive specifies the start index, inclusive.
            //      The parameter toExclusive specifies the end index, exclusive.
            //      And the parameter body specifies the delegate that is invoked once per iteration.
            //      It returns a structure that contains information about which portion of the loop is completed.
            //      It will throw ArgumentNullException if the body argument is null.

            Parallel.For(1, 101, number => {
                //Console.WriteLine(number);
                parallelforloop++;
            });

            stopwatch2.Stop();
            Console.WriteLine(stopwatch2.ElapsedTicks);

            Console.ReadLine();
        }
    }
}

/*
 * What is the difference between the Parallel For loop and Standard C# for loop?
        The main difference between the Parallel For loop and the standard C# for loop is as follows :

            In the case of the standard C# for loop, the loop is going to run using a single thread whereas, 
            in the case of the Parallel For loop, the loop is going to execute using multiple threads.

            The second difference is that, in the case of the standard C# for loop, the loop is iterated in 
            sequential order whereas, in the case of the Parallel For loop, the order of the iteration is not 
            going to be in sequential order.
 */

/*
 * Note: When the iterations are independent of each other, it means that subsequent iterations do not need 
 *       the state updates made by previous iterations, then in such cases, we need to use Task Parallel Library (TPL) 
 *       to run each iteration in parallel on all the available cores. 
 *       
 *       Moreover, the iteration should be an expensive iteration otherwise we will get negative performance.
 */

/*
 * For Bellow program:
 * 
 * As you can see in the above output, the standard C# for loop iterates sequentially using a single thread 
 *      as a result, the results are printed sequentially. 
 * On the other hand, you can see with the Parallel for loop the results are not printed in sequential order. 
 * This is because it uses multiple threads to iterate over the collection.
 */

namespace ParallelProgrammingDemo
{
    class Program
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("C# For Loop");
            int number = 10;
            for (int count = 0; count < number; count++)
            {
                //Thread.CurrentThread.ManagedThreadId returns an integer that 
                //represents a unique identifier for the current managed thread.
                Console.WriteLine($"value of count = {count}, thread = {Thread.CurrentThread.ManagedThreadId}");
                //Sleep the loop for 10 miliseconds
                Thread.Sleep(10);
            }
            Console.WriteLine();
            Console.WriteLine("Parallel For Loop");
            Parallel.For(0, number, count =>
            {
                Console.WriteLine($"value of count = {count}, thread = {Thread.CurrentThread.ManagedThreadId}");
                //Sleep the loop for 10 miliseconds
                Thread.Sleep(10);
            });
            Console.ReadLine();
        }
    }
}

// See Performance difference.

namespace ParallelProgrammingDemo
{
    class Program2
    {
        static void Main3()
        {
            DateTime StartDateTime = DateTime.Now;
            Stopwatch stopWatch = new Stopwatch();
            Console.WriteLine("For Loop Execution start");
            stopWatch.Start();

            for (int i = 0; i < 10; i++)
            {
                long total = DoSomeIndependentTask();
                Console.WriteLine("{0} - {1}", i, total);
            }

            DateTime EndDateTime = DateTime.Now;
            Console.WriteLine("For Loop Execution end ");
            stopWatch.Stop();
            Console.WriteLine($"Time Taken to Execute the For Loop in miliseconds {stopWatch.ElapsedMilliseconds}");

            Console.ReadLine();

            DateTime StartDateTime2 = DateTime.Now;
            Stopwatch stopWatch2 = new Stopwatch();
            Console.WriteLine("Parallel For Loop Execution start");
            stopWatch2.Start();

            Parallel.For(0, 10, i => {
                long total = DoSomeIndependentTask();
                Console.WriteLine("{0} - {1}", i, total);
            });

            DateTime EndDateTime2 = DateTime.Now;
            Console.WriteLine("Parallel For Loop Execution end ");
            stopWatch2.Stop();
            Console.WriteLine($"Time Taken to Execute Parallel For Loop in miliseconds {stopWatch2.ElapsedMilliseconds}");

            Console.ReadLine();
        }
        static long DoSomeIndependentTask()
        {
            //Do Some Time Consuming Task here
            //Most Probably some calculation or DB related activity
            long total = 0;
            for (int i = 1; i < 100000000; i++)
            {
                total += i;
            }
            return total;
        }
    }
}
