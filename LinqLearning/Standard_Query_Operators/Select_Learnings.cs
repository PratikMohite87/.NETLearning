using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard_Query_Operators
{
    internal class Select_Learnings
    {
        public static void Main6(string[] args)
        {
            // There are two projection operators available in LINQ. 1) Select 2) SelectMany

            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John" },
                new Student() { StudentID = 2, StudentName = "Moin" },
                new Student() { StudentID = 3, StudentName = "Bill" },
                new Student() { StudentID = 4, StudentName = "Ram" },
                new Student() { StudentID = 5, StudentName = "Ron" }
            };

            #region Query Syntax

            var selectResult = from s in studentList
                               select s.StudentName;

            // returns collection of anonymous objects with Name and Age property
            var selectResult2 = from s in studentList
                   select new { Name = "Mr. " + s.StudentName, Age = s.Age };

            #endregion

            #region Method Syntax

            var selectResult3 = studentList.Select(s => new {
                Name = s.StudentName,
                Age = s.Age
            });

            #endregion

            // iterate selectResult
            foreach (var item in selectResult3)
                Console.WriteLine("Student Name: {0}, Age: {1}", item.Name, item.Age);
        }
    }
}
