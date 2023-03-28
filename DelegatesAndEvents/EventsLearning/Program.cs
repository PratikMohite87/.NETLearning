using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Events : It is a multicast delegate.
            //          It is subscribed in subscriber class and invoked in publisher class.

            // Create object of Subscriber class
            Subscriber subscriber = new Subscriber();

            // Create object of Publisher class
            Publisher publisher = new Publisher();

            // handle event OR sunscribe to event
            publisher.myEvent += subscriber.Add;

            // invoke event
            publisher.RaiseEvent(2,3);


            // Auto Implemented event:
            //      provides shortcut syntax to create events with less code.
            //      we need not create "add" or "remove" accessors; compiler does the same automatically.

            AutoPublisher autoPublisher = new AutoPublisher();
            autoPublisher.MyEvent += subscriber.Add;
            autoPublisher.RaiseEvent(3,4);
        }
    }

    // Delegate type
    public delegate void MyDelegateType(int a, int b);

    // Publisher class.
    public class Publisher
    {
        // private delegate
        private MyDelegateType myDelegateType;

        // Step1: Create Event
        public event MyDelegateType myEvent
        {
            add { myDelegateType += value; }
            remove { myDelegateType -= value; }
        }

        // Where created event from there only it can be invoked so we are creating method and calling delegate inside it.
        public void RaiseEvent(int a, int b)
        {
            // Step 2 : raise event
            this.myDelegateType(a, b);
        }
    }

    // Subscriber class
    public class Subscriber
    {
        // target method
        public void Add(int a, int b)
        {
            Console.WriteLine(a+b);
        }
    }


    public class AutoPublisher
    {
        public event MyDelegateType MyEvent;

        public void RaiseEvent(int a, int b)
        {
            this.MyEvent(a, b);
        }
    }
}
