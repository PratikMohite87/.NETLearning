using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    /*
     * Async and Await are the two keywords that help us to program asynchronously. 
     * An async keyword is a method that performs asynchronous tasks such as fetching data from a database, 
     *      reading a file, etc, they can be marked as “async”. 
     * Whereas await keyword making  “await” to a statement means suspending the execution of the async method
     *      it is residing in until the asynchronous task completes. 
     * After suspension, the control goes back to the caller method. 
     * Once the task completes, the control comes back to the states where await is mentioned and executes 
     *      the remaining statements in the enclosing method.
     */
    public class SchoolStartingSynchronously
    {
        static void Main4(string[] args)
        {

            Demo();
            Console.ReadLine();

        }

        public static void Demo()
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            StartSchoolAssembly();
            TeachClass12();
            TeachClass11();
            watch.Stop();
            Console.WriteLine($"Execution Time: { watch.ElapsedMilliseconds} ms");
        }

        public static void StartSchoolAssembly()
        {
            Thread.Sleep(8000);
            Console.WriteLine("School Started");
        }

        public static void TeachClass12()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Taught class 12");

        }

        public static void TeachClass11()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Taught class 11");

        }

    }

    public class SchoolStartingAsynchronously
    {

        static void Main5(string[] args)
        {

            Demo();
            Console.ReadLine();

        }

        public static async void Demo()
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            var task1 = StartSchoolAssembly();

            // Here it will wait for task1 to completed which is school starting.
            await task1;

            var task2 = TeachClass12();
            var task3 = TeachClass11();


            Task.WaitAll(task1, task2, task3);
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
        }

        // async keyword turns method into an async method which allows you to use the await keyword in is body.
        public static async Task StartSchoolAssembly()
        {
            // await keyword suspends the calling method & yeilds control back to its caller until the awaited task is completed.
            await Task.Run(() =>
            {
                Thread.Sleep(8000);
                Console.WriteLine("School Started");
            });
        }

        public static async Task TeachClass12()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("Taught class 12");
            });


        }

        public static async Task TeachClass11()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Taught class 11");
            });
        }
    }
}
