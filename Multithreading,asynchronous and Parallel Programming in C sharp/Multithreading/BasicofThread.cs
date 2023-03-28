/*
 Multi-Tasking:

    Running multiple application at a time.
    Exg. Windows OS is Multitasking OS as we can work on Chrom, IE, Word at same time.
         To run multiple app at time OS uses Process.
         So every app running has a process which you can see in Task Manager.
 
 Threading:

    Under OS we have Process that is running our app. Each ruuning app. has its process behind it.
    To run code of app. Process makes use of THREAD.
    
    Thread is a light weight Process.
    A Process has atleast 1 Thread wgich is commonly called as Main Thread which executes app. code.
    
    Single Process can have multiple Threads.
 */

namespace MultiThreadingInCSharp
{
    class BasicofThread
    {
        static void Main1(string[] args)
        {
            /*
            
            Main() method which is starting point is run by Main thread which is created by process.

            Thread Class: 
                System.Threading namespace.
                Creates & controls thread, set its priority, gets its status.
             */

            Thread t = Thread.CurrentThread;       // return currently running thread.
            t.Name = "Main Thread";     // By default thread does not have any name.
            //Console.WriteLine(t.Name);
            //Console.WriteLine(Thread.CurrentThread.Name);

            // So till here we can see it is a single threaded.

            /*
             Drawbacks of Single Threaded App:
                Code will run one after other. i.e 1st Method1() will execute then Method2() then Method3()
                So if any of the method 1 or 2 takes large amount of time then next method has to wait for previous once compeletion.
                So this will become time consuming.
             */

            //Method1();
            //Method2();
            //Method3();

            /*
             Solution for drawbacks of Single Thread : Multi-Threading.
                We will allocate oen thread for each method to run.
                Here advantage is that no method will wait for completion of other method.
                All 3 method will execute simultaneously. Therefore time efficient.
             */

            // Creating Threads

            Thread t1 = new(Method1) { Name = "Thread 1" };
            Thread t2 = new Thread(Method2) { Name = "Thread 2" };
            Thread t3 = new Thread(Method3) { Name = "Thread 3" };

            // Starting threads

            t1.Start();
            t2.Start();
            t3.Start();

            Console.WriteLine("Main Thread Ended");

            /*
             Unstarted state: When an instance of a Thread class is created, it is in the unstarted state, means the thread has not yet started to run when the thread is in this state. 
                              Or in other words Start() method is not called.
 
                                    Thread thr = new Thread(); 
                                    Here, thr is at unstarted state.

             Runnable State: A thread that is ready to run is moved to runnable state. 
                             In this state, a thread might actually be running or it might be ready to run at any instant of time. 
                             It is the responsibility of the thread scheduler to give the thread, time to run. 
                             Or in other words, the Start() method is called. 
 
             Running State: A thread that is running. Or in other words, the thread gets the processor.

             Not Runnable State: A thread that is not executable because
                                 Sleep() method is called.
                                 Wait() method is called. Here it waits for another thread to notify it or wake it up.
                                 Join() method is called.
                                 Due to I/O request.
                                 Suspend() method is called. It will be continue when we call Resume().

             Dead State: When the thread completes its task, then thread enters into dead, terminates, abort state.
                         Abort() method is called. After aborting if you try to Start() ThreadStateException is raised.
             */
        }

        static void Method1()
        {
            Console.WriteLine("Method1 started using " + Thread.CurrentThread.Name);

            for (int i = 0; i < 15; i++)
                Console.WriteLine(i);

            Console.WriteLine("Method1 ended using " + Thread.CurrentThread.Name);
        }

        static void Method2()
        {
            Console.WriteLine("Method2 started using " + Thread.CurrentThread.Name);

            for (int i = 0; i < 15; i++)
                Console.WriteLine(i);

            Console.WriteLine("Method2 ended using " + Thread.CurrentThread.Name);
        }
        static void Method3()
        {
            Console.WriteLine("Method3 started using " + Thread.CurrentThread.Name);

            for (int i = 0; i < 15; i++)
                Console.WriteLine(i);

            Console.WriteLine("Method3 ended using " + Thread.CurrentThread.Name);
        }
    }
}