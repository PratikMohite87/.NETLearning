using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard_Query_Operators
{
    internal class Except_Intersect_Union_Learnings
    {
        public static void Main19(string[] args)
        {
            IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Five" };
            IList<string> strList2 = new List<string>() { "Four", "Five", "Six", "Seven", "Eight" };

            IList<Student> studentList1 = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };

            IList<Student> studentList2 = new List<Student>() {
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };

            #region Except

            // The Except() method requires two collections.
            // It returns a new collection with elements from the first collection which do not exist in the second collection.

            var result = strList1.Except(strList2);

            var resultedCol = studentList1.Except(studentList2, new StudentComparer());

            #endregion

            #region Intersect

            // The Intersect extension method requires two collections.
            // It returns a new collection that includes common elements that exists in both the collection.

            var result2 = strList1.Intersect(strList2);

            var resultedCol2 = studentList1.Intersect(studentList2, new StudentComparer());

            #endregion

            #region Union

            // The Union extension method requires two collections and returns a new collection that includes
            //      distinct elements from both the collections.

            var result3 = strList1.Union(strList2);

            var resultedCol3 = studentList1.Union(studentList2, new StudentComparer());

            #endregion

            foreach (string str in result)
                Console.WriteLine(str);
        }
    }

    class StudentComparer4 : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if (x.StudentID == y.StudentID && x.StudentName.ToLower() == y.StudentName.ToLower())
                return true;

            return false;
        }

        public int GetHashCode(Student obj)
        {
            return obj.StudentID.GetHashCode();
        }
    }
}
