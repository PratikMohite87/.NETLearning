using System;
using System.Collections;
using System.Collections.Specialized;

namespace NonGenericCollection
{
    internal class ListDictionaryLearning
    {
        static void Main3()
        {
            // System.Collections.Specialized namespace.
            // This type represents a non-generic dictionary type. It is implemented with a linked list.
            // ListDictionary is a simple implementation of IDictionary using a singly linked list.
            // It is smaller and faster than a Hashtable if the number of elements is 10 or less.
            // ListDictionary should not be used if performance is important for large numbers of elements.
            // Items in a ListDictionary are not in any guaranteed order.
            // A key cannot be null, but a value can.

            // Creating a ListDictionary named myDict
            ListDictionary myDict = new ListDictionary();

            // Adding key/value pairs in myDict
            myDict.Add("Australia", "Canberra");
            myDict.Add("Belgium", "Brussels");
            myDict.Add("Netherlands", "Amsterdam");
            myDict.Add("China", "Beijing");
            myDict.Add("Russia", "Moscow");
            myDict.Add("India", "New Delhi");

            // To get count of key/value pairs in myDict
            Console.WriteLine("Total key/value pairs in myDict are : " + myDict.Count);

            // Displaying the key/value pairs in myDict
            Console.WriteLine("The key/value pairs in myDict are : ");

            foreach (DictionaryEntry de in myDict)
            {
                Console.WriteLine(de.Key + " " + de.Value);
            }
        }
    }
}
