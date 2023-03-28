using System;
using System.Runtime.Remoting.Messaging;        // to get AsyncResult class

namespace AsyncCodeWithDelegates
{
    class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Before");

            Action obj = display;
            obj.BeginInvoke(null, null);        // asynchronous call begins
                                                // therefor o/p: before after this is display
            Console.WriteLine("After");

            Console.ReadLine();
        }

        static void display()
        {
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("this is display");
        }
    }
}

namespace AsyncCodeWithDelegates2
{
    class Program2
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("Before");

            Action<String> obj = display;
            obj.BeginInvoke("Pratik", null, null);       // obj.BeginInvoke("parameter_value",CallBackFunction,Extra data to be passed(Object)) ) 

            Console.WriteLine("After");

            Console.ReadLine();
        }

        static void display(String s)
        {
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("this is display" + s);
        }
    }
}

namespace AsyncCodeWithDelegates3
{
    class Program3
    {
        static void Main3()
        {
            Console.WriteLine("Before");

            Func<String, String> obj = display;
            obj.BeginInvoke("Pratik", CallBack, null);      // returns System.Runtime.Remoting.Messaging.AsyncResult

            Console.WriteLine("After");

            Console.ReadLine();
        }

        static String display(String s)
        {
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("this is display" + s);

            return s.ToUpper();
        }

        static void CallBack(IAsyncResult ar)
        {
            Console.WriteLine("callback func called");
        }
    }
}

namespace AsyncCodeWithDelegates4
{
    class Program4
    {
        static void Main4()
        {
            Console.WriteLine("Before");

            Func<String, String> obj = display;
            obj.BeginInvoke("Pratik", (IAsyncResult ar) => {
                Console.WriteLine("callback");
                Console.WriteLine(obj.EndInvoke(ar));       // EndInvoke is used to get return value of called function.(display)
            }, null);

            Console.WriteLine("After");

            Console.ReadLine();
        }

        static String display(String s)
        {
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("this is display" + s);

            return s.ToUpper();
        }
    }
}

namespace AsyncCodeWithDelegates5
{
    class Program5
    {
        static void Main5()
        {
            Console.WriteLine("Before");

            Func<String, String> obj = display;
            //obj.BeginInvoke("Pratik", CallBack, "Mohite");      // sending extradata
            obj.BeginInvoke("Pratik", CallBack, obj);       // sending delegate object itself

            Console.WriteLine("After");

            Console.ReadLine();
        }

        static String display(String s)
        {
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("this is display" + s);

            return s.ToUpper();
        }

        static void CallBack(IAsyncResult ar)
        {
            Console.WriteLine("CallBack");

            //Console.WriteLine(ar.AsyncState.ToString());        // getting extradata that is send in BeginInvoke

            Func<String, String> obj = (Func<String, String>)ar.AsyncState;     // getting delegate obj which was sent using BeginInvoke as extradata      // return type is Object typecasting needed
            Console.WriteLine(obj.EndInvoke(ar));
        }
    }
}

namespace AsyncCodeWithDelegates6
{
    class Program6
    {
        static void Main()
        {
            Console.WriteLine("Before");

            Func<String, String> obj = display;

            obj.BeginInvoke("Pratik", CallBack, null);      // No need to pass obj as we are going to use AsyncResult class AysncDelegate function

            Console.WriteLine("After");

            Console.ReadLine();
        }

        static String display(String s)
        {
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("this is display" + s);

            return s.ToUpper();
        }

        static void CallBack(IAsyncResult ar)
        {
            Console.WriteLine("CallBack");

            AsyncResult asr = (AsyncResult)ar;

            Func<String, String> obj = (Func<String, String>)asr.AsyncDelegate;     // AsyncDelegate function return the calling delegate object.       // return type is Object typecasting needed
            Console.WriteLine(obj.EndInvoke(ar));
        }
    }
}

namespace AsyncCodeWithDelegates7
{
    class Program7
    {
        static void Main6(string[] args)
        {
            Console.WriteLine("Before");

            Action obj = display;
            IAsyncResult iar = obj.BeginInvoke(null, null);

            while (!iar.IsCompleted)        // checks whether the invoked thread has completed execution or not
                iar.AsyncWaitHandle.WaitOne();      // if not then it will make the code to wait till the invoked thrread completes its execution the only proceeds forward
                                                
            Console.WriteLine("After");     // therefore o/p: Before this is display After

            Console.ReadLine();
        }

        static void display()
        {
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("this is display");
        }
    }
}
