using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard_Query_Operators
{
    internal class SequenceEqual
    {
        public static void Main14(string[] args)
        {
            // The SequenceEqual method checks whether the number of elements, value of each element and order of elements
            //      in two collections are equal or not.

            // If the collection contains elements of primitive data types then it compares the values and number of elements.

            IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Three" };
            IList<string> strList2 = new List<string>() { "One", "Two", "Three", "Four", "Three" };
            IList<string> strList3 = new List<string>() { "Two", "One", "Three", "Four", "Three" };

            bool isEqual = strList1.SequenceEqual(strList2); // returns true

            bool isEqual2 = strList1.SequenceEqual(strList3); // returns false

            #region Object Scenario

            // Collection with complex type elements, checks the references of the objects.
            // So, if the objects have the same reference then they considered as equal otherwise
            //      they are considered not equal.

            Student std = new Student() { StudentID = 1, StudentName = "Bill" };

            IList<Student> studentList1 = new List<Student>() { std };
            IList<Student> studentList2 = new List<Student>() { std };

            bool isEqual3 = studentList1.SequenceEqual(studentList2); 
            // returns true as reference value of objects in both collection is same as objects itself are same.

            Student std1 = new Student() { StudentID = 1, StudentName = "Bill" };
            Student std2 = new Student() { StudentID = 1, StudentName = "Bill" };

            IList<Student> studentList3 = new List<Student>() { std1 };
            IList<Student> studentList4 = new List<Student>() { std2 };

            isEqual3 = studentList3.SequenceEqual(studentList4);
            // returns false as reference value of objects in both collection is not same as objects itself are different.

            #region IEqualityComperar

            // To compare the values of two collection of complex type (reference type or object),
            // you need to implement IEqualityComperar<T> interface

            IList<Student> studentList11 = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };

            IList<Student> studentList22 = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };

            // following returns true
            bool isEqual4 = studentList11.SequenceEqual(studentList22, new StudentComparer2());

            #endregion

            #endregion

            Console.WriteLine(isEqual);


        }
    }

    class StudentComparer2 : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if (x.StudentID == y.StudentID && x.StudentName.ToLower() == y.StudentName.ToLower())
                return true;

            return false;
        }

        public int GetHashCode(Student obj)
        {
            return obj.GetHashCode();
        }
    }
}
