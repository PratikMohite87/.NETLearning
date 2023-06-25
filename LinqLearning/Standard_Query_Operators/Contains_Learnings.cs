using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard_Query_Operators
{
    internal class Contains_Learnings
    {
        public static void Main8(string[] args)
        {
            IList<int> intList = new List<int>() { 1, 2, 3, 4, 5 };
            bool result = intList.Contains(10);  // returns false

            #region IEqualityComparer

            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };

            #region Why should we use IEqualityComparer ?

            Student std = new Student() { StudentID = 3, StudentName = "Bill" };
            bool result2 = studentList.Contains(std); //returns false

            // Contains returns false even if "Bill" exists in the studentList.
            // This is because the Contains extension method only compares reference of an object but not the actual values
            //      of an object. So to compare values of the student object, you need to create a class by implementing
            //      IEqualityComparer interface, that compares values of two Student objects and returns boolean.

            #endregion

            Student std2 = new Student() { StudentID = 3, StudentName = "Bill" };
            bool result3 = studentList.Contains(std, new StudentComparer()); //returns true

            #endregion
        }
    }

    class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if (x.StudentID == y.StudentID &&
                        x.StudentName.ToLower() == y.StudentName.ToLower())
                return true;

            return false;
        }

        public int GetHashCode(Student obj)
        {
            return obj.GetHashCode();
        }
    }
}
