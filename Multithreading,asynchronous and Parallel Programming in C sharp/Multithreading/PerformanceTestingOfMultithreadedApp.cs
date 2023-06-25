using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    internal class PerformanceTestingOfMultithreadedApp
    {
        /*
           Performance Testing With Multiple Processors:

           If you have a machine with multiple processors, then multiple threads can execute your 
           application code in parallel on different cores. For example, if your machine has two cores 
           and there are two threads to execute your application code, then each thread is going to be run 
           on an individual core. As a result, we will get better performance.

           If you have two threads and if each thread takes 10 milliseconds to complete the execution, 
           then on a machine with 2 processors, the total time taken is 10 milliseconds.
         */

        /*
           Performance Testing With Single Processor:

           If you have a machine with a single processor, then multiple threads are going to execute one 
           after the other. It is not possible for a single-core processor machine to execute multiple threads 
           in parallel. The operating system switches between the threads so fast, it just gives us the illusion 
           that the threads are running in parallel. On a single-core or processor machine, multiple threads can
           negatively affect the performance as there is overhead involved with context-switching.

           If you have two threads and each thread takes 10 milliseconds to complete the execution, then on 
           a machine with a single processor, the total time taken is 20 milliseconds plus thread context 
           switching time if any.
         */

        public static void Main20()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            stopwatch = Stopwatch.StartNew();

            EvenNumbersSum();
            OddNumbersSum();

            stopwatch.Stop();

            Console.WriteLine($"Total time in milliseconds : {stopwatch.ElapsedMilliseconds}");

            stopwatch = Stopwatch.StartNew();

            Thread thread1 = new Thread(EvenNumbersSum);
            Thread thread2 = new Thread(OddNumbersSum);

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            stopwatch.Stop();

            Console.WriteLine($"Total time in milliseconds : {stopwatch.ElapsedMilliseconds}");

            Console.ReadKey();
        }

        public static void EvenNumbersSum()
        {
            double Evensum = 0;
            for (int count = 0; count <= 50000000; count++)
            {
                if (count % 2 == 0)
                {
                    Evensum = Evensum + count;
                }
            }
            Console.WriteLine($"Sum of even numbers = {Evensum}");
        }
        public static void OddNumbersSum()
        {
            double Oddsum = 0;
            for (int count = 0; count <= 50000000; count++)
            {
                if (count % 2 == 1)
                {
                    Oddsum = Oddsum + count;
                }
            }
            Console.WriteLine($"Sum of odd numbers = {Oddsum}");
        }
    }
}
