using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallel_Programming
{
    internal class ParallelOptionClassLearning
    {
        /*
         * ParallelOptions Class in C#:
                The ParallelOptions class is one of the most useful classes when working with multithreading. 
                This class provides options to limit the number of concurrently executing loop methods. 

           The Degree of Parallelism in C#:
                Using the Degree of parallelism we can specify the maximum number of threads to be used to 
                    execute the program. 
                Following is the syntax to use ParallelOptions class with a Degree of Parallelism.
         */

        static void Main(string[] args)
        {
            //Limiting the maximum degree of parallelism to 2
            var options = new ParallelOptions()
            {
                MaxDegreeOfParallelism = 2
            };

            int n = 100;

            Parallel.For(0, n, options, i =>
            {
                Console.WriteLine(@"value of i = {0}, thread = {1}",
                i, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(10);
            });

            Console.WriteLine("Press any key to exist");
            Console.ReadLine();
        }
    }
}
