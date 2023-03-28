using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAndYeild
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Iterators are a method which yield returns elements 1-BY-1.
            // yield return statment returns element; but pauses execution of the method.
            // iterator can be a method or get accessor of a property.
            // iterator cannot contain ref or out parameters.
            //  Multiple yields are allowed
            // iterators are mostly used in custom collections.

            Sample sample = new Sample();

            var enumerable1 = sample.Method();
            var enumerator1 = enumerable1.GetEnumerator();
            enumerator1.MoveNext();
            Console.WriteLine(enumerator1.Current);
            enumerator1.MoveNext();
            Console.WriteLine(enumerator1.Current);

            //-------------------------------------------------------------------------------------------------------

            var enumerable2 = sample.Method2();
            var enumerator2 = enumerable2.GetEnumerator();

            while (enumerator2.MoveNext())
            {
                Console.WriteLine(enumerator2.Current);
            }

            // OR

            foreach (var item in enumerable2)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class Sample
    {
        public List<int> prices = new List<int>() { 1, 2, 3, 4, 5, 6 };

        public IEnumerable<int> Method()
        {
            Console.WriteLine("Iterator method executes");
            yield return 10;        // yield keyword return value but continues the execution.
            Console.WriteLine("Iterator method execution continues");
            yield return 20;
        }

        public IEnumerable<int> Method2()
        {
            int sum = 0;

            foreach (int price in prices)
            {
                sum += price;
                yield return sum;
            }
        }
    }
}
