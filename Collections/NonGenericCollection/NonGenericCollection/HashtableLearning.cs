using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericCollection
{
    internal class HashtableLearning
    {
        static void Main2(string[] args)
        {
            // Hashtable class:  ( namespace : System.Collections ) (implements : Dictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback, and ICloneable)
            //      A Hashtable is a collection of key/value pairs that are arranged based on the HASHCODE of the KEY.
            //      Key cannot be null, but value can be.
            //      KEY objects must be IMMUTABLE as long as they are used as keys in the Hashtable.
            //      You can store elements of the same type and of the different types.
            //      Key must be unique. Duplicate keys are not allowed.
            //      Faster in searching.
            //      Insertion order is not preserved.

            //      Process of adding element:
            //          Generate index based on the key i.e index = hashcode % size of dictionary.
            //          Add the element next to linked list at generated index.

            Hashtable hashtable = new Hashtable() { { 1, "ABC" }, { 2, "EFG" } };

            hashtable.Add("xyz", 3);
            hashtable.Add(3, "WWW");

            Console.WriteLine(hashtable[1]);        // accessing value based on key.

            foreach (object key in hashtable.Keys)
                Console.WriteLine(key);

            foreach (object value in hashtable.Values)
                Console.WriteLine(value);


            //      Elements of hashtable that is a key/value pair are stored in DictionaryEntry, so you can also cast the key/value pairs to a DictionaryEntry.
            foreach (DictionaryEntry dictionaryEntry in hashtable)
                Console.WriteLine(dictionaryEntry.Key + " " + dictionaryEntry.Value);


        }
    }
}
