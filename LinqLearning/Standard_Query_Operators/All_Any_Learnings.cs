using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Standard_Query_Operators
{
    internal class All_Any_Learnings
    {
        public static void Main7(string[] args)
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };

            // The All operator evalutes each elements in the given collection on a specified condition
            //      and returns True if all the elements satisfy a condition.

            // checks whether all the students are teenagers    
            bool areAllStudentsTeenAger = studentList.All(s => s.Age > 12 && s.Age < 20);

            // Any checks whether any element satisfy given condition or not?

            bool isAnyStudentTeenAger = studentList.Any(s => s.Age > 12 && s.Age < 20);
        }
    }
}
