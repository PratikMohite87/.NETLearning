using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard_Query_Operators
{
    internal class Aggregate_Learnings
    {
        public static void Main9(string[] args)
        {
            IList<String> strList = new List<String>() { "One", "Two", "Three", "Four", "Five" };

            var commaSeperatedString = strList.Aggregate((s1, s2) => s1 + ", " + s2);
            Console.WriteLine(commaSeperatedString); // o/p: One, Two, Three, Four, Five

            // Refer for visual explanation of above code : https://www.tutorialsteacher.com/Content/images/linq/linq-aggregate-1.png

            #region Aggregate Method with Seed Value

            // Student collection
            IList<Student> studentList = new List<Student> () {
                new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
                new Student() { StudentID = 2, StudentName = "Moin", Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill", Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram", Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron", Age = 15 }
            };

            string commaSeparatedStudentNames = studentList.Aggregate<Student, string>(
                                                    "Student Names: ",  // seed value
                                                    (str, s) => str += s.StudentName + ",");

            Console.WriteLine(commaSeparatedStudentNames);
            // o/p: Student Names: John,Moin,Bill,Ram,Ron,

            int SumOfStudentsAge = studentList.Aggregate<Student, int>(0,
                                                (totalAge, s) => totalAge += s.Age);

            #endregion

            #region Aggregate Method with Result Selector

            string commaSeparatedStudentNames2 = studentList.Aggregate<Student, string, string>(
                                            String.Empty, // seed value
                                            (str, s) => str += s.StudentName + ",", // returns result using seed value, String.Empty goes to lambda expression as str
                                            str => str.Substring(0, str.Length - 1)); // result selector that removes last comma

            Console.WriteLine(commaSeparatedStudentNames);
            // o/p: Student Names: John,Moin,Bill,Ram,Ron

            #endregion
        }
    }
}
