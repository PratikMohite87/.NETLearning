using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericCollection
{
    internal class SortedListLearning
    {
        static void Main4()
        {
            // SortedList is a collection of key/value pairs which are sorted according to keys.(by default : ascending order)
            // an element can be accessed by its key or by its index.
            // a key cannot be null, but a value can be.
            // duplicate keys are not allowed.
            // you CANNOT store keys of different data types in the same SortedList because the compiler will throw an exception.
            // You can also cast key/value pair of SortedList into DictionaryEntry.

            SortedList my_slist1 = new SortedList();

            // Adding key/value pairs in
            // SortedList using Add() method
            my_slist1.Add(1.02, "This");
            my_slist1.Add(1.07, "Is");
            my_slist1.Add(1.04, "SortedList");
            my_slist1.Add(1.01, "Tutorial");

            foreach (DictionaryEntry pair in my_slist1)
            {
                Console.WriteLine("{0} and {1}",
                          pair.Key, pair.Value);
            }
        }
    }
}
