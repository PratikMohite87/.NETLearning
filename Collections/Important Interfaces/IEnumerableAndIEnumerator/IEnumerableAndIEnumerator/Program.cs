using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableAndIEnumerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // IEnumerable :
            // It is a parent interface of all types of collection.

            //public interface IEnumerable<out T> : IEnumerable         // System.Collections.Generic.IEnumerable<T>
            //{
            //    IEnumerator<T> GetEnumerator();
            //}

            //public interface IEnumerable                              // System.Collections.IEnumerable
            //{
            //    IEnumerator GetEnumerator();
            //}

            //-----------------------------------------------------------------------------------------------------------------

            // IEnumerator :
            //      it is meant for readonly & sequential navigation of group of elements.
            //      it is used by for each loop internally.
            //      IEnumerable Interface has a method called GetEnumerator that returns instance of IEnumerator.
            //      IEnumeartor by default starts with 1st element; MoveNext() method reads the next element; & Current property returns current element.

            //public interface IEnumerator<out T> : IDisposable, IEnumerator         // System.Collections.Generic.IEnumerator<T>
            //{
            //    TCurrent {get;}
            //}

            //public interface IEnumerator                          // System.Collections.IEnumerator
            //{
            //    object Current { get; }
            //    bool MoveNext();
            //    void Reset();
            //}

            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };
            IEnumerator<int> enumerator = list.GetEnumerator();
            enumerator.Reset();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    }
}
