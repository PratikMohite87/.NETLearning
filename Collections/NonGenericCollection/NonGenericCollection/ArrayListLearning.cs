using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericCollection
{
    internal class ArrayListLearning
    {
        static void Main1(string[] args)
        {
            // Non-Generic Collections:
            //      ArrayList, Hashtable, SortedList, Stack, Queue


            // ArrayList class : (namespace : System.Collections)  (implements : System.Collections.IList interface)
            //      collection of variables of multiple types.
            //      size dynamically (automatically) increases through reallocation (by default initial capacity & increment is by 4, you can explicitly decide it.)
            //      size can be decreased by calling "TrimToSize" or by setting Capacity property explicitly.
            //      null is a valid value
            //      duplicates are ALLOWED.
            //      performance is hit when we store value type becoz boxing is required.

            ArrayList arrayList = new ArrayList();

            Console.WriteLine(arrayList.Capacity);      // 0

            arrayList.Add(1);
            Console.WriteLine(arrayList.Capacity);      // 4

            arrayList.Add(2);
            arrayList.Insert(1, "Pratik");
            arrayList.Add(3);
            arrayList.Add(4);
            Console.WriteLine(arrayList.Capacity);      // 8

            Console.WriteLine("--------------------------------------------------");

            ArrayList arrayList2 = new ArrayList(7);    // specifiying initial capacity.

            arrayList2.AddRange(arrayList);
            Console.WriteLine(arrayList2.Capacity);     // 7

            arrayList2.Add(5);
            arrayList2.Add("Pratik");                   // duplicates allowed
            arrayList2.Add(null);                       // null allowed
            Console.WriteLine(arrayList2.Capacity);     // 14

            Console.WriteLine(arrayList2[2]);
            arrayList2[2] = "xyz";

            foreach (var item in arrayList2)
                Console.WriteLine(item);

            Console.WriteLine("--------------------------------------------------");

            // Remove:

            arrayList2.Remove(2);
            arrayList2.RemoveAt(3);
            arrayList2.RemoveRange(4, 2);       //(indexer, count)

            foreach (var item in arrayList2)
                Console.WriteLine(item);

            Console.WriteLine("--------------------------------------------------");

            arrayList2.Sort();      // used quicksort algo.     // objects in arraylist must be comparable else error:  System.InvalidOperationException: Failed to compare two elements in the array.

            foreach (var item in arrayList2)
                Console.WriteLine(item);

            ArrayList arrayList1 = new ArrayList(arrayList2);           // new ArrayList(ICollection).

            arrayList1.Clear();

        }
    }
}
