using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    internal class LinkedListLearning
    {
        // LinkedList<T> Class is present in System.Collections.Generic namespace.
        // This generic type allows fast inserting and removing of elements.
        // Insertion and removal are O(1) operations.
        // Each node in a LinkedList<T> object is of the type LinkedListNode<T>.
        // The LinkedList is doubly linked

        public static void Main()
        {

            // Creating a LinkedList of Strings
            LinkedList<String> myList = new LinkedList<String>();

            // Adding nodes in LinkedList
            myList.AddLast("Geeks");
            myList.AddLast("for");
            myList.AddLast("Data Structures");
            myList.AddLast("Noida");

            // To check if LinkedList is empty or not
            if (myList.Count > 0)
                Console.WriteLine("LinkedList is not empty");
            else
                Console.WriteLine("LinkedList is empty");
        }
    }
}
