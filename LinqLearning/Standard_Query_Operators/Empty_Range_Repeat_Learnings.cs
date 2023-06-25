using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard_Query_Operators
{
    internal class Empty_Range_Repeat_Learnings
    {
        public static void Main17(string[] args)
        {
            #region Empty

            // The Empty() method returns an empty collection of a specified type.

            var emptyCollection1 = Enumerable.Empty<string>();
            var emptyCollection2 = Enumerable.Empty<Student>();

            Console.WriteLine("Count: {0} ", emptyCollection1.Count());
            Console.WriteLine("Type: {0} ", emptyCollection1.GetType().Name);

            Console.WriteLine("Count: {0} ", emptyCollection2.Count());
            Console.WriteLine("Type: {0} ", emptyCollection2.GetType().Name);

            #endregion

            #region Range

            // The Range() method returns a collection of IEnumerable<T> type with specified number of elements
            //      and sequential values starting from the first element.

            var intCollection = Enumerable.Range(10, 10);
            Console.WriteLine("Total Count: {0} ", intCollection.Count());

            for (int i = 0; i < intCollection.Count(); i++)
                Console.WriteLine("Value at index {0} : {1}", i, intCollection.ElementAt(i));

            // o/p:
            /*
             * Total Count: 10
                    Value at index 0 : 10
                    Value at index 1 : 11
                    Value at index 2 : 12
                    Value at index 3 : 13
                    Value at index 4 : 14
                    Value at index 5 : 15
                    Value at index 6 : 16
                    Value at index 7 : 17
                    Value at index 8 : 18
                    Value at index 9 : 19
             */

            #endregion

            #region Repeat

            // The Repeat() method generates a collection of IEnumerable<T> type with specified number of elements
            //      and each element contains same specified value.

            var intCollection2 = Enumerable.Repeat<int>(10, 10);
            Console.WriteLine("Total Count: {0} ", intCollection2.Count());

            for (int i = 0; i < intCollection2.Count(); i++)
                Console.WriteLine("Value at index {0} : {1}", i, intCollection2.ElementAt(i));

            /*
             * o/p:
             * Total Count: 10
                Value at index 0: 10
                Value at index 1: 10
                Value at index 2: 10
                Value at index 3: 10
                Value at index 4: 10
                Value at index 5: 10
                Value at index 6: 10
                Value at index 7: 10
                Value at index 8: 10
                Value at index 9: 10
             */

            #endregion
        }
    }
}
