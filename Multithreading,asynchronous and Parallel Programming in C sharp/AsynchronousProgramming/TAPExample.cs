using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    internal class TAPExample
    {
        /*
         * A Task is an object that represents some work that should be done.
         * 
         * Task can tell you if work is completed & if the operation returns a result,
         *      the task gives you the result.
         *      
         * A TASK in c# is used to implement Task-Based Asynchronous Programming & was introduced with .NET Framework 4.
         * 
         * Task object is typically executed asynchronously on a thread pool thread rather than synchronously 
         *      on the main thread of the app.
         *      
         * Task Scheduler is responsible for starting Task & also responsible for managing it.
         * By default, Task Scheduler uses threads from the thread pool to execute Task.
         */

        public static void Main3(string[] args)
        {
            Console.WriteLine($"Main Thread : {Thread.CurrentThread.ManagedThreadId} started");

            #region General Creation

            //Task task = new Task(PrintCounter);  // Task creation
            //task.Start();     // Task scheduling.

            #endregion

            #region Creating using StartNew()
            //Task task = Task.Factory.StartNew(PrintCounter);    // New need to explicitly start, it starts automatically.
            #endregion

            #region Creating using Run()

            /*
             * Task.Run() provides the esiest way to create a Task object with default configuration values.
             * Run() allowa you to create & execute Task in single method call & is simpler alternative to StartNew().
             */
            //Task task = Task.Run(() => PrintCounter());

            #endregion

            #region Wait Method

            //task.Wait();    // Waits for Task to complete execution. // similar to Join in threads.

            #endregion

            #region Task Returning Value

            // int is type of result we are going to return.
            //Task<int> task = Task<int>.Run(() => { return Total(100); });
            //task.Wait();  // does not matter as Result will force code to wait till task return result.
            //Console.WriteLine("Sum is: " + task.Result);

            #endregion

            #region Task Returning Complex values

            //Task<Student> student = Task<Student>.Run(() =>
            //{
            //    Student student1 = new Student { Id = 1, Name = "Pratik" };
            //    return student1;
            //});

            //Console.WriteLine(student.Result.Name);

            #endregion

            #region Chaining Tasks Using Continuation

            /*
             * A Continuation Task is an asynchronous task that invoked by another task known as antecedent, when antecedent finishes.
             * ContinueWith() : method of task that allows executing code after the task has finished execution.
             */

            Task<string> student = Task<string>.Run(() =>
            {
                Student student1 = new Student { Id = 1, Name = "Pratik" };
                return student1;
            }).ContinueWith((resultOfPreviousTask) =>
            {
                return resultOfPreviousTask.Result.Name;
            });

            Console.WriteLine(student.Result);

            #endregion

            Console.WriteLine($"Main Thread : {Thread.CurrentThread.ManagedThreadId} completed");
            
            Console.ReadKey();

            /*
             * From Performance Point of view, Task.Run or Task.Factory.StartNew methods are preferable to create & schedule Tasks.
             * But if you want Task creation & scehduling separately, then you need to create task separately 
             *      & then call Start method to schedule the task execution for a later time.
             */
        }

        static void PrintCounter()
        {
            Console.WriteLine($"Child Thread : {Thread.CurrentThread.ManagedThreadId} started");

            for(int i = 0; i <= 5; i++)
            {
                Console.WriteLine($"Count Value: {i}");
            }

            Console.WriteLine($"Child Thread : {Thread.CurrentThread.ManagedThreadId} completed");
        }

        static int Total(int max)
        {
            Console.WriteLine($"Child Thread : {Thread.CurrentThread.ManagedThreadId} started");

            int sum = 0;

            for (int i = 0; i <= max; i++)
            {
                sum += i;
            }

            Thread.Sleep(10000);

            Console.WriteLine($"Child Thread : {Thread.CurrentThread.ManagedThreadId} completed");
            return sum;
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

/*
 Differences Between Task And Thread:

    The Thread class is used for creating and manipulating a thread in Windows. 
    A Task represents some asynchronous operation and is part of the Task Parallel Library, a set of APIs for 
        running tasks asynchronously and in parallel.
    The task can return a result. There is no direct mechanism to return the result from a thread.
    Task supports cancellation through the use of cancellation tokens. But Thread doesn't.
    A task can have multiple processes happening at the same time. Threads can only have one task running at a time.
    We can easily implement Asynchronous using ’async’ and ‘await’ keywords.
    A new Thread()is not dealing with Thread pool thread, whereas Task does use thread pool thread.
    A Task is a higher level concept than Thread.
 */

/*
  Why we need Tasks ?
        It can be used whenever you want to execute something in parallel. 
        Asynchronous implementation is easy in a task, using’ async’ and ‘await’ keywords.
 */

/*
  Why we need a Thread ?
        When the time comes when the application is required to perform few tasks at the same time.
 */
