using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Asynchronious
{
    class Test
    {
        public Task ShowAsync()
        {
            return Task.Run(() => {
                Task.Delay(2000);
                throw new Exception("My Own Exception");
            });
        }

        public async void Call()
        {
            await ShowAsync();
        }
    }

    class Program
    {
        public static void Main7(String[] args)
        {
            Test t = new Test();

            try
            {
                t.Call();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Main Ended");
            Console.ReadLine();
        }
    }

    /*
     * The catch will not handle an exception. The reason is that it's asynchronous in nature. 
     * As we know, in asynchronous programming, control does not wait for the function's result and 
     *      it executes the next line. 
     * So when the function throws an exception, at that moment the program control is out of the try-catch 
     *      block.
     */
}

// try-catch block within an asynchronous function.
// This is the solution to catch exceptions in asynchronous methods.

namespace Asynchronious
{
    class Test2
    {
        public Task ShowAsync()
        {
            return Task.Run(() =>
            {
                try
                {
                    Task.Delay(2000);
                    throw new Exception("My Own Exception");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            });
        }

        public async void Call()
        {
            try
            {
                await ShowAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /*
         * Now, you may wonder: We have implemented a try-catch block within Task and it's fine, 
         * but what need is there for implementing a try-catch within the Call() function? 
         *      The reason is because when an asynchronous function fails to execute a Task, 
         *      it throws a Task Cancelled exception. 
         *      We need to implement a mechanism to catch this exception.
         */
    }
    class Program2
    {
        public static void Main(String[] args)
        {
            Test2 t = new Test2();
            t.Call();
            Console.ReadLine();
        }
    }
}