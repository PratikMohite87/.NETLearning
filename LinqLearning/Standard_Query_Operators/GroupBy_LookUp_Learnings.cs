using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard_Query_Operators
{
    internal class GroupBy_LookUp_Learnings
    {
        public static void Main4(string[] args)
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Abram" , Age = 21 }
            };

            var groupedResult = from stud in studentList
                         group stud by stud.Age;

            var groupedResult2 = studentList.GroupBy(stud => stud.Age);


            // ToLookup is the same as GroupBy; the only difference is GroupBy execution is deferred,
            //      whereas ToLookup execution is immediate.

            // ToLookup is not supported in the query syntax.
            var groupedResult3 = studentList.ToLookup(stud => stud.Age);

            //iterate each group        
            foreach (var ageGroup in groupedResult2)
            {
                Console.WriteLine("Age Group: {0}", ageGroup.Key); //Each group has a key 

                foreach (Student s in ageGroup) // Each group has inner collection
                    Console.WriteLine("Student Name: {0}", s.StudentName);
            }

            // A LINQ query syntax can be end with the GroupBy or Select clause.
        }
    }
}
