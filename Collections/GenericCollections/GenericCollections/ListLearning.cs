using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    internal class ListLearning
    {
        static void Main2(string[] args)
        {
            // List class : (namespace : System.Collections.Generic)
            //      List class is generic class, so u need to specify datat type of which it is going to store.
            //      Therefore, it can contain a group of elements of same type,
            //      so when u are sure that there will be only object of particular type the go for List.
            //      insertion order is preserved.

            //List ts = new List();   // no data type mention therefore error.
            List<string> list = new List<string>() { "abc","efg","hig"};        // initialiser.    
            List<string> list2 = new List<string>(10);              // specifying initial capacity of List.

            //      List class uses array internally,
            //      once the array gets full, it creates new array with more size & then copy existing element from old array to new.

            Console.WriteLine(list[0]);     // can access elements through index.

            Console.WriteLine("-------------------------------------------------------------------------------");

            // ADDING

            list.Add("abc");        // duplicate values are allowed
            list.Add(null);         // null is a valid value.

            foreach(string value in list)
                Console.WriteLine(value);

            Console.WriteLine("-------------------------------------------------------------------------------");

            // AddRange(IEnumerable value).
            list2.AddRange(list);

            foreach (string value in list2)
                Console.WriteLine(value);

            Console.WriteLine("-------------------------------------------------------------------------------");


            // INSERT

            list.Insert(3, "xxx");      // (index, value)
            //InsertRange(index, IEnumerable)
            list2.InsertRange(2, list);

            foreach (string value in list)
                Console.WriteLine(value);

            Console.WriteLine("-------------------------------------------------------------------------------");

            foreach (string value in list2)
                Console.WriteLine(value);

            Console.WriteLine("-------------------------------------------------------------------------------");


            // REMOVE

            list.Remove("abc"); // removes 1st occurremce; return true.
            list.RemoveAt(2);   // (index)  return nothing, better to check index is valid or in valaid else RTE.
            list2.RemoveRange(2, 3);    // (index, count) return nothing

            list.Remove(null);
            list2.Remove(null);

            // RemoveAll(Predicate match)
            //int count = list2.RemoveAll(n => n.Length < 3);      // removes all elements which matches condition & return no of elements removed.
            //Console.WriteLine(count);

            // int IndexOf(T value, int startIndex);
            //      return index if value founf else return -1.

            Console.WriteLine(list.IndexOf("abc"));         // linear search stops at 1st occurrence itself.

            // int BinarySearch(T value)
            //      it is same as IndexOf, return index when value found else -1.
            //      its faster in searching when List is SORTED.
            list.BinarySearch("abc");

            // bool Contains(T value):
            list.Contains("abc");


            list2.Sort();
            list2.Reverse();
            list.ToArray();

            // ForEach(Action<T>) : method executes lambda expression once per element.
            list2.ForEach(n => { Console.WriteLine(n); });


            list.Exists(n => n.Length < 3);     // Exists(Predicate) => return true if atleast one element found else false.
            list.Find(n => n.Length < 3);       // Find(Predicate) => return elements first occurence when foound.
            list.FindIndex(n => n.Length < 3);  // FindIndex(Predicate) => eturn index of 1 occurrence element.
            list.FindLast(n => n.Length < 3);   // same as Find() but returns last occurred element.
            list.FindLastIndex(n => n.Length < 3);  // same as FindIndex()  but returns index of last occurred element
            list.FindAll(n => n.Length < 3);    // return List of elements which matches condition.


            // When u want to convert collection from one datattyep to another use ConvertAll(Convert<TInput, TOutput>)
            // it executes lambda expression once per each element.

            //list.ConvertAll<string>(n => Convert.ToChar(n));

        }
    }
}
