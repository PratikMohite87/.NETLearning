
using MultiThreading;

Geek geek = new Geek();

Thread thread1 = new Thread(new ThreadStart(geek.Method1));
Thread thread2 = new Thread(new ThreadStart(geek.Method2));

thread1.Start();
thread1.Join();
thread2.Start();
thread2.Join();


Thread thread3 = new Thread(new ParameterizedThreadStart(geek.Method3));
thread3.Start("Parameterized");


//try
//{
//    thread1.Abort();
//    //thread2.Abort();
//}
//catch (ThreadAbortException tae)
//{
//    Console.WriteLine(tae.ToString());
//}