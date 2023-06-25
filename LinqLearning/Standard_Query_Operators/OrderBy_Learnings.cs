using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard_Query_Operators
{
    internal class OrderBy_Learnings
    {
        public static void Main3(string[] args)
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };

            // Sorting values ascending based on studentname
            var result = from stud in studentList
                         orderby stud.StudentName
                         select stud;

            // Sorting values descending based on studentname
            var result2 = from stud in studentList
                          orderby stud.StudentName descending
                          select stud;

            var result3 = studentList.OrderBy(stud => stud.StudentName);

            var result4 = studentList.OrderByDescending(stud => stud.StudentName);

            // You can do sorting based on multiple fields.

            var result5 = from stud in studentList
                          orderby stud.StudentName descending, stud.Age
                          select new { stud.StudentID, stud.Age };

            // ThenBy & ThenByDescending is only used for Method Syntax for sorting based on multiple fields.

            var result6 = studentList.OrderBy(stu => stu.StudentID).ThenBy(stu => stu.StudentName).ThenByDescending(stu => stu.Age);

        }
    }
}
