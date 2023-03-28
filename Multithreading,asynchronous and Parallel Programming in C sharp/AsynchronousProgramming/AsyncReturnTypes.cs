using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    /*
     * Async methods can have the following return types:

            Task :          for an async method that performs an operation but returns no value.
            Task<TResult> : for an async method that returns a value.
            void :          for an event handler.
            Any type that has an accessible GetAwaiter method. The object returned by the GetAwaiter method 
                    must implement the System.Runtime.CompilerServices.ICriticalNotifyCompletion interface.
            IAsyncEnumerable<T>: for an async method that returns an async stream.
     */
    internal class AsyncReturnTypes
    {
        public static void Main6(string[] args)
        {
            //DisplayCurrentInfoAsync().Wait();

            //DisplayCurrentInfoAsync2().Wait();

            ShowTodaysInfoAsync().Wait();
        }

        public static async Task DisplayCurrentInfoAsync()
        {
            await WaitAndApologizeAsync();

            Console.WriteLine($"Today is {DateTime.Now:D}");
            Console.WriteLine($"The current time is {DateTime.Now.TimeOfDay:t}");
            Console.WriteLine("The current temperature is 76 degrees.");
        }

        public static async Task DisplayCurrentInfoAsync2()
        {
            Task waitAndApologizeTask = WaitAndApologizeAsync();

            string output =
                $"Today is {DateTime.Now:D}\n" +
                $"The current time is {DateTime.Now.TimeOfDay:t}\n" +
                "The current temperature is 76 degrees.\n";


            Console.WriteLine(output);
            await waitAndApologizeTask;
        }

        static async Task WaitAndApologizeAsync()
        {
            await Task.Delay(2000);

            Console.WriteLine("Sorry for the delay...\n");
        }

        public static async Task ShowTodaysInfoAsync()
        {
            string message =
                $"Today is {DateTime.Today:D}\n" +
                "Today's hours of leisure: " +
                $"{await GetLeisureHoursAsync()}";

            Console.WriteLine(message);
        }

        static async Task<int> GetLeisureHoursAsync()
        {
            DayOfWeek today = await Task.FromResult(DateTime.Now.DayOfWeek);

            int leisureHours =
                today is DayOfWeek.Saturday || today is DayOfWeek.Sunday
                ? 16 : 5;

            return leisureHours;
        }
    }
}
