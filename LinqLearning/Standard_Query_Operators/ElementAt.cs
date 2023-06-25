using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Standard_Query_Operators
{
    internal class ElementAt
    {
        public static void Main11(string[] args)
        {
            // The ElementAt() method returns an element from the specified index from a given collection.
            // If the specified index is out of the range of a collection then it will throw an Index out of range exception.
            // Please note that index is a zero based index.

            // The ElementAtOrDefault() method also returns an element from the specified index from a collaction
            //      and if the specified index is out of range of a collection then it will return a default value
            //      of the data type instead of throwing an error.

            IList<int> intList = new List<int>() { 10, 21, 30, 45, 50, 87 };
            IList<string> strList = new List<string>() { "One", "Two", null, "Four", "Five" };

            Console.WriteLine("1st Element in intList: {0}", intList.ElementAt(0));
            Console.WriteLine("1st Element in strList: {0}", strList.ElementAt(0));

            Console.WriteLine("3rd Element in intList: {0}", intList.ElementAtOrDefault(2));
            Console.WriteLine("3rd Element in strList: {0}", strList.ElementAtOrDefault(2));

            // As index is out of range instead of throwing error it will return default value of type int
            Console.WriteLine(intList.ElementAtOrDefault(9));

            // As index is out of range instead of throwing error it will return default value of type string
            Console.WriteLine(strList.ElementAtOrDefault(9));

            Console.WriteLine(intList.ElementAt(9)); // throws an exception: Index out of range"
        }
    }
}
