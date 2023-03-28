using System;

namespace EventHandlersLearning
{
    //Step 1 Create delegate object
    public delegate void MyHandler1(object sender, MyEventArgs e);
    public delegate void MyHandler2(object sender, MyEventArgs e);

    //Step 2 Create event handler methods
    class A
    {
        public const string m_id = "Class A";

        public void OnHandler1(object sender, MyEventArgs e)
        {
            Console.WriteLine("I am in OnHandler1 and MyEventArgs is {0}", e.m_id);
        }
        public void OnHandler2(object sender, MyEventArgs e)
        {
            Console.WriteLine("I am in OnHandler2 and MyEventArgs is {0}", e.m_id);
        }

        //Step 3 create delegates, plug in the handler and register with the object that will fire the events
        public A(B b)
        {
            MyHandler1 d1 = new MyHandler1(OnHandler1);
            MyHandler2 d2 = new MyHandler2(OnHandler2);
            b.Event1 += d1;
            b.Event2 += d2;
        }
    }

    //Step 4 Calls the encapsulated methods through the delegates (fires events)
    class B
    {
        public event MyHandler1 Event1;
        public event MyHandler2 Event2;

        public void FireEvent1(MyEventArgs e)
        {
            if (Event1 != null)
            {
                Event1(this, e);
            }
        }

        public void FireEvent2(MyEventArgs e)
        {
            if (Event2 != null)
            {
                Event2(this, e);
            }
        }
    }

    public class MyEventArgs : EventArgs
    {
        public string m_id;
    }

    public class Driver
    {
        public static void Main()
        {
            B b = new B();
            A a = new A(b);

            MyEventArgs e1 = new MyEventArgs();
            MyEventArgs e2 = new MyEventArgs();

            e1.m_id = "Event args for event 1";
            e2.m_id = "Event args for event 2";

            b.FireEvent1(e1);
            b.FireEvent2(e2);
        }
    }
}
