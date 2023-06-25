using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Standard_Query_Operators
{
    internal class Take_Learnings
    {
        public static void Main21(string[] args)
        {
            // The Take() extension method returns the specified number of elements starting from the first element.

            IList<string> strList = new List<string>() { "One", "Two", "Three", "Four", "Five" };

            var newList = strList.Take(2);

            foreach (var str in newList)
                Console.WriteLine(str);

            // The TakeWhile() extension method returns elements from the given collection until the specified condition
            //      is true.If the first element itself doesn't satisfy the condition then returns an empty collection.

            IList<string> strList2 = new List<string>() {
                                            "Three",
                                            "Four",
                                            "Five",
                                            "Hundred"  };

            var result = strList2.TakeWhile(s => s.Length > 4);

            foreach (string str in result)
                Console.WriteLine(str);
        }
    }
}
