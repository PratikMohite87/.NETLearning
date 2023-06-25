using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard_Query_Operators
{
    internal class Single_Learnings
    {
        public static void Main13(string[] args)
        {
            IList<int> oneElementList = new List<int>() { 7 };
            IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
            IList<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };
            IList<string> emptyList = new List<string>();

            #region Single

            // Returns the only element from a collection, or the only element that satisfies a condition.
            // If Single() found no elements or more than one elements in the collection then throws InvalidOperationException.

            Console.WriteLine("The only element in oneElementList: {0}", oneElementList.Single());

            Console.WriteLine("The only element which is less than 10 in intList: {0}",
                         intList.Single(i => i < 10));

            //following throws error because list contains more than one element which is less than 100
            Console.WriteLine("Element less than 100 in intList: {0}", intList.Single(i => i < 100));

            //following throws error because list contains more than one elements
            Console.WriteLine("The only Element in intList: {0}", intList.Single());

            //following throws error because list does not contains any element
            Console.WriteLine("The only Element in emptyList: {0}", emptyList.Single());

            #endregion

            #region SingleOrDefault

            // The same as Single, except that it returns a default value of a specified generic type,
            //      instead of throwing an exception if no element found for the specified condition.

            // However, it will thrown InvalidOperationException if it found more than one element for the specified
            //      condition in the collection.

            Console.WriteLine("The only element in oneElementList: {0}",
                         oneElementList.SingleOrDefault());

            Console.WriteLine("Element in emptyList: {0}", emptyList.SingleOrDefault());

            //following throws error because list contains more than one element which is less than 100
            Console.WriteLine("Element less than 100 in intList: {0}",
                                                intList.SingleOrDefault(i => i < 100));

            //following throws error because list contains more than one elements
            Console.WriteLine("The only Element in intList: {0}", intList.SingleOrDefault());

            #endregion

        }
    }
}
