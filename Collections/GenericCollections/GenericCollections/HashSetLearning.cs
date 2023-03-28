using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    internal class HashSetLearning
    {
        static void Main(string[] args)
        {
            // HashSet class : (namespace : System.Collections.Generic)
            //      contains group of elements of unique values stored at respective indexes.
            //      Same as Hashtable but with single value, value must be unique becoz hashcode is calculated based on value.

            // HashSet<T> hs = new HashSet<T>();
            // very fast in searching.

            // insertion order is preserved.
            // only one null value s allowed
            // cannot sort hashset.

            HashSet<int> vs = new HashSet<int>();
            vs.Add(1);
            vs.Add(2);  
            vs.Add(3);

            vs.RemoveWhere(n => n > 2);

            vs.Contains(1);  //  very fast as its not linear search.


            // Union

            HashSet<int> vs1 = new HashSet<int>() { 4,5,6};

            vs.UnionWith(vs1);

            foreach(int a in vs)
                Console.WriteLine(a);

            Console.WriteLine("-----------------------------------------------------------------------");

            // Intersect

            HashSet<int> vs2 = new HashSet<int>(){4,5,7};

            vs1.IntersectWith(vs2);

            foreach (int a in vs1)
                Console.WriteLine(a);


        }
    }
}
