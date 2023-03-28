using System;
using System.Threading;

public class ExThread
{

    // Non-Static method
    public void mythread()
    {
        for (int x = 0; x < 4; x++)
        {
            Console.WriteLine(x);
            Thread.Sleep(5000);
        }
    }

    // Non-Static method
    public void mythread1()
    {
        Console.WriteLine("2nd thread is Working..");
    }
}

// Driver Class
public class ThreadExample
{
    // Main method
    public static void Main4()
    {
        // Creating instance for
        // mythread() method
        ExThread obj = new ExThread();

        // Creating and initializing threads 
        Thread thr1 = new Thread(new ThreadStart(obj.mythread));
        Thread thr2 = new Thread(new ThreadStart(obj.mythread1));
        thr1.Start();

        Console.WriteLine(thr1.IsAlive);

        // Join thread

        // we will send the calling of thr2 into waiting until the work of thr1 thread is completed.
        // After that thr2 thread executes.
        // thr1.Join(); 

        // This method blocks the calling thread until the thread represented by this instance terminates or the specified time elapses while continuing to perform standard COM and SendMessage pumping.
        // public bool Join(int millisecondsTimeout);
        thr1.Join(2000); 
        
        thr2.Start();

    }
}