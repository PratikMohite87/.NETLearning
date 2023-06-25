using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard_Query_Operators
{
    internal class Skip_Learnings
    {
        public static void Main20(string[] args)
        {
            // The Skip() method skips the specified number of element starting from first element
            //      and returns rest of the elements.

            IList<string> strList = new List<string>() { "One", "Two", "Three", "Four", "Five" };

            var newList = strList.Skip(2);
            // o/p:
            // Three
            // Four
            // Five

            var resultList = strList.SkipWhile(s => s.Length < 4);
        }
    }
}
