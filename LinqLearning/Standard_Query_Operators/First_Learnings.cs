using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Standard_Query_Operators
{
    internal class First_Learnings
    {
        public static void Main12(string[] args)
        {
            IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
            IList<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };
            IList<string> emptyList = new List<string>();
            IList<string> emptyList2 = new List<string>() { null, null, null };

            #region First

            // The First() method returns the first element of a collection, or the first element that satisfies the specified
            //      condition using lambda expression or Func delegate.
          
            Console.WriteLine("1st Element in intList: {0}", intList.First());

            Console.WriteLine("1st Even Element in intList: {0}", intList.First(i => i % 2 == 0));

            Console.WriteLine("1st Element in strList: {0}", strList.First()); 

            Console.WriteLine(emptyList2.First());

            #region Error Scenarios

            // If a given collection is empty or does not include any element that satisfied the condition then it will
            //      throw InvalidOperation exception.

            Console.WriteLine(emptyList.First()); // Throws error as collection is empty.

            Console.WriteLine(intList.First(i => i > 0 && i < 5)); // Throws error as sequence contain no matching element.

            #endregion

            #endregion

            #region FirstOrDefault()

            // The FirstOrDefault() method does the same thing as First() method.

            // The only difference is that it returns default value of the data type of a collection if a collection is
            //      empty or doesn't find any element that satisfies the condition.

            Console.WriteLine(emptyList.FirstOrDefault()); // Will not throw error will return default value of datatype.
            Console.WriteLine(intList.FirstOrDefault(i => i > 0 && i < 5)); // Will not throw error will return default value of datatype.
            Console.WriteLine(emptyList2.FirstOrDefault());

            #endregion
        }
    }
}
