using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    internal class DictionaryLearning
    {
        static void Main3(string[] args)
        {
            // Dictionary class : (namespace : System.Collections.Generic)
            //      contains a group of elements of key-value pair.
            //      key CAN'T be null or duplicate.
            //      value can be null or duplicate.
            //      values accessed based on key not index.
            //      insertion order is preserved.
            //      Searching is linear here.
            //      Retrieving a value by using its key is very fast, close to O(1), because the Dictionary class is implemented as a hash table.
            //      adding or remove process is faster. Dictionary is faster than a Hashtable as it eliminates the boxing and un-boxing overheads.

            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            keyValuePairs.Add(1, "Pratik");
            keyValuePairs.Add(2, "Chinmay");
            keyValuePairs.Add(3, "Shivam");

            foreach (KeyValuePair<int, string> item in keyValuePairs)
                Console.WriteLine(item.Key+" "+item.Value);

            Console.WriteLine("---------------------------------------------------------------------");

            string value = keyValuePairs[2];        // getting value based on key.
            Console.WriteLine(value);

            Console.WriteLine("---------------------------------------------------------------------");

            Dictionary<int, string>.KeyCollection keys = keyValuePairs.Keys;
            Dictionary<int, string>.ValueCollection values = keyValuePairs.Values;
            
            foreach(int item in keys)
                Console.WriteLine(item);

            foreach (string name in values)
                Console.WriteLine(name);

            Console.WriteLine("---------------------------------------------------------------------");

            keyValuePairs.Remove(3);        // key along with value will be removed.

            keyValuePairs.ContainsKey(3);   // return true or false.
            keyValuePairs.ContainsValue("Pratik");    // return true or false.
        }
    }
}
