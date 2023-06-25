using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard_Query_Operators
{
    internal class Concat_Learnings
    {
        public static void Main15(string[] args)
        {
            // The Concat() method appends two sequences of the same type and returns a new sequence (collection).

            IList<string> collection1 = new List<string>() { "One", "Two", "Three" };
            IList<string> collection2 = new List<string>() { "Five", "Six" };

            var collection3 = collection1.Concat(collection2);

            IList<int> collection4 = new List<int>() { 7, 8 };

            // var collection5 = collection1.Concat(collection4); // Will give error as types are different string & int.

            foreach (string str in collection3)
                Console.WriteLine(str);
        }
    }
}
