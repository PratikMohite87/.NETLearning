using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericCollection
{
    internal class QueueLearning
    {
        // Queue represents a first-in, first out collection of object.
        // It is used when you need a first-in, first-out access of items.When you add an item in the list, it is called enqueue, and when you remove an item, it is called dequeue.
        // This class comes under System.Collections namespace.
        // As elements are added to a Queue, the capacity is automatically increased as required by reallocating the internal array.
        // Queue accepts null as a valid value for reference types and allows duplicate elements.

        static void Main()
        {
            // Creating a Queue 
            Queue myQueue = new Queue();

            // Inserting the elements into the Queue
            myQueue.Enqueue("one");

            // Displaying the count of elements
            // contained in the Queue
            Console.Write("Total number of elements in the Queue are : ");

            Console.WriteLine(myQueue.Count);

            myQueue.Enqueue("two");

            // Displaying the count of elements
            // contained in the Queue
            Console.Write("Total number of elements in the Queue are : ");

            Console.WriteLine(myQueue.Count);

            myQueue.Enqueue("three");

            // Displaying the count of elements
            // contained in the Queue
            Console.Write("Total number of elements in the Queue are : ");

            Console.WriteLine(myQueue.Count);

            myQueue.Enqueue("four");

            // Displaying the count of elements
            // contained in the Queue
            Console.Write("Total number of elements in the Queue are : ");

            Console.WriteLine(myQueue.Count);

            myQueue.Enqueue("five");

            // Displaying the count of elements
            // contained in the Queue
            Console.Write("Total number of elements in the Queue are : ");

            Console.WriteLine(myQueue.Count);

            myQueue.Enqueue("six");

            // Displaying the count of elements
            // contained in the Queue
            Console.Write("Total number of elements in the Queue are : ");

            Console.WriteLine(myQueue.Count);
        }
    }
}
