using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard_Query_Operators
{
    internal class OfType_Learnings
    {
        public static void Main2(string[] args)
        {

            // The OfType operator filters the collection based on a given type
            // Where and OfType extension methods can be called multiple times in a single LINQ query.

            IList mixedList = new ArrayList();
            mixedList.Add(0);
            mixedList.Add("One");
            mixedList.Add("Two");
            mixedList.Add(3);
            mixedList.Add(new Student() { StudentID = 1, StudentName = "Bill" });

            #region Query Syntax

            // Will return string type elements
            var stringResult = from s in mixedList.OfType<string>()
                               select s;

            // Will return int type elements
            var intResult = from s in mixedList.OfType<int>()
                            select s;

            #endregion

            #region Method Syntax

            // Will return string type elements
            var stringResult2 = mixedList.OfType<string>();

            #endregion
        }
    }
}
