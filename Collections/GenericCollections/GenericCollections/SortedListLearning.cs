using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    internal class SortedListLearning
    {
        static void Main4(string[] args)
        {
            // SortedList class : (namespace : System.Collections.Generic)
            //      contains group of elements in key/value pair.
            //      objects are store in sorted format based on key.
            //      searching based on key here is faster than dictionary.
            //      Key cannot be null or duplicate.
            //      Most of the points are same as dictionary.
            //      It is of both generic and non-generic type of collection
            //      an element can be accessed by its key or by its index.
            //      adding or remove process is slower as resorting is needed.

            SortedList<int, string> keyValuePairs = new SortedList<int, string>();

            keyValuePairs.Add(0, "Pratik");
            keyValuePairs.Add(1, "Chinmay");
            keyValuePairs.Add(2, "Prasad");

            Console.WriteLine(keyValuePairs[0]);            // gets value based on key.

            List<int> vs = (List<int>)keyValuePairs.Keys;
            List<string> vs1 = (List<string>)keyValuePairs.Values;

            bool value1 = keyValuePairs.ContainsKey(1);
            bool value2 = keyValuePairs.ContainsValue("Prasad");

            int index = keyValuePairs.IndexOfKey(2);
            int index2 = keyValuePairs.IndexOfValue("Chinmay");

            keyValuePairs.Remove(2);
            
            keyValuePairs.Clear();


        }
    }
}
